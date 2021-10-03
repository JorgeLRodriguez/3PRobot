using DAL.Contracts;
using DAL.Repositories;

namespace DAL.Factory
{
    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();
        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        private Factory()
        {
            GetBitacoraRepository = BitacoraRepository.Current;
        }
        public IBitacoraRepository GetBitacoraRepository { get; }
    }
}