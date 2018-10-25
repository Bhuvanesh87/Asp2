using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspMvcValidation.Models
{
    public class UsersContext:DbContext
    {
        public UsersContext()
            :base("UsersConnection")
        {

        }
        public DbSet<Register> RegisterTable { get; set; }
    }
}