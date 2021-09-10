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
            long hands = Int64.Parse(input[0]);
            char dom = input[1][0];
            int points = 0;
            for(int i = 0; i < (hands*4); i++){
                // Individial cards 
                char[] card = Console.ReadLine().ToUpper().ToCharArray();
                //Setting the first character as the value 
                char value = card[0];
                //Setting the second character as the suit
                char suit = card[1];
                //Using a switch instead of if/else
                //Because cards like A, K, Q add the same amount of points regardless, we don't need to do anything else
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
                    // This is where it differentiates 
                    case 'J':
                        if (suit == dom){
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
                        if(suit == dom){
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