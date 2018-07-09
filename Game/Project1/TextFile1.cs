using System;
namespace Game
{
    class A
    {
        static string[] Name()
        {
            string[] name = new string[2];
            Console.Write("Enter Name Player 1 : ");
            name[0] = Console.ReadLine();
            Console.Write("Enter Name Player 2 : ");
            name[1] = Console.ReadLine();

            return name;
        }
        static int Position(int Trun, string[] PlayerName , char [,] table)
        {
            int Position;
            int P = 0;
            Console.WriteLine("Player {0} : {1}", Trun + 1, PlayerName[Trun]);

            Console.Write("Select Position [1-9] : ");
            Position = int.Parse(Console.ReadLine());

            return Position;
        }
        static void show()
        {
            Console.WriteLine(" {0} |  {1}  |  {2}", 1, 2, 3);
            Console.WriteLine("______________");
            Console.WriteLine();
            Console.WriteLine(" {0} |  {1}  |  {2}", 4, 5, 6);
            Console.WriteLine("______________");
            Console.WriteLine();
            Console.WriteLine(" {0} |  {1}  |  {2}", 7, 8, 9);
        }
        static char[,] show1(int Trun, string xo, int P, char[,] table)
        {

            if (Trun == 0)
            {
                if (P == 1 && table[0, 0] == ' ') table[0, 0] = 'X';
                if (P == 2 && table[0, 1] == ' ') table[0, 1] = 'X';
                if (P == 3 && table[0, 2] == ' ') table[0, 2] = 'X';
                if (P == 4 && table[1, 0] == ' ') table[1, 0] = 'X';
                if (P == 5 && table[1, 1] == ' ') table[1, 1] = 'X';
                if (P == 6 && table[1, 2] == ' ') table[1, 2] = 'X';
                if (P == 7 && table[2, 0] == ' ') table[2, 0] = 'X';
                if (P == 8 && table[2, 1] == ' ') table[2, 1] = 'X';
                if (P == 9 && table[2, 2] == ' ') table[2, 2] = 'X';
            }
            if (Trun == 1)
            {
                if (P == 1 && table[0, 0] == ' ') table[0, 0] = 'O';
                if (P == 2 && table[0, 1] == ' ') table[0, 1] = 'O';
                if (P == 3 && table[0, 2] == ' ') table[0, 2] = 'O';
                if (P == 4 && table[1, 0] == ' ') table[1, 0] = 'O';
                if (P == 5 && table[1, 1] == ' ') table[1, 1] = 'O';
                if (P == 6 && table[1, 2] == ' ') table[1, 2] = 'O';
                if (P == 7 && table[2, 0] == ' ') table[2, 0] = 'O';
                if (P == 8 && table[2, 1] == ' ') table[2, 1] = 'O';
                if (P == 9 && table[2, 2] == ' ') table[2, 2] = 'O';
            }


            Console.WriteLine(" {0} |  {1}  |  {2}", table[0, 0], table[0, 1], table[0, 2]);
            Console.WriteLine("______________");
            Console.WriteLine();
            Console.WriteLine(" {0} |  {1}  |  {2}", table[1, 0], table[1, 1], table[1, 2]);
            Console.WriteLine("______________");
            Console.WriteLine();
            Console.WriteLine(" {0} |  {1}  |  {2}", table[2, 0], table[2, 1], table[2, 2]);


            return table;
        }
        static int Check(char[,] table, int status)
        {
            if (table[0, 0] == 'O' && table[0, 1] == 'O' && table[0, 2] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[1, 0] == 'O' && table[1, 1] == 'O' && table[1, 2] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[2, 0] == 'O' && table[2, 1] == 'O' && table[2, 2] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 0] == 'O' && table[1, 0] == 'O' && table[2, 0] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 1] == 'O' && table[1, 1] == 'O' && table[2, 1] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 2] == 'O' && table[1, 2] == 'O' && table[2, 2] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 0] == 'O' && table[1, 1] == 'O' && table[2, 2] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 2] == 'O' && table[1, 1] == 'O' && table[2, 0] == 'O') { Console.WriteLine("Player 1 : Win !!"); status = 2; }

            if (table[0, 0] == 'X' && table[0, 1] == 'X' && table[0, 2] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[1, 0] == 'X' && table[1, 1] == 'X' && table[1, 2] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[2, 0] == 'X' && table[2, 1] == 'X' && table[2, 2] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 0] == 'X' && table[1, 0] == 'X' && table[2, 0] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 1] == 'X' && table[1, 1] == 'X' && table[2, 1] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 2] == 'X' && table[1, 2] == 'X' && table[2, 2] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 0] == 'X' && table[1, 1] == 'X' && table[2, 2] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }
            if (table[0, 2] == 'X' && table[1, 1] == 'X' && table[2, 0] == 'X') { Console.WriteLine("Player 1 : Win !!"); status = 2; }

            return status;
        }
        static int trun()
        {
            Random random = new Random();
            int RandomNumber = 0;

            RandomNumber = random.Next(0, 2);

            return RandomNumber;
        }

        static string xo(ref int Trun)
        {
            string XO = " ";


            if (Trun == 0)
            {
                XO = "X";
                Trun = 1;
            }
            else if (Trun == 1)
            {
                XO = "O";
                Trun = 0;
            }

            return XO;
        }

        static char[,] table1()
        {
            char[,] table = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

            return table;
        }
        static void Main()
        {
            char key;
            do
            {
                string XO = " ";
                int P = 0;
                int Trun;
                char[,] table = table1();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Game XO !! ^^ ");
                Console.WriteLine();
                show();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                string[] PlayerName = Name();
                Trun = trun();
                Console.WriteLine();
                Console.WriteLine("Player {0} : Play First", Trun + 1);
                Console.ReadKey();
                Console.Clear();

                int status = 1; int check;
                do
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Game XO !! ^^ ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    show1(Trun, XO, P, table);
                    Console.WriteLine();

                    check = Check(table, status);
                    if (check == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        P = Position(Trun, PlayerName,table);
                        XO = xo(ref Trun);
                    }


                } while (check == 1);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Play Again ?? [Y/N] : ");
                key = char.Parse(Console.ReadLine());
            } while (key == 'Y' || key == 'y');

        }
    }
}