using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Calor;
using TiendaOrdenadores.Gasto;
using TiendaOrdenadores.Interfaces;

namespace TiendaOrdenadores.Procesadores
{
    public interface IProcesable 
    {
        int Cores { get; set; }
    }
}
