using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Provincia
    {
        public byte Id_Provincia { get; set; }
        private string Nombre_Provincia { get; set; }

        public Provincia () { }
        public Provincia(byte id_Provincia, string nombre_Provincia)
        {
            this.Id_Provincia = id_Provincia;
            this.Nombre_Provincia = nombre_Provincia;
        }
    }
}
