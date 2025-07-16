using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubic
{
    public partial class StartMenu : Form
    {
        
        DiceGame diceGame = new DiceGame();
       
        public StartMenu()
        {
            InitializeComponent();
        }
        private void roundButtonStart_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = diceGame;

            diceGame.labelNameP1.Text = textBoxP1.Text; //запись имен
            diceGame.labelNameP2.Text = textBoxP2.Text;

            if (textBoxP1.Text.Trim() == string.Empty)  // проверяем ники на пустоту или пустоту из пробелов
                diceGame.labelNameP1.Text = "Player 1";

            if (textBoxP2.Text.Trim() == string.Empty)
                diceGame.labelNameP2.Text = "Player 2";

            diceGame.labelTarget.Text = $"Target: {(radioButton1.Checked ? radioButton1.Text : radioButton2.Text)}";  //добавление очков в таргет при запуске

            diceGame.Show();
            Close();
        }
    }
}
