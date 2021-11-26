# Mars Rover Movement Control Application
You have been told that your exploration area on Mars is a 100 metres x 100 metres square. The area has been divided into a 100 x 100 grid of numbered squares. The squares are numbered from 1 through to 10,000 (please see diagram 1 below).

The rover starts its journey located in square number 1, it is facing south and can either turn left, right or move forward a given number of metres. The rover can take a maximum of 5 commands at any time. After each set of commands, the rover reports back its current position and the direction that it is facing.

For example, here is a set of 5 commands:
50m
Left
23m
Left
4m

The above set of commands would cause the rover to report back position 4,624 north.

The next set of commands would then continue from the square where the rover finished. Please note that the rover cannot venture outside of the 100 x 100 area. If the rover is instructed to cross the perimeter of the exploration area, it will halt and refuse to execute any additional queued commands.