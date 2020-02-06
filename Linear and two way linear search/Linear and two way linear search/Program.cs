using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_and_two_way_linear_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no to be search");
            int search = Convert.ToInt32(Console.ReadLine());
          /*bool check = false;
           */
            int[] arr = new int[7] { 2,6,7,4,8,9,3,};
    /* for (int i = 0; i < arr.Length;i++){

                if (arr[i] == search)
                {
                    check = true;
                    Console.WriteLine("fount at index: " + i);
                    



                }
                if(check ==false)

                {
                    
                    Console.WriteLine("not found");
                }

            }*/
            
            /*
             *  TWO WAY LINEAR SEARCH
             */

            int S = 0;
            int E = arr.Length - 1;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (search == arr[S] || search == arr[E]
                    )
                {
                    Console.WriteLine("found");
                    S++;
                    E--;

                }
                else
                {


                    Console.WriteLine("not found");
                }
            }




            Console.ReadLine();
        }
    }
}
