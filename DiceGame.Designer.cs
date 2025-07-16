
using System.Drawing;

namespace Kubic
{
    partial class DiceGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceGame));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreTable1 = new System.Windows.Forms.Label();
            this.labelNameP1 = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxDice = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxDice2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDice1 = new System.Windows.Forms.PictureBox();
            this.labelScoreResult = new System.Windows.Forms.Label();
            this.labelNameP2 = new System.Windows.Forms.Label();
            this.labelScoreTable2 = new System.Windows.Forms.Label();
            this.pictureBox1PDice = new System.Windows.Forms.PictureBox();
            this.pictureBox2PDice = new System.Windows.Forms.PictureBox();
            this.roundButtonPassTurn = new Kubic.RoundButton();
            this.roundButtonDice = new Kubic.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1PDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2PDice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Kubic.Properties.Resources.player1backHighLight;
            this.pictureBox2.Location = new System.Drawing.Point(198, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Kubic.Properties.Resources.player2back1;
            this.pictureBox3.Location = new System.Drawing.Point(438, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTurn.Location = new System.Drawing.Point(204, 278);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(67, 18);
            this.labelTurn.TabIndex = 5;
            this.labelTurn.Text = "TURN : ";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.BlueViolet;
            this.labelScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelScore.Location = new System.Drawing.Point(446, 278);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(72, 18);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "SCORE:";
            // 
            // labelScoreTable1
            // 
            this.labelScoreTable1.AutoSize = true;
            this.labelScoreTable1.BackColor = System.Drawing.Color.Green;
            this.labelScoreTable1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreTable1.Location = new System.Drawing.Point(332, 36);
            this.labelScoreTable1.Name = "labelScoreTable1";
            this.labelScoreTable1.Size = new System.Drawing.Size(32, 33);
            this.labelScoreTable1.TabIndex = 9;
            this.labelScoreTable1.Text = "0";
            // 
            // labelNameP1
            // 
            this.labelNameP1.AutoSize = true;
            this.labelNameP1.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelNameP1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameP1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameP1.Location = new System.Drawing.Point(2, 16);
            this.labelNameP1.Name = "labelNameP1";
            this.labelNameP1.Size = new System.Drawing.Size(223, 37);
            this.labelNameP1.TabIndex = 12;
            this.labelNameP1.Text = "labelName1P";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.BackColor = System.Drawing.Color.MediumAquamarine;
            this.labelTarget.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarget.Location = new System.Drawing.Point(351, 16);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(65, 17);
            this.labelTarget.TabIndex = 14;
            this.labelTarget.Text = "Target :";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxDice
            // 
            this.pictureBoxDice.BackColor = System.Drawing.Color.White;
            this.pictureBoxDice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDice.Image")));
            this.pictureBoxDice.Location = new System.Drawing.Point(306, 327);
            this.pictureBoxDice.Name = "pictureBoxDice";
            this.pictureBoxDice.Size = new System.Drawing.Size(180, 88);
            this.pictureBoxDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDice.TabIndex = 16;
            this.pictureBoxDice.TabStop = false;
            this.pictureBoxDice.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxDice2
            // 
            this.pictureBoxDice2.BackColor = System.Drawing.Color.White;
            this.pictureBoxDice2.Location = new System.Drawing.Point(398, 327);
            this.pictureBoxDice2.Name = "pictureBoxDice2";
            this.pictureBoxDice2.Size = new System.Drawing.Size(88, 88);
            this.pictureBoxDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDice2.TabIndex = 17;
            this.pictureBoxDice2.TabStop = false;
            this.pictureBoxDice2.Visible = false;
            // 
            // pictureBoxDice1
            // 
            this.pictureBoxDice1.BackColor = System.Drawing.Color.White;
            this.pictureBoxDice1.Location = new System.Drawing.Point(306, 327);
            this.pictureBoxDice1.Name = "pictureBoxDice1";
            this.pictureBoxDice1.Size = new System.Drawing.Size(88, 88);
            this.pictureBoxDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDice1.TabIndex = 17;
            this.pictureBoxDice1.TabStop = false;
            this.pictureBoxDice1.Visible = false;
            // 
            // labelScoreResult
            // 
            this.labelScoreResult.AutoSize = true;
            this.labelScoreResult.BackColor = System.Drawing.Color.BlueViolet;
            this.labelScoreResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelScoreResult.Location = new System.Drawing.Point(524, 279);
            this.labelScoreResult.Name = "labelScoreResult";
            this.labelScoreResult.Size = new System.Drawing.Size(0, 17);
            this.labelScoreResult.TabIndex = 18;
            this.labelScoreResult.Visible = false;
            // 
            // labelNameP2
            // 
            this.labelNameP2.AutoSize = true;
            this.labelNameP2.BackColor = System.Drawing.Color.BlueViolet;
            this.labelNameP2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameP2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameP2.Location = new System.Drawing.Point(484, 16);
            this.labelNameP2.Name = "labelNameP2";
            this.labelNameP2.Size = new System.Drawing.Size(223, 37);
            this.labelNameP2.TabIndex = 19;
            this.labelNameP2.Text = "labelName2P";
            // 
            // labelScoreTable2
            // 
            this.labelScoreTable2.AutoSize = true;
            this.labelScoreTable2.BackColor = System.Drawing.Color.Green;
            this.labelScoreTable2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreTable2.Location = new System.Drawing.Point(403, 36);
            this.labelScoreTable2.Name = "labelScoreTable2";
            this.labelScoreTable2.Size = new System.Drawing.Size(32, 33);
            this.labelScoreTable2.TabIndex = 20;
            this.labelScoreTable2.Text = "0";
            // 
            // pictureBox1PDice
            // 
            this.pictureBox1PDice.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1PDice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1PDice.Image")));
            this.pictureBox1PDice.Location = new System.Drawing.Point(284, 26);
            this.pictureBox1PDice.Name = "pictureBox1PDice";
            this.pictureBox1PDice.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1PDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1PDice.TabIndex = 21;
            this.pictureBox1PDice.TabStop = false;
            // 
            // pictureBox2PDice
            // 
            this.pictureBox2PDice.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox2PDice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2PDice.Image")));
            this.pictureBox2PDice.Location = new System.Drawing.Point(765, 26);
            this.pictureBox2PDice.Name = "pictureBox2PDice";
            this.pictureBox2PDice.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2PDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2PDice.TabIndex = 22;
            this.pictureBox2PDice.TabStop = false;
            this.pictureBox2PDice.Visible = false;
            // 
            // roundButtonPassTurn
            // 
            this.roundButtonPassTurn.BackColor = System.Drawing.Color.Gray;
            this.roundButtonPassTurn.BackColor2 = System.Drawing.Color.Gray;
            this.roundButtonPassTurn.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButtonPassTurn.ButtonHighlightColor = System.Drawing.Color.Indigo;
            this.roundButtonPassTurn.ButtonHighlightColor2 = System.Drawing.Color.Indigo;
            this.roundButtonPassTurn.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButtonPassTurn.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButtonPassTurn.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButtonPassTurn.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButtonPassTurn.ButtonRoundRadius = 30;
            this.roundButtonPassTurn.Enabled = false;
            this.roundButtonPassTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonPassTurn.ForeColor = System.Drawing.Color.White;
            this.roundButtonPassTurn.Location = new System.Drawing.Point(471, 421);
            this.roundButtonPassTurn.Name = "roundButtonPassTurn";
            this.roundButtonPassTurn.Size = new System.Drawing.Size(126, 51);
            this.roundButtonPassTurn.TabIndex = 24;
            this.roundButtonPassTurn.Text = "PASS TURN";
            this.roundButtonPassTurn.Click += new System.EventHandler(this.roundButtonPassTurn_Click);
            this.roundButtonPassTurn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundButtonPassTurn_KeyPress);
            // 
            // roundButtonDice
            // 
            this.roundButtonDice.BackColor = System.Drawing.Color.IndianRed;
            this.roundButtonDice.BackColor2 = System.Drawing.Color.BlueViolet;
            this.roundButtonDice.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButtonDice.ButtonHighlightColor = System.Drawing.Color.Indigo;
            this.roundButtonDice.ButtonHighlightColor2 = System.Drawing.Color.Indigo;
            this.roundButtonDice.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButtonDice.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButtonDice.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButtonDice.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButtonDice.ButtonRoundRadius = 30;
            this.roundButtonDice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonDice.ForeColor = System.Drawing.Color.White;
            this.roundButtonDice.Location = new System.Drawing.Point(198, 421);
            this.roundButtonDice.Name = "roundButtonDice";
            this.roundButtonDice.Size = new System.Drawing.Size(126, 51);
            this.roundButtonDice.TabIndex = 23;
            this.roundButtonDice.Text = "ROLL DICE";
            this.roundButtonDice.Click += new System.EventHandler(this.roundButton1_Click);
            this.roundButtonDice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundButtonDice_KeyPress);
            // 
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 529);
            this.Controls.Add(this.roundButtonPassTurn);
            this.Controls.Add(this.roundButtonDice);
            this.Controls.Add(this.pictureBox2PDice);
            this.Controls.Add(this.pictureBox1PDice);
            this.Controls.Add(this.labelScoreTable2);
            this.Controls.Add(this.labelNameP2);
            this.Controls.Add(this.labelScoreResult);
            this.Controls.Add(this.pictureBoxDice1);
            this.Controls.Add(this.pictureBoxDice2);
            this.Controls.Add(this.pictureBoxDice);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelNameP1);
            this.Controls.Add(this.labelScoreTable1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(810, 568);
            this.MinimumSize = new System.Drawing.Size(810, 568);
            this.Name = "DiceGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1PDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2PDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreTable1;
        public System.Windows.Forms.Label labelNameP1;
        public System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxDice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxDice2;
        private System.Windows.Forms.PictureBox pictureBoxDice1;
        private System.Windows.Forms.Label labelScoreResult;
        public System.Windows.Forms.Label labelNameP2;
        private System.Windows.Forms.Label labelScoreTable2;
        private System.Windows.Forms.PictureBox pictureBox1PDice;
        private System.Windows.Forms.PictureBox pictureBox2PDice;
        private RoundButton roundButtonDice;
        private RoundButton roundButtonPassTurn;
    }
}

