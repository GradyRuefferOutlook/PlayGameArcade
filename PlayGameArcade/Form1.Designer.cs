namespace PlayGameArcade
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.insertCoin = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.startPrompt = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // insertCoin
            // 
            this.insertCoin.BackColor = System.Drawing.Color.Transparent;
            this.insertCoin.Font = new System.Drawing.Font("Press Start 2P", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCoin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insertCoin.Location = new System.Drawing.Point(12, 324);
            this.insertCoin.Name = "insertCoin";
            this.insertCoin.Size = new System.Drawing.Size(460, 37);
            this.insertCoin.TabIndex = 0;
            this.insertCoin.Text = "* Insert Coin To Continue *";
            this.insertCoin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertCoin.Visible = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Press Start 2P", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(99, 127);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(287, 148);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startPrompt
            // 
            this.startPrompt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startPrompt.BackColor = System.Drawing.Color.Transparent;
            this.startPrompt.Font = new System.Drawing.Font("Press Start 2P", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPrompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startPrompt.Location = new System.Drawing.Point(12, 9);
            this.startPrompt.Name = "startPrompt";
            this.startPrompt.Size = new System.Drawing.Size(460, 113);
            this.startPrompt.TabIndex = 2;
            this.startPrompt.Text = ":Welcome To:               THE GAME";
            this.startPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startPrompt.UseWaitCursor = true;
            this.startPrompt.Click += new System.EventHandler(this.startPrompt_Click);
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.Color.Transparent;
            this.countdown.Font = new System.Drawing.Font("Press Start 2P", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.countdown.Location = new System.Drawing.Point(12, 122);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(460, 146);
            this.countdown.TabIndex = 3;
            this.countdown.Text = "3";
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown.Visible = false;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.BackColor = System.Drawing.Color.Transparent;
            this.errorText.Font = new System.Drawing.Font("Press Start 2P", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorText.Location = new System.Drawing.Point(49, 268);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(397, 37);
            this.errorText.TabIndex = 4;
            this.errorText.Text = "ERROR: 404";
            this.errorText.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 750;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.startPrompt);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.insertCoin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertCoin;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label startPrompt;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

