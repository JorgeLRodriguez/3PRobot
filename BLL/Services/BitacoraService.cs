using BLL.Contracts;
using DAL.Factory;
using Domain;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BitacoraService : IBitacoraService
    {
        private readonly Factory repository;
        #region Singleton
        private readonly static BitacoraService _instance = new BitacoraService();
        public static BitacoraService Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public BitacoraService()
        {
            repository = Factory.Current;
        }
        public void Create(Bitacora Bitacora)
        {
            repository.GetBitacoraRepository.Store(Bitacora);
        }
        public List<Bitacora> Read(DateTime Desde, DateTime Hasta)
        {
            return repository.GetBitacoraRepository.Read<Bitacora>("Now", Desde, Hasta);
        }
    }
}