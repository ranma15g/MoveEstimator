using System;

/*

2.2

Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile.

 Write a program named MoveEstimator that prompts a user for and accepts estimates for the number of hours for a job and the number of miles involved in the move and displays the total moving fee.

*/


class Program
{

      static void Main(string[] args)
      {

        // We declare a constant integer to represent the base rate charge
        const int base_rate = 200;

        // We declare a constant integer to represent the mile rate charge
        const int mile_price = 2;

        // We declare a constant integer to represent the hourly rate charge
        const int hour_price = 150;

          // We interact with the customer to discover the amount of hours they will be travelling
          Console.WriteLine("How many hours are you traveling?");
          var time = Console.ReadLine();

          // We interact with the customer to discover the amount of miles they will be travelling
          Console.WriteLine("How many miles are you traveling?");
          var mile = Console.ReadLine();
        
          // We test the input to ensure it is an integer
          int time_test;
        
          // We test the input to ensure it is an integer
          int mile_test;
           
        
          

          // if we can parse both inputs as integers, we can calculate the total cost of the move
          if (int.TryParse(mile, out mile_test) && int.TryParse(time, out time_test))
          {
            // We write the calcuation to an integer to be represented in a string
            int final_price = base_rate + (mile_test * mile_price) + (time_test * hour_price);
            // We deliver the final price to the customer
            Console.WriteLine("{0} miles + {1} hours + base rate = {2}", mile_test, time_test, final_price);           
          }
        else /* if we can not parse both inputs as integers we have to politely tell the
                  customer to go pound sand. */
          {
            Console.WriteLine("You didn't enter the correct information, Good Day...");
          }
      }    

}
