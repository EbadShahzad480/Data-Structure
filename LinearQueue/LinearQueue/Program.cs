using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LQ L = new LQ(4);            
            L.Enqueue(4);
            L.Enqueue(12);
            L.Enqueue(3);
            L.Enqueue(15); 
            Console.WriteLine(L.Dequeue());
            Console.ReadLine();
        }
    }
    public class LQ
    {
        int front, rear, max;
        int[] elements;
        public LQ(int size)
        {
            front = 0; rear = -1;
            max = size;
            elements = new int[size];
        }
        public void Enqueue(int val)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("SorrY! Queue is full");
            }
            else
            {
                elements[++rear] = val;
                
            }
        }
        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Sorry! queue is empty");
                return -1;
            }
            else
            {
                return elements[front++];
            }
        }
    }
}
