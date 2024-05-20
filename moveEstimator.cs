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
        const double base_rate = 200;

        // We declare a constant integer to represent the mile rate charge
        const double mile_price = 2;

        // We declare a constant integer to represent the hourly rate charge
        const double hour_price = 150;

          // We interact with the customer to discover the amount of hours they will be travelling
          Console.WriteLine("How many hours are you traveling?");
          var time = Console.ReadLine();

          // We interact with the customer to discover the amount of miles they will be travelling
          Console.WriteLine("How many miles are you traveling?");
          var mile = Console.ReadLine();
        
          // We test the input to ensure it is an integer
          double time_test;
        
          // We test the input to ensure it is an integer
          double mile_test;
           
        
          

          // if we can parse both inputs as integers, we can calculate the total cost of the move
          if (double.TryParse(mile, out mile_test) && double.TryParse(time, out time_test))
          {
            // We write the calcuation to an integer to be represented in a string
            double final_price = base_rate + (mile_test * mile_price) + (time_test * hour_price);
            // We deliver the final price to the customer
            Console.WriteLine("This would be how much you owe = ${0:F2}", final_price);           
          }
        else /* if we can not parse both inputs as integers we have to politely tell the
                  customer to go pound sand. */
          {
            Console.WriteLine("You didn't enter the correct information, Good Day...");
          }
      }    

}
