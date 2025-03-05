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

                    },
                    Roles = new List<Rol>
                    {

                    },
                    Entidades = new List<Entidad>
                    {

                    },
                    Nacientes = new List<Naciente>
                    {

                    },
                    SitiosDeMuestreo = new List<SitioDeMuestreo>
                    {

                    },
                    Provincias = new List<Provincia>
                    {

                    },
                    Cantones = new List<Canton>
                    {

                    },
                    Distritos = new List<Distrito>
                    {

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
        // Método para cargar el archivo JSON si existe
        public static Dictionary<string, object> CargarJsonSiExiste()
        {
            if (File.Exists(dataFilePath))
            {
                // Mensaje de depuración
                MessageBox.Show("Archivo JSON encontrado. Cargando datos...");
                // Cargar el archivo JSON en un diccionario
                string jsonData = File.ReadAllText(dataFilePath);
                // Retornar el diccionario con los datos
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
        // Método para guardar los usuarios en el archivo JSON
        public static void GuardarUsuarios(List<Usuario> nuevosUsuarios, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());

            if (!permisos.Contains("create"))
            {
                MessageBox.Show("No tienes permisos para crear usuarios.");
                return;
            }
            // Validar los datos de los usuarios
            foreach (var nuevoUsuario in nuevosUsuarios)
            {
                if (!Validaciones.ValidarId(nuevoUsuario.Id))
                {
                    MessageBox.Show($"Error: El ID del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
                if (!Validaciones.ValidarNombre(nuevoUsuario.Nombre_Usuario))
                {
                    MessageBox.Show($"Error: El nombre del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
                if (!Validaciones.ValidarNombre(nuevoUsuario.PrimerApellido))
                {
                    MessageBox.Show($"Error: El primer apellido del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
                if (!Validaciones.ValidarNombre(nuevoUsuario.SegundoApellido))
                {
                    MessageBox.Show($"Error: El segundo apellido del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
                if (!Validaciones.ValidarCorreo(nuevoUsuario.Correo))
                {
                    MessageBox.Show($"Error: El correo electrónico del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
                if (!Validaciones.ValidarContrasena(nuevoUsuario.Contrasena))
                {
                    MessageBox.Show($"Error: La contraseña del usuario {nuevoUsuario.Id} no es válida.");
                    return;
                }
                if (!Validaciones.ValidarId(nuevoUsuario.Id_Entidad))
                {
                    MessageBox.Show($"Error: El ID de la entidad del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
                if (!Validaciones.ValidarRol(nuevoUsuario.Id_Rol.ToString()))
                {
                    MessageBox.Show($"Error: El rol del usuario {nuevoUsuario.Id} no es válido.");
                    return;
                }
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de usuarios
            var usuariosActuales = JsonSerializer.Deserialize<List<Usuario>>(allData["Usuarios"].ToString());
            // Verificar si los nuevos usuarios ya existen
            foreach (var nuevoUsuario in nuevosUsuarios)
            {
                var usuarioExistente = usuariosActuales.FirstOrDefault(u => u.Id == nuevoUsuario.Id);
                if (usuarioExistente != null)
                {
                    MessageBox.Show($"Error: El usuario con ID {nuevoUsuario.Id} ya existe.");
                    return; // Detener el proceso si el usuario ya existe
                }
            }
            // Agregar los nuevos usuarios a la lista actual
            usuariosActuales.AddRange(nuevosUsuarios);
            // Actualizar la sección de usuarios en el diccionario
            allData["Usuarios"] = usuariosActuales;
            // Serializar el diccionario actualizado a JSON
            string jsonData = JsonSerializer.Serialize(allData);
            // Guardar el JSON actualizado en el archivo
            File.WriteAllText(dataFilePath, jsonData);
            // Mensaje de éxito
            MessageBox.Show("Usuarios guardados exitosamente en el archivo JSON.");
        }
        public static void EliminarUsuario(int idUsuarioAEliminar, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("delete"))
            {
                MessageBox.Show("No tienes permisos para eliminar usuarios.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de usuarios
            var usuariosActuales = JsonSerializer.Deserialize<List<Usuario>>(allData["Usuarios"].ToString());
            // Buscar el usuario por ID
            var usuarioAEliminar = usuariosActuales.FirstOrDefault(u => u.Id == idUsuarioAEliminar);
            if (usuarioAEliminar != null)
            {
                // Eliminar el usuario
                usuariosActuales.Remove(usuarioAEliminar);

                // Actualizar la sección de usuarios en el diccionario
                allData["Usuarios"] = usuariosActuales;

                // Serializar el diccionario actualizado a JSON
                string jsonData = JsonSerializer.Serialize(allData);

                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(dataFilePath, jsonData);

                // Mensaje de éxito
                MessageBox.Show("Usuario eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }
        }
        public static void EditarUsuario(Usuario usuarioEditado, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());

            if (!permisos.Contains("update"))
            {
                MessageBox.Show("No tienes permisos para editar usuarios.");
                return;
            }
            // Validar los datos del usuario editado
            if (!Validaciones.ValidarId(usuarioEditado.Id))
            {
                MessageBox.Show("Error: El ID del usuario no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(usuarioEditado.Nombre_Usuario))
            {
                MessageBox.Show("Error: El nombre del usuario no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(usuarioEditado.PrimerApellido))
            {
                MessageBox.Show("Error: El primer apellido del usuario no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(usuarioEditado.SegundoApellido))
            {
                MessageBox.Show("Error: El segundo apellido del usuario no es válido.");
                return;
            }
            if (!Validaciones.ValidarCorreo(usuarioEditado.Correo))
            {
                MessageBox.Show("Error: El correo electrónico del usuario no es válido.");
                return;
            }
            if (!Validaciones.ValidarContrasena(usuarioEditado.Contrasena))
            {
                MessageBox.Show("Error: La contraseña del usuario no es válida.");
                return;
            }
            if (!Validaciones.ValidarId(usuarioEditado.Id_Entidad))
            {
                MessageBox.Show("Error: El ID de la entidad del usuario no es válido.");
                return;
            }
            if (!Validaciones.ValidarRol(usuarioEditado.Id_Rol.ToString()))
            {
                MessageBox.Show("Error: El rol del usuario no es válido.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de usuarios
            var usuariosActuales = JsonSerializer.Deserialize<List<Usuario>>(allData["Usuarios"].ToString());
            // Buscar el usuario por ID
            var usuarioExistente = usuariosActuales.FirstOrDefault(u => u.Id == usuarioEditado.Id);
            if (usuarioExistente != null)
            {
                // Actualizar los datos del usuario existente
                usuarioExistente.Nombre_Usuario = usuarioEditado.Nombre_Usuario;
                usuarioExistente.PrimerApellido = usuarioEditado.PrimerApellido;
                usuarioExistente.SegundoApellido = usuarioEditado.SegundoApellido;
                usuarioExistente.Correo = usuarioEditado.Correo;
                usuarioExistente.Contrasena = usuarioEditado.Contrasena;
                usuarioExistente.Id_Rol = usuarioEditado.Id_Rol;
                usuarioExistente.Id_Entidad = usuarioEditado.Id_Entidad;
                // Actualizar la sección de usuarios en el diccionario
                allData["Usuarios"] = usuariosActuales;
                // Serializar el diccionario actualizado a JSON
                string jsonData = JsonSerializer.Serialize(allData);
                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(dataFilePath, jsonData);
                // Mensaje de éxito
                MessageBox.Show("Usuario editado exitosamente.");
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }
        }

        public static void GuardarNaciente(Naciente nuevoNaciente, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("create"))
            {
                MessageBox.Show("No tienes permisos para crear nacientes.");
                return;
            }
            // Validar los datos del naciente
            if (!Validaciones.ValidarId(nuevoNaciente.Id))
            {
                MessageBox.Show("Error: El ID del naciente no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevoNaciente.Nombre_Naciente))
            {
                MessageBox.Show("Error: El nombre del naciente no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevoNaciente.Direccion_Naciente))
            {
                MessageBox.Show("Error: La dirección del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarLatitud(nuevoNaciente.latitud))
            {
                MessageBox.Show("Error: La latitud del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarLongitud(nuevoNaciente.longitud))
            {
                MessageBox.Show("Error: La longitud del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevoNaciente.Descripcion_Naciente))
            {
                MessageBox.Show("Error: La descripción del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarId(nuevoNaciente.Id_Entidad))
            {
                MessageBox.Show("Error: El ID de la entidad no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nuevoNaciente.Id_Distrito))
            {
                MessageBox.Show("Error: El ID del distrito no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nuevoNaciente.Id_Provincia))
            {
                MessageBox.Show("Error: El ID de la provincia no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nuevoNaciente.Id_Canton))
            {
                MessageBox.Show("Error: El ID del cantón no es válido.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de nacientes
            var nacientesActuales = JsonSerializer.Deserialize<List<Naciente>>(allData["Nacientes"].ToString());
            // Verificar si el naciente ya existe
            var nacienteExistente = nacientesActuales.FirstOrDefault(n => n.Id == nuevoNaciente.Id);
            if (nacienteExistente != null)
            {
                MessageBox.Show($"Error: El naciente con ID {nuevoNaciente.Id} ya existe.");
                return; // Detener el proceso

            }
            // Agregar el nuevo naciente a la lista actual
            nacientesActuales.Add(nuevoNaciente);
            // Actualizar la sección de nacientes en el diccionario
            allData["Nacientes"] = nacientesActuales;
            // Serializar el diccionario actualizado a JSON
            string jsonData = JsonSerializer.Serialize(allData);
            // Guardar el JSON actualizado en el archivo
            File.WriteAllText(dataFilePath, jsonData);
            // Mensaje de éxito
            MessageBox.Show("Naciente guardado exitosamente.");
        }
        public static void EliminarNaciente(int idNacienteAEliminar, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("delete"))
            {
                MessageBox.Show("No tienes permisos para eliminar nacientes.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de nacientes
            var nacientesActuales = JsonSerializer.Deserialize<List<Naciente>>(allData["Nacientes"].ToString());
            // Buscar el naciente por ID
            var nacienteAEliminar = nacientesActuales.FirstOrDefault(n => n.Id == idNacienteAEliminar);
            if (nacienteAEliminar != null)
            {
                // Eliminar el naciente
                nacientesActuales.Remove(nacienteAEliminar);
                // Actualizar la sección de nacientes en el diccionario
                allData["Nacientes"] = nacientesActuales;
                // Serializar el diccionario actualizado a JSON
                string jsonData = JsonSerializer.Serialize(allData);
                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(dataFilePath, jsonData);
                // Mensaje de éxito
                MessageBox.Show("Naciente eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show("El naciente no existe.");
            }
        }
        public static void EditarNaciente(Naciente nacienteEditado, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("update"))
            {
                MessageBox.Show("No tienes permisos para editar nacientes.");
                return;
            }
            // Validar los datos del naciente editado
            if (!Validaciones.ValidarId(nacienteEditado.Id))
            {
                MessageBox.Show("Error: El ID del naciente no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(nacienteEditado.Nombre_Naciente))
            {
                MessageBox.Show("Error: El nombre del naciente no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(nacienteEditado.Direccion_Naciente))
            {
                MessageBox.Show("Error: La dirección del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarLatitud(nacienteEditado.latitud))
            {
                MessageBox.Show("Error: La latitud del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarLongitud(nacienteEditado.longitud))
            {
                MessageBox.Show("Error: La longitud del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarNombre(nacienteEditado.Descripcion_Naciente))
            {
                MessageBox.Show("Error: La descripción del naciente no es válida.");
                return;
            }
            if (!Validaciones.ValidarId(nacienteEditado.Id_Entidad))
            {
                MessageBox.Show("Error: El ID de la entidad no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nacienteEditado.Id_Distrito))
            {
                MessageBox.Show("Error: El ID del distrito no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nacienteEditado.Id_Provincia))
            {
                MessageBox.Show("Error: El ID de la provincia no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nacienteEditado.Id_Canton))
            {
                MessageBox.Show("Error: El ID del cantón no es válido.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de nacientes
            var nacientesActuales = JsonSerializer.Deserialize<List<Naciente>>(allData["Nacientes"].ToString());
            // Buscar el naciente por ID
            var nacienteExistente = nacientesActuales.FirstOrDefault(n => n.Id == nacienteEditado.Id);
            if (nacienteExistente != null)
            {
                // Actualizar los datos del naciente existente
                nacienteExistente.Nombre_Naciente = nacienteEditado.Nombre_Naciente;
                nacienteExistente.Direccion_Naciente = nacienteEditado.Direccion_Naciente;
                nacienteExistente.latitud = nacienteEditado.latitud;
                nacienteExistente.longitud = nacienteEditado.longitud;
                nacienteExistente.Descripcion_Naciente = nacienteEditado.Descripcion_Naciente;
                nacienteExistente.Id_Provincia = nacienteEditado.Id_Provincia;
                nacienteExistente.Id_Canton = nacienteEditado.Id_Canton;
                nacienteExistente.Id_Distrito = nacienteEditado.Id_Distrito;
                nacienteExistente.Id_Entidad = nacienteEditado.Id_Entidad;
                // Actualizar la sección de nacientes en el diccionario
                allData["Nacientes"] = nacientesActuales;
                // Serializar el diccionario actualizado a JSON
                string jsonData = JsonSerializer.Serialize(allData);
                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(dataFilePath, jsonData);
                // Mensaje de éxito
                MessageBox.Show("Naciente editado exitosamente.");
            }
            else
            {
                MessageBox.Show("El naciente no existe.");
            }
        }
        public static void GuardarMedicionDeCaudal(MedicionDeCaudal nuevaMedicionDeCaudal, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("create"))
            {
                MessageBox.Show("No tienes permisos para crear mediciones de caudal.");
                return;
            }
            // Validar los datos de la medición de caudal
            if (!Validaciones.ValidarId(nuevaMedicionDeCaudal.Id))
            {
                MessageBox.Show("Error: El ID de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarDouble(nuevaMedicionDeCaudal.Capacidad))
            {
                MessageBox.Show("Error: La capacidad de la medición de caudal no es válida.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevaMedicionDeCaudal.Metodo))
            {
                MessageBox.Show("Error: El método de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevaMedicionDeCaudal.Observacione))
            {
                MessageBox.Show("Error: Las observaciones de la medición de caudal no son válidas.");
                return;
            }
            if (!Validaciones.ValidarFecha(nuevaMedicionDeCaudal.Fecha))
            {
                MessageBox.Show("Error: La fecha de la medición de caudal no es válida.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevaMedicionDeCaudal.Clima))
            {
                MessageBox.Show("Error: El clima de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(nuevaMedicionDeCaudal.Realizado))
            {
                MessageBox.Show("Error: El campo 'Realizado' de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nuevaMedicionDeCaudal.Id_SitioDeMuestreo))
            {
                MessageBox.Show("Error: El ID del sitio de muestreo no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(nuevaMedicionDeCaudal.Id_Naciente))
            {
                MessageBox.Show("Error: El ID del naciente no es válido.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de mediciones de caudal
            var medicionesDeCaudalActuales = JsonSerializer.Deserialize<List<MedicionDeCaudal>>(allData["MedicionesDeCaudal"].ToString());
            // Verificar si la medición de caudal ya existe
            var medicionDeCaudalExistente = medicionesDeCaudalActuales.FirstOrDefault(m => m.Id == nuevaMedicionDeCaudal.Id);
            if (medicionDeCaudalExistente != null)
            {
                MessageBox.Show($"Error: La medición de caudal con ID {nuevaMedicionDeCaudal.Id} ya existe.");
                return; // Detener el proceso
            }
            // Agregar la nueva medición de caudal a la lista actual
            medicionesDeCaudalActuales.Add(nuevaMedicionDeCaudal);
            // Actualizar la sección de mediciones de caudal en el diccionario
            allData["MedicionesDeCaudal"] = medicionesDeCaudalActuales;
            // Serializar el diccionario actualizado a JSON
            string jsonData = JsonSerializer.Serialize(allData);
            // Guardar el JSON actualizado en el archivo
            File.WriteAllText(dataFilePath, jsonData);
            // Mensaje de éxito
            MessageBox.Show("Medición de caudal guardada exitosamente.");
        }
        public static void EliminarMedicionDeCaudal(int idMedicionDeCaudalAEliminar, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("delete"))
            {
                MessageBox.Show("No tienes permisos para eliminar mediciones de caudal.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de mediciones de caudal
            var medicionesDeCaudalActuales = JsonSerializer.Deserialize<List<MedicionDeCaudal>>(allData["MedicionesDeCaudal"].ToString());
            // Buscar la medición de caudal por ID
            var medicionDeCaudalAEliminar = medicionesDeCaudalActuales.FirstOrDefault(m => m.Id == idMedicionDeCaudalAEliminar);
            if (medicionDeCaudalAEliminar != null)
            {
                // Eliminar la medición de caudal
                medicionesDeCaudalActuales.Remove(medicionDeCaudalAEliminar);
                // Actualizar la sección de mediciones de caudal en el diccionario
                allData["MedicionesDeCaudal"] = medicionesDeCaudalActuales;
                // Serializar el diccionario actualizado a JSON
                string jsonData = JsonSerializer.Serialize(allData);
                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(dataFilePath, jsonData);
                // Mensaje de éxito
                MessageBox.Show("Medición de caudal eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show("La medición de caudal no existe.");
            }
        }
        public static void EditarMedicionDeCaudal(MedicionDeCaudal medicionDeCaudalEditada, int idRolUsuarioActual)
        {
            // Verificar permisos del usuario actual
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioActual.ToString());
            if (!permisos.Contains("update"))
            {
                MessageBox.Show("No tienes permisos para editar mediciones de caudal.");
                return;
            }
            // Validar los datos de la medición de caudal editada
            if (!Validaciones.ValidarId(medicionDeCaudalEditada.Id))
            {
                MessageBox.Show("Error: El ID de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarDouble(medicionDeCaudalEditada.Capacidad))
            {
                MessageBox.Show("Error: La capacidad de la medición de caudal no es válida.");
                return;
            }
            if (!Validaciones.ValidarNombre(medicionDeCaudalEditada.Metodo))
            {
                MessageBox.Show("Error: El método de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(medicionDeCaudalEditada.Observacione))
            {
                MessageBox.Show("Error: Las observaciones de la medición de caudal no son válidas.");
                return;
            }
            if (!Validaciones.ValidarFecha(medicionDeCaudalEditada.Fecha))
            {
                MessageBox.Show("Error: La fecha de la medición de caudal no es válida.");
                return;
            }
            if (!Validaciones.ValidarNombre(medicionDeCaudalEditada.Clima))
            {
                MessageBox.Show("Error: El clima de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarNombre(medicionDeCaudalEditada.Realizado))
            {
                MessageBox.Show("Error: El campo 'Realizado' de la medición de caudal no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(medicionDeCaudalEditada.Id_SitioDeMuestreo))
            {
                MessageBox.Show("Error: El ID del sitio de muestreo no es válido.");
                return;
            }
            if (!Validaciones.ValidarId(medicionDeCaudalEditada.Id_Naciente))
            {
                MessageBox.Show("Error: El ID del naciente no es válido.");
                return;
            }
            // Cargar el JSON completo en un diccionario
            var allData = JsonSerializer.Deserialize<Dictionary<string, object>>(File.ReadAllText(dataFilePath));
            // Cargar la lista actual de mediciones de caudal
            var medicionesDeCaudalActuales = JsonSerializer.Deserialize<List<MedicionDeCaudal>>(allData["MedicionesDeCaudal"].ToString());
            // Buscar la medición de caudal por ID
            var medicionDeCaudalExistente = medicionesDeCaudalActuales.FirstOrDefault(m => m.Id == medicionDeCaudalEditada.Id);
            if (medicionDeCaudalExistente != null)
            {
                // Actualizar los datos de la medición de caudal existente
                medicionDeCaudalExistente.Capacidad = medicionDeCaudalEditada.Capacidad;
                medicionDeCaudalExistente.Metodo = medicionDeCaudalEditada.Metodo;
                medicionDeCaudalExistente.Observacione = medicionDeCaudalEditada.Observacione;
                medicionDeCaudalExistente.Fecha = medicionDeCaudalEditada.Fecha;
                medicionDeCaudalExistente.Clima = medicionDeCaudalEditada.Clima;
                medicionDeCaudalExistente.Realizado = medicionDeCaudalEditada.Realizado;
                medicionDeCaudalExistente.Id_Naciente = medicionDeCaudalEditada.Id_Naciente;
                medicionDeCaudalExistente.Id_SitioDeMuestreo = medicionDeCaudalEditada.Id_SitioDeMuestreo;
                // Actualizar la sección de mediciones de caudal en el diccionario
                allData["MedicionesDeCaudal"] = medicionesDeCaudalActuales;
                // Serializar el diccionario actualizado a JSON
                string jsonData = JsonSerializer.Serialize(allData);
                // Guardar el JSON actualizado en el archivo
                File.WriteAllText(dataFilePath, jsonData);
                // Mensaje de éxito
                MessageBox.Show("Medición de caudal editada exitosamente.");
            }
            else
            {
                MessageBox.Show("La medición de caudal no existe.");
            }



        }
    }
}
