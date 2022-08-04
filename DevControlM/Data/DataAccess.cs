using Dapper;
using DevControlM.Models.Dtos;
using DevControlM.Models.Registro;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Data
{
    public class DataAccess : IDataAccess
    {
        private readonly DevControlContext _context;

        public DataAccess (DevControlContext context)
        {
           _context = context;
        }
        public List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();
                return rows;
            }

        }


        public void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Execute(sql, parameters);

            }

        }

        public void CrearParticipantes(ParticipantesDto dto)
        {

            DevControlContext context = _context;
            var tp = "";
       
            TbParticipantes nuevo = new()
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Sexo = dto.Sexo,

                Telefono = dto.Telefono,
                Email = dto.Email,
                QR = Guid.NewGuid()

            };
            _context.TbParticipantes.Add(nuevo);

            _context.SaveChanges();
        }
        public IEnumerable<TbParticipantes> GetTbParticipantes()
        {

            var data = _context.TbParticipantes.OrderBy(x=>x.Id);
            // ParticipantesDto nuevo = new ()
            // {

            // };
            return data.ToList();
        }

        public void CrearSala(SalaDto sala)
        {
            DevControlContext context = _context;
            TbSala nuevo = new ()
            {
                Nombre=sala.Nombre,
                Descripcion = sala.Descripcion,
                Lugar=sala.Descripcion,
                FInicio=sala.FInicio,
                F_Fin=sala.F_Fin

            };
            _context.TbSala.Add(nuevo);
            _context.SaveChanges();
        }

          public IEnumerable<TbSala> GetSalas()
          {
            var data  = _context.TbSala.ToList();
            return data;
          }

    }
}
