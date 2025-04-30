using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porquiado_Information_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Book_1.xlsx");

            Worksheet sheet = book.Worksheets[0];
            bool log = false ;
            int row = sheet.Rows.Length;

            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, 10].Value == txtUsername.Text && sheet.Range[i, 11].Value == txtPassword.Text)
                {
                    log = true;
                    break;
                }
                else
                {
                    log = false;
                }
            }
            if (log == true)
            {
                DialogResult result = MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Form2 form = new Form2();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
