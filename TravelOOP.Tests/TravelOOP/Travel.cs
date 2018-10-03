using System;

namespace TravelOOP
{
    public class Travel
    {
        //properties
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //constructors
        public Travel(string name )
        {   
            //splits input into first and last name
            var words = name.Split(' ');
            if(words.Length == 1)
            {
                FName = words[0];
            }
            else
            {
                FName = words[0];
                LName = words[1];
            }        
        }
        public Travel()
        {
            //default constructor
        }
        //accepts input of ints and converts into string "mm/dd/yyyy" date format
        public string GetDate(int month, int day, int year)
        {
            DateTime date = new DateTime(year, month, day);           
            string value = (month.ToString() + "/" + day.ToString() + "/" + year.ToString());
            return value;
        }

        public int TtlTravel(int month, int day, int year)
        {
            //puts month, day, and year into array
            var endDateArray = new int[] { month, day, year };
            //converts start day from string to ints 
            var startDate = "9/8/2018";
            var temps = startDate.Split('/');
            int[] startDateArray = new int[3];
            for (int i = 0; i < temps.Length; i++)
            {
                startDateArray[i] = int.Parse(temps[i]);
            }
            //calculates total days when month is the same
            int totalDays = 0;
            if (endDateArray[0] == startDateArray[0])
            {
                totalDays = endDateArray[1] - startDateArray[1];
            }
            //calculate total days when year is the same
            if(endDateArray[2] == startDateArray[2])
            {
                totalDays = endDateArray[1] - startDateArray[1];
            }
            //returns total days
            return totalDays;
        }

        public string GetSelection(int input)
        {
            if (input == 0)
            {
                return "Stay Home";
            }
            else if (input == 1)
            {
                return "Put in Bay";
            }
            else if (input == 2)
            {
                return "Nashville";
            }
            else if (input == 3)
            {
                return "Florida";
            }
            else if (input == 4)
            {
                return "Georgia";
            }
            else if(input == 5)
            {
                return "Cali";
            }else{
                return "The World is Yours";
            }
        }
    }
}