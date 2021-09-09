﻿using Data;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller{
    public class AdmDigitalGames{

        private static AdmDigitalGames adm = null;
        //Validacion v = null;
        List<PagoJARR> pagos = null;
        ClienteJARR cliente = null;
        VendedorJARR vendedor = null;
        JuegoJARR juego = null;
        PagoJARR pago = null;
        SqlConfig bd = null;
        List<PagoJARR> pagosFiltro = null;
        int id;

        private AdmDigitalGames() {
            //    inicializamos la lista
                bd = SqlConfig.GetSql();
        }

        public static AdmDigitalGames GetAdm(){
            if (adm == null){
                adm = new AdmDigitalGames();
            }
            return adm;
        }

        public void EliminarPago(DataGridView dgvPago){
            if(dgvPago.SelectedRows.Count != 1){
                MessageBox.Show("Seleccione una Fila");
                return;
            }

            int id = (int)dgvPago[0, dgvPago.CurrentRow.Index].Value;
            
            if (bd.EliminarPago(id)){
                MessageBox.Show("Pago Eliminado Exitosamente");
                ListarPagos(dgvPago);
            }
        }

        public void GenerarReporte(TextBox txtJuego) {

            // Fonts
            PdfFont fontHeader = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontBody = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            // Generar el PDF
            PdfWriter pdfWriter = new PdfWriter("../../../Reporte_Pagos.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);
            var titulo = new Paragraph("Registo de Pagos").SetFont(fontHeader);
            //var style = new Style();
            titulo.SetFontSize(16);
            titulo.SetMarginBottom(20);

            documento.SetMargins(60, 10, 55, 10);            

            string[] headers = { "Cedula Vendedor", "Cedula Cliente", "Nombre Juego", "Cantidad Comprada", "Precio", "Total", "Tipo de Pago" };

            float[] width = { 2.5f, 2.5f, 2.5f, 2, 2, 2, 2 };

            Table tabla = new Table(UnitValue.CreatePercentArray(width));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (var header in headers) {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(header).SetFont(fontHeader).SetFontSize(10.5f)));
            }

            pagos.ForEach( pago => {
                tabla.AddCell(new Cell().Add(new Paragraph(pago.Vendedor.Cedula).SetFont(fontBody).SetFontSize(10)));
                tabla.AddCell(new Cell().Add(new Paragraph(pago.Cliente.Cedula).SetFont(fontBody).SetFontSize(10)));
                tabla.AddCell(new Cell().Add(new Paragraph(pago.Juego.Nombre).SetFont(fontBody).SetFontSize(10)));
                tabla.AddCell(new Cell().Add(new Paragraph(pago.CantidadJuegos.ToString()).SetFont(fontBody).SetFontSize(10)));
                tabla.AddCell(new Cell().Add(new Paragraph(pago.Juego.Precio.ToString()).SetFont(fontBody).SetFontSize(10)));
                tabla.AddCell(new Cell().Add(new Paragraph(pago.calcularTotal(pago.Juego.Precio, pago.CantidadJuegos).ToString()).SetFont(fontBody).SetFontSize(10)));
                tabla.AddCell(new Cell().Add(new Paragraph(pago.TipoPago).SetFont(fontBody).SetFontSize(10)));
            });

            // Centrar el texto del documento
            documento.SetTextAlignment(TextAlignment.CENTER);

            documento.Add(titulo);

            documento.Add(tabla);

            documento.Close();
        }

        public void BuscarJuego(TextBox txtJuego, DataGridView dgvPago){
            //validar si hay campos vacios
            string nombreJuego = txtJuego.Text;

            if (nombreJuego.Trim() == "") return;

            //pagosFiltro = new List<PagoJARR>();

            pagosFiltro = pagos.FindAll( pago => pago.Juego.Nombre == nombreJuego );
            
            // Limpiar el grid
            dgvPago.Rows.Clear();

            llenarGrid(dgvPago, pagosFiltro);
        }

        public void LlenarCampos(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtCantidad, ComboBox cmbTipoPago, DateTimePicker dtpFechaPagoFinal){

            //pago = bd.ConsultarPago(id);

            pago = pagos.Find( pago => pago.Id == id );

            txtCedulaCliente.Text = pago.Cliente.Cedula;
            txtCedulaVendedor.Text = pago.Vendedor.Cedula;
            txtidJuego.Text = pago.Juego.IdJuego.ToString();
            txtCantidad.Text = pago.CantidadJuegos.ToString();
            cmbTipoPago.SelectedItem = pago.TipoPago;
            dtpFechaPagoFinal.Value = dtpFechaPagoFinal.Enabled ? pago.FechaPagoFin : DateTime.Today;
        }

        public bool EditarPago(DataGridView dgvPago){
            // Validar si hay seleccionada una fila
            if (dgvPago.SelectedRows.Count != 1){
                MessageBox.Show("Seleccione una Fila");
                return false;
            }

            id = (int)dgvPago[0, dgvPago.CurrentRow.Index].Value;
            //MessageBox.Show(id.ToString());

            return true;            
        }

        public void ActualizarPago(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtCantidad, DateTimePicker dtpFechaPagoFinal, ComboBox cmbTipoPago){

            pago = CrearObjs(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);

            if (pago == null) return;

            //pago.Id = id;

            bd.EditarPago(pago, id);

            MessageBox.Show("Pago actualizado exitosamente");
        }

        public void RegistrarPago(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtCantidad, DateTimePicker dtpFechaPagoFinal, ComboBox cmbTipoPago){

            pago = CrearObjs(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);

            if (pago == null) return;

            bd.InsertarPago(pago);

            MessageBox.Show("Registro guardado exitosamente");
        }

        public PagoJARR CrearObjs(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego,  TextBox txtCantidad, DateTimePicker dtpFechaPagoFinal, ComboBox cmbTipoPago){

            // Validar que no haya campos vacios
            if (txtCedulaCliente.Text.Trim() == "" || txtCedulaVendedor.Text.Trim() == "" || txtidJuego.Text.Trim() == "" || txtCantidad.Text.Trim() == ""){
                MessageBox.Show("Por favor llene todos los campos");
                return null;
            }

            string cedulaCliente = txtCedulaCliente.Text;
            cliente = bd.ConsultarCliente(cedulaCliente);

            string cedulaVendedor = txtCedulaVendedor.Text;
            vendedor = bd.ConsultarVendedor(cedulaVendedor);

            int juegoId = Convert.ToInt32(txtidJuego.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            string tipo_pago = (cmbTipoPago.SelectedIndex + 1) + "";
            DateTime fechaPago = DateTime.Now.Date;
            DateTime fechaPagoFinal = dtpFechaPagoFinal.Value.Date;
            if (!dtpFechaPagoFinal.Enabled) fechaPagoFinal = DateTime.Today;

            //cliente = new ClienteJARR();
            //cliente.Id = ;

            //vendedor = new VendedorJARR();
            //vendedor.Cedula = cedulaVendedor;

            juego = new JuegoJARR();
            juego.IdJuego = juegoId;

            PagoJARR pago = new PagoJARR();
            pago.TipoPago = tipo_pago;
            pago.CantidadJuegos = cantidad;
            pago.Juego = juego;
            pago.Cliente = cliente;
            pago.Vendedor = vendedor;
            pago.FechaPago = fechaPago;
            pago.FechaPagoFin = fechaPagoFinal;
            //MessageBox.Show(fechaPago.ToString());
            //MessageBox.Show(pago.Cliente.Id.ToString());

            return pago;
        }

        public void ListarPagos(DataGridView dgvPago){
            dgvPago.Rows.Clear();

            // limpiar la lista
            if (pagos != null) pagos.Clear();

            pagos = bd.ConsultarPagos();

            llenarGrid(dgvPago, pagos);
        }

        public void llenarGrid(DataGridView dgvPago, List<PagoJARR> pagos){
            int index = 0;
            pagos.ForEach(pago => {
                dgvPago.Rows.Add(pago.Id, pago.Vendedor.Cedula, pago.Cliente.Cedula, pago.Juego.Nombre, pago.CantidadJuegos, pago.Juego.Precio, pago.calcularTotal(pago.Juego.Precio, pago.CantidadJuegos), pago.TipoPago, pago.FechaPago.ToString("yyyy-MM-dd"));

                if (pago.FechaPagoFin != DateTime.Today){
                    dgvPago["fechaPagoFinal", index].Value = pago.FechaPagoFin.ToString("yyyy-MM-dd");
                }

                index++;
            });
        }
    }
}