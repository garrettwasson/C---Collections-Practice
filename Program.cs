using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Arrays--------------------------
            int[] array1 = {0,1,2,3,4,5,6,7,8,9};

            string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};

            bool[] array3 = new bool[10];
            for (int idx = 0; idx < 10; idx +=2){
                array3[idx] = true;
            }

            //Multiplication Table-------------------
            int[,] array4 = new int[10,10];
            for (int x = 0; x < 10; x++){
                for (int y = 0; y < 10; y++){
                    array4[x,y] = (x+1) * (y+1);
                }
            }
            for (int x = 0; x < 10; x++){
                string output = " ";
                for (int y = 0; y < 10; y++){
                    output += array4[x,y] + " ";
                    if (array4[x,y] < 10){
                        output += " ";
                    }
                }

                Console.WriteLine(output);
            }

            //List of flavors-------------------------
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Cheese Cake");
            flavors.Add("Green Tea");

            Console.WriteLine(flavors.Count);

            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);

            Console.WriteLine(flavors.Count);

            //User Info Dictionary---------------------
            Dictionary<string,string> flavorArray = new Dictionary<string,string>();
            Random rand = new Random();
            foreach (string name in array2){
                flavorArray[name] = flavors[rand.Next(flavors.Count)];
            }
            foreach (var entry in flavorArray){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
