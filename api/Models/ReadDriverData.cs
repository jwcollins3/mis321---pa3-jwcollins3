using api.Interfaces;
using MySql.Data.MySqlClient; 

namespace api.Models
{
    public class ReadDriverData : IGetAllDrivers
    {
        public List<Driver> GetAllDrivers()
        {
            string cs = "server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user=vvfrz2j3eb6kgoul;database=thmonm4ri20725lf;port=3306;password=g3zjyl1o3v0zecro";

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * FROM driver";
            using var cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Driver> drivers = new List<Driver>();
            while(rdr.Read()) {
                drivers.Add(new Driver(){Id = rdr.GetInt32(0), Name = rdr.GetString(1), Rating = rdr.GetInt32(2), DateHired = rdr.GetDateTime(3), Deleted = rdr.GetBoolean(4)});
            }

            return drivers;
            con.Close();
        }
        
    }
}