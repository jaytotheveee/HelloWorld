using System;

namespace DataTypeApp 
{
    class DataTypeProgram 
    {
        static void Main() 
        {
            string coffeeBrand = "Arabica Gold"; 
            
            int stockQuantity = 120; 
            
            double pricePerServing = 55.25; 
            
            char beanGrade = 'A'; 
            
            const double SALES_TAX = 0.12;

            Console.WriteLine("Coffee Brand: " + coffeeBrand);
            stockQuantity = 115; 
            Console.WriteLine("Updated Stock: " + stockQuantity + " cups");
            Console.WriteLine("Base Price: " + pricePerServing);
            Console.WriteLine("Bean Grade: " + beanGrade);
            Console.WriteLine("Tax Rate: " + SALES_TAX);

            Console.ReadKey();
        }
    }
}