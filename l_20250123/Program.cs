using System.Numerics;

namespace l_20250123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array
            int[,] map =
                {
                    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1} };

            char wall = '*';
            char floor = ' ';
            int playerX = 1;
            int playerY = 1;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();

                if(keyInfo.Key == ConsoleKey.W)
                {
                    playerY--;
                }
                else if(keyInfo.Key == ConsoleKey.S)
                {
                    playerY++;
                }
                else if(keyInfo.Key == ConsoleKey.A)
                {
                    playerX--;
                }
                else if(keyInfo.Key == ConsoleKey.D)
                {
                    playerX++;
                }

                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (x == playerX && y == playerY)
                        {
                            Console.Write('P');
                        }
                        else if (map[y, x] == 1)
                        {
                            Console.Write(wall);
                        }
                        else if (map[y, x] == 0)
                        {
                            Console.Write(floor);
                        }
                    }
                    Console.WriteLine();


                }
            }
            

            


            #region 필기
            //// ==, >, <, <=, >=, !=
            //condition = 1 == 2;

            ////for(int i = 0; ;)
            ////{

            ////}


            #endregion


        }
    }
}

//Ctrl + y (되돌리기. Ctrl + z의 반대)
//Ctrl + k + d (정렬)
//Ctrl + k + c (주석처리)
//Ctrl + k + u (주석해제)
//Ctrl + / (주석처리/해제)

//&& and    || or   ! not
