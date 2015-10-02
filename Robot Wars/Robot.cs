using System;

namespace RobotWars
{
    public class Robot
    {
        private int currentPositionX = 0;
        private int currentPositionY = 0;
        private string currentOrientation = "N";

        private int originX = 0;
        private int originY = 0;

        private int battlefieldWidth = 1;
        private int battlefieldHeight = 1;

        private int robotWidth = 0;
        private int robotHeight = 0;

        //  Look up table for cardinal directions in counter clockwise direction
        private string[] cardinalDirection = { "N", "W", "S", "E" };

        public Robot() { }

        //  Load the battlefield size
        public Robot(int positionX, int positionY, string orientation, int origin_x, int origin_y, int width, int height)
        {
            currentPositionX = positionX;
            currentPositionY = positionY;
            currentOrientation = orientation;
            originX = origin_x;
            originY = origin_y;
            battlefieldWidth = width;
            battlefieldHeight = height;
        }

        public int getPositionX()
        {
            return currentPositionX;
        }

        public int getPositionY()
        {
            return currentPositionY;
        }

        public string getOrientation()
        {
            return currentOrientation;
        }

        public int getRobotWidth()
        {
            return robotWidth;
        }

        public int getRobotHeight()
        {
            return robotHeight;
        }

        public void setRobotDimensions(int width, int height)
        {
            robotWidth = width;
            robotHeight = height;
        }

        public string calculatePlannedPosition(string movement)
        {
            string plannedPosition = currentPositionX.ToString() + " " + currentPositionY.ToString() + " " + currentOrientation;

            foreach (char c in movement)
            {
                switch (c)
                {
                    case ('L'):
                        {
                            //  Rotate 90 degrees counter clockwise
                            int index = Array.FindIndex(cardinalDirection, row => row == currentOrientation);

                            //  Move up the array for counter clockwise
                            //  If we hit the last element of the array then reset to first element
                            currentOrientation = (index < cardinalDirection.Length - 1) ? cardinalDirection[index + 1] : cardinalDirection[0];
                        }
                        break;
                    case ('R'):
                        {
                            //  Rotate 90 degrees clockwise
                            int index = Array.FindIndex(cardinalDirection, row => row == currentOrientation);

                            //  Move down the array for clockwise
                            //  If we hit the first element of the array then reset to last element
                            currentOrientation = (index > 0) ? cardinalDirection[index - 1] : cardinalDirection[3];
                        }
                        break;
                    case ('M'):
                        {
                            //  Move up by 1 unit in y axis within grid boundaries
                            if ((currentOrientation == "N") && (currentPositionY < battlefieldHeight))
                            {
                                currentPositionY++;
                            }
                            //  Move left by 1 unit in x axis within grid boundaries
                            if ((currentOrientation == "W") && (currentPositionX > originX))
                            {
                                currentPositionX--;
                            }

                            //  Move down by 1 unit in y axis within grid boundaries
                            if ((currentOrientation == "S") && (currentPositionY > originY))
                            {
                                currentPositionY--;
                            }

                            //  Move right by 1 unit in x axis within grid boundaries
                            if ((currentOrientation == "E") && (currentPositionX < battlefieldWidth))
                            {
                                currentPositionX++;
                            }
                        }
                        break;
                }
            }

            //  Format string for output of new (x,y) coordinates and orientation
            plannedPosition = currentPositionX + " " + currentPositionY + " " + currentOrientation;

            return plannedPosition;
        }

    }
}
