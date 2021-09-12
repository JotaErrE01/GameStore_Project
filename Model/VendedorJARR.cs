namespace Model{
    public class VendedorJARR : UsuarioJARR{

        string codigo;

        public VendedorJARR(){ }

        //public VendedorJARR(string cedula, string nombre, string email, string codigo) : base (cedula, nombre, email){
        //    this.Codigo = codigo;
        //}

        public string Codigo { get => codigo; set => codigo = value; }
    }
}
