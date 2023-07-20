using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buiness.Dlofcustomer;
namespace mangement_system
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Addform f = new Addform();
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\system\\city.txt";
            CityDL.readData(ref path);
            MessageBox.Show(CityDL.cities.Count.ToString());
            f.Show();
            setpanel(f);
        }

        private void setpanel(Form form)
        {
            panel3.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form);
            panel3.Tag = form;
            form.BringToFront();
            form.Show();
        }


    }
}
