using MySql.Data.MySqlClient;
namespace data_base_form
{
    public partial class Form1 : Form
    {
        const string CONN_STR =
            "SERVER = 172.16.1.241;" +
            "DATABASE = diak66;" +
            "UID = diak66;" +
            "PWD = XXTQ4E;";
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            using MySqlConnection connection = new(CONN_STR);
            connection.Open();

            MySqlCommand cmd = new("SELECT * FROM emberek", connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1]);
            }

        }
       


    }
}
