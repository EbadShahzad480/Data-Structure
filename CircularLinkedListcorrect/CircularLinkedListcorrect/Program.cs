using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListcorrect
{
     class Circularlist
    {
        private int currentdata;
        private Circularlist nextdata;
        public Circularlist()
        {
            currentdata = 0;
            nextdata = this;
        }
        public Circularlist(int value)
        {
            currentdata = value;
            nextdata = this;
        }
        public Circularlist Insert(int value)
        {
            Circularlist n = new Circularlist(value);
            if (this.nextdata == this)
            {
                n.nextdata = this;
                this.nextdata = n;
            }
            else
            {
                Circularlist temp = this.nextdata;
                n.nextdata = temp;
                this.nextdata = n;
            }
            return n;
        }
        public int Delete()
        {   if (this.nextdata == this)
            {
                System.Console.WriteLine("\n There is only one node...");
                return 0;
            }
            Circularlist node = this.nextdata;
            this.nextdata = this.nextdata.nextdata;
            node = null;
            return 1;
        }
        public void Traverse()
        {
            Traverse(this);
        }
        public void Traverse(Circularlist node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("Forward Direction...");
            Circularlist snode = node;
            do
            {
                System.Console.WriteLine(node.currentdata);
                node = node.nextdata;
            }
            while (node != snode);
        }
        public int Gnodes()
        {
            return Gnodes(this);
        }
        public int Gnodes(Circularlist node)
        {
            if (node == null)
               node = this;
            int count = 0;
            Circularlist snode = node;
            do
            {
                count++;
                node = node.nextdata;
            }
            while (node != snode);
            System.Console.WriteLine("\nCurrent Node Value : " + node.currentdata.ToString());
            System.Console.WriteLine("\nTotal nodes :" + count.ToString());
            return count;
        }
        static void Main(string[] args)
        {
            Circularlist node1 = new Circularlist(23);
            node1.Delete();
            Circularlist node2 = node1.Insert(33);
            node1.Delete();
            node2 = node1.Insert(43);
            Circularlist node3 = node2.Insert(33);
            Circularlist node4 = node3.Insert(43);
            Circularlist node5 = node4.Insert(53);
            node1.Gnodes();
            node5.Gnodes();
            node1.Traverse();
            node5.Delete();
            node2.Traverse();
            node1.Gnodes(); node2.Gnodes();
            Console.Read();
        }
    }}

   
