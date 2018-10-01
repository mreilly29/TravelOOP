using System;

namespace TravelOOP
{
    public class Travel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Travel(string name )
        {           
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

        }

        public string GetDate(int month, int day, int year)
        {
            DateTime date = new DateTime(year, month, day);           
            string value = (month.ToString() + "/" + day.ToString() + "/" + year.ToString());
            return value;
        }

        public void TtlTravel(int month, int day, int year)
        {
            var startDate = "9/8/2018";
            var temps = startDate.Split('/');
            int[] num = new int[3];
            for (int i = 0; i < temps.Length; i++)
            {
                num[i] = int.Parse(temps[i]);
            }

        }
    }
}