
using System.Text;

namespace GenericDeckExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bulding deck
            Deck<Card> deck = new Deck<Card>();
            for (int i = 1; i <= 13; i++)
            {
                
                deck.Push(new Card(i, Card.Suits.Diamonds));
                deck.Push(new Card(i, Card.Suits.Spades));
                deck.Push(new Card(i, Card.Suits.Hearts));
                deck.Push(new Card(i, Card.Suits.Clubs));
            }


            Console.WriteLine("Lad os se, hvad der ligger øverst i kortbunken......");
            DrawCard(deck);

            Console.WriteLine(" ");
            Console.WriteLine("Lad os blande kortene......");

            deck.Shuffle();

            Console.WriteLine(" ");
            Console.WriteLine("Lad os så se, hvad der ligger øverst i kortbunken......");
            DrawCard(deck);


            Console.WriteLine(" ");

            char userInput;

            do
            {

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" ");
                Console.Write("Vil du fjerne et kort fra bunken? j/n");
                userInput = Console.ReadKey(true).KeyChar;

                if (userInput == 'j')
                {

                    deck.Pop();
                    Console.WriteLine(" ");
                    Console.WriteLine("Vi har fjernet et kort og lad os så se, hvad der ligger øverst");
                    DrawCard(deck);

                }
                else
                {
                    Environment.Exit(0);
                }


            } while (true);

            Console.ReadKey();
        }



        static void DrawCard(Deck<Card> deck)
        {

            Console.WriteLine(deck.Peek().ToString());

            Console.ForegroundColor = ConsoleColor.White;


            string value = "";



            if ((deck.Peek().Value == 13 )|| (deck.Peek().Value == 12))

                BuildKingOrQueen(deck.Peek());
            else if ((deck.Peek().Value > 1) && (deck.Peek().Value < 10))

            {
                BuildLower(deck.Peek());
            }
            else if (deck.Peek().Value == 1)
                BuildAce(deck.Peek());
            else if (deck.Peek().Value == 11)
                BuildKnight(deck.Peek());

            else if (deck.Peek().Value == 10)
                BuildTen(deck.Peek());


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;


        }


        private static void BuildKnight(Card c)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" _____ ");
            Console.Write("|");


            Console.ForegroundColor = GetColor(c);

                Console.Write("J");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.Write("  ww");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");

            string symbol = GetSymbol(c);

            Console.Write("| ");

            Console.ForegroundColor = GetColor(c);

            Console.Write(symbol);


            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" {)|");
            Console.Write("|");

            Console.ForegroundColor = GetColor(c);

            Console.Write(symbol + " " + symbol);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" %|");
            Console.WriteLine("| | %%|");
            Console.WriteLine("|__%%%|");
        }





        private static void BuildKingOrQueen(Card c)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" _____ ");
            Console.Write("|");


            Console.ForegroundColor = GetColor(c);

            if (c.Value == 13)
                Console.Write("K");
            else
                Console.Write("Q");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (c.Value == 13)
                Console.Write("  WW");
            else
                Console.Write("  ww");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");

            string symbol = GetSymbol(c);

            Console.Write("| ");

            Console.ForegroundColor = GetColor(c);

            Console.Write(symbol);


            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" {)|");
            Console.Write("|");

            Console.ForegroundColor = GetColor(c);

            Console.Write(symbol + " " + symbol);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("%%|");
            Console.WriteLine("| |%%%|");
            Console.WriteLine("|_%%%%|");
        }









        private static void BuildAce(Card c)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" _____ ");

            //2. linie
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);
            Console.Write("A");



            if (c.Suit.Equals(Card.Suits.Hearts))
            {
                Console.Write("_ _ ");

            }
            else if (c.Suit.Equals(Card.Suits.Diamonds))
                Console.Write(" ^  ");
            else if (c.Suit.Equals(Card.Suits.Spades))
                Console.Write(" .  ");
            else if (c.Suit.Equals(Card.Suits.Clubs))
                Console.Write(" _  ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");

            //3. linie
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);



            if (c.Suit.Equals(Card.Suits.Hearts))
            {
                Console.Write("( v )");

            }
            else if (c.Suit.Equals(Card.Suits.Diamonds))
                Console.Write(" / \\ ");
            else if (c.Suit.Equals(Card.Suits.Spades))
                Console.Write(" /.\\ ");
            else if (c.Suit.Equals(Card.Suits.Clubs))
                Console.Write(" ( ) ");



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");




            //4. linie
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);



            if (c.Suit.Equals(Card.Suits.Hearts))
            {
                Console.Write(" \\ / ");

            }
            else if (c.Suit.Equals(Card.Suits.Diamonds))
                Console.Write(" \\ / ");
            else if (c.Suit.Equals(Card.Suits.Spades))
                Console.Write("(_._)");
            else if (c.Suit.Equals(Card.Suits.Clubs))
                Console.Write("|(_'_)");



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");

            //5. linie
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);



            if (c.Suit.Equals(Card.Suits.Hearts))
            {
                Console.Write("  .  ");

            }
            else if (c.Suit.Equals(Card.Suits.Diamonds))
                Console.Write("  .  ");
            else if (c.Suit.Equals(Card.Suits.Spades))
                Console.Write("  |  ");
            else if (c.Suit.Equals(Card.Suits.Clubs))
                Console.Write("  |  ");



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");


            Console.WriteLine("|_____|");



        }

        private static void BuildTen(Card c)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" _____ ");
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);
            Console.Write(c.Value);
            
            string s = GetSymbol(c);
            Console.Write(" "+s);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |");


            Console.Write("|");
            Console.ForegroundColor = GetColor(c);
            Console.Write(s + " " + s + " " + s);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);
            Console.Write(s + " " + s + " " + s);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);
            Console.Write(s + " " + s + " " + s);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|_____|");




        }


        /**Bygger kort 2-9*/
        private static void BuildLower(Card c)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" _____ ");
            Console.Write("|");
            Console.ForegroundColor = GetColor(c);
            Console.Write(c.Value);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    |");
            string s = GetSymbol(c);


            if (c.Value == 8 || c.Value == 9)
            {
                Console.Write("|");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s + " " + s + " " + s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|");

            }

            else if (c.Value >= 3 && c.Value <= 7)
            {


                Console.Write("| ");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s + " " + s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" |");


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|  ");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  |");
            }



            //Næste linie

            if (c.Value >= 2 && c.Value <= 4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|     |");
            }
            else if (c.Value == 6 || c.Value == 8)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("| ");

                Console.ForegroundColor = GetColor(c);
                Console.Write(s + " " + s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" |");
            }
            else if (c.Value == 5)
            {

                Console.Write("|  ");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  |");

            }
            else if (c.Value == 7 || c.Value == 9)
            {

                Console.Write("|");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s + " " + s + " " + s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|");
            }



            //Ny linie



            if (c.Value >= 4 && c.Value <= 7)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("| ");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s + " " + s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" |");


            }
            else if (c.Value == 8 || c.Value == 9)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s + " " + s + " " + s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|");
            }
            else if (c.Value == 2 || c.Value == 3)
            {

                Console.Write("|  ");
                Console.ForegroundColor = GetColor(c);
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  |");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|_____|");




        }


        private static ConsoleColor GetColor(Card c)
        {

            if (c.Suit.Equals(Card.Suits.Diamonds) || c.Suit.Equals(Card.Suits.Hearts))
            {
                return ConsoleColor.Red;
            }
            else
                return ConsoleColor.White;
        }

        private static string GetSymbol(Card c)
        {
            string symbol;
            if (c.Suit.Equals(Card.Suits.Spades))
                symbol = "^";
            else if (c.Suit.Equals(Card.Suits.Hearts))
                symbol = "v";
            else if (c.Suit.Equals(Card.Suits.Clubs))
                symbol = "&";

            else symbol = "o";

            return symbol;
        }
    }
}
