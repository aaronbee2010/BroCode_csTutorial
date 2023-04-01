using System;

namespace ReturnKeyword {
    class Program {
        static void Main(String[] args) {
            /*
                24. "return" keyword.
                
                Used in a method, this keyword will send a value to where its method was invoked.

                The type of the value returned depends on the return type of the method it was
                invoked in.

                "void" methods don't return a value.
            */
            Console.WriteLine(Multiply(5, 7));            
        }

        static double Multiply(double x, double y) {
            return (x * y);
        }
    }
}