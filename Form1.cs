using Microsoft.Data.SqlClient;
using System.Data;
namespace TestSQLConnection
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection();
      connection.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Correos;Integrated Security=True;TrustServerCertificate=True";
      try
      {
        connection.Open();
        //execute the query in txtQuery an show into the datagridview dgvData
        SqlDataAdapter adapter = new SqlDataAdapter(txtQuery.Text, connection);
        DataTable table = new DataTable();
        adapter.Fill(table);  
        dgvData.DataSource = table;

        connection.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.Message);
      }

    }
  }
}
