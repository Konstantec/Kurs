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
using Newtonsoft.Json;

namespace Kurs
{
    public partial class Form2 : Form
    {
        private TransactionManager transactionManager;

        public double Balance { get; set; }
        public double BalanceForm { get; set; }
        public string Cardnumber { get; set; }
        public string CVV { get; set; }
        private Form1 form1;
        public Form2()

        {
            InitializeComponent();
        }
            public Form2(double BalanceForm, string Cardnumber, string CVV)

        {
            InitializeComponent();

            this.BalanceForm = BalanceForm;

            BalanceOfCard.Text = BalanceForm.ToString();
            transactionManager = new TransactionManager(BalanceOfCard, ChoiceOfCard2, Convert.ToDouble(BalanceForm), ChoiceOfCard);
            this.Cardnumber = Cardnumber;
            this.CVV = CVV;

        }
  
        public string SomeData { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            ChoiceOfCard.Items.Add(SomeData);
 
            ChoiceOfCard2.Text = "+380";
            NumberOfCard.Text = Cardnumber;
            CvvOfCard.Text ="CVV";
    
        }

    




    

        private void Continue_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ChoiceOfMoney.Text, out double result1))
            {
                transactionManager.ProcessTransaction(result1);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void CvvCard_click(object sender, EventArgs e)
        {
            if (CvvOfCard.Text == "CVV")
                CvvOfCard.Text = CVV;
            else
                CvvOfCard.Text = "CVV";
        }

        private void ChoiceOfCard_Click(object sender, EventArgs e)
        {
            if (ChoiceOfCard.SelectedIndex == -1)
                ChoiceOfCard.SelectedIndex = 0;
        }
    }
    public class TransactionManager
    {
        private Label label;
        private TextBox textBox3;
        private double balance;
        private ComboBox comboBox;

        public double Balance { get; set; }

        public TransactionManager(Label label, TextBox textBox3, double balance, ComboBox comboBox)
        {
            this.label = label;
            this.textBox3 = textBox3;
            this.balance = balance;
            this.comboBox = comboBox; 
        }

        public void ProcessTransaction(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new InvalidOperationException("Недопустимая сумма.");
                }

                if (amount > balance)
                {
                    throw new InvalidOperationException("Недостаточно средств на счету.");
                }

                if (textBox3.Text.Length != 13)
                {
                    throw new InvalidOperationException("Ошибка, неверный номер телефона.");
                }

                if (comboBox.SelectedIndex == -1)
                {
                    throw new InvalidOperationException("Не выбрана карта отправителя.");
                }

                balance -= amount;

                MessageBox.Show("Операція пройшла успішно");
                string existingJsonContent = File.ReadAllText("History.json");

                // Десериализация JSON-строки в объект JsonContainer
                JsonHistory jsonContainer = JsonConvert.DeserializeObject<JsonHistory>(existingJsonContent);

                // Создание новой транзакции и добавление в список
                string newTransaction = "поповнення мобільного " + amount.ToString();
                jsonContainer.History.Insert(0, newTransaction);
                jsonContainer.History.Add(newTransaction);
                string updatedJsonContent = JsonConvert.SerializeObject(jsonContainer, Formatting.Indented);
                // Сериализация обновленного объекта в JSON-строку
        

                // Запись JSON-строки обратно в файл "History.json"
                File.WriteAllText("History.json", updatedJsonContent);
            }   

            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }



            JsonBalance jsonBalance = new JsonBalance { Balance = balance };

            string jsonBalanceContent = JsonConvert.SerializeObject(jsonBalance, Formatting.Indented);

            File.WriteAllText("Balance.json", jsonBalanceContent);
            
        }
    }

}
