using MasterMindGame.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label33_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disableItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Secret");

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + " " + MasterMind.secretCode[i]);
            }

            Console.WriteLine(comboBox1.Text);
            Console.WriteLine(comboBox2.Text);
            Console.WriteLine(comboBox3.Text);
            Console.WriteLine(comboBox4.Text);
            if ((comboBox1.SelectedItem == null || comboBox1.SelectedIndex == -1) ||
                (comboBox2.SelectedItem == null || comboBox2.SelectedIndex == -1) ||
                (comboBox3.SelectedItem == null || comboBox3.SelectedIndex == -1) ||
                (comboBox4.SelectedItem == null || comboBox4.SelectedIndex == -1))
            {
                MessageBox.Show("Please select color to make a guess");
                return;
            }

            //checking guess with secret code
            if (comboBox1.Text == MasterMind.secretCode[0] &&
               comboBox2.Text == MasterMind.secretCode[1] &&
               comboBox3.Text == MasterMind.secretCode[2] &&
               comboBox4.Text == (MasterMind.secretCode[3]))
            {
                resetSecretCode();
                resetlabels();
                MessageBox.Show("You Win!!!\n" +
                    "Correct Secret Code: " + MasterMind.secretCode[0] + ", " + MasterMind.secretCode[1] + ", " + MasterMind.secretCode[2] + ", " + MasterMind.secretCode[3]);
                disableItems();
                return;
            }
            for (int i = 0; i < MasterMind.secretCode.Length; i++){
Console.WriteLine(i+" " +MasterMind.secretCode[i]);        
}
            //checking correct positioned guesses
         if (comboBox1.Text.Equals(MasterMind.secretCode[0])) {
                MasterMind.incrementcorrectPositionedGuessesCounter();
                Console.WriteLine("CALLED1");
            }
            if (comboBox2.Text.Equals(MasterMind.secretCode[1])) {
                MasterMind.incrementcorrectPositionedGuessesCounter();
                Console.WriteLine("CALLED2");
            }
            if (comboBox3.Text.Equals(MasterMind.secretCode[2])) {
                MasterMind.incrementcorrectPositionedGuessesCounter();
                Console.WriteLine("CALLED3");

            }
            if (comboBox4.Text.Equals(MasterMind.secretCode[3])) {
                MasterMind.incrementcorrectPositionedGuessesCounter();
                Console.WriteLine("CALLED4");
            }

          //checking correct  guesses with different position
            if (MasterMind.secretCode.Contains(comboBox1.Text) && !comboBox1.Text.Equals(MasterMind.secretCode[0]))
            {
                MasterMind.incrementCorrectGuessesCounter();
            }
            if (MasterMind.secretCode.Contains(comboBox2.Text) && !comboBox2.Text.Equals(MasterMind.secretCode[1]))
            {
                MasterMind.incrementCorrectGuessesCounter();
            }
            if (MasterMind.secretCode.Contains(comboBox3.Text) && !comboBox3.Text.Equals(MasterMind.secretCode[2]))
            {
                MasterMind.incrementCorrectGuessesCounter();
            }
            if (MasterMind.secretCode.Contains(comboBox4.Text) && !comboBox4.Text.Equals(MasterMind.secretCode[3]))
            {
                MasterMind.incrementCorrectGuessesCounter();
            }

            //populating guess value
            if(MasterMind.guessCounter == 1)
            {
                label9.Text = comboBox1.Text;
                label10.Text = comboBox2.Text;
                label11.Text = comboBox3.Text;
                label12.Text = comboBox4.Text;
                //populating result
                label41.Text = MasterMind.correctPositionedGuessesCounter.ToString() +"B"+ " "+ MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 2)
            {
                label16.Text = comboBox1.Text;
                label15.Text = comboBox2.Text;
                label14.Text = comboBox3.Text;
                label13.Text = comboBox4.Text;
                //populating result
                label42.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 3)
            {
                label40.Text = comboBox1.Text;
                label39.Text = comboBox2.Text;
                label38.Text = comboBox3.Text;
                label37.Text = comboBox4.Text;
                //populating result
                label43.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 4)
            {
                label36.Text = comboBox1.Text;
                label35.Text = comboBox2.Text;
                label34.Text = comboBox3.Text;
                label33.Text = comboBox4.Text;
                //populating result
                label44.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 5)
            {
                label32.Text = comboBox1.Text;
                label31.Text = comboBox2.Text;
                label30.Text = comboBox3.Text;
                label29.Text = comboBox4.Text;
                //populating result
                label45.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 6)
            {
                label28.Text = comboBox1.Text;
                label27.Text = comboBox2.Text;
                label26.Text = comboBox3.Text;
                label25.Text = comboBox4.Text;
                //populating result
                label46.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 7)
            {
                label24.Text = comboBox1.Text;
                label23.Text = comboBox2.Text;
                label22.Text = comboBox3.Text;
                label21.Text = comboBox4.Text;
                //populating result
                label47.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }
            else if (MasterMind.guessCounter == 8)
            {
                label20.Text = comboBox1.Text;
                label19.Text = comboBox2.Text;
                label18.Text = comboBox3.Text;
                label17.Text = comboBox4.Text;
                //populating result
                label48.Text = MasterMind.correctPositionedGuessesCounter.ToString() + "B" + " " + MasterMind.correctGuessesCounter.ToString() + "W";
            }

            updateCounters();
            //checking max limit of guesses

            if (MasterMind.guessCounter == 9)
            {
                resetSecretCode();
                resetlabels();
                disableItems();
                MessageBox.Show("You Lose!!!\n" +
                    "Correct Secret Code: " + MasterMind.secretCode[0] + ", " + MasterMind.secretCode[1] + ", " + MasterMind.secretCode[2] + ", " + MasterMind.secretCode[3]);
                return;
            }
        }

        private void updateCounters()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            MasterMind.resetCorrectGuessesCounterr();
            MasterMind.resetCorrectPositionedGuessesCounter();
            MasterMind.incrementGuessCounter();
        }

        private void resetSecretCode()
        {
            MasterMind.resetLastValues();
            MasterMind.resetGuessCounter();
            MasterMind.secretCode = MasterMind.getSecretCode();
            if (MasterMind.showSecretCode == true)
            {
                label53.Text = MasterMind.secretCode[0];
                label52.Text = MasterMind.secretCode[1];
                label51.Text = MasterMind.secretCode[2];
                label50.Text = MasterMind.secretCode[3];
            }
            else
            {
                label53.Text = "***";
                label52.Text = "***";
                label51.Text = "***";
                label50.Text = "***";
            }
        }

        private void resetlabels()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
            label17.Text = "";
            label48.Text = "";
            label24.Text = "";
            label23.Text = "";
            label22.Text = "";
            label21.Text = "";
            label47.Text = "";
            label28.Text = "";
            label27.Text = "";
            label26.Text = "";
            label25.Text = "";
            label46.Text = "";
            label32.Text = "";
            label31.Text = "";
            label30.Text = "";
            label29.Text = "";
            label45.Text = "";
            label36.Text = "";
            label35.Text = "";
            label34.Text = "";
            label33.Text = "";
            label44.Text = "";
            label40.Text = "";
            label39.Text = "";
            label38.Text = "";
            label37.Text = "";
            label43.Text = "";
            label16.Text = "";
            label15.Text = "";
            label14.Text = "";
            label13.Text = "";
            label42.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label41.Text = "";
            label53.Text = "";
            label52.Text = "";
            label51.Text = "";
            label50.Text = "";
        }

        private void disableItems()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            button2.Enabled = false;

        }

        private void enableItems()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enableItems();
            resetSecretCode();
        }

        public Boolean isDuplicateColorSelected()
        {
            if ((comboBox2.SelectedItem != null || comboBox2.SelectedIndex != -1) && comboBox1.Text.Equals(comboBox2.Text) ||
                (comboBox3.SelectedItem != null || comboBox3.SelectedIndex != -1) && comboBox1.Text.Equals(comboBox3.Text) ||
                (comboBox4.SelectedItem != null || comboBox4.SelectedIndex != -1) && comboBox1.Text.Equals(comboBox4.Text) ||
                (comboBox2.SelectedItem != null || comboBox2.SelectedIndex != -1) && comboBox2.Text.Equals(comboBox1.Text) ||
                (comboBox3.SelectedItem != null || comboBox3.SelectedIndex != -1) && comboBox2.Text.Equals(comboBox3.Text) ||
                (comboBox4.SelectedItem != null || comboBox4.SelectedIndex != -1) && comboBox2.Text.Equals(comboBox4.Text) ||
                (comboBox1.SelectedItem != null || comboBox1.SelectedIndex != -1) && comboBox3.Text.Equals(comboBox1.Text) ||
                (comboBox2.SelectedItem != null || comboBox2.SelectedIndex != -1) && comboBox3.Text.Equals(comboBox2.Text) ||
                (comboBox4.SelectedItem != null || comboBox4.SelectedIndex != -1) && comboBox3.Text.Equals(comboBox4.Text) ||
                (comboBox1.SelectedItem != null || comboBox1.SelectedIndex != -1) && comboBox4.Text.Equals(comboBox1.Text) ||
                (comboBox2.SelectedItem != null || comboBox2.SelectedIndex != -1) && comboBox4.Text.Equals(comboBox2.Text) ||
                (comboBox3.SelectedItem != null || comboBox3.SelectedIndex != -1) && comboBox4.Text.Equals(comboBox3.Text)) {
                return true;
            }

            return false;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDuplicateColorSelected())
            {
                comboBox1.SelectedIndex = -1;
                MessageBox.Show("Color already selected. Please select different color");
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDuplicateColorSelected())
            {
                comboBox2.SelectedIndex = -1;
                MessageBox.Show("Color already selected. Please select different color");
                return;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDuplicateColorSelected())
            {
                comboBox3.SelectedIndex = -1;
                MessageBox.Show("Color already selected. Please select different color");
                return;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDuplicateColorSelected())
            {
                comboBox4.SelectedIndex = -1;
                MessageBox.Show("Color already selected. Please select different color");
                return;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }


}
