using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class SitioDeMuestreo
    {
        public byte Id_SitioDeMuestreo { get; set; }
        private string Nombre_SitioDeMuestreo { get; set; }

        public SitioDeMuestreo() { }

        public SitioDeMuestreo(byte id_SitioDeMuestreo, string nombre_SitioDeMuestreo)
        {
            this.Id_SitioDeMuestreo = id_SitioDeMuestreo;
            this.Nombre_SitioDeMuestreo = nombre_SitioDeMuestreo;
            
        }

    }


}
