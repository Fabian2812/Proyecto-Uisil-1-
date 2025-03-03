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
    public class Canton : BaseID
    {
        [JsonPropertyName("nombre_canton")]
        public string Nombre_Canton { get; set; }
        [JsonPropertyName("id_provincia")]
        public int Id_Provincia { get; set; }
        public Canton () { }
        public Canton(int id_Canton, string nombre_canton, int id_provincia) : base(id_Canton)
        {
            if (Validaciones.ValidarNombre(nombre_canton))
            {
                MessageBox.Show("Nombre no valido");
                return;
            }
            if (Validaciones.ValidarId(id_provincia))
            {
                MessageBox.Show("ID provincia no valido");
                return;
            }
            this.Nombre_Canton = nombre_canton;
            this.Id_Provincia = id_provincia;
        }
        public override string ToString()
        {
            return $"Canton:{Id} - {Nombre_Canton}, Provincia: {Id_Provincia}";
        }

    }
}
