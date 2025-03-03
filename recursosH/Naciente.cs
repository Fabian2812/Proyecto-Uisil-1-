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
    public class Naciente : BaseID
    {
        [JsonPropertyName("nombre_naciente")]
        public string Nombre_Naciente { get; set; }
        [JsonPropertyName("direccion_naciente")]
        public string Direccion_Naciente { get; set; }
        [JsonPropertyName("latitud")]
        public Double latitud { get; set; }
        [JsonPropertyName("longitud")]
        public Double longitud { get; set; }
        [JsonPropertyName("descripcion_naciente")]
        public string Descripcion_Naciente { get; set; }
        [JsonPropertyName("id_provincia")]
        public int Id_Provincia { get; set; }
        [JsonPropertyName("id_canton")]
        public int Id_Canton { get; set; }
        [JsonPropertyName("id_distrito")]
        public int Id_Distrito { get; set; }
        [JsonPropertyName("id_entidad")]
        public int Id_Entidad { get; set; }
        public Naciente() { }
        public Naciente(int id_Naciente, string nombre_naciente, string direccion_naciente, Double latitud, Double longitud, string descripcion_naciente, int id_provincia, int id_canton, int id_distrito, int id_entidad) : base(id_Naciente)
        {
            if (Validaciones.ValidarNombre(nombre_naciente))
            {
                MessageBox.Show("Nombre no valido");
                return;
            }
            if (Validaciones.ValidarNombre(direccion_naciente))
            {
                MessageBox.Show("Direccion no valida");
                return;
            }
            if (Validaciones.ValidarLatitud(latitud))
            {
                MessageBox.Show("Latitud no valida");
                return;
            }
            if (Validaciones.ValidarLongitud(longitud))
            {
                MessageBox.Show("Longitud no valida");
                return;
            }
            if (Validaciones.ValidarNombre(descripcion_naciente))
            {
                MessageBox.Show("Descripcion no valida");
                return;
            }
            if (Validaciones.ValidarId(id_provincia))
            {
                MessageBox.Show("ID provincia no valido");
                return;
            }
            if (Validaciones.ValidarId(id_canton))
            {
                MessageBox.Show("ID canton no valido");
                return;
            }
            if (Validaciones.ValidarId(id_distrito))
            {
                MessageBox.Show("ID distrito no valido");
                return;
            }
            if (Validaciones.ValidarId(id_entidad))
            {
                MessageBox.Show("ID entidad no valido");
                return;
            }
            this.Nombre_Naciente = nombre_naciente;
            this.Direccion_Naciente = direccion_naciente;
            this.latitud = latitud;
            this.longitud = longitud;
            this.Descripcion_Naciente = descripcion_naciente;
            this.Id_Provincia = id_provincia;
            this.Id_Canton = id_canton;
            this.Id_Distrito = id_distrito;
            this.Id_Entidad = id_entidad;
        }
        public override string ToString()
        {
            return $"Naciente: {Id} - {Nombre_Naciente}, Direccion: {Direccion_Naciente}, Latitud: {latitud}, Longitud: {longitud}, Descripcion: {Descripcion_Naciente}, Provincia: {Id_Provincia}, Canton: {Id_Canton}, Distrito: {Id_Distrito}, Entidad: {Id_Entidad}";
        }

    }

}
