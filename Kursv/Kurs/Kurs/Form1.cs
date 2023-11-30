using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kurs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
 

                InitializeComponent();
            using (System.IO.StreamWriter file = new
           System.IO.StreamWriter(@"Balance.txt", true)) ;
            string[] lines = System.IO.File.ReadAllLines(@"Balance.txt");

            using (System.IO.StreamWriter file1 = new
       System.IO.StreamWriter(@"history.txt", true)) ;
            string[] lines1 = System.IO.File.ReadAllLines(@"history.txt");

        }
        string[] lines = System.IO.File.ReadAllLines(@"Balance.txt");
        string[] lines1 = System.IO.File.ReadAllLines(@"history.txt");
        Form3 form3 = new Form3();
        Form2 form2 = new Form2();
        Form4 form4 = new Form4();

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = lines[lines.Length - 1];

            label3.Text = "1234 5678 9101 1121";
            label2.Text = "CVV";


            listBox1.Items.Add("вітаю");
            if (listBox1.Items.Count > 0)
            {

                for (int i = 1; i <= lines1.Length; i++)
                {
                    listBox1.Items.Insert(0, lines1[lines1.Length - i]);
                }
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            form4.SomeData = label3.Text;
            form4.Show();
            this.Hide();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            form2.SomeData = label3.Text;
            form2.Show();
            this.Hide();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            form3.SomeData = label3.Text;
            form3.Show();
            this.Hide();
    
 


        }

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CVV")
                label2.Text = "123";
            else
                label2.Text = "CVV";
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

 
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
