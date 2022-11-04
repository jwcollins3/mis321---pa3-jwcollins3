using MySql.Data.MySqlClient;
using api.Interfaces;
using api.Models;

namespace api.Database
{
    public class SaveDriver : ISaveDriver
    {
        public static void CreateDriverTable(){
            string cs = "server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user=vvfrz2j3eb6kgoul;database=thmonm4ri20725lf;port=3306;password=g3zjyl1o3v0zecro";
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE drivers(driver_id INT NOT NULL AUTO_INCREMENT, PRIMARY KEY(driver_id), driver_name VARCHAR(255), driver_rating INT, driver_date_hired DATE, driver_deleted BOOLEAN)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertDriver(Driver value)
        {
            string cs = "server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user=vvfrz2j3eb6kgoul;database=thmonm4ri20725lf;port=3306;password=g3zjyl1o3v0zecro";

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO driver(driver_name, driver_rating, driver_date_hired, driver_deleted) VALUES(@driver_name, @driver_rating, @driver_date_hired, @driver_deleted)";

            using var cmd = new MySqlCommand(stm, con);
            // cmd.Parameters.AddWithValue("@driver_id", value.Id);
            cmd.Parameters.AddWithValue("@driver_name", value.Name);
            cmd.Parameters.AddWithValue("@driver_rating", value.Rating);
            cmd.Parameters.AddWithValue("@driver_date_hired", DateTime.Now);
            cmd.Parameters.AddWithValue("@driver_deleted", 0);
            // cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // public void ISaveDriver(Driver value)
        // {
        //     throw new System.NotImplementedException();
        // }
        
    }

}