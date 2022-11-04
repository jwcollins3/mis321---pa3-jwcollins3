using api.Interfaces;
using api.Database;

namespace api.Models
{
    public class Driver 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int Rating {get; set;}
        public DateTime DateHired {get; set;}
        public bool Deleted {get; set;}
        
        // public IInsertDriver SaveDriver {get; set;}
        // public IDeleteDriver DeleteDriver {get; set;}

        public Driver(){
            // SaveDriver = new SaveDriver();
            // DeleteDriver = new DeleteDriver();
        }
    }
}