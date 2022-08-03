using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Data
{
   public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sql, U parameters, string connectionString);
        void SaveData<T>(string sql, T parameters, string connectionString);
    }
}
