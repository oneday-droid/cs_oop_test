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
        ViewState view;
        Random random;
        string[,] nameVariant; 

        public static Dictionary<string, Person.LanguageType> AvailableLanguage()
        {
            Dictionary<string, Person.LanguageType> languages = new Dictionary<string, Person.LanguageType>();
            languages.Add("Russian", Person.LanguageType.Russian);
            languages.Add("English", Person.LanguageType.English);

            return languages;
        }

        public void attachView(ViewState view)
        {
            this.view = view;
        }

        public Presenter()
        {
            random = new Random();
            nameVariant = new string [2,5] {{"Саша", "Маша", "Петя", "Таня", "Марина"}, 
                                            {"John", "Jane", "Mike", "Jake", "Sarah"}};
        }

        public void AddPerson(string name, uint age, int language)
        {
            Person.LanguageType type = (Person.LanguageType)language;
            if ((name == "") || (age <= 0))
                GeneratePerson(out name, out age, out type);

            person = new Person(name, age, type);

            view.InformMessage("You add person to conversation");
            view.PersonMessage(person.Talk());
        }

        public void NewMessageToPerson(string phrase)
        {
            try
            {
                view.PersonMessage(person.Talk(phrase));
            }
            catch (NullReferenceException)
            {
                view.InformMessage("No person in conversation");
            }
        }

        void GeneratePerson(out string name, out uint age, out Person.LanguageType type)
        {
            age = (uint)random.Next(7, 90);
            type = (Person.LanguageType)(random.Next(0, 100) % 2);
            name = nameVariant[(int)type, random.Next(0, 4)];
        }
    }
}
