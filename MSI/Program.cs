using MSI.Entities;
using MSI.Services;
using System;

namespace Msi
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Bienvenido a la tienda");
            Persona cliente = new Persona();
            cliente.Registro();
            Productos cobro = new Productos();
            cobro.Venta();
        }
    }
    
}

