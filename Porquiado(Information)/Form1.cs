using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Porquiado_Information_
{
    public partial class Form1 : Form
    {

        string[] names = new string[5];
        string[] genders = new string[5];
        string[] hobbies = new string[5];
        string[] colors = new string[5];
        string[] sayings = new string[5];
        string[] address = new string[5];
        string[] email = new string[5];
        string[] birthday = new string[5];
        int[] age = new int[5];
        int i = 0;
        int selectedIndex = -1;



        public Form1()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }
        public void LoadData(int index,int age, string name, string gender, string hobby, string color, string saying,string address, string email, string birthday)
        {
            selectedIndex = index;
            txtname.Text = name;

            rdbmale.Checked = gender == "Male";
            rdbfemale.Checked = gender == "Female";

            chkbasketball.Checked = hobby.Contains("Basketball");
            chkvolleyball.Checked = hobby.Contains("Volleyball");
            chksoccer.Checked = hobby.Contains("Soccer");

            cmbFavColor.SelectedItem = color;
            txtsaying.Text = saying;

            btnadd.Visible = false;
            btnUpdate.Visible = true;

            txtAddress.Text = address;
            txtEmail.Text = email;
            txtBirthday.Text = birthday;

        }

        public void CheckEmpty(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        MessageBox.Show(c.Name + "Is Empty, Please use valid data input!");
                    }
                }
                else if (c is System.Windows.Forms.RadioButton)
                {
                    if (c.Text == "")
                    {
                        MessageBox.Show(c.Name + " \"Is Empty, Please use valid data input!");
                    }
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if (i < 5)
            {
                names[i] = txtname.Text;

                genders[i] = rdbmale.Checked ? "Male" : "Female";

                hobbies[i] = "";
                if (chkbasketball.Checked) hobbies[i] += "Basketball";
                if (chkvolleyball.Checked) hobbies[i] += "Volleyball";
                if (chksoccer.Checked) hobbies[i] += "Soccer";

                colors[i] = cmbFavColor.SelectedItem?.ToString() ?? "None";
                sayings[i] = txtsaying.Text;

                i++;

                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Too much data");
            }

            txtname.Text = string.Empty;
            rdbmale.Checked = false;
            rdbfemale.Checked = false;
            chkbasketball.Checked = false;
            chkvolleyball.Checked = false;
            chksoccer.Checked = false;
            cmbFavColor.Text = "";
            txtsaying.Text = string.Empty;

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, names, genders, hobbies, colors, sayings,address,email,birthday, i);
            form2.Show();
        }

        private void txtX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (selectedIndex >= 0 && selectedIndex < i)
            {
                names[selectedIndex] = txtname.Text;
                genders[selectedIndex] = rdbmale.Checked ? "Male" : "Female";

                hobbies[selectedIndex] = "";
                if (chkbasketball.Checked) hobbies[selectedIndex] += "Basketball ";
                if (chkvolleyball.Checked) hobbies[selectedIndex] += "Volleyball ";
                if (chksoccer.Checked) hobbies[selectedIndex] += "Soccer";
                hobbies[selectedIndex] = hobbies[selectedIndex].Trim();

                colors[selectedIndex] = cmbFavColor.SelectedItem?.ToString() ?? "None";
                sayings[selectedIndex] = txtsaying.Text;

                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Invalid selection");
            }

            txtname.Text = string.Empty;
            rdbmale.Checked = false;
            rdbfemale.Checked = false;
            chkbasketball.Checked = false;
            chkvolleyball.Checked = false;
            chksoccer.Checked = false;
            cmbFavColor.Text = "";
            txtsaying.Text = string.Empty;
        }

        internal void LoadData(int rowIndex, string name, string gender, string hobby, string color, string saying, string address, string email, string birthday)
        {
            throw new NotImplementedException();
        }
    }
}

