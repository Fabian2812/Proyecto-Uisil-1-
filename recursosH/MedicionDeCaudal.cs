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
    public class MedicionDeCaudal : BaseID
    {
        [JsonPropertyName("capacidad")]
        public int Capacidad { get; set; }
        [JsonPropertyName("metodo")]
        public string Metodo { get; set; }
        [JsonPropertyName("observacione")]
        public string Observacione { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }
        [JsonPropertyName("clima")]
        public string Clima { get; set; }
        [JsonPropertyName("realizado")]
        public string Realizado { get; set; }
        [JsonPropertyName("id_naciente")]
        public int Id_Naciente { get; set; }
        [JsonPropertyName("id_sitioDeMuestreo")]
        public int Id_SitioDeMuestreo { get; set; }
        public MedicionDeCaudal() { }
        public MedicionDeCaudal (int id, int capacidad, string metodo, string observacione, DateTime fecha, string clima, string realizado, int id_naciente, int id_sitioDeMuestreo) : base(id)
        {
            
            this.Capacidad = capacidad;
            this.Metodo = metodo;
            this.Observacione = observacione;
            this.Fecha = fecha;
            this.Clima = clima;
            this.Realizado = realizado;
            this.Id_Naciente = id_naciente;
            this.Id_SitioDeMuestreo = id_sitioDeMuestreo;
        }
        public override string ToString()
        {
            return $"Medicion de caudal:{Id} - {Capacidad}, Metodo: {Metodo}, Observacion: {Observacione}, Fecha: {Fecha}, Clima: {Clima}, Realizado: {Realizado}, Naciente: {Id_Naciente}, Sitio de muestreo: {Id_SitioDeMuestreo}";
        }
    }
}
