/*
 Author: Priyanka Thakur
 Date: 2/9/2020
 Comments: Assignment1_Spring2020
*/

using System;
using System.Collections;


namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            int n4 = 5;
            Stones(n4);

        }

        // Print pattern
        private static void PrintPattern(int n)
        {
            try
            {

                Console.WriteLine("First Output: ");
                Console.WriteLine("The printpattern for the given number is: ");


                // Using Loops to print the pattern

                int i, j;

                for (i = n; i >= 1; i--) // Start of first Loop
                {
                    // Start of second loop
                    for (j = i; j >= 1; j--)
                    {
                        Console.Write(j);
                    }// end of second loop
                    Console.WriteLine();
                }// end of first loop

                Console.WriteLine();
            }

            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }


        }

        //PrintSeries
        private static void PrintSeries(int n2)
        {
            try
            {
                // printing the series

                Console.WriteLine("Second Output: ");
                Console.WriteLine("The PrintSeries for the given number is: ");

                int i;

                // For loop

                for (i = 1; i <= n2; i++)
                {
                    Console.Write((i * (i + 1) / 2) + "  ");   // Code for printing the series

                }
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }

        //USFTime
        public static string UsfTime(string s)
        {
            try
            {
                DateTime time = DateTime.Parse(s);

                // Getting total number of seconds from the given earth time

                double earthseconds = (((time.Hour) * 60 * 60) + (time.Minute * 60) + (time.Second));

                // Converting the earth time to USF time

                double hours = earthseconds / 60 / 45;
                double minutes = (hours - (Math.Truncate(hours))) * 60;
                double seconds = (minutes - (Math.Truncate(minutes))) * 45;

                double usfhours = Math.Truncate(hours);
                double usfminutes = Math.Truncate(minutes);
                double usfseconds = Convert.ToInt32(seconds);

                // if-else block

                if ((usfhours > 0 || usfhours <= 36) && (usfminutes > 0 || usfminutes <= 59)
                    && (usfseconds > 0 || usfseconds <= 45))
                {
                    Console.WriteLine();
                    Console.WriteLine("Third Output: ");
                    Console.WriteLine("The USF time is " + usfhours + " : "
                             + usfminutes + " : " + usfseconds);
                }
                else
                {
                    usfhours = Math.Abs(36 - usfhours);
                    usfminutes = Math.Abs(60 - usfminutes);
                    usfseconds = Math.Abs(45 - usfseconds);

                    Console.WriteLine("The USF time is " + usfhours + " : "
                             + usfminutes + " : " + usfseconds);

                } // end of if-else block
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        //USFNumbers
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                Console.WriteLine("Fourth Output: ");
                Console.WriteLine("The USFnumbers are : ");
                for (int i = 1; i <= n3; i++)
                {
                    if (i % 5 == 0 && i % 7 == 0 && i % 3 == 0)   // Multiples of 3,5 & 7 will print USF
                    {
                        Console.Write("USF" + " ");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)  // Multiples of 3 & 5 will print US
                    {
                        Console.Write("US" + " ");
                    }
                    else if (i % 3 == 0 && i % 7 == 0) // Multiples of 3 & 7 will print UF
                    {
                        Console.Write("UF" + " ");
                    }
                    else if (i % 5 == 0 && i % 7 == 0) // Multiples of 5 & 7 will print SF
                    {
                        Console.Write("SF" + " ");
                    }

                    else if (i % 3 == 0)  // Multiples of 3  will print U
                    {
                        Console.Write("U" + " ");
                    }
                    else if (i % 5 == 0)// Multiples of 5 will print S
                    {
                        Console.Write("S" + " ");
                    }
                    else if (i % 7 == 0) // Multiples of 3 & 5 will print F
                    {
                        Console.Write("F" + " ");
                    }
                    else
                    {
                        Console.Write(i + " "); // Prints the remaining numbers
                    }

                    Console.Write(((i % k == 0) ? "\n" : " "));
                    // prints only the required numbers per line and moves to a new line

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }

        // PalindromePairs        
        public static void PalindromePairs(string[] words)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Fifth Output: ");
                Console.WriteLine("The Palindrome Pairs are: ");

                int n = words.Length;

                for (int i = 0; i < n; i++) // first loop
                {
                    for (int j = i + 1; j < n; j++) // second loop
                    {
                        string str = "";
                        str = str + words[i] + words[j]; // forming combinations

                        int len = str.Length;
                        char[] charArray = str.ToCharArray();
                        Array.Reverse(charArray);
                        string rev = new string(charArray);

                        if (str == rev) //checking if it is a palindrome
                        {
                            Console.Write("[" + i + "," + j + "]");
                            Console.WriteLine(str + " "); // printing the palindrome string
                        }

                        string str1 = "";
                        str1 = str1 + words[j] + words[i];
                        int len1 = str1.Length;
                        char[] charArray1 = str1.ToCharArray();
                        Array.Reverse(charArray1);
                        string rev1 = new string(charArray1);

                        if (str1 == rev1)
                        {
                            Console.Write("[" + j + "," + i + "]");
                            Console.WriteLine(str1 + " ");

                        }

                    } // end of second loop
                }// end of first loop

            }

            catch
            {

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        // Stones
        public static void Stones(int n4)
        {
            try
            {

                Console.WriteLine();
                Console.WriteLine("Sixth Output: ");
                Console.WriteLine("The Player1 wins with these set of moves: ");

                //Declaring an Array List

                ArrayList mylist = new ArrayList();

                if (n4 <= 3)
                    Console.WriteLine("Player 1 wins by taking out all stones");
                else if (n4 % 4 == 0)
                    Console.WriteLine("False"); // Prints False if Player 1 doesnot win
                else   // Set of moves for which Player 1 wins
                {

                    for (int i = 1; i < 4; i++) //First Loop
                    {

                        for (int j = 1; j < 4; j++) //Second loop
                        {
                            int a = n4 - (i + j);
                            if (a <= 0)
                            {
                                mylist.Clear();

                            }

                            else if (a <= 3 && a != 0)
                            {
                                mylist.Add(i);
                                mylist.Add(j);
                                mylist.Add(a);

                                Console.Write("[");
                                foreach (var k in mylist) // getting output from the array list
                                {

                                    Console.Write(k);

                                }
                                Console.Write("]");
                                mylist.Clear();
                            }

                            else
                            {
                                for (int l = 3; l >= 1; l--)  // third loop
                                {

                                    int b = n4 - (i + j + l);
                                    if (b <= 0)
                                        Console.WriteLine();

                                    if (b <= 3 && b != 0)
                                    {
                                        mylist.Add(i);
                                        mylist.Add(j);
                                        mylist.Add(l);
                                        mylist.Add(b);
                                        Console.Write("[");
                                        foreach (var k in mylist)  // getting output from the array list
                                        {
                                            Console.Write(k);

                                        }
                                        Console.Write("]");

                                    }
                                    mylist.Clear();

                                } // end of third loop


                            }


                        }  // end of second loop

                    } // end of first loop

                }
                Console.WriteLine();

            } //end of try block


            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
} // END OF PROGRAM




/*

Self - Reflection:

 I have learnt about the various data types and how to use them.
 I have  also learnt how to use loops, arrays and methods.
This Assignment is really helpful in understanding the basics of C# Programming

    */





