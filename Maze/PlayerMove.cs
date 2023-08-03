using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class PlayerMove
    {
        bool up = true;
        bool down = true;
        bool right = true;
        bool left = true;
        public bool win = false;
        public int x;
        public int y;

        public int health = 3;

        public int stage = 1;
        public int diag = 10;
        public int horiz = 20;
        public int count = 1;
        Room room = new Room();


        public void Move(int y, int x)
        {
            
            Console.Title = "Random Dungeon Maze" + " " + $"(Stage:{stage}" + " " + $"Health:  {health})";
            int countEnemy = 35;
            
            room.CreateRoom(diag, horiz, count, countEnemy);
            string[,] wall = room.wall;
            this.x = x;
            this.y = y;
            int xpr, ypr;

            xpr = x;
            ypr = y;
            Console.SetCursorPosition(xpr, ypr);
            Console.Write(" ");
            Console.SetCursorPosition(x, y);
            Console.Write("*");

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow: if (up) y--; break;
                    case ConsoleKey.DownArrow: if (down) y++; break;
                    case ConsoleKey.LeftArrow: if (left) x--; break;
                    case ConsoleKey.RightArrow: if (right) x++; break;
                    case ConsoleKey.Escape: return;
                    default: break;
                }

                up = true; left = true; right = true; down = true;

                if (x > 215) right = false;
                if (x < 1) left = false;
                if (y < 1) up = false;
                if (y > 200) down = false;
                try
                {
                    if (wall[y, x] == "O")
                    {
                        wall[y, x] = " ";
                        if (health == 1)
                        {

                            Console.Clear();
                            Console.Write(@"













                           _______  _______  _______  _______    _______           _______  _______
                          (  ____ \(  ___  )(       )(  ____ \  (  ___  )|\     /|(  ____ \(  ____ )
                          | (    \/| (   ) || () () || (    \/  | (   ) || )   ( || (    \/| (    )|
                          | |      | (___) || || || || (__      | |   | || |   | || (__    | (____)|
                          | | ____ |  ___  || |(_)| ||  __)     | |   | |( (   ) )|  __)   |     __)
                          | | \_  )| (   ) || |   | || (        | |   | | \ \_/ / | (      | (\ (   
                          | (___) || )   ( || )   ( || (____/\  | (___) |  \   /  | (____/\| ) \ \__
                          (_______)|/     \||/     \|(_______/  (_______)   \_/   (_______/|/   \__/");

                            Thread.Sleep(2000);
                        Console.SetCursorPosition(xpr, ypr);
                            Console.Write(" ");
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ");
                            health--;
                            up = false;
                            down = false;
                            right = false;
                            left = false;
                            return;
                            
                            
                        }
                        else
                        {
                            health--;
                            Console.Beep();
                        }

                        Console.Title = "Random Dungeon Maze" + " " + $"(Stage:{stage}" + " " + $"Health:  {health})";

                    }
                }
                catch { }
               

               

                try
                { 
                    if (wall[y, x] == "#") 
                    { 
                        wall[y, x] = "#"; x = xpr; y = ypr; 
                    }
                    else if (wall[y, x] != "#")
                    {
                        Console.SetCursorPosition(xpr, ypr);
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        xpr = x;
                        ypr = y;
                        this.x = x;
                        this.y = y;
                    }
                    else
                    {
                        Console.SetCursorPosition(xpr, ypr);
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        xpr = x;
                        ypr = y;
                        this.x = x;
                        this.y = y;
                    }

                    
                }
                catch
                {
                }
                try 
                {   
                    if(ypr == room.rows /2 && xpr == room.columns-1) 
                    {
                        
                        Console.SetCursorPosition(xpr, ypr);
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        xpr = x;
                        ypr = y;
                        Console.SetCursorPosition(0, 0);
                        horiz = horiz + 20;
                        countEnemy += 35;
                        room.CreateRoom(diag, horiz, count, countEnemy);
                        count++;

                        wall = room.wall;

                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        this.x = x;
                        this.y = y;

                    }
                    
                } 
                catch 
                {
                    Console.SetCursorPosition(xpr, ypr);
                    Console.Write(" ");
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    xpr = x;
                    ypr = y;
                    this.x = x;
                    this.y = y;

                }
                try
                {
                    if (wall[y, x - 1] == "#" && wall[y, x + 1] == "#")
                    {

                        if (stage == 5)
                        {
                            Console.Clear();
                            Console.WriteLine(@"          _______                     _________ _        _ 
|\     /|(  ___  )|\     /|  |\     /|\__   __/( (    /|( )
( \   / )| (   ) || )   ( |  | )   ( |   ) (   |  \  ( || |
 \ (_) / | |   | || |   | |  | | _ | |   | |   |   \ | || |
  \   /  | |   | || |   | |  | |( )| |   | |   | (\ \) || |
   ) (   | |   | || |   | |  | || || |   | |   | | \   |(_)
   | |   | (___) || (___) |  | () () |___) (___| )  \  | _ 
   \_/   (_______)(_______)  (_______)\_______/|/    )_)(_)");
                            win = true;
                            return;
                        }
                        else
                        {
                            health += 3;
                            stage++;
                            Console.Title = "Random Dungeon Maze" + " " + $"(Stage:{stage}" + " " + $"Health:  {health})";
                            Console.Clear();
                            count = 1;
                            switch (stage)
                            {
                                case 2: countEnemy = 35; break;
                                case 3: countEnemy = 40; break;
                                case 4: countEnemy = 50; break;
                                case 5: countEnemy = 70; break;
                            }
                            horiz = 20;
                            Console.SetCursorPosition(0, 0);
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            room.CreateRoom(diag, horiz, count, countEnemy);
                            x = room.columns / 2;
                            y = room.rows / 2;
                            wall = room.wall;

                            Console.SetCursorPosition(xpr, ypr);
                            Console.Write(" ");
                            Console.SetCursorPosition(x, y);
                            Console.Write("*");
                            xpr = x;
                            ypr = y;
                            this.x = x;
                            this.y = y;
                        }
                    }

                }
                catch
                {
                    Console.SetCursorPosition(xpr, ypr);
                    Console.Write(" ");
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    xpr = x;
                    ypr = y;
                    this.x = x;
                    this.y = y;
                    
                }
                if (wall[y,x] == "K")
                {
                    room.wall[room.rows - 1, room.columns - 10] = " ";
                    Console.SetCursorPosition(room.columns-10, room.rows-1);
                    Console.Write(" ");
                }
                if (wall[y, x] == "H")
                {
                    wall[y, x] = " ";
                    health++;
                    Console.Title = "Random Dungeon Maze" + " " + $"(Stage:{stage}" + " " + $"Health:  {health})";
                }





            }
        }
    }
}
    

