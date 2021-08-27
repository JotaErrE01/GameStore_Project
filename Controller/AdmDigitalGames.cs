﻿using Data;
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
        Validacion v = null;
        List<PagoJARR> pagos = null;
        ClienteJARR cliente = null;
        VendedorJARR vendedor = null;
        JuegoJARR juego = null;
        PagoJARR pago = null;
        SqlConfig bd = null;
        int id;

        private AdmDigitalGames(){
            //inicializamos la lista
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

        public void LlenarCampos(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtCantidad, TextBox txtPrecio, ComboBox cmbTipoPago, DateTimePicker dtpFechaPagoFinal){

            pago = bd.ConsultarPago(id);

            txtCedulaCliente.Text = pago.Cliente.Cedula;
            txtCedulaVendedor.Text = pago.Vendedor.Cedula;
            txtidJuego.Text = pago.Juego.IdJuego.ToString();
            txtCantidad.Text = pago.CantidadJuegos.ToString();
            cmbTipoPago.SelectedItem = pago.TipoPago;

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

        public void ActualizarPago(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtPrecio, TextBox txtCantidad, DateTimePicker dtpFechaPagoFinal, ComboBox cmbTipoPago){

            pago = CrearObjs(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtPrecio, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);

            if (pago == null) return;

            bd.EditarPago(pago, id);

            MessageBox.Show("Pago actualizado exitosamente");

        }

        public void RegistrarPago(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtPrecio, TextBox txtCantidad, DateTimePicker dtpFechaPagoFinal, ComboBox cmbTipoPago){

            pago = CrearObjs(txtCedulaCliente, txtCedulaVendedor, txtidJuego, txtPrecio, txtCantidad, dtpFechaPagoFinal, cmbTipoPago);

            if (pago == null) return;

            bd.InsertarPago(pago);

            MessageBox.Show("Registro guardado exitosamente");
        }

        public PagoJARR CrearObjs(TextBox txtCedulaCliente, TextBox txtCedulaVendedor, TextBox txtidJuego, TextBox txtPrecio, TextBox txtCantidad, DateTimePicker dtpFechaPagoFinal, ComboBox cmbTipoPago){
            //Validacion
            if (txtCedulaCliente.Text.Trim() == "" || txtCedulaVendedor.Text.Trim() == "" || txtidJuego.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtCantidad.Text.Trim() == ""){
                MessageBox.Show("Por favor llene todos los campos");
                return null;
            }

            string cedulaCliente = txtCedulaCliente.Text;
            string cedulaVendedor = txtCedulaVendedor.Text;
            int juegoId = Convert.ToInt32(txtidJuego.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            //decimal precio = Convert.ToDecimal(txtPrecio.Text);
            string tipo_pago = (cmbTipoPago.SelectedIndex + 1) + "";
            DateTime fechaPago = DateTime.Now.Date;
            DateTime fechaPagoFinal = dtpFechaPagoFinal.Value.Date;
            if (!dtpFechaPagoFinal.Enabled) fechaPagoFinal = DateTime.Today;

            cliente = new ClienteJARR();
            cliente.Cedula = cedulaCliente;

            vendedor = new VendedorJARR();
            vendedor.Cedula = cedulaVendedor;

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

            return pago;
        }

        public void ListarPagos(DataGridView dgvPago){
            dgvPago.Rows.Clear();

            // limpiar la lista
            if (pagos != null) pagos.Clear();

            pagos = bd.ConsultarPagos();
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