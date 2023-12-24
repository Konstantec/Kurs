﻿using System;
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
    public partial class Form3 : Form
    {

        private TransactionManagerCard transactionManagerCard;


        private Form1 form1;
        public string SomeData { get; set; }
        public double BalanceForm { get; set; }
        public string Cardnumber { get; set; }
        public string CVV { get; set; }
        public Form3()
        {
            InitializeComponent();



        }
        public Form3(double BalanceForm,string Cardnumber,string CVV)
        {

            InitializeComponent();
            this.BalanceForm = BalanceForm;
            BalanceOfCard.Text = BalanceForm.ToString();
            transactionManagerCard = new TransactionManagerCard(BalanceOfCard, ChoiceOfNumber, Convert.ToDouble(BalanceForm), ChoiceOfCard);
            this.Cardnumber = Cardnumber;
            this.CVV= CVV;
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            
            ChoiceOfCard.Items.Add(SomeData);

            BalanceOfCard.Text = BalanceForm.ToString();

            NumberOfCard.Text = Cardnumber;
            CvvOfCard.Text = CVV;




        }



   


        private void CvvCard_Click(object sender, EventArgs e)
        {
            if (CvvOfCard.Text == "CVV")
                CvvOfCard.Text = CVV;
            else
                CvvOfCard.Text = "CVV";
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ChoiceOfMoney.Text, out double result1))
            {
                transactionManagerCard.ProcessTransaction(result1);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }



        private void ChoiceOfCard_Click(object sender, EventArgs e)
        {
            if (ChoiceOfCard.SelectedIndex == -1)
                ChoiceOfCard.SelectedIndex = 0;
        }
    }
    public class TransactionManagerCard
    {
        private Label label;
        private TextBox textBox2;
        private double balance;
        private ComboBox comboBox;

        public TransactionManagerCard(Label label, TextBox textBox3, double balance, ComboBox comboBox)
        {

            this.label = label;
            this.textBox2 = textBox3;
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

                if (textBox2.Text.Length != 16)
                {
                    throw new InvalidOperationException("Ошибка, неверный номер Карты.");
                }

                if (comboBox.SelectedIndex == -1)
                {
                    throw new InvalidOperationException("Не выбрана карта отправителя.");
                }

                balance -= amount;

                MessageBox.Show("Операция прошла успешно");

                string existingJsonContent = File.ReadAllText("History.json");

                // Десериализация JSON-строки в объект JsonContainer
                JsonHistory jsonContainer = JsonConvert.DeserializeObject<JsonHistory>(existingJsonContent);

                // Создание новой транзакции и добавление в список
                string newTransaction = "Переказ на картку " + amount.ToString();
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
