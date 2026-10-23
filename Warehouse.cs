using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WarehouseSystem;
public class Warehouse
{
    Product[] products = [];

    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length+1);
        products[products.Length - 1] = product;
        
        Console.WriteLine("Ugurla elave edildi");
    }
    public void ShowAllProducts()
    {
        foreach (Product p in products)
        {
            p.ShowInfo();
            Console.WriteLine("----------------------");
        }
    }

    public void SearchProduct(string name)
    {
        bool founded = false;
        foreach (Product p in products)
        {
            if (p.Name==name)
            {
                founded= true;
                p.ShowInfo();
            }
        }
        if (!founded)
        {
            Console.WriteLine("Ada uygun mehsul tapilmadi");
        }
    }
    public void SearchProduct(double maxPrice)
    {
        bool founded = false;
        foreach (Product p in products)
        {
            if (p.Price<=maxPrice)
            {
                founded = true;
                p.ShowInfo();
            }
        }
        if (!founded)
        {
            Console.WriteLine("bu qiymet araliginda mehsul tapilmadi");
        }
    }
    public void SellProduct(string productName, int count)
    {
        bool found = false;

        foreach (Product p in products)
        {
           
            if (p.Name==productName)
            {
                found=true;
                if (p.StockCount<count)
                {
                    Console.WriteLine($"Anbarda yetərli sayda məhsul yoxdur! Mövcud stok: {p.StockCount}");
                }
                else
                {
                    p.StockCount = p.StockCount - count;
                    double result2 = p.Price * count;
                    Console.WriteLine($"Satış uğurludur. Ümumi məbləğ: {result2}");
                }
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Axtarılan adda məhsul anbarda tapılmadı!");
        }
    }

}
