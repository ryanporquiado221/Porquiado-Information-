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
    public partial class Form2 : Form
    {
        private Form1 parentForm;
       

        public Form2(Form1 form1, string[] names, string[] genders, string[] hobbies, string[] colors, string[] sayings, string[] address, string[] email, string[] birthday, int count)
        {
            InitializeComponent();
            
            parentForm = form1;

            dtg1.Columns.Add("Name","Name");
            dtg1.Columns.Add("Gender", "Gender");
            dtg1.Columns.Add("Hobbies", "Hobbies");
            dtg1.Columns.Add("Favorite Color", "Favorite color");
            dtg1.Columns.Add("Saying", "Saying");
            dtg1.Columns.Add("address", "address");
            dtg1.Columns.Add("email", "email");
            dtg1.Columns.Add("birthday", "birthday");

            for (int i = 0; i < count; i++)
            {
                dtg1.Rows.Add(names[i], genders[i], hobbies[i], colors[i], sayings[i], address[i]);
            }
            
        }

        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();
        }
        public void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Book_1.xlsx");

            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dtg1.DataSource = dt;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dtg1.SelectedRows)
            {
                dtg1.Rows.Remove(r);      
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtg1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg1.Rows[e.RowIndex];

                string name = row.Cells[0].Value.ToString();
                string gender = row.Cells[1].Value.ToString();
                string hobby = row.Cells[2].Value.ToString();
                string color = row.Cells[3].Value.ToString();
                string saying = row.Cells[4].Value.ToString();
                string address = row.Cells[5].Value.ToString();
                string email = row.Cells[6].Value.ToString();
                string birthday = row.Cells[7].Value.ToString();

                parentForm.LoadData(e.RowIndex, name, gender, hobby, color, saying,address, email, birthday);
                parentForm.Show();
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtg1.ClearSelection();
            string searchValue = txtSearch.Text;
            dtg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dtg1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dtg1.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtSearch.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            
        }

    }
}
