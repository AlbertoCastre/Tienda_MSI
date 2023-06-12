using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSI.Entities
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public string Correo { get; set; }

        public void Registro() 
        {
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono");
            Telefono= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su correo");
            Correo = Console.ReadLine();

        }
    }
}
