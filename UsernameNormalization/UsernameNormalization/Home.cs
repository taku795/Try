using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UsernameNormalization
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnBuckToHome_Click(object sender, EventArgs e)
        {
            FormController.pageTransition(this, "G000",false);
        }

        private void btnEndApp_Click(object sender, EventArgs e)
        {
            FormController.pageTransition(this, "endApp", false);
        }

        private void NormalizeUsername_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            string pattern = "[^a-zb0-9_]?";
            string afterUsername = string.Empty;

            // 不要な文字がないか検証
            if (validation.exitUnnecessaryCharInUsername(BeforeUsernameNomalization.Text,pattern) == true)
            {
                AfterNorma.Text = ErrorMessage.getErrorMessage(ErrorCode.InvalidCharacters);
                return;
            }

            // アンダースコアの処理
            afterUsername = validation.doFormatUsername(BeforeUsernameNomalization.Text);

            // 文字数検証
            if (!(3 <= afterUsername.Length && afterUsername.Length <= 15))
            {
                AfterNorma.Text = ErrorMessage.getErrorMessage(ErrorCode.InvalidLength);
                return;
            }

            AfterNorma.Text = afterUsername;
        }
    }
}
