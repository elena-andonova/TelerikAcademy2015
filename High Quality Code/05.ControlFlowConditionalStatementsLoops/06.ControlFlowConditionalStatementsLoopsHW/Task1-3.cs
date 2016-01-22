using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlFlowConditionalStatementsLoopsHW
{
    class Program
    {
        // Task 1.Refactor the following class using best practices for organizing straight-line code:
        public class Chef
        {
            public void Cook()
            {

                Potato potato = GetPotato();
                Peel(potato);
                Cut(potato);

                Carrot carrot = GetCarrot();
                Peel(carrot);
                Cut(carrot);

                Bowl bowl = GetBowl();
                bowl.Add(carrot);
                bowl.Add(potato);
            }
            private Bowl GetBowl()
            {
                //... 
            }
            private Potato GetPotato()
            {
                //...
            }
            private Carrot GetCarrot()
            {
                //...
            }
            private void Cut(Vegetable potato)
            {
                //...
            }
        }
        static void Main(string[] args)
        {
            //Task 2. Refactor the following if statements
                Potato potato = null;
                //... 
                if (potato != null)
                {
                    if (potato.HasBeenPeeled && !potato.IsRotten)
                    {
                        Cook(potato);
                    }                    
                }
                //..and
                bool inRange = MIN_X <= x && x <= MAX_X && MIN_Y <= y && y <= MAX_Y;
                if (inRange && shouldVisitCell)
                {
                   VisitCell();
                }

            //Task 3. Refactor the following loop                
                bool found = false;
                for (int i = 0; i < 100; i++)
                {
                    if (i % 10 == 0)
                    {                        
                        if (numbers[i] == expectedValue)
                        {
                            found = true;
                            break;
                        }
                    }
                    else
                    {
                       //..no need of else
                    }
                    Console.WriteLine(numbers[i]);
                }
                // More code here
                if (found)
                {
                    Console.WriteLine("Value Found");
                }
        }
    }
}
