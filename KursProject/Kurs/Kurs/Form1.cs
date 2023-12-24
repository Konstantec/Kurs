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
using Newtonsoft.Json;

namespace Kurs
{
    public partial class Form1 : Form
    {
 
        public double Balance { get; set; }
        public double BalanceForm { get; set; }
        public double SumOfPay { get; set; }
        public double History { get; set; }
        public string Educational { get; set; }
        public string CourseOfStudy { get; set; }
        public string Speciality { get; set; }
        public string FormEducation { get; set; }
        public double jsonTeachSum { get; set; }
        public string jsonTeaachStudentName { get; set; }
        public string jsonTeaachStudentSurname { get; set; }
        public string jsonTeaachStudentLastname { get; set; }
        public string jsonTeaachStudentEducational { get; set; }
        public string jsonTeaachStudentCourseOfStudy { get; set; }
        public string jsonTeaachStudentSpeciality { get; set; }

        public string jsonTeaachStudentFormEducation { get; set; }

        public string Cardnumber { get; set; }
        public string CVV { get; set; }
        public string DataEnd { get; set; }
        public Form1()
        {
 

                InitializeComponent();
     

        }

 



        Form3 form3 = new Form3();
        Form2 form2 = new Form2();
        Form4 form4 = new Form4();
      
        private void Form1_Load(object sender, EventArgs e)
        {
   
            string jsonContent = File.ReadAllText("Balance.json");
            JsonBalance jsonBalance = JsonConvert.DeserializeObject<JsonBalance>(jsonContent);
            BalanceForm = jsonBalance.Balance;
            BalanceOfCard.Text = jsonBalance.Balance.ToString();

            string jsonHistoryPath=File.ReadAllText("History.json");
            JsonHistory jsonHistory=JsonConvert.DeserializeObject<JsonHistory>(jsonHistoryPath);

            string jsonTeachPath = File.ReadAllText("Teach.json");
            JsonTeach  jsonTeach = JsonConvert.DeserializeObject<JsonTeach>(jsonTeachPath);

           


            jsonTeachSum = jsonTeach.SumOfPay;
            jsonTeaachStudentName= jsonTeach.Name;
            jsonTeaachStudentLastname = jsonTeach.Lastname;
            jsonTeaachStudentSurname = jsonTeach.Surname;
            jsonTeaachStudentEducational = jsonTeach.Educational;
            jsonTeaachStudentCourseOfStudy= jsonTeach.CourseOfStudy;
            jsonTeaachStudentSpeciality = jsonTeach.Speciality;

            jsonTeaachStudentFormEducation = jsonTeach.FormEducation;

            string jsonCardhPath = File.ReadAllText("CardData.json");
            JsonCard jsonCard = JsonConvert.DeserializeObject<JsonCard>(jsonCardhPath);
            Cardnumber = jsonCard.Cardnumber;
            CVV = jsonCard.CVV;
            DataEnd = jsonCard.DataEnd;
            form4 = new Form4(jsonTeachSum, BalanceForm, jsonTeaachStudentName, jsonTeaachStudentLastname, jsonTeaachStudentSurname, jsonTeaachStudentEducational, jsonTeaachStudentCourseOfStudy, jsonTeaachStudentSpeciality, jsonTeaachStudentFormEducation, Cardnumber, CVV);
           form2 = new Form2(BalanceForm, Cardnumber,  CVV);
          form3 = new Form3(BalanceForm, Cardnumber, CVV);

            NumberOfCard.Text = Cardnumber;
            CvvOfCard.Text = "CVV";


            foreach (string historyItem in jsonHistory.History)
            {
                HistoryOfCard.Items.Add(historyItem);
            }

        }

        


        private void TransferToCard_Click_1(object sender, EventArgs e)
        {
            form3.SomeData = NumberOfCard.Text;
            form3.Show();
            this.Hide();

        }

        private void TransfareToTeach_Click(object sender, EventArgs e)
        {
            form4.SomeData = NumberOfCard.Text;
            form4.Show();
            this.Hide();
        }

        private void TransferToMobile_Click(object sender, EventArgs e)
        {
            form2.SomeData = NumberOfCard.Text;
            form2.Show();
            this.Hide();
        }
    

 

        private void CvvCard_Click(object sender, EventArgs e)
        {
            if (CvvOfCard.Text == "CVV")
                CvvOfCard.Text = CVV;
            else
                CvvOfCard.Text = "CVV";
        }
    }
    public class JsonBalance
    {
        public double Balance { get; set; }
    }
    public class JsonHistory
    {
        public List<string> History { get; set; }
    }
    public class JsonTeach
    {

        public double SumOfPay { get; set; }

        public string Educational { get; set; }
        public string CourseOfStudy { get; set; }
        public string Speciality { get; set; }
        public string FormEducation { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
    }
    public class JsonCard
    {

        public string Cardnumber { get; set; }

        public string CVV { get; set; }
        public string DataEnd { get; set; }
    }

}
