using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CardPicker card_picker = new CardPicker();
            
            Console.Write("카드를 몇 장 뽑을 건가요?");
            string s_line = Console.ReadLine();

           if(int.TryParse(s_line, out int numberOfCards))
           {
                foreach (string card in CardPicker.PickSomCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
           else
           {
                Console.WriteLine("Please enter a valid number");
           }

   

        }
    }
}
