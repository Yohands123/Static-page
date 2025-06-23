using System.Collections.Generic;
using System.Linq;            // for FirstOrDefault
using BlazorSSRApp.Models;   // for your Server model

namespace BlazorSSRApp.Data
{
    public static class ServerStore
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server { Id = 1, Name = "Server1", City = "Toronto", IsOnline = false, PeopleOnline = 0 },
            new Server { Id = 2, Name = "Server2", City = "Toronto", IsOnline = false, PeopleOnline = 0 },
        };

        public static void Update(Server server)
        {
            var db = Servers.FirstOrDefault(x => x.Id == server.Id);
            if (db is not null)
            {
                db.Name = server.Name;
                db.City = server.City;
                db.IsOnline = server.IsOnline;
                db.PeopleOnline = server.PeopleOnline;
            }
        }
    }
}
