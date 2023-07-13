namespace TiendaOrdenadores.Memorizadores;

public class Memoria : IMemorizable
{
    private int _memoria;

    public Memoria(int memoria)
    {
        _memoria = memoria;
    }

    public int Almacenamiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

   

}