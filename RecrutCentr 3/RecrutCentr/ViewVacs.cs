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
    enum RowState
    {
        Existed,
        Modified,
        New,
        ModifiedNew,
        Deleted
    }
    public partial class ViewVacs : Form
    {
        DataBase data = new DataBase();

        int selectedRow;

        private void CreateColumns1Comp()
        {
            dataGridView1forComp.Columns.Add("id", "id");
            dataGridView1forComp.Columns.Add("Res_name", "Профессия");
            dataGridView1forComp.Columns.Add("ResText", "Текст соискателя");
           // dataGridView1forComp.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRow1Comp(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void RefreshDataGrid1Comp(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qS = $"select * from Candidate_Resume";

            SqlCommand command = new SqlCommand(qS, data.getConnect());

            data.openConnect();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1Comp(dgw, reader);
            }
            reader.Close();

        }

        //sdsdasdasdasdadsasdadsasdasdasdasdasdfasfwqaefwegawmeeoagmiwioawegoa[iwegoip[gaweo[igewo[iweaiogaeo

        private void CreateColumns2Comp()
        {
            dataGridView2forComp.Columns.Add("id_User", "id Пользователя");//0
            dataGridView2forComp.Columns.Add("name_user", "Имя");//1
            dataGridView2forComp.Columns.Add("Familia_user", "Фамилия");//2
            dataGridView2forComp.Columns.Add("Otchestvo_user", "Отчество");//3
            dataGridView2forComp.Columns.Add("phone", "Телефон");//4
            dataGridView2forComp.Columns.Add("Skills", "Профессия");//5
            dataGridView2forComp.Columns.Add("Gender", "Пол");//6
            dataGridView2forComp.Columns.Add("City", "Город");//7
            dataGridView2forComp.Columns.Add("education_level", "Уровень образования");//8
            //dataGridView2forComp.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRow2Comp(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt64(6), record.GetString(8), record.GetString(10), record.GetString(11), record.GetString(12));  //, RowState.ModifiedNew

        }

        private void RefreshDataGrid2Comp(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qS = $"select * from Users WHERE Role_ = 'Работник'";

            SqlCommand command = new SqlCommand(qS, data.getConnect());

            data.openConnect();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2Comp(dgw, reader);
            }
            reader.Close();
        }

        //sssssssssssdddglkgklgiogigigigkgkgkgigjgjgjgjjrjrjfiuiffjfgifigfjfik
        private void CreateColumns1Cand()
        {
            dataGridView1forCand.Columns.Add("Id", "id Компании");//0
            dataGridView1forCand.Columns.Add("NameCom", "Название компании");//1
            dataGridView1forCand.Columns.Add("City", "Расположение компании");//2         
            //dataGridView1forCand.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRow1Cand(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void RefreshDataGrid1Cand(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qS = $"select * from Company";

            SqlCommand command = new SqlCommand(qS, data.getConnect());

            data.openConnect();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1Cand(dgw, reader);
            }
            reader.Close();
        }

        //sdfsfafmfsmifsimfsijfsijfsijfs
        private void CreateColumns2Cand()
        {
            dataGridView2forCand.Columns.Add("id", "id");//0
            dataGridView2forCand.Columns.Add("Res_name", "Тип компании");//1
            dataGridView2forCand.Columns.Add("Vacancies", "Доступная вакансия");//2
            //dataGridView2forCand.Columns.Add("IsNew", string.Empty);

        }

        private void ReadSingleRow2Cand(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void RefreshDataGrid2Cand(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qS = $"select * from Company_Resume";

            SqlCommand command = new SqlCommand(qS, data.getConnect());

            data.openConnect();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2Cand(dgw, reader);
            }
            reader.Close();
        }
        //ывывыыыыывывывывы
        private void CreateColumns3Cand()
        {
            dataGridView3forCand.Columns.Add("id_User", "id Пользователя");//0
            dataGridView3forCand.Columns.Add("name_user", "Имя");//1
            dataGridView3forCand.Columns.Add("Familia_user", "Фамилия");//2
            dataGridView3forCand.Columns.Add("Otchestvo_user", "Отчество");//3
            dataGridView3forCand.Columns.Add("phone", "Телефон");//4  
           // dataGridView3forCand.Columns.Add("IsNew", string.Empty);


        }

        private void ReadSingleRow3Cand(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt64(6));
            //record.GetInt32(4)
        }

        private void RefreshDataGrid3Cand(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string qS = $"select * from Users WHERE Role_ = 'Работадатель'";

            SqlCommand command = new SqlCommand(qS, data.getConnect());

            data.openConnect();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow3Cand(dgw, reader);
            }
            reader.Close();
        }
        //ssdsdsddsssdsdsdsdsdsddssgdgdsasdgsasdggadgadagdsasgd
        public ViewVacs(string RoleLabeL, string Email)
        {
            InitializeComponent();
            string querystring = $"select id_User, name_user, Familia_user, Otchestvo_user, Email_user, password_user, phone, Role_, Skills, WorkExp from Users where Email_user = '{Email}'";
            RoleLabel.Text = RoleLabeL;
            EmailLabel.Text = Email;
            
        }

        private void ViewVacs_Load(object sender, EventArgs e)
        {
            CreateColumns1Comp();
            CreateColumns2Comp();
            CreateColumns1Cand();
            CreateColumns2Cand();
            CreateColumns3Cand();

            RefreshDataGrid1Comp(dataGridView1forComp);
            RefreshDataGrid2Comp(dataGridView2forComp);  
            RefreshDataGrid1Cand(dataGridView1forCand);
            RefreshDataGrid2Cand(dataGridView2forCand);      
            RefreshDataGrid3Cand(dataGridView3forCand);

            if (RoleLabel.Text == "Работник")
            {
                

                dataGridView1forCand.Visible = true;
                dataGridView2forCand.Visible = true;
                dataGridView3forCand.Visible = true;
            }
            else
            {
               

                dataGridView1forCand.Visible = false;
                dataGridView2forCand.Visible = false;
                dataGridView3forCand.Visible = false;
            }

            if (RoleLabel.Text == "Работадатель")
            {
                

                dataGridView1forComp.Visible = true;
                dataGridView2forComp.Visible = true;
            }
            else
            {
                

                dataGridView1forComp.Visible = false;
                dataGridView2forComp.Visible = false;
            }

            panel2.Visible = true;
            RoleLabel.Visible = false;
            EmailLabel.Visible = false;
        }

        private void AppExitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rolllabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile menu = new Profile(EmailLabel.Text);
            this.Close();
            menu.Show();
        }
    }
}
