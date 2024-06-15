using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace Core.Utulities_Araçlar_.Results
{
    public class Result : IResult
    {
        // c# ta this demek clasın kendini kastetmektir.yani burda this (Result) tır.
        // burası constructar ın base lerle çalışmasına örnektir
        public Result(bool success, string messagess):this(success)
        {
            Message = messagess;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }  
}
