using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EnglishSpeakerImpl : ISpeaker
    {
        Person m_person;

        public EnglishSpeakerImpl(Person person)
        {
            m_person = person;
        }

        public string SayHi()
        {
            return "Hello!";
        }

        public string AskSmth(string question)
        {
            string answer = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(question, "[а-яА-Я]"))
                answer = "I don't understand you";
            else if (question == "Hello")
                answer = SayHi();
            else if (question == "What's your name?")
                answer = String.Format("I'm {0}", m_person.Name);
            else if (question == "How old are you?")
                answer = String.Format("I'm {0}", m_person.Age);
            else
                answer = "I don't know what to say";
            return answer;
        }
    }
}
