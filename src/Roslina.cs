using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Roslina : State
    {
        public override string Info()
        {
            return "Roslina";
        }

        public override void Oddychanie()
        {
            this.woda.setState(new Chmura());
        }

    }
}
