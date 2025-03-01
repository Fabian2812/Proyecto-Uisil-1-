using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursosH
{
    public class BaseID
    {
        byte Id { get; set; }

        public BaseID() { }
        public BaseID(byte id) {
            this.Id = id;
        }

    }
}
