using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySelection
{
    class Program
    {   // No sorting done - the arrays that are inputted are in order
        // list that holds the selected activities
        static List<int> selectedActivities = new List<int>(); 

        static void Main(string[] args)
        {
            Console.WriteLine("Stefana Rusu - Assignment 4 \nGreedy Algorithms \nRecursive Activity Selector Algorithm");
            Console.WriteLine();

            // Use Case 1
            Console.WriteLine("Use case 1 (table from CH16): ");
            Console.WriteLine("Start times = {1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12}");
            Console.WriteLine("Finish times = {4, 5, 6, 7, 9, 9, 10, 11, 12, 14, 16}");
            Console.WriteLine("Number of activities = 11");
            
            int[] startTime1 = { 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 }; // array of start times
            int[] finishTime1 = { 4, 5, 6, 7, 9, 9, 10, 11, 12, 14, 16 }; // array of finish times
            int activities1 = startTime1.Length-1; // number of activities
            selectedActivities.Add(0);
            MaxActivity(startTime1, finishTime1, 0, activities1);

            // Display Output
            Console.WriteLine("\nThe selected mutually compatible activities that can be performed are:\n ");
            for (int i = 0; i < selectedActivities.Count; i++)
            {
                Console.Write("a{0} ", selectedActivities[i]+1);
            }

            // Use Case 2
            selectedActivities.Clear();
            Console.WriteLine("\n\nUse case 2: ");
            Console.WriteLine("Start times = {1, 1, 0, 3, 4, 4, 5, 2}");
            Console.WriteLine("Finish times = {2, 3, 4, 5, 5, 6, 8, 9}");
            Console.WriteLine("Number of activities = 8");
            int[] startTime2 = { 1, 1, 0, 3, 4, 4, 5, 2 }; // array of start times
            int[] finishTime2 = { 2, 3, 4, 5, 5, 6, 8, 9 }; // array of finish times
            int activities2 = startTime2.Length - 1; // number of activities
            selectedActivities.Add(0);
            MaxActivity(startTime2, finishTime2, 0, activities2);

            // Display Output
            Console.WriteLine("\nThe selected mutually compatible activities that can be performed are:\n ");
            for (int i = 0; i < selectedActivities.Count; i++)
            {
                Console.Write("a{0} ", selectedActivities[i] + 1);
            }
            Console.ReadLine();
        }

        // Method that finds the maximum compatible activities to be performed
        // This assumes that the input activities n are already ordered
        public static void MaxActivity (int[] s, int[] f, int k, int n)
        {
            // k will start at 0
            int m;   // compatible activity 
            m = k + 1; 
            
            while((m <= n) && (s[m] < f[k]))
            {
                m = m + 1;
            }

            // as long as m <= n, the compatible activity will be added to the list
            if(m <= n)
            {
                selectedActivities.Add(m); // selected activity is added to the list
                MaxActivity(s, f, m, n); // repread method until all activities have been assessed
            }
        }

    }
}
