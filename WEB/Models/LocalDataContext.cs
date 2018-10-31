using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Domain.Models.Provincia> Provincias { get; set; }
    }
}