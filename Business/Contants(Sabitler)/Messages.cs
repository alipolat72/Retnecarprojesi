using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    // publicten sonra static verdiğimizde sürekli newlemekten kurtulmuş oluruz 
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public  static string MaintenanceTime ="sistem bakım da !";
        public  static string CarsListed = "Araçlar Listelendi ";
    }

}
