using TiendaOrdenadores.Calor;
using TiendaOrdenadores.Factoria;
using TiendaOrdenadores.Interfaces;

namespace TiendaOrdenadores;

public class Componente : IComponente,ICalorable
{
    private TipoColeccionComponentes _tipo;
    private double _precio;
    private string _numeroDeSerie;
    private int _cores;
    private double _memoriaRam;
    private double _memoriaDisco;
    private int _temperatura;

    public Componente(TipoColeccionComponentes tipo,double precio, string numeroDeSerie, int cores, double memoriaRam, double memoriaDisco, int temperatura)
    {
        _tipo = tipo;
        Precio = precio;
        NumeroDeSerie = numeroDeSerie;
        _cores = cores;
        _memoriaRam = memoriaRam;
        _memoriaDisco = memoriaDisco;
        _temperatura = temperatura;
    }

    public double Precio
    {
        get => _precio; set => _precio = value <= 0 ? _precio = 1 : _precio = value;
    }
    public string NumeroDeSerie { get => _numeroDeSerie; set => _numeroDeSerie = value == "" ? _numeroDeSerie = "12340dv" : _numeroDeSerie = value; }
    public int Calor { get => _temperatura; set => _temperatura = value <= 0 ? _temperatura = 1 : _temperatura = value; }
}