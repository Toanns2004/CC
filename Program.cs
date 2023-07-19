// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

ProductControll personController = new ProductControll();
while (true)
{
    Console.WriteLine("=========================");
    Console.WriteLine("1. Add New Product ");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Delete Product");
    Console.WriteLine("4. Exit");
    Console.Write("Choose :");
    int choose = Convert.ToInt32(Console.ReadLine());

    switch (choose)
    {
        case 1:
            personController.AddProduct();
            break;
        case 2:
            personController.GetAll();
            break;
        case 3:
            personController.DeleteProduct();
            break;
        case 4:
            return;
    }
}