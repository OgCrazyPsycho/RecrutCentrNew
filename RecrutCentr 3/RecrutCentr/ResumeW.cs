using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RecrutCentr
{
    public partial class ResumeW : Form
    {
        DataBase dataBase = new DataBase();
        public ResumeW(string JobtextBox1, string Email_TextBox)
        {
            InitializeComponent();
            string querystring = $"select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Skills = '{JobtextBox1}'";



            label1.Text = JobtextBox1;
            EmailLabel.Text = Email_TextBox;
           

        }

        private void ResumeW_Load(object sender, EventArgs e)
        {
            EmailLabel.Visible = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var resName = label1.Text;
            var resText = richTextBox1.Text;
            try
            {


                if (string.IsNullOrEmpty(resText))
                {
                    throw new Exception("Поле должно быть заполнено.");
                }


                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string q = $"Select id, Res_name, ResText from Candidate_Resume where ResText = '{resText}' ";  // and password_user = '{password}'
                SqlCommand command = new SqlCommand(q, dataBase.getConnect());
                adapter.SelectCommand = command;
                adapter.Fill(table);


                dataBase.openConnect();
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такое резюме уже существует!");
                }
                else
                {
                    string querystring = $"insert into Candidate_Resume(Res_name, ResText) values ('{resName}','{resText}')";

                    SqlCommand commands = new SqlCommand(querystring, dataBase.getConnect());
                    adapter.SelectCommand = commands;
                    adapter.Fill(table);
                    MessageBox.Show("Резюме создано");
                    Form1 formm = new Form1();
                    formm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WorkerResume WorkerR = new WorkerResume(EmailLabel.Text);

            WorkerR.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
