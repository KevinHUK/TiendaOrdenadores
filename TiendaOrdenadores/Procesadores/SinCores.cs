namespace TiendaOrdenadores.Procesadores;

public class SinCores : IProcesable
{
    private int _cores;

    public int Cores { get => _cores; set => _cores = value; }
}