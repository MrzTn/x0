using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Game game = new Game();

        public class Game
        {
            public int i;
            public int num_game = 0;
            public int Ovin = 0;
            public int Xvin = 0;
            public string[] arr = new string[10];
            public string t = "X";

            public void refresh(Form1 f)
            {
                f.button1.Text = "";
                f.button2.Text = "";
                f.button3.Text = "";
                f.button4.Text = "";
                f.button5.Text = "";
                f.button6.Text = "";
                f.button7.Text = "";
                f.button8.Text = "";
                f.button9.Text = "";
                f.label1.Text = "";
                for (i = 0; i < 10; i += 1)
                {
                    arr[i] = "";
                }
                i = 1;
                num_game += 1;
                f.label2.Text = num_game + " игра";
            }

            public string game(int j, Form1 f)
            {
                string fakeT;
                if (i % 2 == 1)
                {
                    t = "X";
                    fakeT = "O";
                }
                else
                {
                    t = "O";
                    fakeT = "X";
                }
                fakeT = "Ходит " + fakeT;
                arr[j] = t;
                i += 1;

                f.label1.Text = fakeT;
                return t;
            }
        }

        public Form1()
        {
            InitializeComponent();            
        }

       
/*
        public void who_vin()
        {            
            if ((arr[1] == "X" & arr[2] == "X" & arr[3] == "X") | (arr[1] == "X" & arr[5] == "X" & arr[9] == "X") | (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") | (arr[2] == "X" & arr[5] == "X" & arr[8] == "X") | (arr[3] == "X" & arr[6] == "X" & arr[9] == "X") | (arr[3] == "X" & arr[5] == "X" & arr[7] == "X") | (arr[4] == "X" & arr[5] == "X" & arr[6] == "X") | (arr[7] == "X" & arr[8] == "X" & arr[9] == "X"))
            {
                Xvin += 1;
               
                label3.Text = "X : O\n" + Xvin.ToString() + " : " + Ovin.ToString();
                MessageBox.Show(" X VIN!");
                refresch();
            }

            if ((arr[1] == "O" & arr[2] == "O" & arr[3] == "O") | (arr[1] == "O" & arr[5] == "O" & arr[9] == "O") | (arr[1] == "O" & arr[4] == "O" & arr[7] == "O") | (arr[2] == "O" & arr[5] == "O" & arr[8] == "O") | (arr[3] == "O" & arr[6] == "O" & arr[9] == "O") | (arr[3] == "O" & arr[5] == "O" & arr[7] == "O") | (arr[4] == "O" & arr[5] == "O" & arr[6] == "O") | (arr[7] == "O" & arr[8] == "O" & arr[9] == "O"))
            {
                Ovin += 1;
                
                label3.Text = "X : O\n" + Xvin.ToString() + " : " + Ovin.ToString();
                MessageBox.Show(" O VIN!");
                refresch();
            }
            if ((arr[1] != "") & (arr[2] != "") & (arr[3] != "") & (arr[4] != "") & (arr[5] != "") & (arr[7] != "") & (arr[8] != "") & (arr[9] != ""))
            {                
                MessageBox.Show(" Ничья! :)");
                refresch();
            }           
        }
           
        public void refresch()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "";
            for (i = 0; i < 10; i += 1)
            {
                arr[i] = "";
            }
            i = 1;
            num_game += 1;
            label2.Text = num_game + " игра";
        }*/

        private void button10_Click(object sender, EventArgs e)
        {
            game.refresh(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" | button1.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button1.Text = game.game(1,this); /*who_vin();*/ }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "X" | button2.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button2.Text = game.game(2, this); /*who_vin();*/ }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" | button3.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button3.Text = game.game(3, this); /*who_vin();*/ }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "X" | button4.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button4.Text = game.game(4, this); /*who_vin();*/ }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "X" | button5.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button5.Text = game.game(5, this); /*who_vin();*/ }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "X" | button6.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button6.Text = game.game(6, this); /*who_vin();*/ }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" | button7.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button7.Text = game.game(7, this); /*who_vin();*/ }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" | button8.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button8.Text = game.game(8, this); /*who_vin();*/ }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "X" | button9.Text == "O")
            {
                MessageBox.Show(" Нельзя!"); 
            }
            else { button9.Text = game.game(9, this); /*who_vin();*/ }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            game.refresh(this);
            label3.Text = "X : O\n" + game.Xvin.ToString() + " : " + game.Ovin.ToString();
            //коммент
        }
    }
}
