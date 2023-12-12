using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Person
    {
        //Egenskaper: Gör det lätt för att läsa & exekvera data i ett privatfält. Det gör det lättare att ha
        //kontrollerad och säkrare tillgång till data, med hjälp av Private Set.
        public string firstName { get; set; }
        public string lastName { get; private set; }
        public int age { get; private set; }
        public Gender gender { get; private set; }
        public Hair hair { get; private set; }
        public string eyeColor { get; private set; }
        public DateTime birthday { get; private set; }

        //Constructor: Gör det lätt att kontrollera instantiering, skriva kod som är lätt att läsa. Måste matcha namnet som klassen. 
        //Constructor: Sparar en del tid, då man inte behöver skriva så mycket kod. (W3schools.com/cs/cs_csontructor.php)
        //Constructor: En metod i klassen som anropas vid instantiering.
        public Person(string FirstName, string LastName, int Age, Gender genderType, Hair hairType, string EyeColor, DateTime BirthDay)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
            gender = genderType;
            hair = hairType;
            eyeColor = EyeColor;
            birthday = BirthDay;
        }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}" +
                $"\nAge: {age}" +
                $"\nGender: {gender}" +
                $"\nHair: {hair.hairColor} {hair.hairLength}" +
                $"\nEye Color: {eyeColor}" +
                $"\nBirthday: {birthday:yyyy/MM/dd}"; 
        }
    }
}
