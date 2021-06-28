using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Oczyszczalnia : State
    {
        public override string Info()
        {
            return "Oczyszczalnia";
        }
        public override void Oczyszczanie()
        {
            this.woda.setState(new Rzeka());
        }

    }
}