using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            
            string person2Info = person2.DisplayPersonInfo();
            Console.WriteLine(person2Info);

            string person3List = person3.ToString();
            Console.WriteLine(person3List);

            person1.ChangeFavoriteColour();
            Console.WriteLine(person1.DisplayPersonInfo());

            string person4AgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine(person4AgeTenYears);

            Relation relation1 = new Relation("Sisterhood", person2, "Sisterhood", person4);
            Relation relation2 = new Relation("Brotherhood", person1, "Brotherhood", person3);

            Console.WriteLine(relation1.ShowRelationship());
            Console.WriteLine(relation2.ShowRelationship());

            List<Person> people= new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            double sum = 0;

            foreach (Person person in people) 
            {
                sum += person.Age;
            }

            double average = sum / (double) people.Count;

            Console.WriteLine("Average age is: " + average);

            string youngest = people.Min(s => s.FirstName);
            Console.WriteLine("The youngest person is: " + youngest);

            string oldest = people.Max(s => s.FirstName);
            Console.WriteLine("The oldest person is: " + oldest);

            foreach (Person person in people)
            {
                if (person.FirstName[0] == 'M') 
                    Console.WriteLine(person.ToString());
            }
            foreach (Person person in people)
            {
                if (person.FavoriteColor == "Blue")
                    Console.WriteLine(person.ToString());
            }

        }


    }
}
