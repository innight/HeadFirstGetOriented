using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstGetOriented
{
    public class Guy
    {
        private string Name;
        private int Age;
        private int Cash;

        public Guy(string name,int age, int cash)
        {
            this.Name = name;
            this.Age = age;
            this.Cash = cash;

        }

       public Guy() { }

        public int GiveCash(int amount)
        {
            if(amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {

                Console.WriteLine("I dont have enough cash!" + amount, Name + "says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                Console.WriteLine(amount + " isn´t an amount i ll take", Name + "says...");
                return 0;
            }
        }

        public int ShowCash()
        {
            return Cash;
        }

    }
}
