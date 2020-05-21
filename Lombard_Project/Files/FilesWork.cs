using Lombard_Project.UserClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lombard_Project.FilesWorkk
{
    public class FilesWork
    {
        Lombard lombard;
        const string filePath = "lombard.bin";

        public FilesWork(Lombard lombard)
        {
            this.lombard = lombard;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, lombard);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Lombard st = (Lombard)serializer.Deserialize(stream);

                Copy(st.Products, lombard.Products);
                Copy(st.Clients, lombard.Clients);
                Copy(st.Applications, lombard.Applications);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}