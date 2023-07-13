using TiendaOrdenadores.Calor;
using TiendaOrdenadores.Gasto;

namespace TiendaOrdenadores.Interfaces;

public interface IComponente : ICoste
{
    

    string NumeroDeSerie { get; set; }


}