namespace api
{
    public class ConnectionString
    {
        public string cs{get;}
        public ConnectionString()
        {
            string server ="h1use0ulyws4lqr1.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "thmonm4ri20725lf";
            string port = "3306";
            string userName = "vvfrz2j3eb6kgoul";
            string password = "g3zjyl1o3v0zecro";

            cs = $@"server={server};user={userName};database={database};port={port};password={password};";
            
        }
    }
}