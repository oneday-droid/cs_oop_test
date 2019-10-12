using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Time
    {
        int m_hours;
        int m_minutes;
        int m_seconds;

        public int Hours
        {
            get { return m_hours;  }
            set { m_hours = value; }
        }

        public int Minutes
        {
            get { return m_minutes; }
            set
            {
                if (value < 60)
                    m_minutes = value;
                else
                {
                    m_hours++;
                    m_minutes = value - 60;
                }
            }
        }

        public int Seconds
        {
            get { return m_seconds; }
            set
            {
                if (value < 60)
                    m_seconds = value;
                else
                {
                    m_minutes++;
                    m_seconds = value - 60;
                }
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            m_hours = hours;
            m_minutes = minutes;
            m_seconds = seconds;
        }

        public Time()
        {
            m_hours = 0;
            m_minutes = 0;
            m_seconds = 0;
        }

    }
}
