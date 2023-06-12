using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MSI.Services
{
    public class Productos
    {
        public double P1, temp, total, descuento;
        public double resultado;
        public int Opcion;
        public void Venta() 
        {
            Console.Clear();
            for(int i = 1; i <= 5; i++) 
            {
                Console.WriteLine($"Ingrese el precio del {i} producto");
                P1 = double.Parse(Console.ReadLine());
                total = total +P1;                
            }                       
            Console.WriteLine("Su total es de: "+total);
            
            if(total>5000 && total<8000)
                {
                Console.WriteLine("A su compra se le agrego el 10% de descuento");
                descuento = total * .10;
                Console.WriteLine($"El total a pagar es $ {descuento}");
            }
            if (total>=8000 && total<10000)
            {
                Console.WriteLine("POR SU COMPRA HA OBTENIDO 3 MSI");
                descuento = total / 3;
                Console.WriteLine($"El total a pagar es $ {descuento}");
            }
            if(total>=10000)
            {
                Console.WriteLine("Tiene disponible el método de pago de 3 o 6 MSI");
                Console.WriteLine("1) 6 MSI    2) 12MSI");
                Opcion = int.Parse(Console.ReadLine());
                switch (Opcion)
                {
                    case 1: Console.WriteLine("Usted pagara por 6 meses");
                        descuento = total / 6;
                        Console.WriteLine(descuento);
                        break;
                    case 2:
                        Console.WriteLine("Usted pagara por 12 meses");
                        descuento = total / 12;
                        Console.WriteLine(descuento);
                        break; 
                    default:
                        break;
                }

            }
        }


    }
}
