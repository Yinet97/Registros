using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class UsuarioDb : DbContext
    {
        public UsuarioDb() : base("name= conStr")
        {

        }

        public virtual DbSet<Usuarios> Usuario { get; set; }
    }
}
