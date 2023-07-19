using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuyrukOdevv.Properties
{
    internal class Palindrom
    {
       public void palindrom(Stack a, Queue b)
        {
            int x =0;
            for (int i = a.index; i >-1 ; i--)
            {
                
                if (a.veriler[i] != b.values[x])
                {
                    Console.WriteLine("-----Girilen Kelime Polindrom Değil.");
                    break;
                }
                x++;


            }
            if (x==(a.index+1))
            {
                Console.WriteLine("----Polindrom Bir Kelime Girdiniz...");
            }
           
        }

    }
}
