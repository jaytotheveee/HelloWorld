using System;

namespace DataTypeApp 
{
    class DataTypeProgram 
    {
        static void Main() 
        {
            // 1. String: A reference type for storing the name of the coffee
            string coffeeBrand = "Arabica Gold"; 
            
            // 2. Integer: A value type for the number of cups available
            int stockQuantity = 120; 
            
            // 3. Double: A value type for the price of a single serving
            double pricePerServing = 55.25; 
            
            // 4. Character: A value type representing the storage area
            char beanGrade = 'A'; 
            
            // 5. Constant: A fixed value for the sales tax that cannot be changed
            const double SALES_TAX = 0.12;

            // Displaying the information to the console
            Console.WriteLine("Coffee Brand: " + coffeeBrand);
            stockQuantity = 115; // Demonstrating that variables can change
            Console.WriteLine("Updated Stock: " + stockQuantity + " cups");
            Console.WriteLine("Base Price: " + pricePerServing);
            Console.WriteLine("Bean Grade: " + beanGrade);
            Console.WriteLine("Tax Rate: " + SALES_TAX);

            // Prevents the console from closing immediately
            Console.ReadKey();
        }
    }
}