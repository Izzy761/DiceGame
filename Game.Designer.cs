namespace DiceGame
{
    partial class Game
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtRoll = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumRolls = new System.Windows.Forms.Label();
            this.txtWinLose = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnRoll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(23, 166);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(120, 30);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRollDice_OnClick);
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(20, 31);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(38, 23);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 59);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // txtRoll
            // 
            this.txtRoll.AutoSize = true;
            this.txtRoll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoll.Location = new System.Drawing.Point(76, 31);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(56, 23);
            this.txtRoll.TabIndex = 6;
            this.txtRoll.Text = "label1";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(77, 59);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(56, 23);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "label2";
            // 
            // btnMM
            // 
            this.btnMM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.Location = new System.Drawing.Point(203, 139);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(120, 30);
            this.btnMM.TabIndex = 15;
            this.btnMM.Text = "Main Menu";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(203, 175);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Quit Game";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Rolls";
            // 
            // txtNumRolls
            // 
            this.txtNumRolls.AutoSize = true;
            this.txtNumRolls.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRolls.Location = new System.Drawing.Point(350, 58);
            this.txtNumRolls.Name = "txtNumRolls";
            this.txtNumRolls.Size = new System.Drawing.Size(56, 23);
            this.txtNumRolls.TabIndex = 14;
            this.txtNumRolls.Text = "label3";
            // 
            // txtWinLose
            // 
            this.txtWinLose.AutoSize = true;
            this.txtWinLose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinLose.Location = new System.Drawing.Point(350, 28);
            this.txtWinLose.Name = "txtWinLose";
            this.txtWinLose.Size = new System.Drawing.Size(56, 23);
            this.txtWinLose.TabIndex = 13;
            this.txtWinLose.Text = "label3";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.Location = new System.Drawing.Point(199, 29);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(83, 23);
            this.lblWinLose.TabIndex = 9;
            this.lblWinLose.Text = "Win/Lose";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(23, 112);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(0, 23);
            this.txtResult.TabIndex = 17;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 229);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.txtNumRolls);
            this.Controls.Add(this.txtWinLose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRoll);
            this.Name = "Game";
            this.Text = "CrapsGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label txtRoll;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNumRolls;
        private System.Windows.Forms.Label txtWinLose;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label txtResult;
    }
}

