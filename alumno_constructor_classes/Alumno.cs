using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumno_constructor_classes
{
    internal class Alumno
    {
        //Propiedades
        private string Nombre;
        private int Edad;
        //Constructor
        public Alumno()
        {
            Nombre = "Abelardo Cruz Leos";
            Edad = 20;
        }
        //Metodos
        public void Imprimir_Nombre_Alumno()
        {
            Console.WriteLine("El Nombre del Alumno es: " + Nombre);
        }
        public void Imprimir_Edad_Alumno()
        {
            Console.WriteLine("La edad del Alumno es: " + Edad);
        }
        public void Imprimir_si_es_mayor_o_menor_Edad_Alumno()
        {
            if (Edad >=18)
            {
                Console.WriteLine("El Alumno es mayor de edad tiene: " + Edad);
            }
            else
            {
                Console.WriteLine("El Alumno es menor de edad tiene: " + Edad);
            }
        }
    }
}
