using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args){
        
      int[] arr = new int[9]{3, 6, 2, 91, 86, 54, 87, 21, 1};
      for (int i = 0; i < arr.Length; i++)

      {
          bool check = false;
          for (int j = 0; j < arr.Length; j++)
          {
              if (arr[j] > arr[j + 1])
              {
                  check = true;
                  int temp = arr[j];
                  arr[j] = arr[j+1];
                  arr[j + 1] = temp;
                  Console.WriteLine(arr[j]);

              }
              if (check == false)
              {
                  break;
              }
             
          }
      }
      
      
      Console.ReadLine();



           
        }
    }
}
