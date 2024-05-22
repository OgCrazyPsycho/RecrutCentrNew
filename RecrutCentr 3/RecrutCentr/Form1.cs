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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecrutCentr
{
    public partial class Form1 : Form
    {
        DataBase data = new DataBase();


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegComany Form_regComany = new RegComany();
            Form_regComany.Show();
            this.Hide();
        }

        private void CreateResButton_Click(object sender, EventArgs e)
        { 
            CandidateRegister Form_candidateRegister = new CandidateRegister();
            Form_candidateRegister.Show();
            this.Hide();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            LoginForm rgp = new LoginForm();
            rgp.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginForm rgp = new LoginForm();
            rgp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void CreateColumns1()
        {
            dataGridView1.Columns.Add("Vacancies", "");
           
           // dataGridView3forCand.Columns.Add("name_user", "Имя");//1
        }

        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0));
        }

        private void RefreshDataGrid1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qS = $"select * from vacFE";

            SqlCommand command = new SqlCommand(qS, data.getConnect());

            data.openConnect();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns1();
            RefreshDataGrid1(dataGridView1);

            dataGridView1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridView1.Visible = true; // Показываем dataGridView
                Search(dataGridView1);
            }
            else
            {
                dataGridView1.Visible = false; // Скрываем dataGridView
            }
            
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from vacFE where (Vacancies) like '%" + textBox1.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, data.getConnect());

            data.openConnect();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow1(dgw, read);
            }
            read.Close();
        }
    }
}
