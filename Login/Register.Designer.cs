namespace Login
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegUser = new System.Windows.Forms.TextBox();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.LabelConfirm = new System.Windows.Forms.Label();
            this.RegConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maak een nieuw account";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gebruikersnaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wachtwoord";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // RegUser
            // 
            this.RegUser.Location = new System.Drawing.Point(178, 95);
            this.RegUser.Name = "RegUser";
            this.RegUser.Size = new System.Drawing.Size(174, 20);
            this.RegUser.TabIndex = 3;
            this.RegUser.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // RegPass
            // 
            this.RegPass.Location = new System.Drawing.Point(178, 152);
            this.RegPass.Name = "RegPass";
            this.RegPass.PasswordChar = '*';
            this.RegPass.Size = new System.Drawing.Size(174, 20);
            this.RegPass.TabIndex = 4;
            this.RegPass.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(178, 252);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // LabelConfirm
            // 
            this.LabelConfirm.AutoSize = true;
            this.LabelConfirm.BackColor = System.Drawing.Color.Transparent;
            this.LabelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelConfirm.Location = new System.Drawing.Point(22, 211);
            this.LabelConfirm.Name = "LabelConfirm";
            this.LabelConfirm.Size = new System.Drawing.Size(150, 16);
            this.LabelConfirm.TabIndex = 6;
            this.LabelConfirm.Text = "verifiëer wachtwoord";
            this.LabelConfirm.Click += new System.EventHandler(this.Label4_Click);
            // 
            // RegConfirm
            // 
            this.RegConfirm.Location = new System.Drawing.Point(178, 210);
            this.RegConfirm.Name = "RegConfirm";
            this.RegConfirm.PasswordChar = '*';
            this.RegConfirm.Size = new System.Drawing.Size(174, 20);
            this.RegConfirm.TabIndex = 7;
            this.RegConfirm.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.RegConfirm);
            this.Controls.Add(this.LabelConfirm);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Registreer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegUser;
        private System.Windows.Forms.TextBox RegPass;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label LabelConfirm;
        private System.Windows.Forms.TextBox RegConfirm;
    }
}