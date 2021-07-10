using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    public abstract class State
    {

        protected Woda woda;    //obiekt rodzic bo setWoda to wykorzystuje this.woda
        public void setWoda(Woda _woda)      //potrzebne aby "rodzic" mogl ustawic referencje na siebie
        {
            this.woda = _woda;
        }
        public abstract string Info();
        public virtual void Parowanie() { } //pusta metoda, virtual bo deklaracja pustej metody, jak nie dam virtual 
        //tylko abstract to bym musial robic ovverride z pusta metdoa, i po 15 ovverride w kazdym pliku -> niewygodne
        public virtual void Wpływa() { }
        public virtual void Opady() { }
        public virtual void Oddychanie() { }
        public virtual void Picie() { }
        public virtual void Wydalanie() { }
        public virtual void Oczyszczanie() { }
    }
}
