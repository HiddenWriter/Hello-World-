using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TEST2
{
    class Program
    {
        static void Main(string[] args)
        {   
          var Names = new List<string>{
            "1" ,"2" , "3"
          };

          foreach (var Name in Names) {
            System.Console.Write($"Hello, World!: {Name} \n");
            /* 표준 출력 함수 ex) System.Console.WriteLine이나 System.Console.Write() 같은거 static 으로 선언되어 있다. */
          }
        }
    }
}
