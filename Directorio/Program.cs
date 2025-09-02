using Directorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona cliente = new Persona();
            

            cliente.setNombre("Pablito");
            cliente.setApellidos(" Canales");
            cliente.setDireccion("Col. Las Colinas, Sector X, Tegucigalpa");

            Empresa empresa = new Empresa(
                "222222222222",
                "patito@gmail.com",
                "tegucigalpa",
                "patito sa",
                "Patito",
                "000000000000"
                );
            Console.WriteLine(empresa.getDireccion() +" " +empresa.getRazonSocial());



            Console.ReadLine();
        }

        static void ejemploClassPersona()
        {
            Persona persona = new Persona();               //Declaracion de un objeto de tipo Persona.
            Marcador marcador = new Marcador();            //Declaracion de un objeto de tipo Marcador.

            string nombrecompleto = string.Empty; //Inicia una cadena de texto vacia.

            persona.setNombre("Pedro Antonio");
            persona.setApellidos(" Perez Perez");

            nombrecompleto = persona.getNombreCompleto();


            Console.WriteLine("Persona 1: " + nombrecompleto + "Salario: " + marcador.getSalario(44 * 4));

            nombrecompleto = persona.getNombreCompleto(" Jose Cecilio", "Del Valle");

            Console.WriteLine("Persona 2: " + nombrecompleto + "Salario: " + marcador.getSalario(35 * 4));
        }

        static void ejemploList()
        {
            List<string> frutas = new List<string>();

            frutas.Add("Manzana");
            frutas.Add("Pera");

            Console.WriteLine(frutas[0]);
            // Console.WriteLine(frutas[0]);
            // Console.WriteLine(frutas[1]);


            //Estructura de repeticion for each para recorrer la lista
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }

        static void validarNumero(int num)
        {
            //Condiciones

            if (num < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es positivo");
            }
        }

        static void ciclowhile()
        {
            int final = 0;
            while (final < 5)
            {
                Console.WriteLine("El valor del contador es: " + final);
                final++;
            }
        }


        static void ejemploMenu()
        {
            List<Persona> personas = new List<Persona>();
            string continuar = "Y";
            string nombre = string.Empty;
            string apellidos = string.Empty;

            while (continuar == "Y" || continuar == "y")
            {
                Console.WriteLine("Ingrese un nombre...");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese apellidos");
                apellidos = Console.ReadLine();

                personas.Add(new Persona(nombre, apellidos));
                Console.WriteLine("Desea ingresar otra persona? (Y/N)");

                continuar = Console.ReadLine();

            }

            foreach (Persona per in personas)
            {
                Console.WriteLine(per.getNombreCompleto());
            }

        }
    }
}