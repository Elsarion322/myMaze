using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    
    public class Maze
    {
        
        PlayerMove player = new PlayerMove();
        
        public  void StartGame()
        {           
            while (true)
            {
                if(player.win)
                {
                    break;
                }
                Console.Clear();
                player.diag = 10;
                player.horiz = 20;
                player.count = 1;
                player.health = 3;
                player.stage = 1;
                player.Move(player.diag / 2, player.horiz / 2);
            }
            

        }
        
        

    }
}
