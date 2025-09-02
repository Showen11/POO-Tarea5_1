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
        private string apellidos { get; set; }
        private string edad { get; set; }
        private DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        private string celular { get; set; }
        private string email { get; set; }
        private string pais { get; set; }
        private string ciudad { get; set; }
        private string direccion;

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

        public Persona(string p_nombre, string p_apellido, string p_direccion)
        {
            this.nombres = p_nombre;
            this.apellidos = p_apellido;
            this.direccion = p_direccion;
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
            return this.nombres +" "+ this.apellidos;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getDireccion()
        {
            return this.direccion;
        }

        public string getNombreCompleto(string p_nombre, string p_apellido)
        {
            this.nombres = p_nombre;
            this.apellidos = p_apellido;

            return this.nombres + " " + this.apellidos;
        }

       
    }
}
