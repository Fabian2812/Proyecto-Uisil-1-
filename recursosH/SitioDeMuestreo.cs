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
    public class SitioDeMuestreo : BaseID
    {
        [JsonPropertyName("nombre_sitioDeMuestreo")]
        public string Nombre_SitioDeMuestreo { get; set; }
        [JsonPropertyName("id_provincia")]
        public int Id_Provincia { get; set; }
        [JsonPropertyName("id_canton")]
        public int Id_Canton { get; set; }
        [JsonPropertyName("id_distrito")]
        public int Id_Distrito { get; set; }
        [JsonPropertyName("id_entidad")]
        public int Id_Entidad { get; set; }
        public SitioDeMuestreo() { }
        public SitioDeMuestreo(int id_SitioDeMuestreo, string nombre_sitioDeMuestreo, int id_provincia, int id_canton, int id_distrito, int id_entidad) : base(id_SitioDeMuestreo)
        {

            this.Nombre_SitioDeMuestreo = nombre_sitioDeMuestreo;
            this.Id_Provincia = id_provincia;
            this.Id_Canton = id_canton;
            this.Id_Distrito = id_distrito;
            this.Id_Entidad = id_entidad;
        }
        public override string ToString()
        {
            return $"sitio de muestreo:{Id} - {Nombre_SitioDeMuestreo}, Provincia: {Id_Provincia}, Canton: {Id_Canton}, Distrito: {Id_Distrito}, Entidad: {Id_Entidad}";
        } 
    }
}
