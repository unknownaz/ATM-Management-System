namespace ATM_management_system_GP
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.MiniStatement = new System.Windows.Forms.Button();
            this.FastCash = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.ChangePin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AccNumlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(762, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your Transaction";
            // 
            // desposit
            // 
            this.desposit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.desposit.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desposit.ForeColor = System.Drawing.Color.White;
            this.desposit.Location = new System.Drawing.Point(36, 118);
            this.desposit.Name = "desposit";
            this.desposit.Size = new System.Drawing.Size(228, 46);
            this.desposit.TabIndex = 9;
            this.desposit.Text = "Deposit";
            this.desposit.UseVisualStyleBackColor = false;
            this.desposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Withdraw.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.ForeColor = System.Drawing.Color.White;
            this.Withdraw.Location = new System.Drawing.Point(514, 118);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(228, 46);
            this.Withdraw.TabIndex = 10;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = false;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // MiniStatement
            // 
            this.MiniStatement.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MiniStatement.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniStatement.ForeColor = System.Drawing.Color.White;
            this.MiniStatement.Location = new System.Drawing.Point(514, 213);
            this.MiniStatement.Name = "MiniStatement";
            this.MiniStatement.Size = new System.Drawing.Size(228, 46);
            this.MiniStatement.TabIndex = 11;
            this.MiniStatement.Text = "Mini Statement";
            this.MiniStatement.UseVisualStyleBackColor = false;
            this.MiniStatement.Click += new System.EventHandler(this.MiniStatement_Click);
            // 
            // FastCash
            // 
            this.FastCash.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FastCash.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCash.ForeColor = System.Drawing.Color.White;
            this.FastCash.Location = new System.Drawing.Point(36, 213);
            this.FastCash.Name = "FastCash";
            this.FastCash.Size = new System.Drawing.Size(228, 46);
            this.FastCash.TabIndex = 12;
            this.FastCash.Text = "Fast Cash";
            this.FastCash.UseVisualStyleBackColor = false;
            this.FastCash.Click += new System.EventHandler(this.FastCash_Click);
            // 
            // Balance
            // 
            this.Balance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Balance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.Color.White;
            this.Balance.Location = new System.Drawing.Point(514, 303);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(228, 46);
            this.Balance.TabIndex = 13;
            this.Balance.Text = "Balance";
            this.Balance.UseVisualStyleBackColor = false;
            this.Balance.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChangePin
            // 
            this.ChangePin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChangePin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePin.ForeColor = System.Drawing.Color.White;
            this.ChangePin.Location = new System.Drawing.Point(36, 303);
            this.ChangePin.Name = "ChangePin";
            this.ChangePin.Size = new System.Drawing.Size(228, 46);
            this.ChangePin.TabIndex = 14;
            this.ChangePin.Text = "Change Pin";
            this.ChangePin.UseVisualStyleBackColor = false;
            this.ChangePin.Click += new System.EventHandler(this.ChangePin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(336, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Log Out";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 16;
            // 
            // AccNumlbl
            // 
            this.AccNumlbl.AutoSize = true;
            this.AccNumlbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumlbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AccNumlbl.Location = new System.Drawing.Point(210, 79);
            this.AccNumlbl.Name = "AccNumlbl";
            this.AccNumlbl.Size = new System.Drawing.Size(184, 36);
            this.AccNumlbl.TabIndex = 21;
            this.AccNumlbl.Text = "Account No :";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccNumlbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChangePin);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.FastCash);
            this.Controls.Add(this.MiniStatement);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.desposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button desposit;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button MiniStatement;
        private System.Windows.Forms.Button FastCash;
        private System.Windows.Forms.Button Balance;
        private System.Windows.Forms.Button ChangePin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AccNumlbl;
    }
}