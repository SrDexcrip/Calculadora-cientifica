// codigo 8.0 calculadoracientifica
//by julio Nazario Beristain Gonzalez
//clase que representa una calculadora cientifica 

using System;

public class OperacionesAvanzadas
{
    public double potencia(double x, double y)
    {
            return Math.Pow(x, y);
    }//fin del metodo potencia()

    public double RaizCuadrada(double x)
    {
        return Math.Sqrt(x);
    }//fin del metodo RaizCuadrada()

    public double ValorAbsoluto(double x)
    {
        return Math.Abs(x);
    }//fin del metodo ValorAbsoluto()
}//fin de la clase OperacionesAvanzadas
