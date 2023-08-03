using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
       public class Room
    {
        public int x;
        public int y;
        public string[,] wall;
        public int rows;
        public int columns;
        
        


        public  void CreateRoom (int x,int y, int count, int countE)
        {
            
            Random r = new Random();
            int countEnemy = 0;
            int keyCount = 0;
            int healthCount = 0;
            this.x = x;
            this.y = y;
            wall = new string[x, y];
            rows = wall.GetUpperBound(0) + 1;    
            columns = wall.Length / rows;
            
            

            for ( int i = 0; i< rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j % 20 == 0)
                    {
                        wall[i, j] = "#";
                        wall[rows / 2, j] = " ";
                    }
                    if (i % 10 == 0)
                    {
                        wall[i, j] = "#";
                    }

                    if (wall[i, j] != wall[i, 0] && wall[i, j] != wall[0, j] && wall[i, j] != wall[i, columns - 1] && wall[i, j] != wall[rows - 1, j])
                    {
                        if (wall[i, j] != "#" && wall[i, j] != " " && wall[i, j] != "O" && wall[i, j] != "K" && wall[i, j] != "H")
                            wall[i, j] = " ";
                        if (healthCount < 2)
                        {
                            while (true)
                            {
                                int rY = r.Next(1, y - 2);
                                int rX = r.Next(1, x - 1);
                                if (wall[rX, rY] != "#" && wall[rX, rY] != " " && wall[rX, rY] != "O" && wall[rX, rY] != "H" && wall[rX,rY] != "K")
                                {
                                    wall[rX, rY] = "H";
                                    healthCount++;
                                    break;
                                }
                                    
                                
                            }
                            

                        }
                        if (count == 5)
                        {
                        if (keyCount < 1)
                        {
                            while (true)
                            {
                                int rY = r.Next(1, y - 2);
                                int rX = r.Next(1, x - 1);
                                    if (wall[rX, rY] != "#" && wall[rX, rY] != " " && wall[rX, rY] != "O" && wall[rX,rY] != "H")
                                    {
                                        wall[rX, rY] = "K";
                                        keyCount++;
                                        break;
                                    }
                                    else
                                    { 
                                        wall[i, j] = "K";
                                        keyCount++;
                                        break;
                                    }
                                
                            }

                            }
                        }
                        if (countEnemy < countE)
                        {   
                        while (true)                           
                            {
                                int rY = r.Next(1, y - 2);
                                int rX = r.Next(1, x - 1);
                                if (wall[rX, rY] != "#" && wall[rX, rY] != " " && wall[rX, rY] != "O" && wall[rX, rY] != "K" && wall[rX, rY] != "H")
                                {
                                    wall[rX, rY] = "O";
                                    countEnemy++;
                                    break;
                                }
                                else if (wall[rX, rY] == " " && wall[rX, rY] == "0" && wall[rX, rY] == "#" && wall[rX,rY] == "K" && wall[rX, rY] != "H")
                                {
                                    wall[i, j] = "0";
                                    countEnemy++;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (x == 10)
                        {
                            
                            wall[i, 0] = "#";
                            wall[0, j] = "#";
                            wall[i, columns - 1] = "#";
                            wall[rows / 2, 0] = "#";
                            wall[rows - 1, j] = "#";
                            wall[rows / 2, columns - 1] = " ";
                        }
                        
                        else 
                        {
                            wall[i, 0] = "#";
                            wall[0, j] = "#";
                            wall[i, columns - 1] = "#";
                            wall[rows - 1, j] = "#";
                            wall[rows / 2, 0] = "#";

                            wall[rows / 2, columns - 1] = " ";
                        }
                        if (count == 5)
                        {
                            
                            wall[i, 0] = "#";
                            wall[0, j] = "#";
                            wall[i, columns - 1] = "#";
                            wall[rows - 1, j] = "#";
                            wall[rows / 2, columns-1] = "#";
                            wall[rows / 2, 0] = "#";
                            
                        }
                    }
                    
                    Console.Write(wall[i,j]);
                }   
                Console.WriteLine();          
            }
        }    
    }
}
