using System;
using System.Collections.Generic;
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



        //добавляет новый продукт
        // возвращает true - если продукта с таким id еще не было
        // возвращает false - если был такой id, вставка отменяется
        public bool addProduct(Product product)
        {
            //реализация
        }

        //Удаляет продукт
        // возвращает true - если продукт с таким id был
        // возвроащает false - если id не было, (удаления не происходит)
        public bool deleteProduct(Product product)
        {
            // реализация
        }


        //Получает имя (name) продукта
        // возращает name продукта у которого идентификатор равен (=) id
        // если продукта нет, вернуть пустую строку ""
        public string getName(String id)
        {
            // реализация
        }


        //возвращает массив (список) идентификаторов (id)
        // У котрых наименование равно (=) name
        // Если таких нет, возвращается пустой массив (список)
        public List<Product> findByName(String name)
        {
            //реализация
        }
    }
}
