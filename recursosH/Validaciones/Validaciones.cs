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
    public static class Validaciones
    {
        // Expresión regular para validar correos electrónicos
        private static readonly Regex CorreoRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        // Expresión regular para validar contraseñas (al menos 8 caracteres, una mayúscula, una minúscula y un número)
        private static readonly Regex ContraseñaRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        // Expresión regular para validar números de teléfono (solo dígitos, 8 caracteres)
        private static readonly Regex TelefonoRegex = new Regex(@"^\d{8}$");
        // Expresión regular para validar cédulas jurídicas (formato específico)
        private static readonly Regex CedulaJuridicaRegex = new Regex(@"^\d{3}-\d{6}-\d{4}$");
        // Expresión regular para validar nombres (solo letras, espacios, guiones y apóstrofes)
        private static readonly Regex NombreRegex = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s'-]{2,500}$");
        // Expresión regular para validar números double (incluyendo negativos y decimales)
        private static readonly Regex DoubleRegex = new Regex(@"^-?\d+(\.\d+)?$");
        // Expresión regular para validar números enteros
        private static readonly Regex EnteroRegex = new Regex(@"^\d+$");
        // Expresión regular para validar fechas (formato YYYY-MM-DD)
        private static readonly Regex FechaRegex = new Regex(@"^\d{2}-\d{2}-\d{4}$");
        // Lista de nombres de roles permitidos
        public static readonly List<string> RolesPermitidos = new List<string>
        {
            "Usuario", "Administrador", "SuperAdministrador"
        };
        // Lista de permisos permitidos
        public static readonly List<string> PermisosPermitidos = new List<string>
        {
            "create", "read", "update", "delete"
        };
        private static readonly Dictionary<string, List<string>> PermisosPorRol = new Dictionary<string, List<string>>
        {
            { "Usuario", new List<string> { "read" } },
            { "Administrador", new List<string> { "create", "read", "update" } },
            { "SuperAdministrador", new List<string> { "create", "read", "update", "delete" } }
        };
        // Método para validar IDs (debe ser un número entero positivo)
        public static bool ValidarId(int id)
        {
            return id > 0; // Asegura que el ID sea un número entero positivo
        }
        // Método para validar correos electrónicos
        public static bool ValidarCorreo(string email)
        {
            return !string.IsNullOrEmpty(email) && CorreoRegex.IsMatch(email);
        }
        // Método para validar contraseñas
        public static bool ValidarContrasena(string contrasena)
        {
            return !string.IsNullOrEmpty(contrasena) && ContraseñaRegex.IsMatch(contrasena);
        }
        // Método para validar números de teléfono
        public static bool ValidarTelefono(int telefono)
        {
            return TelefonoRegex.IsMatch(telefono.ToString());
        }

        // Método para validar cédulas jurídicas
        public static bool ValidarCedulaJuridica(string cedula)
        {
            return !string.IsNullOrEmpty(cedula) && CedulaJuridicaRegex.IsMatch(cedula);
        }
        // Método para validar nombres
        public static bool ValidarNombre(string nombre)
        {
            return !string.IsNullOrEmpty(nombre) && NombreRegex.IsMatch(nombre);
        }
        // Método para validar el nombre del rol
        public static bool ValidarRol(string nombreRol)
        {
            return !string.IsNullOrEmpty(nombreRol) && RolesPermitidos.Contains(nombreRol);
        }
        // Método para obtener los permisos de un rol
        public static List<string> ObtenerPermisosPorRol(string nombreRol)
        {
            if (PermisosPorRol.ContainsKey(nombreRol))
                return PermisosPorRol[nombreRol];
            return new List<string>(); // Retorna una lista vacía si el rol no existe
        }
        public static bool ValidarLatitud(double latitud)
        {
            return DoubleRegex.IsMatch(latitud.ToString());
        }
        public static bool ValidarLongitud(double longitud)
        {
            
            return DoubleRegex.IsMatch(longitud.ToString());
        }
        public static bool ValidarDouble(double numero)
        {
            return DoubleRegex.IsMatch(numero.ToString());
        }
        public static bool ValidarEntero(int entero)
        {
            return EnteroRegex.IsMatch(entero.ToString());
        }
        public static bool ValidarFecha(DateTime fecha)
        {
            return FechaRegex.IsMatch(fecha.ToString());
        }
        // Método para verificar si un valor es nulo o vacío
        public static bool EsNuloOVacio(string valor)
        {
            return string.IsNullOrEmpty(valor);
        }
    }
}