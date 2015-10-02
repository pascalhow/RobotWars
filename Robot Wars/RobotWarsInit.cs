using System;
using System.Windows.Forms;

namespace RobotWars
{
    public partial class InitForm : Form
    {
        private Grid thisGrid = new Grid();
        private Robot robot_1;
        private Robot robot_2;
        private int origin_x = 0;
        private int origin_y = 0;

        public InitForm()
        {
            InitializeComponent();
        }

        private void initialise_btn_Click(object sender, EventArgs e)
        {          
            //  Display user input
            Output_initPage_textbox.AppendText("Grid size: " + thisGrid.HorizontalCells.ToString() + " " + 
                thisGrid.VerticalCells.ToString() + " " + Environment.NewLine + Environment.NewLine);

            //  A robot needs these parameters to start: x coordinate, y coordinate, orientation, x origin, y origin, gridth width, grid height
            //  Tell robot 1 how big the battlefield is and give it its corrdinates
            robot_1 = new Robot(Int32.Parse(robot_1_positionX_cbox.Text), Int32.Parse(robot_1_positionY_cbox.Text), robot_1_orientation_cbox.Text, origin_x, origin_y, thisGrid.HorizontalCells, thisGrid.VerticalCells);
            string R1_currentPosition = robot_1_positionX_cbox.Text + " " + robot_1_positionY_cbox.Text + " " + robot_1_orientation_cbox.Text;
            string R1_newPosition = robot_1.calculatePlannedPosition(robot1_FirstMove_textbox.Text);

            //  Display user input
            Output_initPage_textbox.AppendText("******* Robot 1 *******" + Environment.NewLine +
                "Initial Position: " + R1_currentPosition + Environment.NewLine + 
                "First move: " + robot1_FirstMove_textbox.Text + Environment.NewLine + 
                "New Position: " + R1_newPosition + Environment.NewLine + Environment.NewLine);

            //  Tell robot 1 how big the battlefield is and give it its corrdinates
            robot_2 = new Robot(Int32.Parse(robot_2_positionX_cbox.Text), Int32.Parse(robot_2_positionY_cbox.Text), robot_2_orientation_cbox.Text, origin_x, origin_y, thisGrid.HorizontalCells, thisGrid.VerticalCells);
            string R2_currentPosition = robot_2_positionX_cbox.Text + " " + robot_2_positionY_cbox.Text + " " + robot_2_orientation_cbox.Text;
            string R2_newPosition = robot_2.calculatePlannedPosition(robot2_FirstMove_textbox.Text);

            //  Display user input
            Output_initPage_textbox.AppendText("******* Robot 2 *******" + Environment.NewLine +
                "Initial Position: " + R2_currentPosition + Environment.NewLine +
                "First move: " + robot2_FirstMove_textbox.Text + Environment.NewLine +
                "New Position: " + R2_newPosition + Environment.NewLine + Environment.NewLine);

            Output_initPage_textbox.AppendText("Press Go button to go to the Arena!" + Environment.NewLine);
           Go_btn.Enabled = true;
        }

        private void setGridSize_btn_Click(object sender, EventArgs e)
        {
            panel_robot1Setup.Enabled = true;
            panel_robot2Setup.Enabled = true;
            initialise_btn.Enabled = true;  
            gridWidth_numUpDown.Enabled = false;
            gridHeight_numUpDown.Enabled = false;
            setGridSize_btn.Enabled = false;

            //  Take user input grid width and grid height to build grid size
            thisGrid.HorizontalCells = (int) gridWidth_numUpDown.Value;
            thisGrid.VerticalCells = (int) gridHeight_numUpDown.Value;

            //  Fill the combobox accorging to the size of the grid
            for (int i = 0; i <= thisGrid.HorizontalCells; i++)
            {
                robot_1_positionX_cbox.Items.Add((i).ToString());
                robot_2_positionX_cbox.Items.Add((i).ToString());
            }

            for (int i = 0; i <= thisGrid.VerticalCells; i++)
            {
                robot_1_positionY_cbox.Items.Add((i).ToString());
                robot_2_positionY_cbox.Items.Add((i).ToString());
            }

            robot_1_positionX_cbox.SelectedIndex = 0;
            robot_1_positionY_cbox.SelectedIndex = 0;
            robot_1_orientation_cbox.SelectedIndex = 0;

            robot_2_positionX_cbox.SelectedIndex = 1;
            robot_2_positionY_cbox.SelectedIndex = 0;
            robot_2_orientation_cbox.SelectedIndex = 0;
        }

        private void Go_btn_Click(object sender, EventArgs e)
        {
            RobotWarBattleField_Form robotWarsBattlefield_form = new RobotWarBattleField_Form();

            // Launch the battlefield form with the entered data
            robotWarsBattlefield_form.StartPosition = FormStartPosition.CenterScreen;
            robotWarsBattlefield_form.gridProperty.HorizontalCells = thisGrid.HorizontalCells;
            robotWarsBattlefield_form.gridProperty.VerticalCells = thisGrid.VerticalCells;

            //  Parse robot 1 and robot 2 objects to next form
            robotWarsBattlefield_form.robot_1_property = robot_1;
            robotWarsBattlefield_form.robot_2_property = robot_2;

            //  Hide the init form
            this.Hide();

            //  Launch next form
            robotWarsBattlefield_form.ShowDialog();
        }

        private void robot1_FirstMove_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyPress event: Only allow L, M, R, l, m, r and backspace
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^L^M^R^l^m^r^\b]"))
            {
                e.Handled = true;
            }
        }

        private void robot1_FirstMove_textbox_TextChanged(object sender, EventArgs e)
        {
            //  If user entered a lower case letter, change to upper case
            robot1_FirstMove_textbox.CharacterCasing = CharacterCasing.Upper;
        }

        private void robot2_FirstMove_textbox_TextChanged(object sender, EventArgs e)
        {
            //  If user entered a lower case letter, change to upper case
            robot2_FirstMove_textbox.CharacterCasing = CharacterCasing.Upper;
        }

        private void robot2_FirstMove_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyPress event: Only allow L, M, R, l, m, r and backspace
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^L^M^R^l^m^r^\b]"))
            {  
                e.Handled = true;
            }
        }
    }
}
