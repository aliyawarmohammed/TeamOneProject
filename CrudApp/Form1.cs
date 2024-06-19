using System.Data;
using System.Data.SqlClient;

namespace CrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3T7SP2U;Initial Catalog=EmployeeDb;Integrated Security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            SqlCommand cmd = new SqlCommand("sp_GetEmployeeData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "EmpId";
            comboBox1.ValueMember = "EmpId";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_GetEmployeeDatabyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", comboBox1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            txtEmpName.Text = dt.Rows[0][1].ToString();
            txtEmpSalary.Text = dt.Rows[0][2].ToString();
        }
    }
}
