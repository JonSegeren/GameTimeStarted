﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace GameTimeStarted
{
    class Sprite
    {
        public int x, y;
        int sizeX, sizeY;
       
        public Rectangle rect; 
        public Sprite(int _x,int _y, int _size)
        {
            x = _x;
            y = _y;
           
            sizeX = _size;
            sizeY = _size;
            rect= new Rectangle(x, y, sizeX, sizeY);
        }
        public Sprite(int _x, int _y, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            sizeX = _sizeX;
            sizeY = _sizeY;
            rect = new Rectangle(x, y, sizeX, sizeY);

        }
        public void Jump(int jHeight)
        {
          rect.Y -= 2 * jHeight;
  
        }
        public void slide(int speed)
        {
            rect.X -= speed;
           
        }
    
        public Boolean collision(Sprite mobster)
        {
            return mobster.rect.IntersectsWith(rect);

        }

    }
}
