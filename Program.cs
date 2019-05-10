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
            "A" ,"B" , "C"
          };

          foreach (var Name in Names) {
            System.Console.Write($"Massage : {Name} \n");
            System.Console.Write(TEST2.AllNames.GetUserName());
            Console.Write("\n");
            Console.Write("{0:C} + {1:P} + {2}{3}{4}", 10, 2, "and", Name, "\n" );
            /* 표준 출력 함수 ex) System.Console.WriteLine이나 System.Console.Write() 같은거 static 으로 선언되어 있다. */
          }
        }
    }
}