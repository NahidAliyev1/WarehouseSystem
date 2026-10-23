using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem;
public abstract class Product : IDiscountable
{
    public const int MaxDiscountRate = 50;
    public readonly DateTime CreateDate;

    private string _name;

    public string Name
    {
        get 
        {
            return _name; 
        }

        set 
        {
            if (value.Length>=2)
            {
            _name = value;

            }
            else
            {
                Console.WriteLine("Xeta");
            }
        }

    }

    private double _price;

    public double Price
    {
        get 
        {
            return _price; 
        }

        set 
        {
            if (value>0)
            {

            _price = value;
            }
            else
            {
                Console.WriteLine("Xeta");
            }
        }

    }
    private int _stockCount;

    public int StockCount
    {
        get 
        {
            return _stockCount; 
        }

        set 
        {
            if (value>=0)
            {

            _stockCount = value; 
            }
        }

    }


    public Product(string name,double price,int stockcount)
    {
        Name = name;
        Price = price;
        StockCount = stockcount;
        CreateDate = DateTime.Now;
    }
    public abstract void ShowInfo();


    public void ApplyDiscount(double percentage)
    {
        if (percentage> MaxDiscountRate)
        {
            Console.WriteLine("Xeta blet");
            return;
        }
        Price = Price - ((Price*percentage)/100);
        Console.WriteLine($"{percentage} faiz endirimle mehsulun qiymeti {Price} manatdir.");
    }
}
