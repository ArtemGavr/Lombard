using Lombard_Project.UserClasses;

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lombard_Project.FilesWorkk
{
    //тЗбереження та завантаження серіалізованих данних.
    public class FilesWork
    {
        private Lombard lombard;
        private const string fileName = "lombard.bin";

        private string path = "";//Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, @"");

        public FilesWork(Lombard lombard)
        {
            this.lombard = lombard;
        }

        // Збереження даних у файл.
        public void Save()
        {
            using (Stream stream = File.Create(path + fileName))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, lombard);
            }
        }

        // Заввнтаження данних з файлу.
        public void Load()
        {
            using (Stream stream = File.OpenRead(path + fileName))
            {
                var serializer = new BinaryFormatter();
                Lombard lmd = (Lombard)serializer.Deserialize(stream);

                Copy(lmd.Products, lombard.Products);
                Copy(lmd.Clients, lombard.Clients);
                Copy(lmd.ApplicationsToAdmin, lombard.ApplicationsToAdmin);
                Copy(lmd.ApplicationsToUser, lombard.ApplicationsToUser);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}