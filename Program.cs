using System.Runtime;

namespace WarehouseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            while (true)
            {
                Console.WriteLine("1.Noutbuk elave et");
                Console.WriteLine("2.Telefon elave et");
                Console.WriteLine("3Anbardaki mehsullarin hamisini goster");
                Console.WriteLine("4.Mehsul axtar\n a.Ada gore\n b.Maksimum qiymete gore");
                Console.WriteLine("5.Mehsul sat(Mehsulun adi ve sayi daxil edilir)");
                
                Console.WriteLine("6.Cixis");
                byte op = Convert.ToByte(Console.ReadLine());
                if (op==6)
                {
                    return;
                }
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Noutbukadini qeyd et:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ram daxil et");
                        int ram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Oyuncu komputeri? (he-h yox-y)");
                        string answer = Console.ReadLine();
                        bool isgaming = (answer == "h");
                        Console.WriteLine("Qiymet daxil edin");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Anbar sayini daxil et");
                        int stockcount = Convert.ToInt32(Console.ReadLine());


                        Laptop laptop = new Laptop(name,price,stockcount,ram,isgaming);
                        warehouse.AddProduct(laptop);
                        break;
                    case 2:
                        Console.WriteLine("Telefonun adi qeyd et:");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Yaddas daxil et");
                        int storage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("has5g? (he-h,yox-y)");
                        string ans = Console.ReadLine();
                        bool has5g = (ans == "h");
                        Console.WriteLine("Qiymet daxil edin");
                        double price2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Anbar sayini daxil et");
                        int stockcount2 = Convert.ToInt32(Console.ReadLine());


                        Phone phone = new Phone(name2,price2,stockcount2,storage,has5g);
                        warehouse.AddProduct(phone);
                        break;
                    case 3:
                        warehouse.ShowAllProducts();
                        break;
                    case 4:
                        Console.WriteLine("Ada gore axtaris ucun a maksimum qiymete gore axtaris b");
                        string opp = Console.ReadLine();
                        if (opp=="a")
                        {
                            Console.WriteLine("Ad daxil edin");
                            string searchName = Console.ReadLine();
                            warehouse.SearchProduct(searchName);
                        }
                        else if(opp=="b")
                        {
                            Console.WriteLine("Maks qiymet daxil edin daxil edin");
                            double maxprice = Convert.ToDouble(Console.ReadLine());
                            warehouse.SearchProduct(maxprice);
                        }
                            break;
                    case 5:
                        Console.WriteLine("Mehsulun adini daxil edin");
                        string sellName = Console.ReadLine();
                        Console.WriteLine("Sayi daxil edin");
                        int count = Convert.ToInt32(Console.ReadLine());

                        warehouse.SellProduct(sellName,count);
                        break;
                    
                }
            }
        }
    }
}
