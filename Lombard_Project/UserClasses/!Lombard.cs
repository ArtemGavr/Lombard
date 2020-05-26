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
                Clients.Add(new Client(i + 10000, $"Client{i}", "12345"));
            }

            // Products
            Products.Clear();
            var noImage = new Bitmap(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"ClientApp\Images\rose.png"));

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Products.Add((Product)new Item($"Item{i}", 10 + i * 10, Clients[i], "Sample", noImage, DateTime.Now - TimeSpan.FromDays(i + 16)) { Image = noImage, StoreDays = 20 });
                }
                else
                {
                    Products.Add((Product)new Property($"Property{i}", 10 + i * 10, Clients[i], "Sample", DateTime.Now - TimeSpan.FromDays(i + 16)) { Image = noImage, StoreDays = 20 });
                }
            }

            // ApplicationsToAdmin
            ApplicationsToAdmin.Clear();
            const int m = 5;
            for (int i = 0; i < m; i++)
            {
                ApplicationsToAdmin.Add(new MyApplication(Products[0], Clients[0]));
            }

            // ApplicationsToUser
            ApplicationsToUser.Clear();

            for (int i = 0; i < m; i++)
            {
                ApplicationsToUser.Add(new MyApplication(Products[0], Clients[0]));
            }
        }

        public void Save()
        {
            new FilesWork(this).Save();
        }

        public void Load()
        {
            new FilesWork(this).Load();

            for (int i = 0; i < Products.Count; i++)
            {
                int days = Convert.ToInt32((DateTime.Now - Products[i].DateTime).TotalDays);
                if (days > Products[i].StoreDays)
                    Products[i].Price = Convert.ToInt32(1.2 * Products[i].Value);
                else
                    Products[i].Price = Convert.ToInt32((1 + (0.2 * days / Products[i].StoreDays)) * Products[i].Value);
            }
        }
    }
}