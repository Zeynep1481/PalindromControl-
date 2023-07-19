using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuyrukOdevv.Properties
{
    internal class Stack
    {
        public int index;
        int boyut;
        public char[] veriler;

        public Stack(int eleman_sayisi)
        {
            this.boyut= eleman_sayisi;
            this.index = -1;
            veriler=new char[eleman_sayisi];
        }

        public void push(char data)
        {
            // yığın doluysa
            if (this.index == this.boyut - 1)
            {
                Console.WriteLine("Stack Dolu");
            }

            else
            {
                this.index++;
                veriler[this.index] = data;
            }
        }

        public void print()
        {
            if (this.index == -1)
            {
                Console.WriteLine("Stack Boş");
            }
            else
            {
                for (int i = this.index; i > -1; i--)
                {
                    Console.WriteLine(this.veriler[i]);
                }
            }

        }
    }
}
