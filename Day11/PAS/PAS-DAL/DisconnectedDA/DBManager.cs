namespace PAS_DAL.DisConnected;
using PAS_BOL;
using System.Data;
using MySql.Data.MySqlClient;
public class DBManager
{
  public static string cString = @"server=localhost;port=3306;user=root" +
  "password=password;databse=emp_info";
  public static List<Person> getAllPersons(){
      MySqlConnection con = new MySqlConnection();
      

  }
}
