using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Presenter
    {
        Person person;
        Random random;
        string[,] nameVariant; 

        public Presenter()
        {
            random = new Random();
            nameVariant = new string [2,5] {{"Саша", "Маша", "Петя", "Таня", "Марина"}, {"John", "Jane", "Mike", "Jake", "Sarah"}};
        }

        public string AddPerson()
        {
            GeneratePerson();
            return "You add person to conversation\n>> " + person.Talk("");
        }

        public string NewMessageToPerson(string phrase)
        {
            string answer;
            try
            {
                answer = person.Talk(phrase);
            }
            catch (NullReferenceException)
            {
                answer = "No person in conversation";
            }                
                
            return answer;
        }

        void GeneratePerson()
        {
            uint age = (uint)random.Next(7, 90);
            Person.LanguageType type = (Person.LanguageType)(random.Next(0, 100) % 2);
            string name = nameVariant[(int)type, random.Next(0, 4)];
            person = new Person(name, age, type);
        }
    }
}
