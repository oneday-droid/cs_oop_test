using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Person 
    {
        public enum LanguageType
        {
            Russian = 0,
            English
        }

        string m_name;
        uint m_age;
        ISpeaker m_language;

        public string Name
        {
            private set { m_name = value; }
            get { return m_name; }
        }

        public uint Age
        {
            private set { m_age = value; }
            get { return m_age; }
        }

        public Person(string name, uint age, LanguageType type)
        {
            Name = name;
            Age = age;

            switch (type)
            {
                case LanguageType.English: m_language = new EnglishSpeakerImpl(this); break;
                case LanguageType.Russian: m_language = new RussianSpeakerImpl(this); break;
            }
        }

        public string Talk(string phrase)
        {
            string answer = "";
            if (phrase == "")
                answer = m_language.SayHi();
            else
                answer = m_language.AskSmth(phrase);

            return answer;
        }
    }
}
