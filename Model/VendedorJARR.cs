﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class VendedorJARR : UsuarioJARR{

        string codigo;

        public VendedorJARR(string cedula, string nombre, string email, string codigo) : base (cedula, nombre, email){
            this.Codigo = codigo;
        }

        public string Codigo { get => codigo; set => codigo = value; }
    }
}