﻿using TiendaOrdenadores.Guardadores;
using TiendaOrdenadores.Interfaces;

namespace TiendaOrdenadores.Memorizadores;

public class SinMemoria : IMemorizable, IGuardable
{
    private double _memoria;
    public double Almacenamiento { get => _memoria;
        set => _memoria = value;
    }
}