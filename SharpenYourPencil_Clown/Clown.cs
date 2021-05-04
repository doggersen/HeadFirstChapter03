using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenYourPencil_Clown
{
    class Clown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine("my name is " + Name + " and i'm " + Height + " inches tall");
        }
    }
}
