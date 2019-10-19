using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Presenter
    {
        AbstractPerson person;
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
            return "You add person to conversation";
        }

        public string NewMessageToPerson(string phrase)
        {
            return person.Talk(phrase);
        }

        void GeneratePerson()
        {
            uint age = (uint)random.Next(7, 90);
            AbstractPerson.LanguageType type = (AbstractPerson.LanguageType)(random.Next(0, 100)%2);
            string name = nameVariant[(int)type, random.Next(0, 4)];
            person = new AbstractPerson(name, age, type);
        }
    }
}
