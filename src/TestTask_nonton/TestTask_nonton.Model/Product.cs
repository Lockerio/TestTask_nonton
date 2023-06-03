using System;
using System.Globalization;

namespace TestTask_nonton.Model
{
    /// <summary>
    /// Описывает продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id продукта
        /// </summary>
        private string _id;

        /// <summary>
        /// Название продукта
        /// </summary>
        private string _name;

        /// <summary>
        /// Конструктор класса Product, создает экземпляр этого класса
        /// </summary>
        /// <param name="id">Id продукта</param>
        /// <param name="name">Название продукта</param>
        public Product(string id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Возвращает или задает Id продукта
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = AssertString(value, 15); }
        }

        /// <summary>
        /// Возвращает или задает название продукта
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = AssertString(value, 50); }
        }

        /// <summary>
        /// Проверяет на правильность входящую строку
        /// </summary>
        /// <param name="incomingStr">Входящую строка</param>
        /// <param name="maxLength">Максимальное количество символов</param>
        /// <returns>Проверенная входящая строка</returns>
        /// <exception cref="ArgumentException">
        /// Исключение, генерируемое при нулевой строке, или при выходе за ограничение символов
        /// </exception>
        private string AssertString(string incomingStr, int maxLength)
        {
            if ((incomingStr == null) || (incomingStr == ""))
            {
                string messege = "Ваша строка пустая.";
                throw new ArgumentException(messege);
            }
            else if (incomingStr.Length > maxLength)
            {
                string messege = incomingStr + ": Вы превысили лимит в " + maxLength + " символов.";
                throw new ArgumentException(messege);
            }
            return incomingStr;
        }
    }
}