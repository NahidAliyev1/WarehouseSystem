using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem;
public class Laptop : Product
{
    private int _ram;

    public int Ram
    {
        get 
        {
            return _ram; 
        }

        set 
        {
            if (value>=2 && value<128)
            {
            _ram = value;

            }
            else
            {
                Console.WriteLine("Xeta");
            }
        }

    }

    public bool IsGaming { get; set; }

    public Laptop(string name, double price, int stockcount,int ram,bool isgaming) : base(name, price, stockcount)
    {
        Ram = ram;
        IsGaming = isgaming;

    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\n Qiymet: {Price}\n Ram: {Ram}");
    }
    public void UpgradeRAM(int extraRam)
    {
       
        if (Ram + extraRam > 128)
        {
            Console.WriteLine("Yeni RAM 128 GB-dan böyük ola bilməz!");
            return; 
        }

        
        Ram += extraRam;

       
        int increaseAmount = (extraRam / 4) * 50;
        Price += increaseAmount;

        Console.WriteLine($"{extraRam} GB RAM əlavə olundu. Yeni RAM: {Ram} GB, Yeni Qiymət: {Price} AZN");
    }
}
