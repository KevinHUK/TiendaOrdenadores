namespace TiendaOrdenadores.Memorizadores;

public class Memoria : IMemorizable
{
    private double _memoria;

    public Memoria(double memoria)
    {
        _memoria = memoria;
    }

    public double Almacenamiento { get => _memoria;
        set => _memoria = value <= 0 ? _memoria = 1 : _memoria = value;
    }

   

}