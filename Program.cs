using System;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {    
            // Splits on space
            // Stores input as string in an array
            string[] input = Console.ReadLine().ToUpper().Split(" ");

            long n = Int64.Parse(input[0]);
            char b = input[1][0];

            int points = 0;

            for(int i = 0; i < (n*4); i++){
                // Individial cards 
                char[] card = Console.ReadLine().ToUpper().ToCharArray();
                char value = card[0];
                char suit = card[1];

                switch(value){
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    case 'J':
                        if (suit == b){
                            points += 20;
                        }
                        else {
                            points += 2;
                        }
                        break;
                    case 'T':
                        points += 10;
                        break;
                    case '9':
                        if(suit == b){
                            points += 14;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(points);

        }
    }
}