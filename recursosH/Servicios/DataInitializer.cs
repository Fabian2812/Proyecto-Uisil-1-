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
                        new Usuario(1, "Esteban", "Castro", "Rojas", "davidcr333@gmail.com", "T4uV7Ym", 1, 1),
                        new Usuario(2, "Johana", "Segura", "Cruz", "johsc@gmail.com", "J3v#Fp4P", 2, 1),
                        new Usuario(3, "Ana", "Matamorros", "Laiba", "anamlaiba67@gmail.com", "Wz8#r1pQ", 3, 1),
                        new Usuario(4, "Daniela","Mora","Zapata","danymora@gmail.com", "Z9q2Xm7M", 1, 2),
                        new Usuario(5, "José", "Barquero", "Calvo", "bcjose12@gmail.com", "YW6+wP2Z", 2, 2),
                        new Usuario(6, "Pablo", "Guzmán", "Moreira", "guzmanpablo1@gmail.com", "N1zG+t4H", 3, 2),
                        new Usuario(7, "Maria", "Perez", "Castillo", "perezcastillo@gmail.com","L8eVb$2R",1, 3),
                        new Usuario(8, "David", "Barquero", "Rojas", "tebanbrojas@gmail.com", "Kxj5*kf3A", 2, 3),
                        new Usuario(9, "Jonh", "Acevedo", "Alvarado", "jonh188@gamil.com", "Kd9Vb2$z3", 3, 3 ),
                        new Usuario(10, "Maribel", "Gamboa", "Santos", "marigs@gamil.com", "Hvde7+4DJ", 1, 4),
                        new Usuario(11, "Angelo", "Morales", "Acuña", "angelo789@gmail.com", "Wc88+t7W", 2, 4)
                        new Usuario(12, "Karen", "Delgado", "Villalobos", "karendelgado@gmail.com", " L#67PsQn",3, 4)
                        

                    },
                    Roles = new List<Rol>
                    {
                        new Rol(1, "Usuario"), // Permisos se asignan automáticamente
                        new Rol(2, "Administrador"), // Permisos se asignan automáticamente
                        new Rol(3, "SuperAdministrador") // Permisos se asignan automáticamente
                    },
                    Entidades = new List<Entidad>
                    {
                        new Entidad(1, "3102234567", "ASADA Río Claro", "info@asaricr.go.cr", 24671342, "Calle Central, Río Claro, Puntarenas", "La ASADA Río Claro administra el servicio de agua potable en la comunidad, garantizando un suministro seguro y eficiente para los habitantes."),
                        new Entidad(2, "3103887654", "ASADA Los Laureles ", "info@asadaloslaureles.go.cr", 24893456, "200 m norte del parque, Los  Laureles, Heredia", "Asociación comunal encargada de la gestión del acueducto y el mantenimiento del agua potable en la zona de Los Laureles."),
                        new Entidad(3, "3101876543", "Municipalidad de San Pedro", "info@cdss.go,cr", 24782345, "Avenida Principal, San Pedro, San José", "Instituto gubernamental responsable del desarrollo local, la infraestructura y la prestación de servivios en San Pedro."),
                        new Entidad(4, "3104345678", "Comité Municipal de Cultura San Carlos", "info@cds.co.cr",24984567, "Frente al Parque Central, San Carlos","Entidad ascrita a la Municipalidad de San Carlos encargada de fomentar el arte, la cultura y la educación en la comunidad.")
                    },
                    Nacientes = new List<Naciente>
                    {
                        new Naciente(1, "Naciente Río Celeste", "Parque Nacional Celeste", 10.737, -85.013, "Naciente de aguas turquesas ubicada en el Parque Nacional Celeste", 7, 19, 19, 1),
                        new Naciente(2, "Naciente Las Trancas", "Parque Nacional Tracas", 10.200, -84.220, "Aguas termales de la región volcánica", 2, 6, 6, 1),
                        new Naciente(3, "Naciente Río Blanco", "Reserva Forestal Río Blanco", 9.880, -84.330, "Naciente de aguas frescas en una zona forestal de la región", 1, 2, 2, 1),
                        new Naciente(4, "Naciente Río Pirrís", "Parque Natural Río Pirrís", 9.620, -83.960, "Aguas que nacen en las montañas cercanas al Parque Natural Río Pirrís", 3, 8, 8, 1),
                        new Naciente(5, "Naciente Río Grande", "Reserva Río Grande", 10.303, -84.821, "Naciente de aguas que atraviesan el Río Grande", 5, 14, 14, 2),
                        new Naciente(6, "Naciente Río Naranjo", "Reserva Forestal Río Naranjo", 10.102, -84.153, "Naciente ubicada en una reserva de alta biodiversidad", 2, 4, 4, 2),
                        new Naciente(7, "Naciente Río Azul", "Parque Nacional Río Azul", 10.200, -83.700, "Aguas cristalinas que fluyen a través de una zona montañosa", 4, 11, 11, 2),
                        new Naciente(8, "Naciente Río Sierpe", "Parque Nacional Río Sierpe", 8.776, -83.600, "Aguas de un río en una de las áreas más biodiversas del país", 6, 17, 17, 2),
                        new Naciente(9, "Naciente Río Tempisque", "Bosque Tropical Seco", 9.490, -83.790, "Naciente de un río de importancia ecológica en Tempisque", 5, 13, 13, 3),
                        new Naciente(10, "Naciente Río La Estrella", "Área de Conservación La Estrella", 9.490, -83.790, "Aguas que nacen en la una área de conservación importante", 5, 15, 15, 3),
                        new Naciente(11, "Naciente Río Nochebuena", "Parque Nacional Los Quetzales", 9.070, -83.900, "Naciente ubicada en un bosque nuboso en la región sur del país", 7, 21, 21, 3),
                        new Naciente(12, "Naciente Río Pacuare", "Reserva Natural Pacuare", 10.073, -83.725, "Aguas que fluyen por una de las zonas más vírgenes del país", 7, 20, 20, 3),
                        new Naciente(13, "Naciente Río Savegre", "Parque Nacional Manuel Antonio", 9.497, -84.130, "Naciente de aguas cristalinas en una zona protegida", 6, 16, 16, 4),
                        new Naciente(14, "Naciente Río Esperanza", "Reserva Biológica Esperanza", 10.320, -84.550, "Naciente de un río que atraviesa una reserva de gran biodiversidad", 2, 5, 5, 4),
                        new Naciente(15, "Naciente Río Cielito", "Parque Nacional Cielito", 10.380, -84.050, "Naciente de un río que fluye por la región montañosa del parque", 4, 12, 12, 4),
                        new Naciente(16, "Naciente Río Flores", "Reserva Forestal de Río Flores", 8.710, -82.940, "Aguas que nacen en la región montañosa de Flores", 1, 1, 1, 4)

                    },
                    SitiosDeMuestreo = new List<SitioDeMuestreo>
                    {
                        new SitioDeMuestreo(1, "Naciente Río Celeste", 7, 19, 19, 1),
                        new SitioDeMuestreo(2, "Naciente Las Trancas", 2, 6, 6, 1),
                        new SitioDeMuestreo(3, "Naciente Río Blanco", 1, 2, 2, 1),
                        new SitioDeMuestreo(4, "Naciente Río Pirrís", 3, 8, 8, 1),
                        new SitioDeMuestreo(5, "Naciente Río Grande", 5, 14, 14, 1),
                        new SitioDeMuestreo(6, "Naciente Río Naranjo", 2, 4, 4, 1),
                        new SitioDeMuestreo(7, "Naciente Río Azul", 4, 11, 11, 2),
                        new SitioDeMuestreo(8, "Naciente Río Sierpe", 6, 17, 17, 2),
                        new SitioDeMuestreo(9, "Naciente Río Tempisque", 5, 13, 13, 2),
                        new SitioDeMuestreo(10, "Naciente Río La Estrella",  5, 15, 15, 2),
                        new SitioDeMuestreo(11, "Naciente Río Nochebuena", 7, 21, 21, 2),
                        new SitioDeMuestreo(12, "Naciente Río Pacuare", 7, 20, 20, 2),
                        new SitioDeMuestreo(13, "Naciente Río Celeste", 7, 19, 19,3),
                        new SitioDeMuestreo(14, "Naciente Las Trancas", 2, 6, 6, 3),
                        new SitioDeMuestreo(15, "Naciente Río Blanco", 1, 2, 2, 3),
                        new SitioDeMuestreo(16, "Naciente Río Pirrís", 3, 8, 8, 3),
                        new SitioDeMuestreo(17, "Naciente Río Grande", 5, 14, 14, 3),
                        new SitioDeMuestreo(18, "Naciente Río Naranjo", 2, 4, 4, 3),
                        new SitioDeMuestreo(19, "Naciente Río Azul", 4, 11, 11, 4),
                        new SitioDeMuestreo(20, "Naciente Río Sierpe", 6, 17, 17, 4),
                        new SitioDeMuestreo(21, "Naciente Río Tempisque", 5, 13, 13, 4),
                        new SitioDeMuestreo(22, "Naciente Río La Estrella", 5, 13, 13, 4),
                        new SitioDeMuestreo(23, "Naciente Río Nochebuena", 7, 21, 21, 4),
                        new SitioDeMuestreo(24, "Naciente Río Pacuare", 7, 20, 20, 4)

                    },
                    Provincias = new List<Provincia>
                    {
                        new Provincia(1, "San José"),
                        new Provincia(2, "Alajuela"),
                        new Provincia(3, "Cartago"),
                        new Provincia(4, "Heredia"),
                        new Provincia(5, "Guanacaste"),
                        new Provincia(6, "Puntarenas"),
                        new Provincia(7, "Limón")
                    },
                    Cantones = new List<Canton>
                    {
                        new Canton(1, "San José", 1),
                        new Canton(2, "Escazú", 1),
                        new Canton(3, "Desamparados", 1),
                        new Canton(4, "Alajuela", 2),
                        new Canton(5, "San Ramón", 2),
                        new Canton(6, "Grecia", 2),
                        new Canton(7, "Cartago", 3),
                        new Canton(8, "Paraíso", 3),
                        new Canton(9, "La Unión", 3),
                        new Canton(10, "Heredia", 4),
                        new Canton(11, "Barva", 4),
                        new Canton(12, "Santo Domingo", 4),
                        new Canton(13, "Liberia", 5),
                        new Canton(14, "Nicoya", 5),
                        new Canton(15, "Santa Cruz", 5),
                        new Canton(16, "Puntarenas", 6),
                        new Canton(17, "Esparza", 6),
                        new Canton(18, "Golfito", 6),
                        new Canton(19, "Limón", 7),
                        new Canton(20, "Talamanca", 7),
                        new Canton(21, "Siquirres", 7)


                    },
                    Distritos = new List<Distrito>
                    {
                        new Distrito(1, "Carmen", 1),
                        new Distrito(2, "San Antonio", 2),
                        new Distrito(3, "San Miguel" 3),
                        new Distrito(4, "Carrizal", 4),
                        new Distrito(5, "Santiago", 5),
                        new Distrito(6, "San Isidro", 6),
                        new Distrito(7, "Oriental", 7),
                        new Distrito(8, "Orosi", 8),
                        new Distrito(9, "San Diego", 9),
                        new Distrito(10, "Mercedes", 10),
                        new Distrito(11, "San pablo", 11),
                        new Distrito(12, "San Vicente", 12),
                        new Distrito(13, "Cañas Dulces", 13),
                        new Distrito(14, "Nicoya", 14),
                        new Distrito(15, "Bolsón", 15),
                        new Distrito(16, "El Roble", 26),
                        new Distrito(17, "Buenos Aires", 17),
                        new Distrito(18, "Puerto Jimenéz", 18),
                        new Distrito(19, "Matama", 19),
                        new Distrito(20, "Bribri", 20),
                        new Distrito(21, "Barbilla", 21)

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
                string jsonData = File.ReadAllText(dataFilePath);
                return JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData);
            }
            return null; // Retorna null si el archivo no existe
        }

        public static void VerificarYCargarJson()
        {
            var datos = CargarJsonSiExiste();
            if (datos != null)
            {
                // Mensaje de depuración
                MessageBox.Show("JSON cargado exitosamente.");
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