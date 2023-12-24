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
    public partial class Form4 : Form
    {
        public TransactionManagerTeach transactionManagerTeach;
        public double jsonTeachSum { get; set; }
        public string jsonTeaachStudent { get; set; }
        public double Balance { get; set; }
        public double BalanceForm { get; set; }
        public string jsonTeaachStudentName { get; set; }
        public string jsonTeaachStudentSurname { get; set; }
        public string jsonTeaachStudentLastname { get; set; }
        public string jsonTeaachStudentEducational { get; set; }
        public string jsonTeaachStudentCourseOfStudy { get; set; }
        public string jsonTeaachStudentSpeciality { get; set; }
        public string SummaSplat { get; set; }
        public string jsonTeaachStudentFormEducation { get; set; }
        public string Cardnumber { get; set; }
        public string CVV { get; set; }
        
        public string SomeData { get; set; }
        private Form1 form1;
        public Form4()
        {
            InitializeComponent();
            

        }
        public Form4(double jsonTeachSum, double BalanceForm, string jsonTeaachStudentName, string jsonTeaachStudentLastname, string jsonTeaachStudentSurname, string jsonTeaachStudentEducational, string jsonTeaachStudentCourseOfStudy, string jsonTeaachStudentSpeciality, string jsonTeaachStudentFormEducation, string Cardnumber, string CVV)
        {
            InitializeComponent();
            this.jsonTeachSum = jsonTeachSum;
            this.BalanceForm = BalanceForm;
            this.jsonTeaachStudentName= jsonTeaachStudentName;
            this.jsonTeaachStudentLastname = jsonTeaachStudentLastname;
            this.jsonTeaachStudentSurname = jsonTeaachStudentSurname;
            this.jsonTeaachStudentEducational = jsonTeaachStudentEducational;
            this.jsonTeaachStudentCourseOfStudy = jsonTeaachStudentCourseOfStudy;
            this.jsonTeaachStudentSpeciality = jsonTeaachStudentSpeciality;
            this.jsonTeaachStudentFormEducation = jsonTeaachStudentFormEducation;
            this.Cardnumber = Cardnumber;
            this.CVV = CVV;
            transactionManagerTeach = new TransactionManagerTeach(BalanceOfCard, Convert.ToDouble(BalanceForm), ChoiceOfCard);
        }

        string[] lines2 = System.IO.File.ReadAllLines(@"teach.txt");
     
  

        private void Form4_Load(object sender, EventArgs e)
        {
    
            BalanceOfCard.Text = BalanceForm.ToString();
   
            
                NumberOfCard.Text = Cardnumber;
            CvvOfCard.Text = "CVV";
            ChoiceOfCard.Items.Add(SomeData);

            string labelText = $"Имя: {jsonTeaachStudentName}\nФамилия: {jsonTeaachStudentLastname}\nОтчество: {jsonTeaachStudentSurname}\nЗаклад: {jsonTeaachStudentEducational}\nКурс навчання: {jsonTeaachStudentCourseOfStudy}\nСпеціальність: {jsonTeaachStudentSpeciality}\n:Форма навчання: {jsonTeaachStudentFormEducation}\n:Сумма сплати: {jsonTeachSum}";

            DateOfSufent.Text = labelText;



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

            transactionManagerTeach.ProcessTransaction(jsonTeachSum);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BackToMain_Click(object sender, EventArgs e)
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
    public class TransactionManagerTeach
    {

        private Label label;
        public string SummaSplat { get; set; }
        private double balance;
        private ComboBox comboBox;

        public TransactionManagerTeach(Label label, double balance, ComboBox comboBox)
        {
            this.label = label;
        
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
                string newTransaction = "Сплата за навчання " + amount.ToString();
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
