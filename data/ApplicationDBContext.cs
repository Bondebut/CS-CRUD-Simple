using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAspMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAspMvc.data
{
    public class ApplicationDBContext:DbContext
    {
        //Constuctor Db
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}