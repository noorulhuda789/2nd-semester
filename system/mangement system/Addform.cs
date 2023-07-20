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
using Buiness.Bl;
namespace mangement_system
{
    public partial class Addform : Form
    {
        public Addform()
        {
            
            
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\system\\city.txt";
            CityDL.readData(ref path);
            MessageBox.Show(CityDL.cities.Count.ToString());
            InitializeComponent();
            LoadCitiesIntoCombo1();
            LoadCitiesIntoCombo2();
            LoadCitiesIntoCombo3();

        }

        private void Addform_Load(object sender, EventArgs e)
        {

        }



        private void LoadCitiesIntoCombo1()
        {
            foreach(var obj in CityDL.cities)
            {
                comboBox1.Items.Add(obj.getDeparture());
               
                
            }
        }
        private void LoadCitiesIntoCombo2()
        {
            foreach (var obj in CityDL.cities)
            {
                comboBox3.Items.Add(obj.getArrival());


            }
        }
        private void LoadCitiesIntoCombo3()
        {
            foreach (var obj in CityDL.cities)
            {
                comboBox2.Items.Add(obj.getCode());


            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1 = comboBox1.Text;
            string n2 = comboBox3.Text;
            for(int i=0;i< CityDL.cities.Count;i++)
            {
                if(n1== CityDL.cities[i].getDeparture()&& n2 == CityDL.cities[i].getArrival())
                {
                    bill(CityDL.cities[i].getPrice());
                    break;
                }
            }
        }
        public void bill(string number)
        {
            string n1 = comboBox4.Text;
            int  bill = int.Parse(n1) *int.Parse( number);
        }

 
    }
}
