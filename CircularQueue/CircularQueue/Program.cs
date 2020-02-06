using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CQ C = new CQ(4);
            C.Enqueue(4);
            C.Enqueue(21);
            C.Enqueue(15);
            Console.WriteLine(C.Dequeue());
            C.Enqueue(5);
            Console.WriteLine(C.Dequeue());
            Console.ReadLine();
        }
    }
    public class CQ
    {
        int front, rear, max;
        int count;
        int[] elements;
        public CQ(int size)
        {
            front = 0; rear = -1;
            max = size;
            elements = new int[size];
            count = 0;
        }
        public void Enqueue(int val)
        {
            if (count == max)
            {
                Console.WriteLine("SorrY! Queue is full");
            }
            else
            {
                rear = (rear + 1)%max;
                elements[rear] = val;
                count++;

            }
        }
        public int Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Sorry! queue is empty");
                return -1;
            }
            else
            {
                count--;
                int val = elements[front];
                front = (front + 1 % max);
                return val;
            }
        }
    }
}
