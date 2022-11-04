using MySql.Data.MySqlClient;
using api.Interfaces;
using api.Models;

namespace api.Database
{
    public class UpdateDriver : IUpdateDriver
    {
        public void UpdateDriverRating(Driver value){
            string cs = "server=h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user=vvfrz2j3eb6kgoul;database=thmonm4ri20725lf;port=3306;password=g3zjyl1o3v0zecro";

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm =  @"UPDATE driver SET driver_rating = @driver_rating WHERE driver_id = @driver_id";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@driver_id", value.Id);
            cmd.Parameters.AddWithValue("@driver_rating", value.Rating);
            // cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        } 



    }
}