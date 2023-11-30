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

namespace Kurs
{
    public partial class Form2 : Form
    {
        double a, b;
        private Form1 form1;
        public Form2()
        {
            InitializeComponent();
            using (System.IO.StreamWriter file = new
       System.IO.StreamWriter(@"Balance.txt", true)) ;
            string[] lines = System.IO.File.ReadAllLines(@"Balance.txt");


            using (System.IO.StreamWriter file1 = new
       System.IO.StreamWriter(@"Balance.txt", true)) ;
            string[] lines1 = System.IO.File.ReadAllLines(@"history.txt");
        }
        string[] lines = System.IO.File.ReadAllLines(@"Balance.txt");
        string[] lines1 = System.IO.File.ReadAllLines(@"history.txt");
        public string SomeData { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(SomeData);
            label1.Text = lines[lines.Length - 1];
            textBox3.Text = "+380";
            label3.Text = "1234 5678 9101 1121";
            label2.Text = "CVV";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double result1))
            {

                a = result1;// сумма введена 
                
            }

            if (double.TryParse(label1.Text, out double result2))
            {
                if (result2 >= 0)
                {


                    b = result2; // баланс
                    
                }
            }

            double c = result2;
            try
            {
                if (a < b && textBox3.Text.Length == 13 && a > 0 && comboBox1.SelectedIndex != -1)
                {
                    c = b - a;
                        MessageBox.Show("Операція пройшла успішно");

                        string filePath = @"history.txt";

                        // Прочитать существующий текст из файла
                        string existingText = File.ReadAllText(filePath);

                        // Добавить новый результат перед старым
                        string newText = "Поповнення Мобільного                        " + a.ToString() + Environment.NewLine + existingText;

                        // Записать обновленный текст в файл
                        File.WriteAllText(filePath, newText);

                
                }
                else
                    throw new InvalidOperationException ();
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
            catch (InvalidOperationException ex3) when (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("необрана картка відправника");
                c = result2;
            }
            catch (InvalidOperationException ex2) when (textBox2.Text.Length != 13)
            {

                MessageBox.Show("помилка, неіснючий номер тлефону");

            }
  
            catch (InvalidOperationException ex4)
            {

                MessageBox.Show("загальна помилка");

            }

            File.WriteAllText(@"Balance.txt", label1.Text);

            label1.Text = c.ToString();
            lines[lines.Length - 1] = label1.Text;
            File.WriteAllText(@"Balance.txt", label1.Text);

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            if (label2.Text == "CVV")
                label2.Text = "123";
            else
                label2.Text = "CVV";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

    }
}
