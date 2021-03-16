using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_App
{
    class HealthProfile
    {

        private string firstName;
        private string lastName;
        private string gender;

        private string month;
        private int    day;
        private int    year;
        private double height; // in inches
        private double weight; // in pounds
        private int currentYear;

        // constructor to initialize the above attributes
        public HealthProfile (string first, string last, string sex, string monthOfBirth, int dayOfBirth, int yearOfBirth, double heightinInches, double weightInPounds)
        {
            firstName    = first;
            lastName     = last;
            gender       = sex;
            month        = monthOfBirth;
            day          = dayOfBirth;
            year         = yearOfBirth;
            height       = heightinInches;
            weight       = weightInPounds;
            

        }

        //get and set properties for the First Name
        public string FirstName
        {
            get { return firstName;  }
            set { firstName = value; }

        }

        //get and set properties for the Last Name
        public string LastName
        {
            get { return LastName; }
            set { lastName = value; }

        }

        //get and set properties for the Gender
        public string Gender
        {
            get { return gender; }
            set { gender = value; }

        }

        //get and set properties for the Month of Birth
        public string MonthOfBirth
        {
            get { return month; }
            set { month = value; }
        }

        //get and set properties for the Day of Birth
        public int DayOfBirth
        {
            get { return day; }
            set { day = value; }
        }

        //get and set properties for the Year of Birth
        public int YearOfBirth
        {
            get { return year; }
            set { year = value; }

        }

        //get and set properties for the Weight
        public double Weight
        {
            get { return weight; }
            set { weight = value; }

        }
        //get and set properties for the Height
        public double Height
        {
            get { return height; }
            set { height = value; }

        }
        //get and set properties for the Current year
        public int CurrentYear
        {
            get { return currentYear; }
            set { currentYear = value; }

        }

        int heartRate;
        //method handling the Age
        public int Age()
        {
            
            year = currentYear - year;
            return year;

        }
        //method handling the Maximum Heart Rate
        public double MaxHeart()
        {

            heartRate = 220 - year;
            return heartRate;

        }
        //method handling the Target Rate
        public double TargetRate ()
        {
            double TargetHeartRate = (0.55 * MaxHeart());
            return TargetHeartRate;

          
        }
        //method handling the Body Mass index (BMI)
        double bmi;
        public double BMI()
        {
            bmi = (weight * 703) / (height * height);
            return bmi;
        }
        //method handling the Body Mass index (BMI) Status
        public void BMISTATUS()
        { 

            if (bmi < 18.5)
            {
                
                Console.WriteLine("You are Underweight");
                
            }
            else if (bmi > 18.5 && bmi < 25 )
            {
                Console.WriteLine("You are Normal");
               
            }
            else if (bmi > 25 && bmi < 30)
            {
                Console.WriteLine("You are Overweight");

            }
            else
            {
                Console.WriteLine("You are Obese");

            }
           
        }

    }   
}
