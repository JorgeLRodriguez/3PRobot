using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace DAL.Repositories
{
    internal class BitacoraRepository : IBitacoraRepository
    {
        #region Singleton
        private readonly static BitacoraRepository _instance = new BitacoraRepository();
        public static BitacoraRepository Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        private BitacoraRepository() { }
        private BinaryFormatter _formateadorBinario = new BinaryFormatter();
        private string _path = ConfigurationManager.AppSettings["Bitacora"];
        private Stream GetConexion(FileMode fileMode, FileAccess fileAccess)
        {
            return new FileStream(_path, fileMode, fileAccess);
        }
        public void Store(object registro)
        {
            try
            {
                using (Stream flujo = GetConexion(FileMode.Append, FileAccess.Write))
                {
                    _formateadorBinario.Serialize(flujo, registro);
                    flujo.Close();
                }
            }
            catch { throw; }
        }
        public List<T> Read<T>(string Property, DateTime Desde, DateTime Hasta)
        {
            try
            {
                List<T> items = new List<T>();
                Stream flujo = GetConexion(FileMode.Open, FileAccess.Read);
                while (flujo.Position < flujo.Length)
                {
                    object Objeto = _formateadorBinario.Deserialize(flujo);
                    Type tipoObjeto = Objeto.GetType();
                    FieldInfo selectedProperty = tipoObjeto.GetFields().FirstOrDefault(propertyInfo => propertyInfo.Name == Property);
                    if (typeof(T).Name == Objeto.GetType().Name && selectedProperty != null
                        && selectedProperty.FieldType.Name == "DateTime")
                    {
                        DateTime eventDate = (DateTime)selectedProperty.GetValue(Objeto);
                        if (eventDate > Desde && eventDate < Hasta) items.Add((T)Objeto);
                    }
                }
                flujo.Close();
                return items;
            }
            catch {throw;}     
        }
    }
}