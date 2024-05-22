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
    public partial class LoginForm : Form
    {
        DataBase dataBase = new DataBase();
        public LoginForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main_Form = new Form1();
            Main_Form.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            EmailtextBox.MaxLength = 35;
            PasswordtextBox.MaxLength = 40;
        }

        private void LogINbutton_Click(object sender, EventArgs e)
        {
            var login = EmailtextBox.Text;
            var password = PasswordtextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Email_user = '{login}' and password_user = '{password}' ";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnect());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Profile menu = new Profile(EmailtextBox.Text);
                this.Close();
                menu.ShowDialog();
                //frm1.Show();

            }
            else
            {
                MessageBox.Show("Такой аккаунт отсутствует", "аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
