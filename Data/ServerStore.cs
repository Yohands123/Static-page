using BlazorSSRApp.Components.Pages;
using BlazorSSRApp.Models;
using Microsoft.AspNetCore.Hosting.Server;
using System.Collections.Generic;

namespace BlazorSSRApp.Data
{
    public static class ServerStore
    {
        public static List<Server> Servers { get; } = new()
        {
            new Server (){ Name = "Server1", City = "Toronto", IsOnline = false, PeopleOnline = 0 },
            new Server (){ Name = "Server2", City = "Toronto", IsOnline = false, PeopleOnline = 0 },
        };
    }
}