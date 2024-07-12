// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");


//Controller(http request is handled in this layer)---> Services(business logic)--->Repositories(will talk to database)--->data access layer(entity framework, dapper) 





//RequestModel---> Entity(for request from users)
//Entity---> ResponseModel(for response from the database)

//ResponseModel--> will contain data that you want to show to the user


// Serilog: third party library for logging


using EntityFramework.Presentation.UI;

ManageEmployee manageEmployee = new ManageEmployee();
manageEmployee.Run();


// using EntityFramework.Presentation.UI;
//
// ManageDepartment manageDepartment = new ManageDepartment();
// manageDepartment.Run();