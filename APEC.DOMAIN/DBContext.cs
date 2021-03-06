﻿using APEC.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEC.DOMAIN
{
    public class APECDBContext : DbContext
    {
        public APECDBContext()
            : base("APECConnString")
        {
            Database.SetInitializer<APECDBContext>(new CreateDatabaseIfNotExists<APECDBContext>());
        }
        public virtual DbSet<Client> Clients{get;set;}
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }

        //public System.Data.Entity.DbSet<APEC.Models.RegistrationViewModel> RegistrationViewModels { get; set; }
    }
}
