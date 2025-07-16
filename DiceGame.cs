using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubic
{
    
    public partial class DiceGame : Form
    {
        public DiceGame()
        {
            InitializeComponent();
        }
        
        int countDice = 0; //счетчик кол-во нажатий кнопки RollDice
        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1PDice.Visible == true) //отображение имени в TURN
            {
                labelTurn.Text = "TURN: " + labelNameP1.Text;
            }
            else if (pictureBox2PDice.Visible == true)
            {
                labelTurn.Text = "TURN: " + labelNameP2.Text;
            }

            countDice++;

            timer1.Enabled = true;  //включаем таймер

            roundButtonDice.Enabled = false; //офаем кнопку чтобы во время проигрывания гифки чел не сломал программу многократными нажатиями
            roundButtonDice.BackColor = Color.Gray;
            roundButtonDice.BackColor2 = Color.Gray;

            pictureBoxDice.Visible = true; //делаем видимой гифку

            labelScoreResult.Visible = false; //делаем невидимым счетчик суммы выпавших кубиков
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rndDice = new Random();

            int diceResult1 = rndDice.Next(1, 7);  //вывод рандомного значения первого кубика
            pictureBoxDice1.Image = Image.FromFile($"{diceResult1}.png");
            pictureBoxDice1.Visible = true;

            int diceResult2 = rndDice.Next(1, 7); //вывод рандомного значения второго кубика
            pictureBoxDice2.Image = Image.FromFile($"{diceResult2}.png");
            pictureBoxDice2.Visible = true;

            labelScoreResult.Text = (diceResult1 + diceResult2).ToString(); //подсчитываем сумму значений выпавших кубиков
            labelScoreResult.Visible = true; //показываем сумму значений выпавших кубиков

            pictureBoxDice.Visible = false; //скрываем гифку
   
            timer1.Enabled = false; //выключаем таймер

            if (countDice == 1) //если счетчик(RollDice) доходит до 1, то выключаем RollDice и включаем PassTurn
            {
                roundButtonDice.Enabled = false;
                roundButtonDice.BackColor = Color.Gray;
                roundButtonDice.BackColor2 = Color.Gray;

                roundButtonPassTurn.Enabled = true;
                roundButtonPassTurn.BackColor = Color.IndianRed;
                roundButtonPassTurn.BackColor2 = Color.BlueViolet;

                roundButtonPassTurn.Focus(); //фокусим, это для привязки клавиш
            }


            if (pictureBox1PDice.Visible == true)
            {
                int sum = int.Parse(labelScoreTable1.Text) + int.Parse(labelScoreResult.Text);
                labelScoreTable1.Text = sum.ToString(); //добавление в левый счетчик количества суммы очков   
                CheckWinner(labelNameP1.Text);
            }
            
            else if(pictureBox2PDice.Visible == true)
            {
                int sum = int.Parse(labelScoreTable2.Text) + int.Parse(labelScoreResult.Text);
                labelScoreTable2.Text = sum.ToString(); //добавление в правый счетчик количества суммы очков
                CheckWinner(labelNameP2.Text);
            }
        }
        private void roundButtonPassTurn_Click(object sender, EventArgs e)
        {
            countDice = 0;
            labelTurn.BackColor = SystemColors.Highlight; // При нажатии PASS TURN меня цвет в соответствии с игроком

            roundButtonDice.Enabled = true; //включение кнопки ROll DICE
            roundButtonDice.BackColor = Color.IndianRed;
            roundButtonDice.BackColor2 = Color.BlueViolet;

            if (pictureBox1PDice.Visible == true) //если кубик стоит возле первого игрока, то скрываем этот кубик и открываем кубик второго игрока
            {
                pictureBox2PDice.Visible = true;
                pictureBox1PDice.Visible = false;
                pictureBox2.Image = Image.FromFile("player1backBlueViolet.png"); //меняем цвет pictureBox в соответствии TURN'ом
                labelTurn.BackColor = Color.BlueViolet;
                labelTurn.Text = "TURN: " + labelNameP2.Text;
            }
            else if (pictureBox2PDice.Visible == true) // тоже самое только наоборот
            {
                pictureBox1PDice.Visible = true;
                pictureBox2PDice.Visible = false;
                pictureBox2.Image = Image.FromFile("player1backHighLight.png"); //меняем цвет pictureBox в соответствии TURN'ом
                labelTurn.Text = "TURN: " + labelNameP1.Text;
            }

            roundButtonPassTurn.Enabled = false; //выключаем кнопку Pass Turn, для того чтобы чел 100% нажал Roll DICE
            roundButtonPassTurn.BackColor = Color.Gray;
            roundButtonPassTurn.BackColor2 = Color.Gray;
        }
        private void roundButtonDice_KeyPress(object sender, KeyPressEventArgs e) // Обработка клавиши (Q)
        {
            if (e.KeyChar == 'q' || e.KeyChar == (char)Keys.Q || e.KeyChar == 'й' || e.KeyChar == 'Й') 
            {
                roundButton1_Click(sender, e);
                e.Handled = true;
            }
        }
        private void roundButtonPassTurn_KeyPress(object sender, KeyPressEventArgs e) // Обработка клавиши (E)
        {
            if (e.KeyChar == 'e' || e.KeyChar == (char)Keys.E || e.KeyChar == 'у' || e.KeyChar == 'У')
            {
                roundButtonPassTurn_Click(sender, e);
                e.Handled = true;
            }
        }
        private void CheckWinner(string currentPlayerName)
        {
            switch (labelTarget.Text.Contains("50"))
            {
                case true:
                    if (int.Parse(labelScoreTable1.Text) >= 50)
                    {
                        MessageBox.Show($"{currentPlayerName} выиграл!", "Победа");
                        Application.Restart();
                    }
                    if (int.Parse(labelScoreTable2.Text) >= 50)
                    {
                        MessageBox.Show($"{currentPlayerName} выиграл!", "Победа");
                        Application.Restart();
                    }
                    break;

                case false:
                    if(int.Parse(labelScoreTable1.Text) >= 100)
                    {
                        MessageBox.Show($"{currentPlayerName} выиграл!", "Победа");
                        Application.Restart();
                    }
                    if (int.Parse(labelScoreTable2.Text) >= 100)
                    {
                        MessageBox.Show($"{currentPlayerName} выиграл!", "Победа");
                        Application.Restart();
                    }
                    break;
            }
        }
    }
}
