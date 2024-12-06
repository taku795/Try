namespace UsernameNormalization
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuckToHome = new System.Windows.Forms.Button();
            this.btnEndApp = new System.Windows.Forms.Button();
            this.NormalizeUsername = new System.Windows.Forms.Button();
            this.BeforeUsernameNomalization = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AfterNorma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ユーザー名の正規化を行います";
            // 
            // btnBuckToHome
            // 
            this.btnBuckToHome.Location = new System.Drawing.Point(183, 272);
            this.btnBuckToHome.Name = "btnBuckToHome";
            this.btnBuckToHome.Size = new System.Drawing.Size(75, 23);
            this.btnBuckToHome.TabIndex = 1;
            this.btnBuckToHome.Text = "戻る";
            this.btnBuckToHome.UseVisualStyleBackColor = true;
            this.btnBuckToHome.Click += new System.EventHandler(this.btnBuckToHome_Click);
            // 
            // btnEndApp
            // 
            this.btnEndApp.Location = new System.Drawing.Point(461, 272);
            this.btnEndApp.Name = "btnEndApp";
            this.btnEndApp.Size = new System.Drawing.Size(75, 23);
            this.btnEndApp.TabIndex = 2;
            this.btnEndApp.Text = "終了";
            this.btnEndApp.UseVisualStyleBackColor = true;
            this.btnEndApp.Click += new System.EventHandler(this.btnEndApp_Click);
            // 
            // NormalizeUsername
            // 
            this.NormalizeUsername.Location = new System.Drawing.Point(473, 145);
            this.NormalizeUsername.Name = "NormalizeUsername";
            this.NormalizeUsername.Size = new System.Drawing.Size(75, 23);
            this.NormalizeUsername.TabIndex = 3;
            this.NormalizeUsername.Text = "正規化する";
            this.NormalizeUsername.UseVisualStyleBackColor = true;
            this.NormalizeUsername.Click += new System.EventHandler(this.NormalizeUsername_Click);
            // 
            // BeforeUsernameNomalization
            // 
            this.BeforeUsernameNomalization.Location = new System.Drawing.Point(322, 111);
            this.BeforeUsernameNomalization.Name = "BeforeUsernameNomalization";
            this.BeforeUsernameNomalization.Size = new System.Drawing.Size(100, 19);
            this.BeforeUsernameNomalization.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "正規化対象：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "正規化後：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AfterNorma
            // 
            this.AfterNorma.AutoSize = true;
            this.AfterNorma.Location = new System.Drawing.Point(320, 200);
            this.AfterNorma.Name = "AfterNorma";
            this.AfterNorma.Size = new System.Drawing.Size(0, 12);
            this.AfterNorma.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AfterNorma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BeforeUsernameNomalization);
            this.Controls.Add(this.NormalizeUsername);
            this.Controls.Add(this.btnEndApp);
            this.Controls.Add(this.btnBuckToHome);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuckToHome;
        private System.Windows.Forms.Button btnEndApp;
        private System.Windows.Forms.Button NormalizeUsername;
        private System.Windows.Forms.TextBox BeforeUsernameNomalization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AfterNorma;
    }
}