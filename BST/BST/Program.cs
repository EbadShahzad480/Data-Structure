using System;
using System.Collections.Generic;
1.	using System.Text;
2.	namespace TreeSort
3.	{
4.	    class Node
5.	    {
6.	        public int item;
7.	        public Node leftc;
8.	        public Node rightc;
9.	        public void display()
10.	        {
11.	            Console.Write("[");
12.	            Console.Write(item);
13.	            Console.Write("]");
14.	        }
15.	    }
16.	    class Tree
17.	    {
18.	        public Node root;
19.	        public Tree()
20.	        { 
21.	            root = null; 
22.	        }
23.	        public Node ReturnRoot()
24.	        {
25.	            return root;
26.	        }
27.	        public void Insert(int id)
28.	        {
29.	            Node newNode = new Node();
30.	            newNode.item = id;
31.	            if (root == null)
32.	                root = newNode;
33.	            else
34.	            {
35.	                Node current = root;
36.	                Node parent;
37.	                while (true)
38.	                {
39.	                    parent = current;
40.	                    if (id < current.item)
41.	                    {
42.	                        current = current.leftc;
43.	                        if (current == null)
44.	                        {
45.	                            parent.leftc = newNode;
46.	                            return;
47.	                        }
48.	                    }
49.	                    else
50.	                    {
51.	                        current = current.rightc;
52.	                        if (current == null)
53.	                        {
54.	                            parent.rightc = newNode;
55.	                            return;
56.	                        }
57.	                    }
58.	                }
59.	            }
60.	        }
61.	        public void Preorder(Node Root)
62.	        {
63.	            if (Root != null)
64.	            {
65.	                Console.Write(Root.item + " ");
66.	                Preorder(Root.leftc);
67.	                Preorder(Root.rightc);
68.	            }
69.	        }
70.	        public void Inorder(Node Root)
71.	        {
72.	            if (Root != null)
73.	            {
74.	                Inorder(Root.leftc);
75.	                Console.Write(Root.item + " ");
76.	                Inorder(Root.rightc);
77.	            }
78.	        }
79.	        public void Postorder(Node Root)
80.	        {
81.	            if (Root != null)
82.	            {
83.	                Postorder(Root.leftc);
84.	                Postorder(Root.rightc);
85.	                Console.Write(Root.item + " ");
86.	            }
87.	        }
88.	    }
89.	    class Program
90.	    {
91.	        static void Main(string[] args)
92.	        {
93.	            Tree theTree = new Tree();
94.	            theTree.Insert(20);
95.	            theTree.Insert(25);
96.	            theTree.Insert(45);
97.	            theTree.Insert(15);
98.	            theTree.Insert(67);
99.	            theTree.Insert(43);
100.	            theTree.Insert(80);
101.	            theTree.Insert(33);
102.	            theTree.Insert(67);
103.	            theTree.Insert(99);
104.	            theTree.Insert(91);            
105.	            Console.WriteLine("Inorder Traversal : ");
106.	            theTree.Inorder(theTree.ReturnRoot());
107.	            Console.WriteLine(" ");
108.	            Console.WriteLine();
109.	            Console.WriteLine("Preorder Traversal : ");
110.	            theTree.Preorder(theTree.ReturnRoot());
111.	            Console.WriteLine(" ");
112.	            Console.WriteLine();
113.	            Console.WriteLine("Postorder Traversal : ");
114.	            theTree.Postorder(theTree.ReturnRoot());
115.	            Console.WriteLine(" ");
116.	            Console.ReadLine();
117.	        }	    }	}
