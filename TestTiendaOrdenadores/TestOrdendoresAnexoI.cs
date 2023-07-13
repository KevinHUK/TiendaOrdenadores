using TiendaOrdenadores;
using TiendaOrdenadores.Factoria;
using TiendaOrdenadores.Guardadores;
using TiendaOrdenadores.Memorizadores;
using TiendaOrdenadores.Procesadores;

namespace TestTiendaOrdenadores
{
    [TestClass]
    public class TestOrdendoresAnexoI
    {
        private IComponenteFactoryMethod Factoria;
        private Ordenador ordenadorMaria = new();
        private Ordenador ordenadorAndres = new();

        [TestInitialize]
        public void TestInitialize()
        {

             Factoria = new FactoriaComponentes();
             
             

             var discoM = Factoria.dameComponente(TipoComponentes._789XX);
             var procesadorM = (Factoria.dameComponente(TipoComponentes._789XCS));
             var memoriaM = (Factoria.dameComponente(TipoComponentes._879FH));

             ordenadorMaria.add(discoM);
             ordenadorMaria.add(procesadorM);
             ordenadorMaria.add(memoriaM);

            
            

             var disco = Factoria.dameComponente(TipoComponentes._879FHT);
             var procesador = (Factoria.dameComponente(TipoComponentes._789XX3));
             var memoria = (Factoria.dameComponente(TipoComponentes._797X3));

             ordenadorAndres.add(disco);
             ordenadorAndres.add(procesador);
             ordenadorAndres.add(memoria);
        }

        [TestMethod]
        public void TestOrdenadorMaria()
        {
            Assert.AreEqual(ordenadorMaria.CalorTotal, 30);
            Assert.AreEqual(ordenadorMaria.PrecioPorOrdenador, 180);

        }
        [TestMethod]
        public void TestOrdenadorAndres()
        {
            Assert.AreEqual(ordenadorAndres.CalorTotal, 30);
            Assert.AreEqual(ordenadorAndres.PrecioPorOrdenador, 180);

        }

    }
}