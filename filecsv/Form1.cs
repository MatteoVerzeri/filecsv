using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace filecsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;

            // Read the file and display it line by line.  
            foreach (string nline in System.IO.File.ReadLines(@"./dati.csv"))
            {

                counter++;
            }

            MessageBox.Show(Convert.ToString(counter));
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;
        }

    }
}
