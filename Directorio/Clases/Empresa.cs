using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Directorio.Clases
    {
        public class Empresa : Persona
        {
            private string razonsocial { set; get; }
            private string nombrecomercial { set; get; }
            private string registroTributario;

            public Empresa()
            {

            }

            public Empresa(string razonsocial)
            {
                this.razonsocial = razonsocial;
            }

        public Empresa(string p_nombre, string p_apellido) : base (p_nombre, p_apellido)
        {


        }

        public Empresa(string telefono, string email, string direccion) : base (telefono, email, direccion)
        {

        }

            public Empresa(string telefono, string email, string direccion, string razonsocial, string nombrecomercial, string registroTributario)
        {
                this.razonsocial = razonsocial;
                this.nombrecomercial = nombrecomercial;
                this.registroTributario = registroTributario;
            }

            public void setRazonSocial(string razonsocial)
            {
                this.razonsocial = razonsocial;
            }

            public string getRazonSocial()
            {
                return this.razonsocial;
            }

            public void setNombreComercial(string nombrecomercial)
            {
                this.nombrecomercial = nombrecomercial;
            }

            public string getNombreComercial()
            {
                return this.nombrecomercial;
            }

        }
    }


