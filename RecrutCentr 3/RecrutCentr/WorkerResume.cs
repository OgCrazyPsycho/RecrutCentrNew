using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecrutCentr
{
    public partial class WorkerResume : Form
    {
        DataBase dataBase = new DataBase();
       
        public WorkerResume(string EmailLabel) 
        {
            InitializeComponent();
            string querystring = $"select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Email_user = '{EmailLabel}'";


           
            Email_TextBox.Text = EmailLabel;
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            panel2.Visible = false;
            panel3.Visible = false;

            ContinueButton1.Visible = true;
            ContinueButton2.Visible = false;
            ContinueButton3.Visible = false;
            //короче при нажатии на эту кнопку скрывает все панели и показывает самую 1-ю
            //так же кнопка должна быть disable если отображена 1-я панель
        }

        private void DayBtextBox_MouseEnter(object sender, EventArgs e)
        {
            if (DayBtextBox.Text == "День")
            {
                DayBtextBox.Text = "";
                DayBtextBox.ForeColor = Color.Black;
            }
        }

        private void DayBtextBox_MouseLeave(object sender, EventArgs e)
        {
            if (DayBtextBox.Text == "")
            {
                DayBtextBox.Text = "День";
                DayBtextBox.ForeColor = Color.Gray;
            }
        }

        private void DayBtextBox_Enter(object sender, EventArgs e)
        {
            if (YearBtextBox.Text == "Год")
            {
                YearBtextBox.Text = "";
                YearBtextBox.ForeColor = Color.Black;
            }
        }

        private void YearBtextBox_Leave(object sender, EventArgs e)
        {
            if (YearBtextBox.Text == "")
            {
                YearBtextBox.Text = "Год";
                YearBtextBox.ForeColor = Color.Gray;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                EducationTextBox.Text = radioButton1.Text;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton2.Checked)
            {
                EducationTextBox.Text = radioButton2.Text;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                EducationTextBox.Text = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                EducationTextBox.Text = radioButton4.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                EducationTextBox.Text = radioButton5.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                EducationTextBox.Text = radioButton6.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                EducationTextBox.Text = radioButton7.Text;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                EducationTextBox.Text = radioButton8.Text;
            }
        }


        private void WorkerResume_Load(object sender, EventArgs e)
        { 
                panel2.Visible = false;
                panel3.Visible = false;

            ContinueButton2.Visible = false;
            ContinueButton3.Visible = false;

            Email_TextBox.Visible = false;
            EducationTextBox.Visible = false;
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ContinueButton2.Visible = false;

            panel3.Visible = true;
            ContinueButton3.Visible = true;
        }

        private void ContinueButton1_Click(object sender, EventArgs e)
        {
                panel1.Visible = false;
                panel2.Visible = true;
                ContinueButton1.Visible = false;
                ContinueButton2.Visible = true;


           
        }

        private void ContinueButton3_Click(object sender, EventArgs e) // //()
        {
            var Job = JobtextBox1.Text;
            var Gender = GendercomboBox1.Text;
            var City = CityTextBox.Text;
            var DayB = DayBtextBox.Text;
            var MonthB = MonthBcomboBox.Text;
            var Yearb = YearBtextBox.Text;
            var Educ = EducationTextBox.Text;

            var UserEmail_ = Email_TextBox.Text;

            try
            {
                if (string.IsNullOrEmpty(Job) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(DayB) || string.IsNullOrEmpty(MonthB) || string.IsNullOrEmpty(Yearb))
                {
                    throw new Exception("Все поля должны быть заполнены.");
                }


                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                var q = $"Select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, Age, Gender, City, education_level, WorkExp from Users where Email_user = '{UserEmail_}' ";
                SqlCommand command = new SqlCommand(q, dataBase.getConnect());
                adapter.SelectCommand = command;
                adapter.Fill(table);


                dataBase.openConnect();
                if (table.Rows.Count == 0)
                {
                    var querystring = $"insert into Users(Skills, Age, Gender, City, education_level) values ('{Job}', '{DayB + " " + MonthB + " " + Yearb + " Года"}','{Gender}','{City}', {Educ})";

                    SqlCommand commands = new SqlCommand(querystring, dataBase.getConnect());
                    adapter.SelectCommand = commands;
                    adapter.Fill(table);
                    ResumeW resWorker = new ResumeW(JobtextBox1.Text, Email_TextBox.Text);
                    this.Close();
                    resWorker.Show();

                }
                else
                {


                    var changeQuery = $"update Users set Skills = '{Job}', Age = '{DayB + " " + MonthB + " " + Yearb + " Года"}', Gender ='{Gender}', City ='{City}', education_level ='{Educ}' ";

                    var commandd = new SqlCommand(changeQuery, dataBase.getConnect());
                    commandd.ExecuteNonQuery();
                    ResumeW resWorker = new ResumeW(JobtextBox1.Text, Email_TextBox.Text);
                    this.Close();
                    resWorker.Show();
                }
                dataBase.closeConnect();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Skill = JobtextBox1.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Skills = '{Skill}' ";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnect());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            if (table.Rows.Count <= 1)
            {
               // MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResumeW ResW = new ResumeW(JobtextBox1.Text, Email_TextBox.Text);
                this.Close();
                ResW.ShowDialog();
                //frm1.Show();

            }
            else
            {
                MessageBox.Show("Резюме отсутствует", "У вас нет резюме!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main_Form = new Form1();
            Main_Form.Show();
            this.Hide();
        }

        private void AppExitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rolllabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

