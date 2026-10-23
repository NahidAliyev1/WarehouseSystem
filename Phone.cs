using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem;
public class Phone : Product
{
    private int _storage;

    public int Storage
    {
        get 
        {
            return _storage; 
        }

        set 
        {
            if (value==64 || value==128 || value==256)
            {
            _storage = value;

            }
            else
            {
                Console.WriteLine("Xeta");
            }
        }

    }
    public bool Has5g { get; set; }


    public Phone(string name, double price, int stockcount, int storage,bool has5g) : base(name, price, stockcount)
    {
        Storage = storage;
        Has5g = has5g;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\n Qiymet: {Price}\n Storage: {Storage}");
    }
    public double SimulateTradeIn(double oldPhoneValue)
    {
        if (oldPhoneValue>Price*0.8)
        {
            Console.WriteLine("Kohne telefon cox baha qiymetlendirilib");
            return 0;
        }

        return Price - oldPhoneValue; 
    }
}
