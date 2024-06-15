using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // context : Db tabloları ile proje claslarını bağlamak 
    // class ın isminin context olması onu cantext yapmıyor onu DbContext ten inherite edeceğiz
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);(ilk bura geliyor burayı siliyoruz)
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Car;Trusted_connection=true");
        }
        //yukarda hangi veri tabanına bağlandığımızı söyledik ama benim hangi nesnem hangi nesneye
        //karşılık gelecek onuda aşağıda belirtiyoruz
        public DbSet<Car> Cars { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }

    }
}
