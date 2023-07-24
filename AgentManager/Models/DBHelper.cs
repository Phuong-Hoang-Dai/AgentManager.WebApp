using AgentManager.WebApp.Models;

namespace AgentManager.Models
{
    public class DBHelper
    {
        AgentManagerDbContext _db;
        public DBHelper(AgentManagerDbContext db) {  _db = db; }


    }
}
