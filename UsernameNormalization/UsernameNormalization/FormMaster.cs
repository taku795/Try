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
    public partial class FormMaster : Form
    {
        private Dictionary<string, Type> formMapp;

        public FormMaster()
        {
            formMapp = new Dictionary<string, Type>
            {
                { "G000", typeof(Login) },
                { "G001", typeof(Home) },
            };
        }

        public void ShowForm(string formCode)
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
