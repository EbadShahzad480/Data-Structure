using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL S = new SLL();
            S.add(5);
            S.add(19);
            S.add(15);
            S.print();
            S.search(19);
            S.search(5);
            S.update(5, 8);


            Console.ReadLine();

        }

        class Node
        {
            public int data;
            public Node Nlink;
            public Node(int val)
            {
                data = val;
                Nlink = null;
            }
        }
        class SLL
        {
            Node head;
            Node tail;
            public SLL()
            {
                head = null;
                tail = null;
            }
            public void add(int data)
            {
                Node n = new Node(data);

                if (head == null)
                {
                    head = n;
                    tail = n;
                }
                else
                {
                    tail.Nlink = n;
                    tail = n;

                }


            }
         public void print()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Nlink;
                }
            }
         public void search (int val)
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == val)
                    {
                        Console.WriteLine("found");
                        break;
                    }
                    temp = temp.Nlink;
                }
            }
  public   void update(int old_val, int new_val)
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == old_val)
                    {
                        Console.WriteLine(temp.data = new_val);
                        break;
                    }
                    temp = temp.Nlink;
                }

            }

         
        }
    }
}
