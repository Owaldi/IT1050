using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("A NIGHT at the MOVIES");
        

            Console.WriteLine("Answer the Questions Below to Get Start it!");
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine();



            #region MATINEE PRICES

            double ChildPrice = 3.99;
            double AdultPrice = 5.99;
            double SeniorPrice = 4.50;
      
            double ChildTotalPrice = 0;
            double AdultTotalPrice = 0;
            double SeniorTotalPrice = 0;
           
            #endregion


            #region CONCESSION STAND

            ///double SmallSodaPrice = 3.50;
            ///double LargeSodaPrice = 5.99;
            ///double HotDogPrice = 3.99;
            ///double PopCornPrice = 4.50;
            ///double CandyPrice = 1.99;
           
            #endregion

            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("SHOWTIME");
            Console.WriteLine("Enter [1] for Matinee or Enter [2] for Evening");
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine();

            string showtime = Console.ReadLine();

            if (showtime == "1")
            {

                ChildPrice = 3.99;
                AdultPrice = 5.99;
                SeniorPrice = 4.50;
            }


            if (showtime == "2")
            {
                ChildPrice = 6.99;
                AdultPrice = 10.99;
                SeniorPrice = 8.50;
            }

            Console.Write("How Many Children's tickets? ");
            int ChildTicketsq = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ChildTicketsq > 0)
            {
                ChildTotalPrice = ChildTicketsq * ChildPrice;
            }

            Console.Write("How Many Adult tickets? ");
            int AdultTicketsq = int.Parse(Console.ReadLine());
            Console.WriteLine();


            if (AdultTicketsq > 0)
            {
                AdultTotalPrice = AdultTicketsq * AdultPrice;
            }

            Console.Write("How Many Senior tickets? ");
            int SeniorTicketsq = int.Parse(Console.ReadLine());
            Console.WriteLine();


            if (SeniorTicketsq > 0)
            {
                SeniorTotalPrice = SeniorTicketsq * SeniorPrice;
            }

            double TotalTicketsq = ChildTicketsq + AdultTicketsq + SeniorTicketsq;
            double TotalPrice = ChildTotalPrice + AdultTotalPrice + SeniorTotalPrice;
          

            if (ChildTicketsq + AdultTicketsq + SeniorTicketsq >= 3 && showtime == "2")
            {
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("3 or more tickets purchase on an evening show.");
            Console.WriteLine("YOU GET ONE FREE BAG OF POPCORN!");
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine();
            }

          
            Console.Write("How Many Small sodas? ");
            int SmallSodaq = int.Parse(Console.ReadLine());
            double SmallSodaqPrice = SmallSodaq * 3.50; 
            

            System.Console.Write("How Many Large sodas? ");
            int LargeSodaq = int.Parse(Console.ReadLine());
            double LargeSodaqaPrice = LargeSodaq * 5.99; 
           


            Console.Write("How Many Hot dogs?");
            int HotDogq = int.Parse(Console.ReadLine());
            double HotDogqPrice = HotDogq * 3.99;
           


            Console.Write("How Many Popcorn?");
            int PopCornq = int.Parse(Console.ReadLine());
            double PopCornqPrice = PopCornq * 4.50; 
          


            Console.Write("How Many Candies? ");
            int Candyq = int.Parse(Console.ReadLine());
            double CandyqPrice = Candyq * 1.99;


            double Concession = SmallSodaq * 3.50 + LargeSodaq * 5.99 + HotDogq * 3.99 + PopCornq * 4.50 + Candyq * 1.99;
           

            if (Candyq >=3)
            {
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("3 candies Purchased, you get a 4th free.");
            Console.WriteLine("YOU GET 1 CANDY FREE!!");
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine();
            }


            if ( LargeSodaq >0 && PopCornq > 0)
            {
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("popcorn & large soda purchased.");
            Console.WriteLine("YOU GET $ 2 DISCOUNT ON ONE MOVIE TICKET!!");
            Console.WriteLine("+----------------------------------------------+"); 
            Console.WriteLine();
            }


            Console.WriteLine("To  purchase Press Enter");
            Console.ReadKey();


            double Discount = -2;
            double finalPrice = Concession + TotalPrice;

            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("Tickets purchased: "+"=" + TotalTicketsq);
            Console.WriteLine("Concessions Purchased: " + "=" +   SmallSodaq  +  LargeSodaq  +   HotDogq  +  PopCornq  +  Candyq );
            Console.WriteLine("Tickets Total: = $" + TotalPrice);
            Console.WriteLine("Concessions Total: = $" + Concession);
            if ( LargeSodaq >0 && PopCornq > 0 )
            {
            Console.WriteLine("Discount earned on tickets: = $" + Discount);
            Console.WriteLine("Final Total Plus Discount: = $" + (Concession + TotalPrice + Discount));
            Console.WriteLine("+----------------------------------------------+");
            Console.ReadLine();
            }
    
            else 
            {
            Console.WriteLine("Final Total: $" + finalPrice);
            Console.WriteLine("+----------------------------------------------+");
            Console.ReadLine();
            }
      
            Console.ReadLine();

        }
    }
}
