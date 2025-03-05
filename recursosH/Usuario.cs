using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.Json.Serialization;
namespace recursosH
{
    public class Usuario : BaseID
    {
        [JsonPropertyName("nombre_usuario")]
        public string Nombre_Usuario { get; set; }
        [JsonPropertyName("primer_apellido")]
        public string PrimerApellido { get; set; }
        [JsonPropertyName("segundo_apellido")]
        public string SegundoApellido { get; set; }
        [JsonPropertyName("correo")]
        public string Correo { get; set; }
        [JsonPropertyName("contrasena")]
        public string Contrasena { get; set; }
        [JsonPropertyName("id_rol")]
        public int Id_Rol { get; set; }
        [JsonPropertyName("id_entidad")]
        public int Id_Entidad { get; set; }
        //Constructor vacío Necesario para la serialización del Json
        public Usuario() { }
        public Usuario (int id_Usuario,string Nombre_Usuario, string PrimerApellido, string SegundoApellido, string Correo, string Contrasena, int Id_Rol, int Id_Entidad) : base(id_Usuario)
        {

            this.Nombre_Usuario = Nombre_Usuario;
            this.PrimerApellido = PrimerApellido;
            this.SegundoApellido = SegundoApellido;
            this.Correo = Correo;
            this.Contrasena = Contrasena;
            this.Id_Rol = Id_Rol;
            this.Id_Entidad = Id_Entidad;
        }
        public override string ToString()
        {
            return $"Usuario: {Id} - {Nombre_Usuario} {PrimerApellido} {SegundoApellido}, Correo: {Correo}, Rol: {Id_Rol}, Entidad: {Id_Entidad}";
        }
    }
}

