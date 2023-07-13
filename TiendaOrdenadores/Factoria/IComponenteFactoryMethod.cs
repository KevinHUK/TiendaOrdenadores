using TiendaOrdenadores.Interfaces;

namespace TiendaOrdenadores.Factoria;

public interface IComponenteFactoryMethod
{
    IComponente dameComponente(TipoComponentes tipo);
}