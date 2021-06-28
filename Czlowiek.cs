using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Czlowiek : State
    {
        public override string Info()
        {
            return "Czlowiek";
        }
        public override void Wydalanie()
        {
            this.woda.setState(new Oczyszczalnia());
        }
        public override void Oddychanie()
        {
            this.woda.setState(new Chmura());
        }

    }
}