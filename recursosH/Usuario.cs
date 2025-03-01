using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Usuario 
    {
        public byte Id_Usuario { get; set; }
        private string Nombre_Usuario { get; set; }
        private string PrimerApellido { get; set; }
        private string SegundoApellido { get; set; }
        private string Correo { get; set; }
        private string Contrasena { get; set; }

        public Usuario() { }

        public Usuario(byte id_Usuario, string nombre_Usuario, string primerApellido, string segundoApellido, string correo, string contrasena)
        {
            this.Id_Usuario = id_Usuario;
            this.Nombre_Usuario = nombre_Usuario;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Correo = correo;
            this.Contrasena = contrasena;
        }



    }
}
