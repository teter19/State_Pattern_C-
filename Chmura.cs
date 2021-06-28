using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    class Chmura : State
    {
        public override string Info()
        {
            //Console.WriteLine("rzeka");
            return "Chmura";
        }
        public override void Opady() 
        {
            int rnd = new Random().Next(0, 2);
            if (rnd == 0)
            {
                this.woda.setState(new Roslina());
            }
            else if (rnd == 1)
            {
                this.woda.setState(new Studnia());
            }
            else if (rnd == 2)
            {
                this.woda.setState(new Rzeka());
            }

        }
    }
}
