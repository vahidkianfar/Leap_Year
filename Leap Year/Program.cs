
    using System;
    namespace Leap_Year  
    {  
        class Program   
        {  
            public static void Main()  
            {  
                Console.WriteLine("Enter Year : ");
                try
                {
                    var year = Convert.ToInt32(Console.ReadLine());
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) Console.WriteLine("{0} is a Leap Year.", year);
                    else Console.WriteLine("{0} is not a Leap Year.", year);
                }
                catch (Exception)
                {
                    Console.WriteLine("Year should be a number.");
                }
                
            }  
        }  
    }  
