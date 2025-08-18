using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    public class Persona
    {
        private string numeroid { get; set; }
        private string nombres  { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string edad { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public string telefono { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        public Persona (){ 
        this.nombres = "Jose";
        }

        public Persona(string p_nombre)
        {
            this.nombres = p_nombre;
        }

        public Persona(string p_nombre, string p_apellido)
        {
            this.nombres = p_nombre;
            this.apellidos = p_apellido;
        }

        public string getNombre()
        {
            return this.nombres;
        }

        public void setNombre(string p_nombres)
        {
            this.nombres = p_nombres;
        }

        public void setApellidos(string p_apellidos)
        {
            this.apellidos = p_apellidos;
        }

        public string getNombreCompleto()
        {
            return this.nombres + this.apellidos;
        }

        public string getNombreCompleto(string p_nombre, string p_apellido)
        {
            this.nombres = p_nombre;
            this.apellidos = p_apellido;
            return this.nombres + " " + this.apellidos;
        }


    }
}
