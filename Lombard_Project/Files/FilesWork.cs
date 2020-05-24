using Lombard_Project.UserClasses;

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lombard_Project.FilesWorkk
{
    public class FilesWork
    {
        private Lombard lombard;
        private const string fileName = "lombard.bin";

        // string patth = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
        private string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"AdminApp\bin\Debug\");

        public FilesWork(Lombard lombard)
        {
            this.lombard = lombard;
            // Console.WriteLine(path);
        }

        public void Save()
        {
            using (Stream stream = File.Create(path + fileName))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, lombard);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(path + fileName))
            {
                var serializer = new BinaryFormatter();
                Lombard st = (Lombard)serializer.Deserialize(stream);

                Copy(st.Products, lombard.Products);
                Copy(st.Clients, lombard.Clients);
                Copy(st.ApplicationsToAdmin, lombard.ApplicationsToAdmin);
                Copy(st.ApplicationsToUser, lombard.ApplicationsToUser);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}