using LearningApp.api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningApp.api.Data
{
    public class DataContxt:DbContext
    {
        public DataContxt(DbContextOptions<DataContxt> options) : base(options) { }
        
        public DbSet<Value> Values { get; set; }        
    }
}
