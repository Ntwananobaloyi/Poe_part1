using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poe_part1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //creating instance for voice greeting class
            new voice() { };

            //creating instance for voice class
           

            //creating instance for logo display
            new logo() { };

            //creating an instance for full_name classs with object name display_class
            full_name display_name = new full_name();
            //calling the welcome method
            display_name.welcome();
            //calling the ask name method 
            display_name.ask_name();

            string name = display_name.GetUsername();
            ChatBot bot = new ChatBot();
            bot.Ai_chat(name);

        }
    }
}
