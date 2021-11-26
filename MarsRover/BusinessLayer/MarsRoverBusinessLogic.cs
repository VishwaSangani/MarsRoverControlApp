using MarsRover.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MarsRover.BusinessLayer
{
    public class MarsRoverBusinessLogic
    {
        public RoverModel ExecuteCommands(bool next, int position, string direction, int vDist, int hDist)
        {
            RoverModel res = new();
            List<string> commands = new();
            bool onhold = false;

            //take next set of commands
            for (int i = 0; i < 5; i++)
                commands.Add(Console.ReadLine());

            foreach (var c in commands)
            {
                int result = 0;
                bool success = int.TryParse(Regex.Match(c, @"\d+").Value, out result);

                if (success)
                {
                    //Keep record of distance traversed by rover
                    switch (direction)
                    {
                        case "South":
                            vDist += result;
                            break;
                        case "East":
                            hDist += result;
                            break;
                        case "North":
                            vDist -= result;
                            break;
                        case "West":
                            hDist -= result;
                            break;
                    }

                    //if rover tries to cross perimeter, it will halt
                    if (0 > vDist || vDist > 100 || 0 > hDist || hDist > 100)
                    {
                        onhold = true;
                        break;
                    }

                }
                else
                {
                    //change direction of rover
                    if (c.ToLower() == "move forward")
                    {
                        continue;
                    }
                    else if (c.ToLower() == "left")
                    {
                        switch (direction)
                        {
                            case "South":
                                direction = "East"; break;
                            case "East":
                                direction = "North"; break;
                            case "North":
                                direction = "West"; break;
                            case "West":
                                direction = "South"; break;
                            default: break;
                        }
                    }
                    else if (c.ToLower() == "right")
                    {
                        switch (direction)
                        {
                            case "South":
                                direction = "West"; break;
                            case "West":
                                direction = "North"; break;
                            case "North":
                                direction = "East"; break;
                            case "East":
                                direction = "South"; break;
                            default: break;
                        }
                    }
                }

            }

            if (!onhold)
            {
                //code to calculate final rover position
                position = vDist * 100 + hDist;
                Console.WriteLine(position + " " + direction);

                res.Next = true;
                res.hDist = hDist;
                res.vDist = vDist;
                res.Position = position;
                res.Direction = direction;
                return res;
            }
            else
            {
                Console.WriteLine("Rover halt!!");
                res.Next = false;
                return res;
            }
        }
    }
}
