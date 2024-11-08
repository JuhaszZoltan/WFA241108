using Microsoft.Data.SqlClient;

namespace WFA241108;

public partial class FrmMain : Form
{
    //db server címe:
    const string connStr =
        "SERVER = (localdb)\\MSSQLLocalDB;" +
        "DATABASE = elso_adatbazis;";

    //connect server
    //open connencion
    //def. query
    //run query
    //output

    public FrmMain()
    {
        InitializeComponent();
        rtb.Font = new("Consolas", 20f);

        this.Load += FrmMainLoad;
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
