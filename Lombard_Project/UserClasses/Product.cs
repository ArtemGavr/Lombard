using System;
using System.Drawing;

namespace Lombard_Project.UserClasses
{
    [Serializable]
    // Абстрактний класс "Товару", який буде унаслідовано.
    public abstract class Product
    {
        // Назва.
        public abstract string Name { get; set; }
        // Оціночна вартість.
        public abstract int Value { get; set; }
        // Дата та час здачі на зберігання.
        public abstract DateTime DateTime { set; get; }
        // Данні клієнта.
        public abstract Client Giver { get; set; }
        // Опис.
        public abstract string Description { get; set; }
        // Тип.
        public abstract string Type { get; set; }
        // Зображення.
        public abstract Image Image { get; set; }
        public abstract string GiverName { get; }
        // Ціна на продажі.
        public abstract int Price { get; set; }
        // Термін зберігання.
        public abstract int StoreDays { get; set; }

        public Product()
        {
        }
    }
}