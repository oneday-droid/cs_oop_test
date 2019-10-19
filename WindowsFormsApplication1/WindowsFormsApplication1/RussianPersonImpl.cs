using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class RussianPersonImpl : IPerson
    {
        AbstractPerson m_person;

        public RussianPersonImpl(AbstractPerson person)
        {
            m_person = person;
        }

        public string SayHi()
        {
            return "Привет!";
        }

        public string AskSmth(string question)
        {
            string answer = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(question, "[a-zA-Z]"))
                answer = "Я Вас не понимаю";
            else if (question == "Как тебя зовут?")
                answer = String.Format("Меня зовут {0}", m_person.Name);
            else if (question == "Сколько тебе лет?")
                answer = String.Format("Мне {0}", m_person.Age);
            else
                answer = "Не знаю что на это ответить";
            return answer;
        }
    }
}
