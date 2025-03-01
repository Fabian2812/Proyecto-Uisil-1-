using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class Canton 
    {
        public byte Id_Canton { get; set; }
        private string Nombre_Canton { get; set; }

        public Canton () { }


        public Canton(byte id_Canton, string nombre_Canton) 
        {
            this.Id_Canton = id_Canton;
            this.Nombre_Canton = nombre_Canton;
        }

    }
}
