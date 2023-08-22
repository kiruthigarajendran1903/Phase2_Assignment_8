using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment8
{
    internal class Program
    {
        static AdvancedDBEntities db;
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.WriteLine("\nEnter your choice\n1. Employees Table\n2. Products Table\n3. Orders Table");
                int option = int.Parse(Console.ReadLine());
                int options;
                Employees emp = new Employees();
                Products product = new Products();
                Orders order = new Orders();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEmployee Table");
                        Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete");
                        options = int.Parse(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                emp.ViewEmpDetails();
                                break;
                            case 2:
                                emp.InsertEmpDetails();
                                break;
                            case 3:
                                emp.updateEmpDetails();
                                break;
                            case 4:
                                emp.deleteEmpDetails();
                                break;
                            default:
                                Console.WriteLine("Wrong Choice!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nProducts Table");
                        Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete");
                        options = int.Parse(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                product.ReadProductDetails();
                                break;
                            case 2:
                                product.insertProductDetails();
                                break;
                            case 3:
                                product.updateProductDetails();
                                break;
                            case 4:
                                product.deleteProductDetails();
                                break;
                            default:
                                Console.WriteLine("Wrong Choice!");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nOrders Table");
                        Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete");
                        options = int.Parse(Console.ReadLine());
                        switch (options)
                        {
                            case 1:
                                order.ReadOrderDetails();
                                break;
                            case 2:
                                order.insertOrderDetails();
                                break;
                            case 3:
                                order.updateOrderDetails();
                                break;
                            case 4:
                                order.deleteOrderDetails();
                                break;
                            default:
                                Console.WriteLine("Wrong Choice!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }               
                Console.WriteLine("\nDo you wish to continue CRUD operations\nIf yes press 'y' or press any key");
                choice = char.Parse(Console.ReadLine().ToLower());
            } while (choice == 'y');

        }
    }
}

