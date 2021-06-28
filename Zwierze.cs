using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Zwierze : State
    {
        public override string Info()
        {
            return "Zwierze";
        }
        public override void Oddychanie()
        {
            this.woda.setState(new Chmura());
        }
        public override void Wydalanie()
        {
            this.woda.setState(new Rzeka());
        }

    }
}