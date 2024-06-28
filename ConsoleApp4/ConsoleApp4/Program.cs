// See https://aka.ms/new-console-template for more information

using ConsoleApp4;
using ConsoleApp4.DataModel;

MyStack<int> stack1 = new MyStack<int>();
stack1.Push(1);
stack1.Push(2);
stack1.Push(3);

Console.WriteLine("Count: " + stack1.Count()); 
Console.WriteLine("Pop: " + stack1.Pop());
Console.WriteLine("Count: " + stack1.Count());

Console.WriteLine("-------------------------------------------");

MyList<int> list1 = new MyList<int>();
list1.Add(1);
list1.Add(2);
list1.Add(3);

Console.WriteLine("Remove at index 1: " + list1.Remove(1)); 
Console.WriteLine("Contains 2: " + list1.Contains(2));

list1.InsertAt(4, 1);
Console.WriteLine("Find at index 1: " + list1.Find(1)); 

list1.DeleteAt(1);
Console.WriteLine("Find at index 1: " + list1.Find(1)); 

Console.WriteLine("-------------------------------------------");

var customerRepository = new GenericRepository<Customer>();

var customer1 = new Customer
{
    Id = 1,
    Name = "John Doe",
    Email = "john@example.com",
    
};
        
var customer2 = new Customer
{
    Id = 2,
    Name = "Rakshit Soni",
    Email = "rakshit@gmail.com",
};

customerRepository.Add(customer1);
customerRepository.Add(customer2);

Console.WriteLine("All customers:");
foreach (var customer in customerRepository.GetAll())
{
    Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
}

var customerById = customerRepository.GetById(1);
Console.WriteLine($"Customer with ID 1: {customerById.Name}");
customerRepository.Remove(customer1);

Console.WriteLine("Updated customers:");
foreach (var customer in customerRepository.GetAll())
{
    Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
}



