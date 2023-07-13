namespace TiendaOrdenadores.Gasto;

public class Coste : ICoste
{
    private double _precio;

    public Coste(double precio)
    {
        Precio = precio;
    }

    public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

    