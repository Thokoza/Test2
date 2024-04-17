using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add("1,1");
        }

        public static int Add(string numbers)
        {
            int result = 0;
            //Check that the string is not empty
            if (string.IsNullOrEmpty(numbers) == true)
            {
                result = 0;
                Console.WriteLine(result);
            }
            else 
            {
                string[] splitThestring = numbers.Split(",");
                int[] numbersToAdd = new int[splitThestring.Length];
                int[] negatives = new int[splitThestring.Length];
                //We split the numbers array, then loop through it to get the numbers as int
                for (int i = 0; i < splitThestring.Length; i++)
                {
                    numbersToAdd[i] = int.Parse(splitThestring[i]);
                    //checking for negative numbers in the array, then add those to a list
                    if (int.Parse(splitThestring[i]) < 0)
                    {
                        negatives[i] = int.Parse(splitThestring[i]);
                    }
                }
                //Before doing the calculation, check that the numbers array had no negative values. 
                if (negatives.Length > 0)
                {
                    foreach (var n in negatives)
                    {
                        Console.WriteLine("Negative not allowed" + n);
                    }
                    
                }
                else 
                {
                    for (int j = 0; j < numbersToAdd.Length; j++)
                    {
                        result += numbersToAdd[j];
                    }
                    Console.WriteLine(result);
                }
            }
            return result;
        
        }
    }
}
