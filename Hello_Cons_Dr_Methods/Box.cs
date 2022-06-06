using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public char symbol { get; set; }
        public string messege_input { get; set; }
        public Box(int x, int y, int width, int height, char symbol, string messege_input)
        { 
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
            this.messege_input = messege_input;
        }
        public void draw()
        {
            int initial_x = x;
            int initial_y = y;
            int width = Math.Max(this.width, messege_input.Length);
            int srting_x = x + ((width - messege_input.Length) / 2) + 1;
            int srting_y = y + (height / 2);

            for (int i = 0; i <= width; i++)
            {
                
                Console.SetCursorPosition(x,y);
                Console.Write(symbol);
                Console.SetCursorPosition(x, y + height);
                Console.Write(symbol);
                x++;
            }
            x = initial_x;
            y = initial_y;
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine(symbol);
                Console.SetCursorPosition(x + width, y);
                Console.WriteLine(symbol);
                y++;
            }
            Console.WriteLine();
            Console.SetCursorPosition(srting_x, srting_y);
            Console.WriteLine(messege_input);
            Console.WriteLine();
        }
    }
}