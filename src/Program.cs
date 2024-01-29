class Program
{
    static void Main()
    {
        int playerCoins = 6000;
        int discount =10;
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;
        int drinks = 100;
        string welcome=Console.ReadLine();

        do{


        Console.WriteLine("------------------------------");
    
        Console.WriteLine("------------------------------");

        Console.WriteLine("");

        Console.WriteLine("What would you like to purchase?");

        Console.WriteLine("A: A nice shirt.");
        Console.WriteLine("B: A protective helmet..");
        Console.WriteLine("C: Some food.");
        Console.WriteLine("D: A present.");
        Console.WriteLine("E: A Drink.");
        Console.WriteLine("");

        Console.WriteLine("Enter the letter for your purchase: ");
        string purchaseLetter = Console.ReadLine().ToUpper();

        Console.WriteLine("");
       

        switch (purchaseLetter) {
            case "A" :
            if(shirtPrice>playerCoins)
            {
                Console.WriteLine($"You don't have sufficient funds, You have {playerCoins} coins remaining.");
            }else
            {
                playerCoins = playerCoins - shirtPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
            }
                break;
            case "B":
             if(helmetPrice>playerCoins)
            {
                 Console.WriteLine($"You don't have sufficient funds, You have {playerCoins} coins remaining.");
            }
            else
            {
                playerCoins = playerCoins - helmetPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
            }
                break;
            case "C":
             if(foodPrice>playerCoins)
            {
                 Console.WriteLine($"You don't have sufficient funds, You have {playerCoins} coins remaining.");
            }
            else
            {
                playerCoins = playerCoins - foodPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
            }
                break;
            case "D":

             if(presentPrice>playerCoins)
            {
                 Console.WriteLine($"You don't have sufficient funds, You have {playerCoins} coins remaining.");
            }
            else
            {
                playerCoins = playerCoins - presentPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
            }
                break;
                case "E":
                 if(drinks>playerCoins)
            {
                 Console.WriteLine($"You don't have sufficient funds, You have {playerCoins} coins remaining.");
            }
            else
            {
                playerCoins = playerCoins - drinks;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
            }
                break;
        }
        }
        while(playerCoins>0);
    }
}

