using System;
using TestTask_nonton.Model;



ProductsImpl productsImpl = new ProductsImpl();


void PrintProducts()
{
    int counter = 1;
    Console.WriteLine("\nСписок продуктов");

    foreach (Product product in productsImpl.Products)
    {
        Console.WriteLine(counter + ") Id: " + product.Id + "Name: " + product.Name);
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
    PrintProducts();

    Console.WriteLine(
        "Что вы хотите сделать?\n" +
        "1) Добавить продукт\n" +
        "2) Удалить продукт\n" +
        "3) Искать по id\n" +
        "4) Искать по названию\n" +
        "5) Выход\n");

    Console.WriteLine("Выберите желаемое действие (введите число): ");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            while (true)
            {
                Console.WriteLine("\nВведите id продукта: ");
                string incomingId = Console.ReadLine();

                Console.WriteLine("Введите название продукта: ");
                string incomingName = Console.ReadLine();

                Product newProduct = new Product();

                try
                {
                    newProduct = new Product(incomingId, incomingName);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nОшибка! " + e.Message + " Попробуйте еще раз.\n\n");
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
            }
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        default:
            Console.WriteLine("До встречи!");
            Environment.Exit(0);
            break;
    }
}
