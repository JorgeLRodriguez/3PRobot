using Domain;
using System;
using System.Collections.Generic;

namespace BLL.Contracts
{
    public interface IBitacoraService
    {
        void Create(Bitacora Bitacora);
        List<Bitacora> Read(DateTime Desde, DateTime Hasta);
    }
}
