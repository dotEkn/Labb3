using Labb3;

namespace Gik299_HT23_William_Ekengren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Slutgiltiga för utskrift av insamlad data ifrån Hair.cs, Gender.cs och Person.cs.
            string FirstName = "Per";
            string LastName = "Andersson";
            int age = 25;
            Gender gender = Gender.Man;
            Hair hair = new Hair { hairLength = "2cm" , hairColor = "Black" };
            string eyeColor = "Blue";
            DateTime BirthDay = new DateTime(1997, 12, 04);

            Person person = new Person (FirstName,LastName,age,gender,hair,eyeColor,BirthDay);
            
            Console.WriteLine(person.ToString());
        }
    }
}
