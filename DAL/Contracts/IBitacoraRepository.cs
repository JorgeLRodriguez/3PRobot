using System;
using System.Collections.Generic;

namespace DAL.Contracts
{
    public interface IBitacoraRepository
    {
        void Store(object registro);
        List<T> Read<T>(string Property, DateTime Desde, DateTime Hasta);
    }
}