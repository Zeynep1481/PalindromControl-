using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuyrukOdevv.Properties
{
    internal class Queue
    {
        int front;
        int rear;
        public char[] values;
        int size;

        public Queue(int sizeParametre)
        {
            this.size = sizeParametre;
            values = new char[this.size];
            front = -1;
            rear = -1;
        }

        Boolean bosMu()
        {
            return rear == front;

        }

        Boolean doluMu()
        {

            return this.rear == size - 1;

        }

        public void enQueue(char data)  // Ekleme fonksiyonu
        {
            if (doluMu())
                Console.WriteLine("Kuyruk Dolu");
            else
            {
                values[++rear] = data;
            }

        }

        public void print()
        {
            if (bosMu())
                Console.WriteLine("Kuyruk Boş");
            else
            {
                for (int i = front + 1; i <= this.rear; i++)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
    }
}
