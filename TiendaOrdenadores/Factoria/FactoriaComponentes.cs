using TiendaOrdenadores.Interfaces;

namespace TiendaOrdenadores.Factoria;

public class FactoriaComponentes : IComponenteFactoryMethod
{
    public IComponente dameComponente(TipoComponentes tipo)
    {
        IncialBuilderComponentes build = new IncialBuilderComponentes();
        ;
        switch (tipo)
        {
            case TipoComponentes._789XCS:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Procesadores, "789XCS", 
                    134, 9, 0, 0, 10);
            case TipoComponentes._879FH:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Memorizadores, "879FH", 
                    100, 0, 512, 0, 10);
            case TipoComponentes._789XX:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Guardadores, "789XX", 
                    50, 0, 0, 50, 10);
            case TipoComponentes._789XCD:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Procesadores, "789XCD",
                    134,9,0,0,12);
            case TipoComponentes._789XCT:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Procesadores, "789XCT", 
                    138, 11, 0, 0, 22); 
            case TipoComponentes._879FHT:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Memorizadores, "879FHT",
                    150, 0, 2000, 0, 24);
            case TipoComponentes._879FHL:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Memorizadores, "879FHL", 
                    125, 0, 1000, 0, 15);
            case TipoComponentes._789XX2:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Guardadores, "789XX2", 
                    90, 0, 0, 1000, 29);
            case TipoComponentes._789XX3:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Guardadores, "789XX3", 
                    128, 0, 0, 2000, 39);
            case TipoComponentes._797X:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Procesadores, "797X", 
                    78, 10, 0, 0, 30);
            case TipoComponentes._797X2:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Procesadores, "797X2", 
                    178, 29, 0, 0, 30);
            case TipoComponentes._797X3:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Procesadores, "797X3", 
                    278, 34, 0, 0, 60);
            case TipoComponentes._788fg:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Guardadores, "788fg", 
                    37, 0, 0, 250, 35); ;
            case TipoComponentes._788fg2:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Guardadores, "788fg2", 
                    67, 0, 0, 250, 35);
            case TipoComponentes._788fg3:
                return build.dameTipoDeComponente(TipoColeccionComponentes.Guardadores, "788fg3", 
                    97, 0, 0, 250, 35);
            default: return null;
        }
    }


}