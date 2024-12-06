using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsernameNormalization
{
    public partial class Login : Form
    {
        private string STRING_USERNAME_ERROR = "入力してください";
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (existsInputMissing(UserName.Text, PassWord.Text) == true)
            {
                return;
            }

            // ユーザーIDとPWの検証
            if (canLogin(UserName.Text, PassWord.Text) == false) 
            {
                return;
            }

            // 画面遷移
            FormController.pageTransition(this, "G001",false);
        }

        private bool canLogin(string userName, string passWorld)
        {
            if (userName == "admin" && passWorld == "admin")
            {
                return true;
            }

            return false;
        }

        private bool existsInputMissing(string userName, string passWorld) 
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userName))
            {
                UserNameError.Text = STRING_USERNAME_ERROR;
                PassWorldError.Text = STRING_USERNAME_ERROR;
                return true;
            }
            return false;
        }
    }
}
