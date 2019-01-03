using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);

        // game loop
        while (true)
        {
            Direction bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

            switch (bombDir)
            {
                case Up:
                break;
                case UpRight:
                break;
                case Right:
                break;
                case DownRight:
                break;
                case Down:
                break;
                case DownLeft:
                break;
                case Left:
                break;
                case UpLeft:
                break;
                default:
                break;
            }


            // the location of the next window Batman should jump to.
            Console.WriteLine("0 0");
        }
    }
}
enum Direction
{
    Up = "U",
    UpRight = "UR",
    Right = "R",
    DownRight = "DR",
    Down = "D",
    DownLeft = "DL",
    Left = "L",
    UpLeft = "UL"
}