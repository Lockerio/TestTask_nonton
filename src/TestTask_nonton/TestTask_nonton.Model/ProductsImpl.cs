using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_nonton.Model
{
    /// <summary>
    /// Описывает объект для работы с классом Product
    /// </summary>
    internal class ProductsImpl
    {

        /// <summary>
        /// Список продуктов
        /// </summary>
        private List<Product> _products;

        /// <summary>
        /// Конструктор класса ProductsImpl, создает экземпляр этого класса
        /// </summary>
        public ProductsImpl()
        {
            Products = new List<Product>();
        }

        /// <summary>
        /// Возвращает или задает список продуктов
        /// </summary>
        public List<Product> Products
        {
            get { return _products; }
            set
            {
                _products = new List<Product>();
            }
        }

        /// <summary>
        /// Добавляет новый продукт
        /// </summary>
        /// <param name="incomingProduct">Входящий продукт</param>
        /// <returns>
        /// Возвращает true - если продукта с таким id еще не было
        /// Возвращает false - если был такой id, вставка отменяется
        /// </returns>        
        public bool AddProduct(Product incomingProduct)
        {
            if (Products.Any(product => product.Id.ToLower() == incomingProduct.Id.ToLower()))
            {
                return false;
            }
            Products.Add(incomingProduct);
            return true;
        }

        /// <summary>
        /// Удаляет продукт
        /// </summary>
        /// <param name="incomingProduct">Входящий продукт</param>
        /// <returns>
        /// Возвращает true - если продукт с таким id был
        /// Возвроащает false - если id не было, (удаления не происходит)
        /// </returns>
        public bool DeleteProduct(Product incomingProduct)
        {
            if (Products.Any(product => product.Id.ToLower() == incomingProduct.Id.ToLower()))
            {
                Products.Remove(incomingProduct);
                return true;
            }
            return false;
        }


        //Получает имя (name) продукта
        // возращает name продукта у которого идентификатор равен (=) id
        // если продукта нет, вернуть пустую строку ""
        public string GetName(String id)
        {
            // реализация
        }


        //возвращает массив (список) идентификаторов (id)
        // У котрых наименование равно (=) name
        // Если таких нет, возвращается пустой массив (список)
        public List<Product> FindByName(String name)
        {
            //реализация
        }
    }
}
