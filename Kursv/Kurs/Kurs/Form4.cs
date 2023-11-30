using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
namespace Kurs
{
    public partial class Form4 : Form
    {
        double a, b;
        string sum;
        private Form1 form1;
        public Form4()
        {
            InitializeComponent();
            using (System.IO.StreamWriter file = new
System.IO.StreamWriter(@"Balance.txt", true)) ;
            string[] lines = System.IO.File.ReadAllLines(@"Balance.txt");


            using (System.IO.StreamWriter file1 = new
       System.IO.StreamWriter(@"history.txt", true)) ;
            string[] lines1 = System.IO.File.ReadAllLines(@"history.txt");
            using (System.IO.StreamWriter file1 = new
    System.IO.StreamWriter(@"teach.txt", true)) ;
            string[] lines2 = System.IO.File.ReadAllLines(@"teach.txt");

        }
        string[] lines = System.IO.File.ReadAllLines(@"Balance.txt");
        string[] lines1 = System.IO.File.ReadAllLines(@"history.txt");
        string[] lines2 = System.IO.File.ReadAllLines(@"teach.txt");
        public string SomeData { get; set; }
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = lines[lines.Length - 1];

            label3.Text = "1234 5678 9101 1121";
            label2.Text = "CVV";

            comboBox1.Items.Add(SomeData);
            string filePath = @"teach.txt";

                string line = File.ReadAllText(filePath);
                label4.Text = line;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CVV")
                label2.Text = "123";
            else
                label2.Text = "CVV";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePath = @"teach.txt";
            for (int i = 0; i <= 6; i++)
            {
                string[] line = File.ReadAllLines(filePath);

                if (i == 6 && line != null)
                    {
                
                   sum = line[i];
                }
                
                
            }
            if (double.TryParse(sum, out double result1))
            {

                a = result1;
            }

            if (double.TryParse(label1.Text, out double result2))
            {
                if (result2 >= 0)
                {


                    b = result2;

                }
            }
            double c = result2;

            try
            {
                if (a < b && a > 0&& comboBox1.SelectedIndex != -1)
                {

                    c = b - a;
                    MessageBox.Show("Операція пройшла успішно");

                    string filePath1 = @"history.txt";

                    // Прочитать существующий текст из файла
                    string existingText = File.ReadAllText(filePath1);

                    // Добавить новый результат перед старым
                    string newText = "Переказ                                                          " + a.ToString() + Environment.NewLine + existingText;

                    // Записать обновленный текст в файл
                    File.WriteAllText(filePath1, newText);





                }

                else
                    throw new InvalidOperationException();
            }
            catch (InvalidOperationException ex) when (a <= 0)
            {
                MessageBox.Show("недопустиме значення ");
                c = result2;
            }
            catch (InvalidOperationException ex1) when (a > b)
            {
                MessageBox.Show("недостатньо коштів на картці");
                c = result2;
            }
            catch (InvalidOperationException ex2) when (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("необрана картка відправнкиа");
                c = result2;
            }
  
            catch (InvalidOperationException ex3)
            {

                MessageBox.Show("Загальна помилка");

            }
   
            File.WriteAllText(@"Balance.txt", label1.Text);

            label1.Text = c.ToString();
            lines[lines.Length - 1] = label1.Text;
            File.WriteAllText(@"Balance.txt", label1.Text);

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
