using KuyrukOdevv.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuyrukOdevv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cevap;

            do
            {
                Console.WriteLine("Kelimeyi Girin..:");
                string kelime = Console.ReadLine();
                
                Stack Yigin = new Stack(kelime.Length);
                for (int i = 0; i < kelime.Length; i++)
                {
                    Yigin.push(kelime[i]);
                }
                
                Console.WriteLine("----STACK YAPISI----");
                Yigin.print();
                Console.WriteLine("------------");

                Queue Kuyruk = new Queue(kelime.Length);

                for (int i = 0; i < kelime.Length; i++)
                {
                    Kuyruk.enQueue(kelime[i]);
                }
                Console.WriteLine("----QUEUE YAPISI----");
                Kuyruk.print();
                Console.WriteLine("------------");

                Palindrom poliNesne = new Palindrom();
                poliNesne.palindrom(Yigin, Kuyruk);

                Console.WriteLine("Devam Etmek İstiyor musunuz?(e/h)...:");
                cevap = Convert.ToChar(Console.ReadLine());

            } while (cevap == 'e' || cevap == 'E');

            Console.ReadLine();

        }
    }
}
