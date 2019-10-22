using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface ViewState
    {
        void InformMessage(string message);
        void PersonMessage(string message);
        void UserMessage(string message);        
    }
}
