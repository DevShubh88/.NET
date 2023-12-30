namespace DBmanager1;
using MySeri;
using MySql.Data.MySqlClient;
public  class DBmanager{
 

    public void InsertData()
    {
          int rowsAffected =0;

    MySqlConnection connection = new MySqlConnection(); 
    food f1 = new food();
    List<food> foo = f1.StoreData();
    
    try{
    connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac27;password=welcome;database=dac27";  //connection string to connection object
    MySqlCommand command =null;
    connection.Open();
    foreach(food f in foo)
    {
              
        string query = "insert into food (item_id,item_name,item_unit,company_id) values (@item_id,@item_name,@item_unit,@company_id)";
        command= new MySqlCommand(query,connection);
        command.Parameters.AddWithValue("@item_id",f.item_id);
        command.Parameters.AddWithValue("@item_name",f.item_name);
        command.Parameters.AddWithValue("@item_unit",f.item_unit);
        command.Parameters.AddWithValue("@company_id",f.company_id);
        rowsAffected+= command.ExecuteNonQuery();

    }

  
        
     
        Console.WriteLine($"Inserted {rowsAffected} row(s)!");
        

    }
    // command.ExecuteNonQuery();
    
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }finally{
        connection.Close();
    }
    }
}