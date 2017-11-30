namespace DTM
{
    partial class DtmMainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DtmMainWindow));
            this.Login_UserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Label_Pwd = new System.Windows.Forms.Label();
            this.Login_Pwd = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_UserName
            // 
            this.Login_UserName.Location = new System.Drawing.Point(245, 174);
            this.Login_UserName.Name = "Login_UserName";
            this.Login_UserName.Size = new System.Drawing.Size(170, 20);
            this.Login_UserName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 318);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Location = new System.Drawing.Point(130, 177);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(110, 13);
            this.Label_UserName.TabIndex = 2;
            this.Label_UserName.Text = "Enter your username :";
            // 
            // Label_Pwd
            // 
            this.Label_Pwd.AutoSize = true;
            this.Label_Pwd.Location = new System.Drawing.Point(130, 212);
            this.Label_Pwd.Name = "Label_Pwd";
            this.Label_Pwd.Size = new System.Drawing.Size(109, 13);
            this.Label_Pwd.TabIndex = 3;
            this.Label_Pwd.Text = "Enter your password :";
            // 
            // Login_Pwd
            // 
            this.Login_Pwd.Location = new System.Drawing.Point(245, 209);
            this.Login_Pwd.Name = "Login_Pwd";
            this.Login_Pwd.Size = new System.Drawing.Size(170, 20);
            this.Login_Pwd.TabIndex = 4;
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(260, 235);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            // 
            // DtmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 316);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Login_Pwd);
            this.Controls.Add(this.Label_Pwd);
            this.Controls.Add(this.Label_UserName);
            this.Controls.Add(this.Login_UserName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DtmMainWindow";
            this.Text = "DTM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Label Label_Pwd;
        private System.Windows.Forms.TextBox Login_Pwd;
        private System.Windows.Forms.Button Login_Button;
    }
}

