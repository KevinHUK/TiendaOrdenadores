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

    private TipoComponentes _tipo;
    private IGuardable _disco;
    private IProcesable _procesador;
    private IMemorizable _bancoDeMemoria;
    private ICalorable _calor;
    private ICoste _coste;
    public Ordenador(TipoComponentes tipo, IGuardable disco, IProcesable procesador, IMemorizable bancoDeMemoria)
    {
        _tipo = tipo;
        _disco = disco;
        _procesador = procesador;
        _bancoDeMemoria = bancoDeMemoria;
    }

    public double PrecioPorOrdenador => throw new NotImplementedException();

    public double CalorTotal => throw new NotImplementedException();

    public double calorTotal()
    {
        return _calor.Calor;
    }

    public double precioPorOrdenador()
    {
        return _coste.Precio;
    }
}