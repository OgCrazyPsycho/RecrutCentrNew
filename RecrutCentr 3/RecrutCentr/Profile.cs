using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecrutCentr
{
    
    public partial class Profile : Form
    {
        DataBase data = new DataBase();

        
        public Profile(string EmailtextBox) : this()
        {
            string querystring = $"select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Email_user = '{EmailtextBox}'";


            using (SqlConnection connection = data.getConnect())
            {
                connection.Open();

                //string query = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(querystring, connection);



                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        //string userRole = reader["Role_"].ToString();
                        var userRole = reader["Role_"].ToString();
                      
                        var userName = reader["name_user"].ToString();
                        var userFam = reader["Familia_user"].ToString();
                        var userOtch = reader["Otchestvo_user"].ToString();
                        var Phone_ = reader["phone"].ToString();

                        EmailLabel.Text = EmailtextBox;
                        RoleLabel.Text = userRole; //+ " " + userName + " " + userFam + " " + userOtch + " ";
                        NameLabel.Text = userName;
                        FamLabel.Text = userFam;
                        OtchLabel.Text = userOtch;
                        PhoneLabel.Text = Phone_;

                    }

                }
                data.closeConnect();

            }
        }

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            


            if (RoleLabel.Text == "Работник")
            {
                CreateResumeWorker.Visible = true;

                
            }
            else 
            {
                CreateResumeWorker.Visible = false;

                
            }

            if(RoleLabel.Text == "Работадатель") 
            { 
                CreateResumeCompany.Visible = true;

                
            }
            else
            {
                CreateResumeCompany.Visible= false;

                
            }

            
        }

        private void Userrole_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main_Form = new Form1();
            Main_Form.Show();
            this.Close();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if(panel1.Visible ) 
            { 
                panel1.Hide();
            }
            else
            { 
                panel1.Show(); 
            }
        }

        private void CreateResumeCompany_Click(object sender, EventArgs e)
        {
            CompanyResume companyR = new CompanyResume();
            companyR.Show();
            this.Close();
        }

        private void CreateResumeWorker_Click(object sender, EventArgs e)
        {
            WorkerResume WorkerR = new WorkerResume(EmailLabel.Text);
            
            WorkerR.Show();
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewVacs Vacans = new ViewVacs(RoleLabel.Text, EmailLabel.Text);
            Vacans.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Main_Form = new Form1();
            Main_Form.Show();
            this.Close();
        }

        private void AppExitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rolllabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView2forComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
