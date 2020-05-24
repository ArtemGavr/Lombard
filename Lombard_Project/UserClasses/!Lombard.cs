using Lombard_Project.FilesWorkk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    public class Lombard
    {
        public List<Product> Products { private set; get; }
        public List<Client> Clients { private set; get; }
        public List<MyApplication> ApplicationsToAdmin { private set; get; }
        public List<MyApplication> ApplicationsToUser { private set; get; }

        public bool IsDirty = false;

        public Lombard()
        {
            Products = new List<Product>();
            Clients = new List<Client>();
            ApplicationsToAdmin = new List<MyApplication>();
            ApplicationsToUser = new List<MyApplication>();
        }

        public void FillTestData(int n)
        {
            // Clients
            Clients.Clear();
            for (int i = 1; i <= n; i++)
            {
                Clients.Add(new Client(i + 10000, $"Buer{i}", "123456"));
            }

            // Products
            Products.Clear();
            var noImage = new Bitmap(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"ClientApp\Images\rose.png"));

            for (int i = 0; i < n; i++)
            {
                Products.Add((Product)new Item($"Product{i}", i * 10, Clients[0], "Sample", noImage, DateTime.Now + TimeSpan.FromDays(i))
                //{
                //    //Id = i,
                //    Name = $"Product{i}",
                //    Value = i * 10,
                //    Giver = Clients[i]

                //}
                );
            }

            // ApplicationsToAdmin
            ApplicationsToAdmin.Clear();
            const int m = 3;
            for (int i = 0; i < m; i++)
            {
                ApplicationsToAdmin.Add(new MyApplication(Products[i], Clients[0]));
            }

            // ApplicationsToUser
            ApplicationsToUser.Clear();
            //const int m = 3;
            for (int i = 0; i < m; i++)
            {
                ApplicationsToUser.Add(new MyApplication(Products[i], Clients[0]));
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