




using Homework_Interface;
using System.Reflection.Metadata;

Market market = new Market();
string opt;
do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("1 Product elave et");
    Console.WriteLine("2 Product sat");
    Console.WriteLine("3 Productlara bax");
    Console.WriteLine("0 Emeliyati sonlandir");
    Console.WriteLine(" Emeliyyat");
    Console.ForegroundColor= ConsoleColor.White;
    opt = Console.ReadLine();
	switch (opt)
	{
		case "1":
            string name;
            bool check = false;
            do
            {
                Console.WriteLine("Adi");
                name = Console.ReadLine();
                check = false;
                for (int i = 0; i < market.Products.Length; i++)
                {
                    if (market.Products[i].Name == name)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                          Eyni adda product olmaz");
                        Console.ForegroundColor = ConsoleColor.White;
                        check = true;
                        break;
                    }
                }
            } while (string.IsNullOrWhiteSpace(name) || check);
            
            string priceStr;
            double price;
            do
            {
                Console.WriteLine("Qiymeti");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr,out price));
            int count;
            string countStr;
            do
            {
                Console.WriteLine("Sayi");
                countStr = Console.ReadLine();
            } while (!int.TryParse(countStr, out count));
            Product product = new Product()
            {
                Name = name,
                Price = price,
                Count = count
            };
            market.AddProducts(product);
            break;
        case "2":
            Console.Write("Satmaq istedyinz productun adin daxil edin : ");
            string sellproduct = Console.ReadLine();
            market.SellProduct(sellproduct);
            break;
        case "3":
            market.ShowProduct();
            break;
        default:
            if (opt !="0")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzgun emeliyyat daxil edin");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            break;
	}
} while (opt != "0");