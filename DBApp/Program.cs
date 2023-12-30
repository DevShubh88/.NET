using MySql.Data.MySqlClient;
Console.WriteLine("welcome to database");

MySqlConnection connection = new MySqlConnection(); //connection object
connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac27;password=welcome;database=dac27";  //connection string to connection object
string query = "select * from product";//define query
MySqlCommand command = new MySqlCommand(query,connection); //create command object

try{
    connection.Open();//open connection
    MySqlDataReader reader = command.ExecuteReader();//execute command
    while(reader.Read())
    {
        int id = int.Parse(reader["item_id"].ToString()); 
        string name = (reader["item_name"].ToString());
        Console.WriteLine(id+" | "+name);
    }
    reader.Close();
    // command.ExecuteNonQuery();
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();//close connection
}