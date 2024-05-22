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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RecrutCentr
{
    public partial class CompanyResume : Form
    {
        DataBase dataBase = new DataBase();
        public CompanyResume()
        {
            InitializeComponent();
        }
        private void CompanyResume_Load(object sender, EventArgs e)
        {
            VacNAmetextBox1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel3.Visible = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // инсерт в компани
            var CompName = CompanyNAmetextBox.Text;
            var CityCom = CompCitytextBox2.Text;



            try
            {
                if (string.IsNullOrEmpty(CompName) || string.IsNullOrEmpty(CityCom))
                {
                    throw new Exception("Все поля должны быть заполнены.");
                }


                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                var q = $"Select Id, NameCom, City from Company where NameCom = '{CompName}' ";
                SqlCommand command = new SqlCommand(q, dataBase.getConnect());
                adapter.SelectCommand = command;
                adapter.Fill(table);



                dataBase.openConnect();
                if (table.Rows.Count == 0)
                {
                    string querystring = $"insert into Company(NameCom, City) values ('{CompName}','{CityCom}')";

                    SqlCommand commands = new SqlCommand(querystring, dataBase.getConnect());
                    adapter.SelectCommand = commands;
                    adapter.Fill(table);
                    panel1.Visible = false;
                    panel2.Visible = true;
                    button1.Visible = false;
                    button2.Visible = true;
                }
                else
                {
                    var changeQuery = $"update Company set NameCom = '{CompName}', City ='{CityCom}'";

                    var commandd = new SqlCommand(changeQuery, dataBase.getConnect());
                    commandd.ExecuteNonQuery();
                    panel1.Visible = false;
                    panel2.Visible = true;
                    button1.Visible = false;
                    button2.Visible = true;
                }

                dataBase.closeConnect();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible=false;
            panel2.Visible=false;

            button3.Visible=true;
            panel3.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            panel3.Visible=false;

            button4.Visible=true;
            panel4.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Vacan = VacNAmetextBox1.Text;
            var Vov = VacancytextBox1.Text;
            var ResText = richTextBox1.Text;

            try
            {
                if (string.IsNullOrEmpty(Vacan) || string.IsNullOrEmpty(Vov) || string.IsNullOrEmpty(ResText) )
                {
                    throw new Exception("Все поля должны быть заполнены.");
                }


                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                var q = $"Select id, Res_name, ResText, Vacancies from Company_Resume ";
                SqlCommand command = new SqlCommand(q, dataBase.getConnect());
                adapter.SelectCommand = command;
                adapter.Fill(table);


                dataBase.openConnect();
                if (table.Rows.Count == 0)
                {
                    var querystring = $"insert into Company_Resume(Res_name, ResText, Vacancies) values ('{Vacan}','{ResText}','{Vov}')";

                    SqlCommand commands = new SqlCommand(querystring, dataBase.getConnect());
                    adapter.SelectCommand = commands;
                    adapter.Fill(table);
                    Form1 Main_Form = new Form1();
                    Main_Form.Show();
                    this.Hide();

                }
                else
                {


                    var changeQuery = $"update Company_Resume set Res_name = '{Vacan}', ResText ='{ResText}', Vacancies ='{Vov}' ";

                    var commandd = new SqlCommand(changeQuery, dataBase.getConnect());
                    commandd.ExecuteNonQuery();
                    Form1 Main_Form = new Form1();
                    Main_Form.Show();
                    this.Hide();
                }
                dataBase.closeConnect();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                VacNAmetextBox1.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                VacNAmetextBox1.Text = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                VacNAmetextBox1.Text = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                VacNAmetextBox1.Text = radioButton4.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                VacNAmetextBox1.Text = radioButton5.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                VacNAmetextBox1.Text = radioButton6.Text;
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            Form1 Main_Form = new Form1();
            Main_Form.Show();
            this.Hide();
        }
    }
}
