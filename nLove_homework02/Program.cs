using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_homework02
{
    //the program takes the first 3 digits - divides by 7 - gets the reminder and compares the reminder to the last digit.
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a 4-digit number
            Console.Write("Enter a four -digit number: ");

            //store the number as a string
            string input = Console.ReadLine();

            //take the first 3 digits- use Substring method
            string firstThree = input.Substring(0, 3);// 0 - the place of the digit in the number - it is the 1st digit! and 3 is how many digits we take

            // parse those digits into int
            int intFirstThree = Int32.Parse(firstThree);

            //take the last digit
            string lastDigit = input.Substring(3); // 3 - the place of the digit in the number - it is the 4th digit!

            //parse the last digit into an int
            int intLastDigit = Int32.Parse(lastDigit);

            //take first three digits %7 (modulo 7)
            int mod = intFirstThree % 7;

            //compare that to the last digit int
            if (mod == intLastDigit)
            {
                Console.WriteLine("good number");
            }
            else
            {
                Console.WriteLine("bad number");
            }

            string answer="y";
            while (answer == "y")
            {

                //ISBN
                //ask the user for a ISBN 13-digit number
                Console.Write("Enter a ISBN 13-digit number: ");

                //store the number as a string
                string input2 = Console.ReadLine();

                //take each digit- use Substring method
                string firstDigit = input2.Substring(0, 1);// 0 - the place of the digit in the number - it is the 1st digit! and 1 is how many digits we take
                string secondDigit = input2.Substring(1, 1);
                string thirdDigit = input2.Substring(2, 1);
                string fourthDigit = input2.Substring(3, 1);
                string fifthDigit = input2.Substring(4, 1);
                string sixthDigit = input2.Substring(5, 1);
                string seventhDigit = input2.Substring(6, 1);
                string eighthDigit = input2.Substring(7, 1);
                string ninethDigit = input2.Substring(8, 1);
                string tenthDigit = input2.Substring(9, 1);
                string eleventhDigit = input2.Substring(10, 1);
                string twelvthDigit = input2.Substring(11, 1);

                // parse those digits into int
                int first = Int32.Parse(firstDigit);
                int second = Int32.Parse(secondDigit);
                int third = Int32.Parse(thirdDigit);
                int fourth = Int32.Parse(fourthDigit);
                int fifth = Int32.Parse(fifthDigit);
                int sixth = Int32.Parse(sixthDigit);
                int seventh = Int32.Parse(seventhDigit);
                int eighth = Int32.Parse(eighthDigit);
                int nineth = Int32.Parse(ninethDigit);
                int tenth = Int32.Parse(tenthDigit);
                int eleventh = Int32.Parse(eleventhDigit);
                int twelvth = Int32.Parse(twelvthDigit);

                //take the last digit
                string lastDigit2 = input2.Substring(12); // 12 - the place of the 13th digit in the number - it is the 13th digit!

                //parse the last digit into an int
                int intLastDigit2 = Int32.Parse(lastDigit2);

                //create array of digits - created variables
                int[] numbers = { first, second, third, fourth, fifth, sixth, seventh, eighth, nineth, tenth, eleventh, twelvth };
                int total = 0;

                //calculate with the for - loop - the total: multiplying by 3 every second / even number - 
                //but position of every even number is odd - so working with the position in the array, not the number itself!!!
                for (int i = 0; i < numbers.Length; i++)
                {
                    int m = i % 2;
                    if (m == 0)
                    {
                        total += numbers[i];// it is the position of the digit in the array - first position is=0, but the digit is '1' - 
                                            //(so need to multiply by 3 the opposite numbers, not these, which %2=0.)
                    }
                    else
                    {
                        total += numbers[i] * 3;// total is added to the previous result
                    }

                }

                //checking modulo 10 on the total (total%10)
                int mod2 = total % 10;

                //compare that to the last digit int
                if (mod2 == intLastDigit2)
                {
                    Console.WriteLine("good number");
                }
                else
                {
                    Console.WriteLine("bad number");
                }

                // (int mod = intFirstThree % 7;)
                // if (int % 2 == 0) {newInt=int*3;}
                //else {new Int=int;}
                //sum = all ints+ all newInts

                //ask the user if he wants to continue
                Console.WriteLine("Wanna try again? y/n");
                answer = Console.ReadLine();

            }
            //WriteLine - adds a new line; Write - stays in the same line.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
                
    }
}
