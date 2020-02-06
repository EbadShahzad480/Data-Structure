using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackcorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            stack S = new stack(6);
            S.push(12);
            S.push(91);
            S.push(21);
            S.push(8);
            Console.WriteLine(S.pop());
            Console.WriteLine(S.pop());
            Console.WriteLine(S.peak());
            Console.WriteLine(S.pop());
            Console.ReadLine();

        }
    }
    public class stack
    {
        int[] arr;
        int top;
        int size;
        int max;
        public stack(int size)
        {
            top = -1;
            arr = new int[size];
             max = size;

        }
        public void push(int val)
        {
            if (top == max - 1)
            {
                Console.WriteLine("stack overflow");

            }
            else
            {
                arr[++top] = val;

            }
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack undeflow");
                return -1;
            }
            else
            {
                int val = arr[top];
                top--;
                return val;
            }
        }

        public int peak()
        {
            if (top == -1)
            {
                Console.WriteLine("stack undeflow");
                return -1;
            }
            else
            {
                int val = arr[top];
              
                return val;
            }

        }
    }
}
