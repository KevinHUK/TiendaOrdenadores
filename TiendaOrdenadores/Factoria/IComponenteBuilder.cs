using TiendaOrdenadores.Calor;
using TiendaOrdenadores.Gasto;
using TiendaOrdenadores.Guardadores;
using TiendaOrdenadores.Interfaces;
using TiendaOrdenadores.Memorizadores;
using TiendaOrdenadores.Procesadores;

namespace TiendaOrdenadores.Factoria;

public interface IComponenteBuilder
{
    IComponente dameTipoDeComponente(TipoColeccionComponentes tipoComponentes, 
         string numSerie, ICoste coste,int cores, double memoriaRam, double memoriaDisco, ICalorable temperatura);
}