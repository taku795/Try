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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ログインしました";
            // 
            // btnBuckToHome
            // 
            this.btnBuckToHome.Location = new System.Drawing.Point(274, 273);
            this.btnBuckToHome.Name = "btnBuckToHome";
            this.btnBuckToHome.Size = new System.Drawing.Size(75, 23);
            this.btnBuckToHome.TabIndex = 1;
            this.btnBuckToHome.Text = "戻る";
            this.btnBuckToHome.UseVisualStyleBackColor = true;
            this.btnBuckToHome.Click += new System.EventHandler(this.btnBuckToHome_Click);
            // 
            // btnEndApp
            // 
            this.btnEndApp.Location = new System.Drawing.Point(438, 272);
            this.btnEndApp.Name = "btnEndApp";
            this.btnEndApp.Size = new System.Drawing.Size(75, 23);
            this.btnEndApp.TabIndex = 2;
            this.btnEndApp.Text = "終了";
            this.btnEndApp.UseVisualStyleBackColor = true;
            this.btnEndApp.Click += new System.EventHandler(this.btnEndApp_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}