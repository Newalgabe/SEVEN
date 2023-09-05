// task 1
//struct Article
//{
//    public int ProductCode;
//    public string ProductName;
//    public double Price;

//    public Article(int code, string name, double price)
//    {
//        ProductCode = code;
//        ProductName = name;
//        Price = price;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Product Code: {ProductCode}");
//        Console.WriteLine($"Product Name: {ProductName}");
//        Console.WriteLine($"Price: {Price}");
//    }
//}


// task 2
//public struct Client
//{
//    public int ClientCode;
//    public string FullName;
//    public string Address;
//    public string PhoneNumber;
//    public int OrderCount;
//    public double TotalOrdersAmount;

//    public Client(int code, string name, string address, string phone, int orderCount, double totalAmount)
//    {
//        ClientCode = code;
//        FullName = name;
//        Address = address;
//        PhoneNumber = phone;
//        OrderCount = orderCount;
//        TotalOrdersAmount = totalAmount;
//    }
//}


// task 3
//struct RequestItem
//{
//    public string ProductName { get; set; }
//    public int Quantity { get; set; }

//    public RequestItem(string productName, int quantity)
//    {
//        ProductName = productName;
//        Quantity = quantity;
//    }
//}


// task 4
//struct Request
//{
//    public int OrderCode;
//    public Client Customer;
//    public DateTime OrderDate;
//    public RequestItem[] OrderedItems;

//    public Request(int orderCode, Client customer, DateTime orderDate, RequestItem[] orderedItems)
//    {
//        OrderCode = orderCode;
//        Customer = customer;
//        OrderDate = orderDate;
//        OrderedItems = orderedItems;
//    }

//    public double CalculateTotalAmount()
//    {
//        double total = 0;
//        foreach (var item in OrderedItems)
//        {
//            total += item.Price * item.Quantity;
//        }
//        return total;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Order Code: {OrderCode}");
//        Console.WriteLine($"Order Date: {OrderDate}");
//        Console.WriteLine($"Customer: {Customer.FullName}");
//        Console.WriteLine($"Total Amount: {CalculateTotalAmount()}");

//        Console.WriteLine("Ordered Items:");
//        foreach (var item in OrderedItems)
//        {
//            Console.WriteLine($"  {item.ProductName}, Quantity: {item.Quantity}, Price: {item.Price}");
//        }
//    }
//}


// task 5
//public enum ArticleType
//{
//    Electronics,
//    Clothing,
//    Books,
//    Food,
//    Other
//}

//public struct Article
//{
//    public int ProductCode;
//    public string ProductName;
//    public double Price;
//    public ArticleType Type; 

//    public Article(int code, string name, double price, ArticleType type)
//    {
//        ProductCode = code;
//        ProductName = name;
//        Price = price;
//        Type = type; 
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Product Code: {ProductCode}");
//        Console.WriteLine($"Product Name: {ProductName}");
//        Console.WriteLine($"Price: {Price}");
//        Console.WriteLine($"Type: {Type}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Article product1 = new Article(1, "Smartphone", 499.99, ArticleType.Electronics);
//        Article product2 = new Article(2, "T-Shirt", 19.99, ArticleType.Clothing);
//        Article product3 = new Article(3, "Book", 9.99, ArticleType.Books);

//        Console.WriteLine("Product 1 Information:");
//        product1.DisplayInfo();

//        Console.WriteLine("\nProduct 2 Information:");
//        product2.DisplayInfo();

//        Console.WriteLine("\nProduct 3 Information:");
//        product3.DisplayInfo();
//    }
//}


// task 6
//public enum ClientType
//{
//    Regular,
//    Premium,
//    VIP
//}

//public struct Client
//{
//    public int ClientCode;
//    public string FullName;
//    public string Address;
//    public string PhoneNumber;
//    public int OrderCount;
//    public double TotalOrdersAmount;
//    public ClientType Type; 

//    public Client(int code, string name, string address, string phone, int orderCount, double totalAmount, ClientType type)
//    {
//        ClientCode = code;
//        FullName = name;
//        Address = address;
//        PhoneNumber = phone;
//        OrderCount = orderCount;
//        TotalOrdersAmount = totalAmount;
//        Type = type;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Client client1 = new Client(1, "John Doe", "123 Main St", "555-1234", 5, 500.0, ClientType.Regular);
//        Client client2 = new Client(2, "Jane Smith", "456 Elm St", "555-5678", 10, 1500.0, ClientType.Premium);
//        Client client3 = new Client(3, "Bob Johnson", "789 Oak St", "555-9876", 20, 5000.0, ClientType.VIP);

//        Console.WriteLine("Client 1 Information:");
//        Console.WriteLine($"Type: {client1.Type}");
//        Console.WriteLine($"Client Code: {client1.ClientCode}");
//        Console.WriteLine($"Full Name: {client1.FullName}");
//        Console.WriteLine($"Address: {client1.Address}");
//        Console.WriteLine($"Phone Number: {client1.PhoneNumber}");
//        Console.WriteLine($"Order Count: {client1.OrderCount}");
//        Console.WriteLine($"Total Orders Amount: {client1.TotalOrdersAmount}");

//        Console.WriteLine("\nClient 2 Information:");
//        Console.WriteLine($"Type: {client2.Type}");
//        Console.WriteLine($"Client Code: {client2.ClientCode}");
//        Console.WriteLine($"Full Name: {client2.FullName}");
//        Console.WriteLine($"Address: {client2.Address}");
//        Console.WriteLine($"Phone Number: {client2.PhoneNumber}");
//        Console.WriteLine($"Order Count: {client2.OrderCount}");
//        Console.WriteLine($"Total Orders Amount: {client2.TotalOrdersAmount}");

//        Console.WriteLine("\nClient 3 Information:");
//        Console.WriteLine($"Type: {client3.Type}");
//        Console.WriteLine($"Client Code: {client3.ClientCode}");
//        Console.WriteLine($"Full Name: {client3.FullName}");
//        Console.WriteLine($"Address: {client3.Address}");
//        Console.WriteLine($"Phone Number: {client3.PhoneNumber}");
//        Console.WriteLine($"Order Count: {client3.OrderCount}");
//        Console.WriteLine($"Total Orders Amount: {client3.TotalOrdersAmount}");
//    }
//}


// task 7
//public enum PayType
//{
//    Cash,
//    CreditCard,
//    PayPal
//}

//public struct Request
//{
//    public int OrderCode;
//    public Client Customer;
//    public DateTime OrderDate;
//    public RequestItem[] OrderedItems;
//    public double TotalAmount;

//    public PayType PaymentType; 

//    public Request(int orderCode, Client customer, DateTime orderDate, RequestItem[] orderedItems, PayType paymentType)
//    {
//        OrderCode = orderCode;
//        Customer = customer;
//        OrderDate = orderDate;
//        OrderedItems = orderedItems;
//        PaymentType = paymentType; 
//        TotalAmount = CalculateTotalAmount(); 
//    }

//    private double CalculateTotalAmount()
//    {
//        double total = 0;
//        foreach (var item in OrderedItems)
//        {
//            total += item.Price * item.Quantity;
//        }
//        return total;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Order Code: {OrderCode}");
//        Console.WriteLine($"Order Date: {OrderDate}");
//        Console.WriteLine($"Customer: {Customer.FullName}");
//        Console.WriteLine($"Total Amount: {TotalAmount}");
//        Console.WriteLine($"Payment Type: {PaymentType}");

//        Console.WriteLine("Ordered Items:");
//        foreach (var item in OrderedItems)
//        {
//            Console.WriteLine($"  {item.ProductName}, Quantity: {item.Quantity}, Price: {item.Price}");
//        }
//    }
//}
