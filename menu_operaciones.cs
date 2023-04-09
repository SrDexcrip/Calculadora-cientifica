// codigo 8.0 calculadoracientifica
//by julio Nasario Beristain Gonzalez
//clase que continue el menu de operaciones

using Microsoft.VisualBasic;
using System;

public class MenuOperaciones
{
    public void MostrarMenu()
    {
        OperacionesBasicas opB = new OperacionesBasicas();
        OperacionesAvanzadas opA = new OperacionesAvanzadas();
        CalculadoraCientifica mensaje = new CalculadoraCientifica("Calculadora elegante");

        bool salir = false;
        while (!salir) 
        {
            try
            {
                mensaje.MensajeBienvenida();
                Console.WriteLine("1-   suma");
                Console.WriteLine("2-   resta");
                Console.WriteLine("3-   multiplicacion");
                Console.WriteLine("4-   potencia");
                Console.WriteLine("5-   Raiz Cuadrada");
                Console.WriteLine("6-   Valor Absoluto");
                Console.WriteLine("7-   Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingresar el primer numero a sumar");
                        double s1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("ingresar el segundo numero a sumar");
                        double s2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("el resultado de la suma es: {0}", opB.suma(s1, s2));
                        break;

                    case 2:
                        Console.WriteLine("ingresar el primer numero a restar");
                        double r1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("ingresar el segundo numero a restar");
                        double r2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("el resultado de la suma es: {0}", opB.resta(r1, r2));
                        break;

                    case 3:
                        Console.WriteLine("ingresar el primer numero a multiplicar");
                        double m1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("ingresar el segundo numero a multiplicar");
                        double m2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("el resultado de la suma es: {0}", opB.suma(m1, m2));
                        break;

                }


            } //fin de try
        
        }
    }//fin del metodo MostrarMenu
}//fin de la clase MenuOperaciones
