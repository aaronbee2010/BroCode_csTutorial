using System;

namespace ParamsKeyword {
    class Program {
        static void Main(String[] args) {
            /*
                26. "params" keyword. This keyword lets you specify a method parameter with a VARIABLE number of arguments.
                The parameter type must be a single-dimensional array
            */
            double total = Checkout(2.99, 4.58, 1.09, 2.14, 18.99);
            Console.WriteLine("Dear customer, the total price of your groceries comes to: £" + total);
        }
        
        static double Checkout(params double[] prices) {
            double totalPrice = 0;
            foreach (double price in prices) {
                totalPrice += price;
            }
            return totalPrice;
        }
    }
}