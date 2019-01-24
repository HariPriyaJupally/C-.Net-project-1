using System;

namespace C_.Net_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var i = 1;
            var eyeSight = 0.0;
            var useApp = true;
            var name = String.Empty;
            var unitCost = 0.0m;
            var fname = String.Empty;
            var c = 'q';
            while(useApp)
            {
                Console.WriteLine("Enter any character to use the application or q to Quit");
                var str = Console.ReadLine();
                c = Convert.ToChar(str);
                if(c == 'q')
                {
                     Console.WriteLine("Done");
                     break;
                }
            
            Console.WriteLine("Welcome User to the Spectacles Application");

            Console.WriteLine("Do you have enough amount to buy?");
            Console.WriteLine($"Enter the amount you have");
            var st = Console.ReadLine();
            var sum = Convert.ToDecimal(st);
            if(sum < 75.0m)
            {
                Console.WriteLine("Sorry you don't have enough amount to buy!");
            }
            else if(sum >= 75.0m && sum <= 99m)
            {
                Console.WriteLine($"You can buy only \n {i}.fullframe");
            }
            else if(sum >= 100m && sum <= 150m)
            {
                Console.WriteLine($"You can buy \n {i}.fullframe \n {i+1}.halfframe");
            }
            else
            {
                Console.WriteLine($"You can buy \n {i}.fullframe \n {i+1}.halfframe \n {i+2}.frameless");
            }

            if(sum >= 75.0m)
            {
              while(name == "")
            {
            Console.WriteLine($"Enter your name:");
            name = Console.ReadLine();
            }
            
            Console.WriteLine($"Your name is {name}.");
            
            
            //get the eye sight
            while(eyeSight  == 0.0)
            {
            Console.WriteLine($"Enter your eye sight:");
            var ans = Console.ReadLine();
            eyeSight = Convert.ToDouble(ans);
            }

            Console.WriteLine($"Your eye sight is {eyeSight}.");

            //get the count
            //get the desired frame (switch)
            while(fname == "")
            {
             Console.WriteLine($"Enter your frame name:");
             fname = Console.ReadLine();
             switch(fname.ToLower())
            {
                case "fullframe":
                     unitCost = 75.0m;
                     Console.WriteLine($"The cost for fullframe is {unitCost}");
                     remainingAmount(unitCost);
                    break;
                case "halfframe":
                     unitCost = 100m;
                     Console.WriteLine($"The cost for halfframe is {unitCost}");
                     remainingAmount(unitCost);
                      break;
                case "frameless":
                      unitCost = 150m;
                      Console.WriteLine($"The cost for frameless is {unitCost}");
                      remainingAmount(unitCost);
                      break;
                default:
                    break;
            }
            }
            }

            void remainingAmount(decimal uCost)
            {
                Console.WriteLine($"Your name is {name}\n your eye sight is {eyeSight} \n The frame you ordered is {fname}");
                Console.WriteLine($"The amount remaining in your pocket is {sum-uCost}");
            }
            
            }  
        }
    }
}
