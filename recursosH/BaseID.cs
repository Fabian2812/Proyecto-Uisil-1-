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
    public class BaseID
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                if (!Validaciones.ValidarId(value))
                    MessageBox.Show("ID no válido. Debe ser un número entero positivo.");
                _id = value;
            }
        }

        public BaseID() { }

        public BaseID(int id)
        {
            this.Id = id; // Usa el setter para aplicar la validación
        }
    }
}