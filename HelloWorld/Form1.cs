using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
{
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //MessageBox.Show(button.Text);

            Random random = new Random();
            int randomNumber = random.Next(3) + 1;

            //MessageBox.Show(randomNumber +　"");

            int playerGuess = Convert.ToInt32(button.Tag);
            int computerGuess = randomNumber;

            //1是剪刀
            //2是石頭
            //3是布

            switch (playerGuess)
            {
                case 1:
                    switch (computerGuess)
                    {
                        case 1:
                            MessageBox.Show("電腦出剪刀。平手!");
                            break;

                        case 2:
                            MessageBox.Show("電腦出石頭。你輸了! 廢物");
                            break;

                        case 3:
                            MessageBox.Show("電腦出布。你贏了! 運氣好啦!");

                            break;

                        default:

                            break;
                    }
                    break;

                case 2:
                    switch (computerGuess)
                    {
                        case 1:
                            MessageBox.Show("電腦出剪刀。你贏了! 運氣好啦!");
                            break;

                        case 2:
                            MessageBox.Show("電腦出石頭。平手!");
                            break;

                        case 3:
                            MessageBox.Show("電腦出布。你輸了! 廢物");

                            break;

                        default:

                            break;
                    }
                    break;
                    

                case 3:
                    switch (computerGuess)
                    {
                        case 1:
                            MessageBox.Show("電腦出剪刀。你輸了! 廢物");
                            break;

                        case 2:
                            MessageBox.Show("電腦出石頭。你贏了! 運氣好啦!");
                            break;

                        case 3:
                            MessageBox.Show("電腦出布。平手!");

                            break;

                        default:

                            break;
                    }
                    break;

                default:

                    break;
            }
        }

    }
}
