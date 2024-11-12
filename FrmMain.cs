using Microsoft.Data.SqlClient;

namespace WFA241108;

public partial class FrmMain : Form
{
    
    private string connStr =
        "SERVER = (localdb)\\MSSQLLocalDB;" +
        "DATABASE = my_database;";

    private SqlConnection connection;


    //connect server
    //open connencion
    //def. query
    //run query
    //output

    public FrmMain()
    {
        InitializeComponent();

        InitConnection();


        rtb.Font = new("Consolas", 20f);

        this.Load += FrmMainLoad;
    }

    private void InitConnection()
    {
        connection = new(connStr);

        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("connection was successfully established with the server"))
            {
                InitNewDatabase();
            }
        }
        finally
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    private void InitNewDatabase()
    {
        SqlConnection conn = new("SERVER = (localdb)\\MSSQLLocalDB; DATABASE = master;");
        conn.Open();

        //create new database
        SqlCommand command = new("CREATE DATABASE my_database;", conn);
        command.ExecuteNonQuery();

        command = new("USE my_database;", conn);
        command.ExecuteNonQuery();

        command = new(
            "CREATE TABLE diakok (" +
            "id INT PRIMARY KEY IDENTITY, " +
            "nev VARCHAR(64) NOT NULL, " +
            "szul DATE, " +
            "jogsi BIT NULL);", conn);

        command.ExecuteNonQuery();

        command = new("INSERT INTO diakok VALUES " +
            "('Juhász Zoltán', '1990-07-11', 0)," +
            "('Lapos Elemér', '1981-02-10', 1)," +
            "('Para Zita', '1998-04-14', 0)," +
            "('Füty Imre', '2001-01-30', 1)," +
            "('Végh Béla', '2010-12-24', 0)," +
            "('Viz Elek', '2011-03-15', 0)," +
            "('Alap Alfonz', '1999-05-10', 1);", conn);

        command.ExecuteNonQuery();

        conn.Close();
    }

    private void FrmMainLoad(object? sender, EventArgs e)
        => Lekerdezes();

    public void Lekerdezes()
    {
        using SqlConnection conn = new(connStr);
        conn.Open();

        SqlCommand cmd = new(
            cmdText: "SELECT * FROM diakok;",
            connection: conn);

        SqlDataReader reader = cmd.ExecuteReader();

        while(reader.Read())
        {
            rtb.Text += 
                $"{reader[0]} " +                                  // id
                $"{reader[1], -15} " +                             // nev
                $"{reader.GetDateTime(2):yyyy-MM-dd}    " +        // szul
                $"{(reader.GetBoolean(3) ? "van" : "nincs"),5}\n"; // jogsi?
        }
    }

}
