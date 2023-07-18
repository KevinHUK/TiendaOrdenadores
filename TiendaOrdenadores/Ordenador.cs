using TiendaOrdenadores.Calor;
using TiendaOrdenadores.Gasto;
using TiendaOrdenadores.Interfaces;

namespace TiendaOrdenadores;

public class Ordenador : IOrdenador, ICaracteristicasComponenentes
{

    private List<IComponente> componentes = new();
    private double precio;
    private int calor;
    public void add(IComponente nuevoComponente)
    {
        componentes.Add(nuevoComponente);
    }

    public double CalorTotal
    {
        get
        {
            foreach (var item in componentes)
            {
                calor += (item as ICalorable).Calor;
            }
        return calor;
    }
        
    }
    public double PrecioPorOrdenador
    {
        get
        {
            foreach (var item in componentes)
            {
                precio += (item as ICoste).Precio;
            }
            return precio;
        }
    }
}