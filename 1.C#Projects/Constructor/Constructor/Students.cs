using System;
using System.Runtime.Remoting.Services;

namespace Constructor
{
    internal class Students
    {
        public string FirstName;
        private string LastName;
        public double Age;
        public double Hight;
        public double Weight;
        public static int StudentsNum;

        public Students(string aFirstName, string aLastName, double aAge, double aHight, double aWeight)
        {
            FirstName = aFirstName;
            LastName = aLastName;
            Age = aAge;
            Hight = aHight;
            Weight = aWeight;
            StudentsNum++;

        }
        public bool HasHight()
        {
            if (Hight >= 170)
            {
                return true;
                
            }
           return false;
           
        }
        
        public string Lastname
        {
            get { return LastName; }
            set
            {
                if (value == "Lastname")
                { LastName = value; }
                else LastName = "You don't have Permission";
            }
        }
    }
}
