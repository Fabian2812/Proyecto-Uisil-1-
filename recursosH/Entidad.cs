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
    public class Entidad : BaseID
    {
        [JsonPropertyName("cedula_juridica")]
        public string Cedula_Juridica { get; set; }
        [JsonPropertyName("nombre_entidad")]
        public string Nombre_Entidad { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("telefono")]
        public int Telefono { get; set; }
        [JsonPropertyName("direccion_entidad")]
        public string Direccion_Entidad { get; set; }
        [JsonPropertyName("descripcion_entidad")]
        public string Descripcion_Entidad { get; set; }
        public Entidad() { }
        public Entidad(int id_Entidad, string cedula_juridica, string nombre_entidad, string email, int telefono, string direccion_entidad, string descripcion_entidad) : base(id_Entidad)
        {
            if (Validaciones.ValidarCedulaJuridica(cedula_juridica))
            {
                MessageBox.Show("Cedula juridica no valida");
                return;
            }
            if (Validaciones.ValidarNombre(nombre_entidad))
            {
                MessageBox.Show("Nombre no valido");
                return;
            }
            if (Validaciones.ValidarCorreo(email))
            {
                MessageBox.Show("Email no valido");
                return;
            }
            if (Validaciones.ValidarTelefono(telefono))
            {
                MessageBox.Show("Telefono no valido");
                return;
            }
            if (Validaciones.ValidarNombre(direccion_entidad))
            {
                MessageBox.Show("Direccion no valida");
                return;
            }
            if (Validaciones.ValidarNombre(descripcion_entidad))
            {
                MessageBox.Show("Descripcion no valida");
                return;
            }
            this.Cedula_Juridica = cedula_juridica;
            this.Nombre_Entidad = nombre_entidad;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion_Entidad = direccion_entidad;
            this.Descripcion_Entidad = descripcion_entidad;
        }
        public override string ToString()
        {
            return $"Entidad: {Id} - {Nombre_Entidad}, Cedula Juridica: {Cedula_Juridica}, Email: {Email}, Telefono: {Telefono}, Direccion: {Direccion_Entidad}, Descripcion: {Descripcion_Entidad}";
        }
    }
}
