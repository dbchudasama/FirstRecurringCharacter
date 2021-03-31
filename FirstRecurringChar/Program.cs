using System;
using System.Collections;

namespace FirstRecurringChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 5, 1, 8, 8, 7, 4, 4, 10 };
            Console.WriteLine(FirstRecurringChar(arr));
        }

        static int FirstRecurringChar(int[] arr)
        {
            Hashtable h = new Hashtable();
            for( int i = 0; i < arr.Length; i++)
            {
                //Doing a blank check on the Hash table to start with. 
                //ContainsKey is a boolean evaluation so will return true or false
                //NOTE - MOST CASES START WITH THE REVERSE SCENARIO - REVERSE ENGINEER
                if (h.ContainsKey(arr[i]))
                {
                    //return the recurring value if true
                    return arr[i];
                }
                //Add value to Hashtable
                h[arr[i]] = arr[i];
            }
            //If no recurring value then just return 0
            return 0;
        }
    }
}
