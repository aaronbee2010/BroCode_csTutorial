using System;

namespace StringMethods {
    class Program {
        static void Main(String[] args) {
            /*
                11. String methods
            */
            String myForename = "Aaron";
            Console.WriteLine(myForename);

            myForename = myForename.ToUpper(); // Converts all lower-case alphabet characters in a string to upper-case
            Console.WriteLine(myForename);

            myForename = myForename.ToLower(); // Converts all upper-case alphabet characters in a string to lower-case
            Console.WriteLine(myForename);

            String myFullName = "Aaron";
            myFullName = myFullName.Insert(0, "Mr. ");
            // The "Insert(int a, String b)" method accepts two parameters:
            // * An integer "a" specifying the index to insert string "b"
            // * A string "b" to be inserted into a given string at a specific location.
            int myFullNameLength = myFullName.Length;
            // We can use the "Length" attribute of a string to attain the index needed to append a string to the end of another one.
            myFullName = myFullName.Insert(myFullName.Length, " Bee");
            Console.WriteLine(myFullName);

            String myPhoneNumber = "0789-321-4567";
            Console.WriteLine(myPhoneNumber);

            myPhoneNumber = myPhoneNumber.Replace("-", " ");
            Console.WriteLine(myPhoneNumber);

            String myLetters = "abcdefg";
            Console.WriteLine(myLetters);
            myLetters = myLetters.Substring(2); // Extracts all characters in the string "myLetters" from zero-based index 2 onwards
                                                // (the 3rd character onwards) and reassigns them to "myLetters"
            Console.WriteLine(myLetters);
            myLetters = "abcdefg";
            myLetters = myLetters.Substring(3,2); // Extracts 2 characters in the string "myLetters" from zero-based index 3 onwards
                                                  // (the 4th character onwards) and reassigns them to "myLetters"
            Console.WriteLine(myLetters);

        }
    }
}