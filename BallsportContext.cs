using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skriftlig_opgave
{
    class BallsportContext : DbContext
    {
        public DbSet<Ballsport> Ballsports { get; set; }


        public BallsportContext() : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BallsportContext>());
        }
    }
}
