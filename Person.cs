using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public int Age 
        { 
            get => age; 
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
            }
        }
        public bool IsWorking { get => isWorking; set => isWorking = value; }
    
        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string name = FirstName + " " + LastName;
            string personInfo = "";

            personInfo += personId + ": " + name + "'s favorite colour is: " + favoriteColor;

            return personInfo;
        }
        public void ChangeFavoriteColour()
        {
            favoriteColor = "White";

        }
        
        public string GetAgeInTenYears()
        {
            string name = FirstName + " " + LastName;
            int newAge = age + 10;
            string ageInTenYears = "";
                
            ageInTenYears += name + "'s Age in 10 years is: " + newAge;

            return ageInTenYears;
        }
        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonId: " + personId + "\n";
            formatted += "FirstName: " + firstName + "\n";
            formatted += "LastName: " + lastName + "\n";
            formatted += "FavoriteColour: " + favoriteColor + "\n";
            formatted += "Age: " + age + "\n";
            formatted += "IsWorking: " + isWorking;

            return formatted;
        }

    }
}
