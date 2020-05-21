using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lombard_Project.FilesWorkk;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Lombard
    {

        public List<Product> Products { private set; get; }
        public List<Client> Clients { private set; get; }
        public List<Application> Applications { private set; get; }

        public Lombard()
        {
            Products = new List<Product>();
            Clients = new List<Client>();
            Applications = new List<Application>();
        }

        public void FillTestData(int n)
        {
            // Products
            Products.Clear();
            for (int i = 0; i < n; i++)
            {
                Products.Add((Product)new Item($"Product{i}", i * 10, Clients[i], DateTime.Now + TimeSpan.FromDays(i))
                //{
                //    //Id = i,
                //    Name = $"Product{i}",
                //    Value = i * 10,
                //    Giver = Clients[i]

                //}
                );
            }

            // Clients
            Clients.Clear();
            for (int i = 1; i <= n; i++)
            {
                Clients.Add(new Client(i + 10000, $"Buer{i}", "123"));
            }

            // Applications
            Applications.Clear();
            const int m = 3;
            for (int i = 0; i < m; i++)
            {
                Applications.Add( new Application(Products[i], Clients[i]));
                //var ps = new List<Portion>();
                //for (int j = 0; j < m; j++)
                //{
                //    ps.Add(new Portion { Product = Products[i + j], Amount = j });
                //}
                //Orders.Add(new Order(ps, Buyers[i], DateTime.Now + TimeSpan.FromDays(i)));
            }

        }

        public void Save()
        {
            new FilesWork(this).Save();
        }

        public void Load()
        {
            new FilesWork(this).Load();
        }
    }  
}
