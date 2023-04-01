using System;

namespace Constants {
    class Program {
        static void Main(String[] args) {
            // Constants: Immutable values which are known at compile time
            //            and do not change for the duration of the program.
            //
            //            This can be desirable from a security perspective if, for example,
            //            we don't want the user to change the value of an important variable.

            const double pi = 3.14159; // We initiate the statement with the "const" keyword, which prevents the program from
                                       // changing the value of this variable at any point while its running.
        }
    }
}