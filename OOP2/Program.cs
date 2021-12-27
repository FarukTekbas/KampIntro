// See https://aka.ms/new-console-template for more information
using OOP2;

Console.WriteLine("Hello, World!");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.FirstName = "Faruk";
customer1.LastName = "Tekbaş";
customer1.CustomerNumber = "12345";
customer1.TcNumber = "123145678910";

CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CompanyName = "afartech";
customer2.CustomerNumber = "54321";
customer2.TaxNumber = "1234567890";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);



