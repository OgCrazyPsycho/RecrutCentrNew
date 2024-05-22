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

namespace RecrutCentr
{
    public partial class CandidateRegister : Form
    {
        DataBase dataBase = new DataBase();
        public CandidateRegister()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main_Form = new Form1();
            Main_Form.Show();
            this.Hide();
        }

        private void CandidateRegister_Load(object sender, EventArgs e)
        {
            EmailtextBox.MaxLength = 35;
            PasswordtextBox.MaxLength = 40;
            NametextBox.MaxLength = 18;
            FamiliatextBox.MaxLength = 20;
            OtchestvotextBox.MaxLength = 25;
            PhonetextBox.MaxLength = 11;
            
           
        }

        private void SingUPbutton_Click(object sender, EventArgs e)
        {
            var login = EmailtextBox.Text;
            var password = PasswordtextBox.Text;
            var nameUser = NametextBox.Text;
            var Familia = FamiliatextBox.Text;
            var Otchestvo = OtchestvotextBox.Text;
            var Phone = PhonetextBox.Text;
            try
            {
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nameUser) || string.IsNullOrEmpty(Familia) || string.IsNullOrEmpty(Otchestvo) || string.IsNullOrEmpty(Phone))
                {
                    throw new Exception("Все поля должны быть заполнены.");
                }

                if (!login.Contains("@"))
                {
                    throw new Exception("Email должен содержать символ '@'");
                }

                if (!IsNumeric(Phone))
                {
                    throw new Exception("Номер телефона должен содержать только цифры.");
                }

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string q = $"Select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Email_user = '{login}' ";  // and password_user = '{password}'
                SqlCommand command = new SqlCommand(q, dataBase.getConnect());
                adapter.SelectCommand = command;
                adapter.Fill(table);


                dataBase.openConnect();
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такой пользователь есть!!");
                }
                else
                {
                    string querystring = $"insert into Users(name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_) values ('{nameUser}','{Familia}','{Otchestvo}','{login}','{password}','{Phone}','Работник')";

                    SqlCommand commands = new SqlCommand(querystring, dataBase.getConnect());
                    adapter.SelectCommand = commands;
                    adapter.Fill(table);
                    MessageBox.Show("Аккаунт создан");
                    LoginForm rgp = new LoginForm();
                    rgp.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm rgp = new LoginForm();
            rgp.Show();
            this.Close();
        }

        private void JobtextBox_TextChanged(object sender, EventArgs e)
        {

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
