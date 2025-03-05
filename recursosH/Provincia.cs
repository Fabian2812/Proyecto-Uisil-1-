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
    public class Provincia : BaseID
    {
        [JsonPropertyName("nombre_provincia")]
        public string Nombre_Provincia { get; set; }
        public Provincia() { }

        public Provincia(int id_Provincia, string nombre_provincia) : base(id_Provincia)
        {

            this.Nombre_Provincia = nombre_provincia;
        }
        public override string ToString()
        {
            return $"Provincia:{Id} - {Nombre_Provincia}";
        }
    }
}
