using EPortfolioAlexWitkowski.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EPortfolioAlexWitkowski.DAL
{
    public class DBEntity : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<FileType> FileTypes { get; set; }

    }
}