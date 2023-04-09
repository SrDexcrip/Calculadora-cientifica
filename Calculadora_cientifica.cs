// codigo 8.0 calculadoracientifica
//by julio Nazario Beristain Gonzalez
//clase que representa una calculadora cientifica 
using System;

public class CalculadoraCientifica
{
    private string nombre;

    public CalculadoraCientifica(string nombre)
    {
        NombreCalculadora = nombre;

    }// fin de constructor

    public string NombreCalculadora
    {
        get { return nombre; }
        set { nombre = value; }
    }// fin de la propiedad Nombrecalculadora

    public void MensajeBienvenida()
    {
        Console.WriteLine("bienvenido a la calculadora de matematicas {0}", NombreCalculadora);
    }//fin del metodo MensajeBienvenida()

    public void MensajeDespedida()
    {
        Console.WriteLine("Nos vemios en la proxima");
    }//fin del metodo MensajeDespedia()
}//fin de la clase CalculadoraCientifica