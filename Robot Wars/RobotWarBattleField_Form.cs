using System;
using System.Drawing;
using System.Windows.Forms;

namespace RobotWars
{
    public partial class RobotWarBattleField_Form : Form
    {
        private Grid thisGrid = new Grid();
        private Robot robot_1 = new Robot();
        private Robot robot_2 = new Robot();

        private int R1_score = 0;
        private int R2_score = 0;
        private int MaxScore = 5;

        private int gridStartLocationX = 40;        //  horizontal margin
        private int gridStartLocationY = 40;        //  Vertical margin
        private int gridCellSizeHorizontal = 10;    //  Default horizontal cell size
        private int gridCellSizeVertical = 10;      //  Default vertical cell size

        Bitmap robot_1_bitmap = new Bitmap(Robot_Wars.Properties.Resources.robot_1);
        Bitmap robot_2_bitmap = new Bitmap(Robot_Wars.Properties.Resources.robot_2);

        private int originX = 0;
        private int originY = 0;

        public Grid gridProperty
        {
            get { return thisGrid; }
            set { thisGrid = value; }
        }

        public Robot robot_1_property
        {
            get { return robot_1; }
            set { robot_1 = value; }
        }

        public Robot robot_2_property
        {
            get { return robot_2; }
            set { robot_2 = value; }
        }

        public RobotWarBattleField_Form()
        {
            InitializeComponent();
        }

        private void RobotWarBattleField_Form_Load(object sender, EventArgs e)
        {
            //  Set the grid size of battlefield based on number of grids in both x and y directions
            gridCellSizeHorizontal = ((battleground_panel.Size.Width - 2 * gridStartLocationX) / gridProperty.HorizontalCells);
            gridCellSizeVertical = ((battleground_panel.Size.Height - 2 * gridStartLocationY) / gridProperty.VerticalCells);

            //  Set the grid parameters
            thisGrid.Origin = new Point(gridStartLocationX, gridStartLocationY);
            thisGrid.GridCellSize = new Size(gridCellSizeHorizontal, gridCellSizeVertical);
            thisGrid.HorizontalCells = gridProperty.HorizontalCells;
            thisGrid.VerticalCells = gridProperty.VerticalCells;

            //  Load robot parameters from previous form
            robot_1 = robot_1_property;
            robot_2 = robot_2_property;

            //  Load and position the robots on the battlefield
            R1_pbox.Image = robot_1_bitmap;
            R1_pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            robot_1.setRobotDimensions(R1_pbox.Size.Width,R1_pbox.Size.Height);
            LoadDisplay(R1_pbox, robot_1_bitmap, robot_1);

            R2_pbox.Image = robot_2_bitmap;
            R2_pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            robot_2.setRobotDimensions(R2_pbox.Size.Width, R2_pbox.Size.Height);
            LoadDisplay(R2_pbox, robot_2_bitmap, robot_2);

            //  Load robots starting position
            R1_newPosition_lbl.Text = "Position: " + robot_1.getPositionX() + " " + robot_1_property.getPositionY() + " " + robot_1.getOrientation();
            R2_newPosition_lbl.Text = "Position: " + robot_2.getPositionX() + " " + robot_2_property.getPositionY() + " " + robot_2.getOrientation();

            if ((robot_1.getPositionX() == robot_2.getPositionX()) && (robot_1.getPositionY() == robot_2.getPositionY()))
            {
                Output_battlePage_textbox.AppendText("First move does not count..." + Environment.NewLine + Environment.NewLine);
            }
        }

        private void battleground_panel_Paint(object sender, PaintEventArgs e)
        {
            // Make some fancy pen, make ANY pen you like here
            Pen myPen = new Pen(Color.Cyan, 2f);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            myPen.DashCap = System.Drawing.Drawing2D.DashCap.Triangle;
            thisGrid.Draw(e.Graphics, myPen);
        }

        private void RobotWarBattleField_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void R1_Go_btn_Click(object sender, EventArgs e)
        {
            R1_plannedMove_textbox.Enabled = false;
            R1_Go_btn.Enabled = false;
            R2_plannedMove_textbox.Enabled = true;
            R2_Go_btn.Enabled = true;

            //  "Position: " has 10 chars so capture the remaining string after that
            string currentPosition = R1_newPosition_lbl.Text.Substring(10);

            //  Update robot 1 image position on the battlefield based on user command
            UpdateDisplay(R1_pbox, robot_1_bitmap, robot_1.getPositionX(), robot_1.getPositionY(), robot_1.getOrientation(), R1_plannedMove_textbox.Text);

            string newPosition = robot_1.calculatePlannedPosition(R1_plannedMove_textbox.Text);

            R1_newPosition_lbl.Text = "Position: " + newPosition;
            
            //  Log results in Output window
            Output_battlePage_textbox.AppendText("******* Robot 1 *******" + Environment.NewLine +
                "Initial Position: " + currentPosition + Environment.NewLine +
                "Planned Path: " + R1_plannedMove_textbox.Text + Environment.NewLine +
                "New Position: " + newPosition + Environment.NewLine + Environment.NewLine);

            //  Clear the planned move textbox for the next move
            R1_plannedMove_textbox.Text = string.Empty;

            if ((robot_1.getPositionX() == robot_2.getPositionX()) && (robot_1.getPositionY() == robot_2.getPositionY()))
            {
                //  Robot 1 scores a point!
                R1_pbox.BringToFront();
                R1_score++;

                Output_battlePage_textbox.AppendText("Robot 2 has been crushed by Robot 1! Ouch!!!" + 
                    Environment.NewLine + Environment.NewLine);

                robot_1_score_lbl.Text = R1_score.ToString();

                if(R1_score == MaxScore)
                {
                    robot1_name_lbl.Text = "Robot 1 Wins!!!";
                    R1_Go_btn.Enabled = false;
                    R1_plannedMove_textbox.Enabled = false;
                    R2_Go_btn.Enabled = false;
                }
            }
        }

        private void R2_Go_btn_Click(object sender, EventArgs e)
        {
            R1_plannedMove_textbox.Enabled = true;
            R1_Go_btn.Enabled = true;
            R2_plannedMove_textbox.Enabled = false;
            R2_Go_btn.Enabled = false;

            //  "Position: " has 10 chars so capture the remaining string after that
            string currentPosition = R2_newPosition_lbl.Text.Substring(10);

            //  Update robot 1 image position on the battlefield based on user command
            UpdateDisplay(R2_pbox, robot_2_bitmap, robot_2.getPositionX(), robot_2.getPositionY(), robot_2.getOrientation(), R2_plannedMove_textbox.Text);

            string newPosition = robot_2.calculatePlannedPosition(R2_plannedMove_textbox.Text);
            R2_newPosition_lbl.Text = "Position: " + newPosition;
     
            //  Log results in Output window
            Output_battlePage_textbox.AppendText("******* Robot 2 *******" + Environment.NewLine +
                "Initial Position: " + currentPosition + Environment.NewLine +
                "Planned Path: " + R2_plannedMove_textbox.Text + Environment.NewLine +
                "New Position: " + newPosition + Environment.NewLine + Environment.NewLine);

            //  Clear the planned move textbox for the next move
            R2_plannedMove_textbox.Text = string.Empty;

            if ((robot_2.getPositionX() == robot_1.getPositionX()) && (robot_2.getPositionY() == robot_1.getPositionY()))
            {
                //  Robot 2 scores a point!
                R2_pbox.BringToFront();
                R2_score++;

                Output_battlePage_textbox.AppendText("Robot 1 has been crushed by Robot 2! Booya!!!" +
                    Environment.NewLine + Environment.NewLine);

                robot_2_score_lbl.Text = R2_score.ToString();

                if (R2_score == MaxScore)
                {
                    robot2_name_lbl.Text = "Robot 2 Wins!!!";
                    R1_Go_btn.Enabled = false;
                    R2_plannedMove_textbox.Enabled = false;
                    R2_Go_btn.Enabled = false;
                }
            }
        }

        private void LoadDisplay(PictureBox pBox, Bitmap robotBitmap, Robot robot)
        {
            switch(robot.getOrientation())
            {
                case("W"):
                {
                    //  Rotate 90 degrees counter clockwise
                    robotBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pBox.Image = robotBitmap;
                }
                break;
                case ("S"):
                    {
                        //  Rotate 90 degrees counter clockwise
                        robotBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        pBox.Image = robotBitmap;
                    }
                    break;
                case ("E"):
                    {
                        //  Rotate 90 degrees counter clockwise
                        robotBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        pBox.Image = robotBitmap;
                    }
                    break;
                default:
                    break;
            }

            //  Position the robot's initial position on the arena
            pBox.Location = new Point(X_map(robot.getPositionX()), Y_map(robot.getPositionY()));
        }

        private void UpdateDisplay(PictureBox pBox, Bitmap robotBitmap, int x, int y, string currentOrientation, string movement)
        {
            string[] cardinalDirection = { "N", "W", "S", "E" };

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

                            //  Rotate bitmap 90 degrees counter clockwise
                            robotBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            pBox.Image = robotBitmap;
                            pBox.Location = new Point(X_map(x), Y_map(y));
                        }
                        break;
                    case ('R'):
                        {
                            //  Rotate 90 degrees clockwise
                            int index = Array.FindIndex(cardinalDirection, row => row == currentOrientation);

                            //  Move down the array for clockwise
                            //  If we hit the first element of the array then reset to last element
                            currentOrientation = (index > 0) ? cardinalDirection[index - 1] : cardinalDirection[3];

                            //  Rotate bitmap 90 degrees clockwise
                            robotBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            pBox.Image = robotBitmap;
                            pBox.Location = new Point(X_map(x), Y_map(y));
                        }
                        break;
                    case ('M'):
                        {
                            //  Move up by 1 unit in y axis within grid boundaries
                            if ((currentOrientation == "N") && (y < gridProperty.VerticalCells))
                            {
                                y = y + 1;
                                pBox.Location = new Point(X_map(x), Y_map(y));
                            }
                            //  Move left by 1 unit in x axis within grid boundaries
                            if ((currentOrientation == "W") && (x > originX))
                            {
                                x = x - 1;
                                pBox.Location = new Point(X_map(x), Y_map(y));
                            }

                            //  Move down by 1 unit in y axis within grid boundaries
                            if ((currentOrientation == "S") && (y > originY))
                            {
                                y = y - 1;
                                pBox.Location = new Point(X_map(x), Y_map(y));
                            }

                            //  Move right by 1 unit in x axis within grid boundaries
                            if ((currentOrientation == "E") && (x < gridProperty.HorizontalCells))
                            {
                                x = x + 1;
                                pBox.Location = new Point(X_map(x), Y_map(y));      
                            }
                        }
                        break;
                }
            }
        }

        private void R1_plannedMove_textbox_TextChanged(object sender, EventArgs e)
        {
            //  If user entered a lower case letter, change to upper case
            R1_plannedMove_textbox.CharacterCasing = CharacterCasing.Upper;
        }

        private void R1_plannedMove_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyPress event: Only allow L, M, R, l, m, r and backspace
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^L^M^R^l^m^r^\b]"))
            {
                e.Handled = true;
            }
        }

        private void R2_plannedMove_textbox_TextChanged(object sender, EventArgs e)
        {
            //  If user entered a lower case letter, change to upper case
            R2_plannedMove_textbox.CharacterCasing = CharacterCasing.Upper;
        }

        private void R2_plannedMove_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyPress event: Only allow L, M, R, l, m, r and backspace
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^L^M^R^l^m^r^\b]"))
            {
                e.Handled = true;
            }
        }

        private int X_map(int x_coord)
        {
            return (x_coord * gridCellSizeHorizontal) + (gridStartLocationX - robot_1.getRobotWidth() / 2);
        }

        private int Y_map(int y_coord)
        {
            //  Offset is required so that increase in y goes up the y axis
            return (battleground_panel.Height - 2 * gridStartLocationY) - (y_coord * gridCellSizeVertical) + (gridStartLocationY - robot_1.getRobotHeight() / 2);
        }
    }
}

