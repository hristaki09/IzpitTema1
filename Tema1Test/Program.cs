using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            double washingMachinePrice = 0.00;
            int presentPrice = 0;

            age = int.Parse(Console.ReadLine());
            washingMachinePrice = double.Parse(Console.ReadLine());
            presentPrice = int.Parse(Console.ReadLine());

            double savings = 0.00;
            int moneyFromPresents = 0;
            double bonus = 10.00;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += bonus;
                    savings -= 1.00;
                    bonus += 10.00;
                }
                else
                {
                    moneyFromPresents += presentPrice;
                }
            }
            var allMoney = savings + moneyFromPresents;
            if (allMoney >= washingMachinePrice)
                Console.WriteLine("Yes! {0:F2}", allMoney - washingMachinePrice);
            else
                Console.WriteLine("No! {0:F2}", washingMachinePrice - allMoney);

        }
    }
}
