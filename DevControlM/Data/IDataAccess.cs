using DevControlM.Models.Dtos;
using DevControlM.Models.Registro;
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
        void CrearParticipantes(ParticipantesDto dto);
        void CrearSala(SalaDto sala);
        IEnumerable<TbParticipantes> GetTbParticipantes();
        IEnumerable<TbSala> GetSalas();
        

    }

}
