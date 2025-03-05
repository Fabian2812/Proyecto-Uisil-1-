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
    public class Distrito : BaseID
    {
        [JsonPropertyName("nombre_distrito")]
        public string Nombre_Distrito { get; set; }
        [JsonPropertyName("id_canton")]
        public int Id_Canton { get; set; }
        public Distrito() { }
        public Distrito(int id_Distrito, string nombre_distrito, int id_canton) : base(id_Distrito)
        {

            this.Nombre_Distrito = nombre_distrito;
            this.Id_Canton = id_canton;
        }
        public override string ToString()
        {
            return $"Distrito:{Id} - {Nombre_Distrito}, Canton: {Id_Canton}";
        }
    }
}
