namespace TiendaOrdenadores.Calor;

public class CalorGenerado
{
    public double calor;

    public CalorGenerado(double calor)
    {
        Calor = calor;
    }

    public double Calor
    {
        get => calor;
        set => calor = (value <= 0) ? calor = 1 : calor = value;
    }
}