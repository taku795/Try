using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsernameNormalization
{
    public partial class FormController : Form
    {
        private Dictionary<string, Type> formMapp;

        public FormController()
        {
            formMapp = new Dictionary<string, Type>
            {
                { "G000", typeof(Login) },
                { "G001", typeof(Home) },
            };
        }

        public static void pageTransition(Form formFrom, string formCdTo ,bool fromVisible)
        {
            // endApp：アプリ終了の合図
            if (formCdTo == "endApp")
            {
                Application.Exit();
            }

            // staticで同クラス内メソッドを呼び出すため
            FormController formController = new FormController();
            // 遷移元表示非表示選択
            formFrom.Visible = fromVisible;
            // マッピングされている画面を文字列指定し画面遷移
            formController.ShowForm(formCdTo);
        }

        private void ShowForm(string formCode)
        {
            if (formMapp.TryGetValue(formCode, out Type formType))
            {
                // 指定されたフォームをインスタンス化して表示
                Form form = (Form)Activator.CreateInstance(formType);
                form.Show();
            }
            else
            {
                MessageBox.Show("指定されたコードのフォームが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
