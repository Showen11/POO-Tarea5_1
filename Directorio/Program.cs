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
            Persona persona = new Persona();
            Marcador marcador = new Marcador(); 

            string nombrecompleto = string.Empty; //Inicia una cadena de texto vacia.

            persona.setNombre("Pedro Antonio");
            persona.setApellidos(" Perez Perez");

            nombrecompleto = persona.getNombreCompleto();


            Console.WriteLine("Persona 1: " + nombrecompleto + "Salario: "+ marcador.getSalario(44*4));

            nombrecompleto = persona.getNombreCompleto(" Jose Cecilio", "Del Valle");

            Console.WriteLine("Persona 2: " + nombrecompleto + "Salario: " + marcador.getSalario(35*4));

            Console.ReadLine();
        }
    }
}
