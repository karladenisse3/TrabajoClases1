using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO1.ClaseEncapsulamiento
{
    public class Prestamo
    {
        public Prestamo()
        {

        }

        private string cancha;

        public string Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }


        public float Costo
        {
            get {
                if (this.Cancha=="FUTBOL")
                  {
                      return 20;
                  }
                  else if (this.Cancha=="FULBITO")
                  {
                      return 15;
                  }
                  else
                  {
                      return 5;
                  }

            }
        }

        private int horas;

        public int Horas
        {
            get { return horas; }
            set {
                if (value > 3)
                {
                    throw new Exception("No se puede solicitar ninguna cancha por más de 3 horas.");//Para crear una exception
                }

                horas = value; }
        }


        public double Subtotal
        {
            get {
                return Costo*Horas;
            }
           
        }
        private double descuento;

        public double Descuento
        {
            get {
             
                return descuento;
            }
            set
            {
                if (value!=10 && value!=20 )
                {
                    throw new Exception("El descuento debe ser entre 10% y 20% ");

                }
                descuento = value;

            }

        }

      
        public double Subtotal2
        {
            get {

                return Subtotal - (Subtotal*Descuento/100);
            }
        }

   
        public double Iva
        {
            get { return Subtotal2*0.12; }
        }

   
        public double Final
        {
            get {
                return Subtotal2+Iva;
            }
        }

        private double pagado;

        public double Pagado
        {
            get { return pagado; }
            set {
                if (value < (Subtotal*0.5) )
                {
                    throw new Exception("Debe cancelar por lo menos el 50% de la cancha");//Para crear una exception
                }
                pagado = value;
            }
        }

    
        public double Pendiente
        {
            get { return Final-Pagado; }
        }

        private string estado;

        public string Estado
        {
            get {
                if (Pendiente == 0)
                {
                    Console.WriteLine("PAGADO");
                }
                else
                {
                    Console.WriteLine("PENDIENTE");
                }
                return estado;
            }
            set { estado = value; }
        }


    }
}
