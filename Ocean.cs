using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public class Ocean: State
    {
        public override string Info()
        {
            return "Ocean";
        }

        public override void Parowanie()
        {
            this.woda.setState(new Chmura());
        }

    }
}
