using MarsRover.BusinessEntities;
using MarsRover.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsRoverBusinessLogic marsRoverLogic = new();
            RoverModel start = new();

            //Initialize rover direction and position and execute first 5 commands
            start = marsRoverLogic.ExecuteCommands(true,0,"South",0,0);

            //Below loop will execute till rover is not instructed to cross the perimeter of exploration area
            while(start.Next)
            {
               start = marsRoverLogic.ExecuteCommands(start.Next, start.Position,start.Direction,start.vDist,start.hDist);
            }

            Console.ReadLine();
        }

    }
}
