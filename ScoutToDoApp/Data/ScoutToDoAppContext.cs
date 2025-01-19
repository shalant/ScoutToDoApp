using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScoutToDoApp.Models;

namespace ScoutToDoApp.Data
{
    public class ScoutToDoAppContext : DbContext
    {
        public ScoutToDoAppContext (DbContextOptions<ScoutToDoAppContext> options)
            : base(options)
        {
        }

        public DbSet<ScoutToDoApp.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
