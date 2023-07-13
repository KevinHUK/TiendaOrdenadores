namespace TiendaOrdenadores.Gasto;

public class Coste : ICoste
{
    private double _precio;

    public Coste(double precio)
    {
        Precio = precio;
    }

    public double Precio { get => _precio; set => _precio = value <= 0 ? _precio = 1 : _precio = value; }
}

    