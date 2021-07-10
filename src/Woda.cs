using System;
using System.Collections.Generic;
using System.Text;
//w pliku Woda.cs implementuje rozkazy, np Paruj() rozkazuje stanowi aby wykonał metode Parowanie()
namespace lab06
{
    public class Woda
    {
        private State state;

        public void setState(State newstate)        //on ustawia aktualny stan co sie z nia dzieje, to znaczy co sie dzieje z woda
        {
            state = newstate;
            this.state.setWoda(this);
        }
        public string Info()
        {
           return state.Info();     //wywoluje metode Info() z State
        }

        public void Paruj()
        {
            this.state.Parowanie();
        }
        public void Wplywaj()
        {
            this.state.Wpływa();
        }
        public void Padaj()
        {
            this.state.Opady();
        }
        public void Oddychaj()
        {
            this.state.Oddychanie();
        }
        public void Pij()
        {
            this.state.Picie();
        }
        public void Wydalaj()
        {
            this.state.Wydalanie();
        }
        public void Oczyszczaj()
        {
            this.state.Oczyszczanie();
        }
    }
}
