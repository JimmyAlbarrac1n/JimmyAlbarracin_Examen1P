using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JimmyAlbarracin_Examen1P.Models;

    public class JimmyAlbarracin_DataContext : DbContext
    {
        public JimmyAlbarracin_DataContext (DbContextOptions<JimmyAlbarracin_DataContext> options)
            : base(options)
        {
        }

        public DbSet<JimmyAlbarracin_Examen1P.Models.JA_Tabla1> JA_Tabla1 { get; set; } = default!;
    }
