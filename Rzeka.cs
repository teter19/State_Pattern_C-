using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Rzeka : State
    {
        public override string Info()
        {
            //Console.WriteLine("rzeka");
            return "Rzeka";
        }

        public override void Parowanie()
        {
            this.woda.setState(new Chmura());
        }

        public override void Wpływa()
        {
            this.woda.setState(new Ocean());        //terz rzeka jest oceanem
        }
        public override void Picie()
        {
            this.woda.setState(new Zwierze());
        }
    }
}
