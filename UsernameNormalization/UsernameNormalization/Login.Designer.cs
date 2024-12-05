namespace UsernameNormalization
{
    partial class Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.UserNameError = new System.Windows.Forms.Label();
            this.PassWorldError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(323, 262);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "ログイン";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(382, 126);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 19);
            this.UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ユーザー名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "パスワード：";
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(382, 174);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(100, 19);
            this.PassWord.TabIndex = 4;
            // 
            // UserNameError
            // 
            this.UserNameError.AutoSize = true;
            this.UserNameError.Location = new System.Drawing.Point(503, 129);
            this.UserNameError.Name = "UserNameError";
            this.UserNameError.Size = new System.Drawing.Size(0, 12);
            this.UserNameError.TabIndex = 5;
            // 
            // PassWorldError
            // 
            this.PassWorldError.AutoSize = true;
            this.PassWorldError.Location = new System.Drawing.Point(505, 180);
            this.PassWorldError.Name = "PassWorldError";
            this.PassWorldError.Size = new System.Drawing.Size(0, 12);
            this.PassWorldError.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassWorldError);
            this.Controls.Add(this.UserNameError);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.loginBtn);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label UserNameError;
        private System.Windows.Forms.Label PassWorldError;
    }
}

