using System.ComponentModel.Design;

namespace TiendaOrdenadores.Guardadores;

public class Guardador : IGuardable
{
    private double _almacenamiento;

  


    public Guardador(double almacenamiento)
    {
        Almacenamiento = almacenamiento;
        
    }



    public double Almacenamiento
    {
        get => _almacenamiento;

        set => _almacenamiento = (value <= 0) ? _almacenamiento = 0 : _almacenamiento = value;  
    }

}