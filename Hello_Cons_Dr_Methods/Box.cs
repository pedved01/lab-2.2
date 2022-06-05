using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {


        //1.  Implement public  auto-implement properties for start position (point position)
        public int x { get; set; }
        public int y { get; set; }

        //auto-implement properties for width and height of the box

        public int width { get; set; }
        public int height { get; set; }
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        public char symbol { get; set; }
        //and a message inside the box
        public string messege_input { get; set; }
        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message
        public Box(int x, int y, int width, int height, char symbol, string messege_input)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.symbol = symbol;
            this.messege_input = messege_input;
        }
        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary
        public void draw()
        {

            int initial_x = x;
            int initial_y = y;
            int width = Math.Max(this.width, messege_input.Length);
         
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < height; j++)
                {

                    Console.Write(symbol);
                }
                y++;
            }
            y = initial_y + 1;
            x = initial_x + 1;
            for (int i = 0; i < width - 2; i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < height - 2; j++)
                {

                    Console.Write(" ");
                }
                y++;
            }
            y = initial_y ;
            x = initial_x ;
            int srt_y = y + height / 2 - 1;
            int str_x = x + ((width - messege_input.Length) / 2);
            Console.SetCursorPosition(str_x, srt_y);
            Console.WriteLine(messege_input);

        }
    }
}