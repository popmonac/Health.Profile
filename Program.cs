using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_App
{
    class Program
    {
        static void Main(string[] args)
        {


            HealthProfile health = new HealthProfile (null, null, null, null, 0, 0, 0, 0);
            Console.WriteLine ("{0}\n{1}\n", "Hello","kindly enter your data's");

            Console.Write("First name :");
            health.FirstName = Console.ReadLine(); //Input first name

            Console.Write("Last name :");
            health.LastName   = Console.ReadLine();  //Input last name

            Console.Write("Gender :");
            health.Gender  = Console.ReadLine();     //Input gender

            Console.Write("Day of birth :");
            health.DayOfBirth = Convert.ToInt32 (Console.ReadLine());  //Input day of birth

            Console.Write("Month of birth :");
            health.MonthOfBirth = Console.ReadLine(); //Input Month of birth

            Console.Write("Year of birth :");
            health.YearOfBirth    = Convert.ToInt32(Console.ReadLine()); //Input Year of birth

            Console.WriteLine("Your date of birth is : " + health.DayOfBirth +"/" + health.MonthOfBirth + "/" + health.YearOfBirth); //output dateof birth

            Console.Write("Height in inches :");
             health.Height    = Convert.ToDouble (Console.ReadLine());//Input height

            Console.Write("Weight in pounds:");
            health.Weight    = Convert.ToDouble (Console.ReadLine()); //Input weight

            Console.Write("Current Year :");
            health.CurrentYear = Convert.ToInt32(Console.ReadLine()); //Input current year
            Console.WriteLine();
           

            Console.WriteLine("Your age is : " + health.Age() + " years old"); //Display Age
            Console.WriteLine("Your maximum heart rate is : " + health.MaxHeart()); //Display Maximum Heart Rate
            Console.WriteLine("Your Target rate is : " + health.TargetRate()); //Display Target Rate
            Console.WriteLine("Your BMI is : " + health.BMI()); //Display Body mass index
            health.BMISTATUS(); //Display Body mass index Status
            Console.WriteLine();
            Console.WriteLine("Endeavor to visit the health center for regular check up "); 
            Console.WriteLine("stay Safe");
            Console.ReadLine();



        }
    }
}
