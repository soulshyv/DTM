namespace DTM.Forms
{
    partial class DtmLoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DtmLoginWindow));
            this.Login_UserName = new System.Windows.Forms.TextBox();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Label_Pwd = new System.Windows.Forms.Label();
            this.Login_Pwd = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.Login_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_UserName
            // 
            this.Login_UserName.Location = new System.Drawing.Point(211, 192);
            this.Login_UserName.Name = "Login_UserName";
            this.Login_UserName.Size = new System.Drawing.Size(170, 20);
            this.Login_UserName.TabIndex = 0;
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.Label_UserName.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserName.Location = new System.Drawing.Point(255, 172);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(73, 14);
            this.Label_UserName.TabIndex = 2;
            this.Label_UserName.Text = "Username";
            // 
            // Label_Pwd
            // 
            this.Label_Pwd.AutoSize = true;
            this.Label_Pwd.Location = new System.Drawing.Point(269, 227);
            this.Label_Pwd.Name = "Label_Pwd";
            this.Label_Pwd.Size = new System.Drawing.Size(53, 13);
            this.Label_Pwd.TabIndex = 3;
            this.Label_Pwd.Text = "Password";
            // 
            // Login_Pwd
            // 
            this.Login_Pwd.Location = new System.Drawing.Point(211, 243);
            this.Login_Pwd.Name = "Login_Pwd";
            this.Login_Pwd.PasswordChar = '*';
            this.Login_Pwd.Size = new System.Drawing.Size(170, 20);
            this.Login_Pwd.TabIndex = 4;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(258, 281);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 23);
            this.SignIn.TabIndex = 5;
            this.SignIn.Text = "Login";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(498, 281);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 23);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "S\'enregistrer";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Login_Error
            // 
            this.Login_Error.AutoSize = true;
            this.Login_Error.BackColor = System.Drawing.Color.Transparent;
            this.Login_Error.Font = new System.Drawing.Font("MS PGothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Error.Location = new System.Drawing.Point(12, 293);
            this.Login_Error.Name = "Login_Error";
            this.Login_Error.Size = new System.Drawing.Size(0, 14);
            this.Login_Error.TabIndex = 7;
            // 
            // DtmLoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 316);
            this.Controls.Add(this.Login_Error);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Login_Pwd);
            this.Controls.Add(this.Label_Pwd);
            this.Controls.Add(this.Label_UserName);
            this.Controls.Add(this.Login_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DtmLoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_UserName;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Label Label_Pwd;
        private System.Windows.Forms.TextBox Login_Pwd;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label Login_Error;
    }
}

