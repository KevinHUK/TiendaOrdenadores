using System.ComponentModel.Design;

namespace TiendaOrdenadores.Guardadores;

public class Guardador : IGuardable
{
    private int _almacenamiento;

  


    public Guardador(int almacenamiento)
    {
        Almacenamiento = almacenamiento;
        
    }

    public int GetAlmacenamiento()
    {
        return Almacenamiento;
    }

    public int Almacenamiento
    {
        get => _almacenamiento;

        set => _almacenamiento = (value <= 0) ? _almacenamiento = 1 : _almacenamiento = value;  
    }

}