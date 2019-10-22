using System;
using EJERCICIO1.ClaseEncapsulamiento;

namespace EJERCICIO1

{
    class Program
    {
        static void Main(string[] args)
        {

            //Int16 x = Con Console.ReadLine();

            Prestamo prestamo=
                  new Prestamo();
            Console.WriteLine("Ingrese cancha a utilizar");
            String can = Console.ReadLine();
            prestamo.Cancha=can;

            Console.WriteLine("Ingrese horas a utilizar");
            string linea = Console.ReadLine();
            int hor = int.Parse(linea);
            prestamo.Horas = hor;
            
            Console.WriteLine("Ingrese el anticipo o pago a cancelar");
            double pag = double.Parse(Console.ReadLine());
            prestamo.Pagado = pag;

            Console.WriteLine("Ingrese el descuento a aplicar que es entre 10% y 20%");
            double des = double.Parse(Console.ReadLine());
            prestamo.Descuento = des;

            Console.WriteLine("\n");
            Console.WriteLine("Subtotal: " + prestamo.Subtotal);
            Console.WriteLine("Descuento: " + prestamo.Descuento);
            Console.WriteLine("IVA: " + prestamo.Iva);
            Console.WriteLine("Total Final: " + prestamo.Final);
            Console.WriteLine("Valor Pagado: " + prestamo.Pagado);
            Console.WriteLine("Saldo Pendiente: " + prestamo.Pendiente);
            Console.WriteLine("Deuda: " + prestamo.Estado);
            Console.Read();
        }
    }
}
