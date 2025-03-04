using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace recursosH
{
    public static class DataInitializer
    {
        private static string dataFilePath = "data.json";

        public static void InitializeData()
        {
            // Mostrar la ruta del archivo JSON
            MessageBox.Show($"Ruta del archivo JSON: {Path.GetFullPath(dataFilePath)}");

            if (!File.Exists(dataFilePath))
            {
                var data = new
                {
                    Usuarios = new List<Usuario>
                    {
                        new Usuario(1, "admin", "Apellido1", "Apellido2", "admin@example.com", "admin123", 2, 1),
                        new Usuario(2, "usuario", "Apellido1", "Apellido2", "usuario@example.com", "usuario123", 1, 2)
                    },
                    Roles = new List<Rol>
                    {
                        new Rol(1, "Usuario"), // Permisos se asignan automáticamente
                        new Rol(2, "Administrador"), // Permisos se asignan automáticamente
                        new Rol(3, "SuperAdministrador") // Permisos se asignan automáticamente
                    },
                    Entidades = new List<Entidad>
                    {
                        new Entidad(1, "123456789", "Entidad1", "entidad1@example.com", 12345678, "Direccion1", "Descripcion1"),
                        new Entidad(2, "987654321", "Entidad2", "entidad2@example.com", 123456789, "Direccion2", "Descripcion2")
                    },
                    Nacientes = new List<Naciente>
                    {
                        new Naciente(1, "Naciente1", "Direccion1", 1, 1, "Descripcion1", 1, 1, 1, 1)
                    },
                    SitiosDeMuestreo = new List<SitioDeMuestreo>
                    {
                        new SitioDeMuestreo(1, "Sitio1", 1, 1, 1, 1)
                    },
                    Provincias = new List<Provincia>
                    {
                        new Provincia(1, "Provincia1")
                    },
                    Cantones = new List<Canton>
                    {
                        new Canton(1, "Canton1", 1)
                    },
                    Distritos = new List<Distrito>
                    {
                        new Distrito(1, "Distrito1", 1)
                    }
                };

                string jsonData = JsonSerializer.Serialize(data);
                File.WriteAllText(dataFilePath, jsonData);

                // Mensaje de depuración
                MessageBox.Show("Archivo JSON creado exitosamente.");
            }
            else
            {
                // Mensaje de depuración
                MessageBox.Show("El archivo JSON ya existe. No se necesita inicialización.");
            }
        }

        public static Dictionary<string, object> CargarJsonSiExiste()
        {
            if (File.Exists(dataFilePath))
            {
                // Mensaje de depuración
                MessageBox.Show("Archivo JSON encontrado. Cargando datos...");

                string jsonData = File.ReadAllText(dataFilePath);
                return JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData);
            }
            else
            {
                // Mensaje de depuración
                MessageBox.Show("Archivo JSON no encontrado.");
                return null; // Retorna null si el archivo no existe
            }
        }

        public static void VerificarYCargarJson()
        {
            var datos = CargarJsonSiExiste();
            if (datos != null)
            {
                // Mensaje de depuración
                MessageBox.Show("JSON cargado exitosamente.");
                // Aquí puedes trabajar con los datos cargados
            }
            else
            {
                // Mensaje de depuración
                MessageBox.Show("El archivo JSON no existe. Se debe inicializar primero.");
                InitializeData(); // Inicializa el JSON si no existe
            }
        }

        public static TipoDeDato LoadData<TipoDeDato>(string key)
        {
            string jsonData = File.ReadAllText(dataFilePath);
            var data = JsonSerializer.Deserialize<Dictionary<string, TipoDeDato>>(jsonData);
            return data[key];
        }

        public static void SaveData<TipoDeDato>(string key, TipoDeDato data)
        {
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            allData[key] = data;
            string jsonData = JsonSerializer.Serialize(allData);
            File.WriteAllText(dataFilePath, jsonData);

            // Mensaje de depuración
            MessageBox.Show("Datos guardados exitosamente en el archivo JSON.");
        }
    }
}