using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevControlM.Models;

    public class DevControlContext : DbContext
    {
        public DevControlContext (DbContextOptions<DevControlContext> options)
            : base(options)
        {
        }

        public DbSet<DevControlM.Models.Establecimientos> Establecimientos { get; set; }
        public DbSet<DevControlM.Models.TbProvincias> Provincias { get; set; }
        public DbSet<DevControlM.Models.TbMunicipios> Municipios { get; set; }
        public DbSet<DevControlM.Models.TbInstitucion> Institucion { get; set; }    
        public DbSet<DevControlM.Models.Tbnivel> Nivel { get; set; }

}

// dotnet ef migrations add TbIntitucion&TbNivel
// dotnet ef database update

