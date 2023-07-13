using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Calor;

namespace TiendaOrdenadores.Procesadores
{
    public class Procesador : IProcesable, ICalorable
    {
        public double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NumeroDeSerie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Calor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetCalor()
        {
            throw new NotImplementedException();
        }

        public int GetCores()
        {
            throw new NotImplementedException();
        }

        
    }
}
