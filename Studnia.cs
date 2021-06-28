using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Studnia : State
    {
        public override string Info()
        {
            return "Studnia";
        }
        public override void Picie()
        {
            this.woda.setState(new Czlowiek());
        }

    }
}