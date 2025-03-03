﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.Json.Serialization;
namespace recursosH
{
    public class MedicionalDeCaudal : BaseID
    {
        [JsonPropertyName("capacidad")]
        public int Capacidad { get; set; }
        [JsonPropertyName("metodo")]
        public string Metodo { get; set; }
        [JsonPropertyName("observacione")]
        public string Observacione { get; set; }
        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }
        [JsonPropertyName("realizado")]
        public string Realizado { get; set; }
        [JsonPropertyName("id_naciente")]
        public int Id_Naciente { get; set; }
        [JsonPropertyName("id_sitioDeMuestreo")]
        public int Id_SitioDeMuestreo { get; set; }
        public MedicionalDeCaudal() { }
        public MedicionalDeCaudal(int id_MedicionDeCaudal,int capacidad, string metodo, string observacione, DateTime fecha, string realizado, int id_naciente, int id_sitioDeMuestreo) : base(id_MedicionDeCaudal)
        {
            if (Validaciones.ValidarEntero(capacidad))
            {
                MessageBox.Show("Capacidad no valida");
                return;
            }
            if (Validaciones.ValidarNombre(metodo))
            {
                MessageBox.Show("Metodo no valido");
                return;
            }
            if (Validaciones.ValidarNombre(observacione))
            {
                MessageBox.Show("Observacion no valida");
                return;
            }
            if (Validaciones.ValidarFecha(fecha))
            {
                MessageBox.Show("Fecha no valida");
                return;
            }
            if (Validaciones.ValidarNombre(realizado))
            {
                MessageBox.Show("Realizado no valido");
                return;
            }
            if (Validaciones.ValidarId(id_naciente))
            {
                MessageBox.Show("ID naciente no valido");
                return;
            }
            if (Validaciones.ValidarId(id_sitioDeMuestreo))
            {
                MessageBox.Show("ID sitio de muestreo no valido");
                return;
            }
            this.Capacidad = capacidad;
            this.Metodo = metodo;
            this.Observacione = observacione;
            this.Fecha = fecha;
            this.Realizado = realizado;
            this.Id_Naciente = id_naciente;
            this.Id_SitioDeMuestreo = id_sitioDeMuestreo;
        }
        public override string ToString()
        {
            return $"Medicion de caudal:{Id} - {Capacidad}, Metodo: {Metodo}, Observacion: {Observacione}, Fecha: {Fecha}, Realizado: {Realizado}, Naciente: {Id_Naciente}, Sitio de muestreo: {Id_SitioDeMuestreo}";
        }
    }
}
