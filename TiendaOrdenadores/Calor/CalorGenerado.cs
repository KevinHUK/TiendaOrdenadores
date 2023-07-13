namespace TiendaOrdenadores.Calor;

public class CalorGenerado : ICalorable
{
    public int calor;

    public CalorGenerado(int calor)
    {
        Calor = calor;
    }

    public int Calor
    {
        get => calor;
        set => calor = (value <= 0) ? calor = 1 : calor = value;
    }
    
}