﻿using System;
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
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // 画面遷移
            pageTransition(this, "G001");
        }

        private void pageTransition(Form formFrom, string formCdTo)
        {
            FormControler formMaster = new FormControler();

            // 遷移元非表示
            formFrom.Visible = false;

            // マッピングされている画面を文字列指定し画面遷移
            formMaster.ShowForm(formCdTo);
        }
    }
}
