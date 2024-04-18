using MySql.Data.MySqlClient;

namespace trees2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=192.168.1.38;" +
                "user=PC1;" +
                "password=1111;" +
                "port=3306;" +
                "database=trees_zaimov";

            MySqlConnection connect = new MySqlConnection(connectionString);
            if (connect.State == 0)
            {
                connect.Open();
            }
            MessageBox.Show("Imash vruzka s Belezireva HeidiSQL");


            string insertQueryText = "insert into trees_zaimov.type " +
                "(`name`,`name_bg`) " +
                "values " +
                "(@name,@name_bg)";

            MySqlCommand query = new MySqlCommand(insertQueryText, connect);

            query.Parameters.AddWithValue("@name", txtName.Text);
            query.Parameters.AddWithValue("@name_bg", txtNameBG.Text);

            int result = query.ExecuteNonQuery();
            if (result != 0) 
            {
                MessageBox.Show($"Dobavi {result} records !!!");
            }

            

            connect.Close();

        }
    }
}
