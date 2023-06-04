using System;
using TestTask_nonton.Model;


ProductsImpl productsImpl = new ProductsImpl();

void PrintProducts(List<Product> products)
{
    if (products.Count == 0)
    {
        Console.WriteLine("Список продуктов пуст!");
    }
    else
    {
        foreach (Product product in products)
        {
            Console.WriteLine("* Id: " + product.Id + "; Name: " + product.Name);
        }
    }
}

Console.WriteLine(
    "Доброго времени суток!\n\n" +
    "Вы используете демо версию программы SuperProductsManager.\n" +
    "К сожалению демо версия не содержит в себе много функций " +
    "(только Поиск, Удаление, Поиск по id, Поиск по имени), " +
    "и у продукта есть всего два поля: " +
    "id, который вы должны сами указывать, и name - название продукта.\n\n" +
    "Если вы хотите полную версию данного софта, просто напишите нашему разработчику " +
    "(да, он у нас один; tg: @Lockerio) и напомните ему, что зарплату разработчикам дают " +
    "за написание качественного кода, а не за бред сумасшедшего, который вы только что прочитали.\n\n" +
    "Приятного использования)\n\n");

while (true)
{
    Console.WriteLine("\nСписок всех продуктов:");
    PrintProducts(productsImpl.Products);

    Console.WriteLine(
        "\nЧто вы хотите сделать?\n" +
        "1) Добавить продукт\n" +
        "2) Удалить продукт\n" +
        "3) Искать по id\n" +
        "4) Искать по названию\n" +
        "5) Выход\n");

    Console.WriteLine("Выберите желаемое действие (введите число): ");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        // Добавить продукт
        case "1":
            Product newProduct = new Product();

            while (true)
            {
                Console.WriteLine("\nВведите id продукта: ");
                string idToAdd = Console.ReadLine();

                Console.WriteLine("Введите название продукта: ");
                string nameToAdd = Console.ReadLine();

                try
                {
                    newProduct = new Product(idToAdd, nameToAdd);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nОшибка! " + e.Message + " Попробуйте еще раз.\n\n");
                }
                
            }

            bool is_product_added = productsImpl.AddProduct(newProduct);

            if (is_product_added)
            {
                Console.WriteLine("Продукт успешно добавлен");
            }
            else
            {
                Console.WriteLine("Продукт с таким id уже существует");
            }
            break;

        // Удалить продукт
        case "2":
            Console.WriteLine("\nВведите id продукта: ");
            string idToDelete = Console.ReadLine();

            bool is_product_deleted = productsImpl.DeleteProduct(idToDelete);

            if (is_product_deleted)
            {
                Console.WriteLine("Продукт успешно удален");
            }
            else
            {
                Console.WriteLine("Продукт с таким id не существует");
            }
            break;

        // Искать по id
        case "3":
            Console.WriteLine("\nВведите id продукта: ");
            string idToSearch = Console.ReadLine();

            string productName = productsImpl.GetName(idToSearch);

            Console.WriteLine("Название искомого продукта: " + productName);
            break;

        // Искать по названию
        case "4":
            Console.WriteLine("\nВведите название продукта: ");
            string nameToSearch = Console.ReadLine();

            List<Product> products = productsImpl.FindByName(nameToSearch);

            Console.WriteLine("\nСписок продуктов с названием: " + nameToSearch);
            PrintProducts(products);
            break;

        // Выход
        case "5":
            Console.WriteLine("До встречи!");
            Environment.Exit(0);
            break;

        // Ввод некорректного значения
        default:
            Console.WriteLine("Вы ввели некорректое значение!");
            break;
    }
}
