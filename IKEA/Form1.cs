using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKEA
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["IKEA.Properties.Settings.IKEAConnectionString"].ConnectionString;
        }

        private void PopulateIKEATable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Room", connection))
            {
                DataTable ikeaTable = new DataTable();
                adapter.Fill(ikeaTable);

                listIkea.DisplayMember = "RoomName";
                listIkea.ValueMember = "Id";
                listIkea.DataSource = ikeaTable;
            }

        }

        private void PopulateIKEANames()
        {
            string query = "SELECT Series.Name From Room INNER JOIN Series ON Series.RoomId = Room.Id WHERE Room.Id = @RoomId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RoomId", listIkea.SelectedValue);
                DataTable seriesTableName = new DataTable();
                adapter.Fill(seriesTableName);

                listSeriesNames.DisplayMember = "SeriesName";
                listSeriesNames.ValueMember = "Id";
                listSeriesNames.DataSource = seriesTableName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateIKEATable();
        }

        private void listIkea_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIKEANames();
        }
    }
}
