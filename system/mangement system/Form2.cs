using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mangement_system.DL;
using mangement_system.BL;
using System.Windows.Forms;

namespace mangement_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\Buiness\\User.txt";
            UserDL.readData(path);
            string name = textBox1.Text;
            string password = textBox2.Text;
            BL.User user = new BL.User(name, password);
            bool reslut = UserDL.Check(name, password);
            if(reslut==true)
            {
                this.Hide();
                UserForm form = new UserForm();
                form.Show();
                //setpanel(form);
                
            }
            if (reslut == false)
            {
                MessageBox.Show("Invalid input");
            }
        }

    }
}
