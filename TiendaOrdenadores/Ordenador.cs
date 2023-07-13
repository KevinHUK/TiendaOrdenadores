using TiendaOrdenadores.Calor;
using TiendaOrdenadores.Factoria;
using TiendaOrdenadores.Gasto;
using TiendaOrdenadores.Guardadores;
using TiendaOrdenadores.Interfaces;
using TiendaOrdenadores.Memorizadores;
using TiendaOrdenadores.Procesadores;

namespace TiendaOrdenadores;

public class Ordenador : IOrdenador, ICaracteristicasComponenentes
{

    private List<IComponente> componentes = new();
    private double precio;
    private int calor;
    public double PrecioPorOrdenador  {
        get{
            foreach (var item in componentes)
            {
                precio += (item as ICoste).Precio;
            }
            return precio;
        }
    }





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
}