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
    public class Rol : BaseID
    {
        [JsonPropertyName("nombre_rol")]
        public string Nombre_Rol { get; set; }
        [JsonPropertyName("permisos")]
        public List<string> Permisos { get; set; }
        // Constructor vacío requerido para la serialización
        public Rol() { }
        // Constructor con validaciones y asignación automática de permisos
        public Rol(int id, string nombre_rol)
        {
            if (!Validaciones.ValidarRol(nombre_rol))
            {
                MessageBox.Show($"Nombre de rol no válido. Los roles permitidos son: {string.Join(", ", Validaciones.RolesPermitidos)}");
                return; // Detiene la ejecución si el rol no es válido
            }
            // Asigna el nombre del rol
            this.Id = id;
            this.Nombre_Rol = nombre_rol;
            // Asigna los permisos correspondientes al rol
            this.Permisos = Validaciones.ObtenerPermisosPorRol(id);

            MessageBox.Show("Rol creado exitosamente.");
        }
    }
}
