class Program
{


    static bool greetings(String message)
    {
        return message.Contains("hi") || message.Contains("hello");
    }



    static void Main()
    {
        int playerCoins = 6000;
        int discount =0;
        int bill=0;
      
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;
        int drinks = 100;
        
        Console.WriteLine("------------------------------");
    
        Console.WriteLine("------------------------------");

        Console.WriteLine("");

        Console.WriteLine("Welcome to genetal store would you like, say hi to the store manager");
        string welcomemesage=Console.ReadLine();
        
        if(greetings(welcomemesage))
        {
                Console.WriteLine("Thanks for your response now you will get a 10% disocunt on overall purchase");
                discount=10;
        }
        else{
                Console.WriteLine("So sad lets get you to the shop");
        }




        do{


   

        

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
                  bill=bill+shirtPrice;
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
                bill=bill+helmetPrice;
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
                bill=bill+foodPrice;
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
                bill=bill+presentPrice;
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
                bill=bill+drinks;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
            }
                break;
                default:
            Console.WriteLine($" You selected wrong letter .");
                break;

        }
        }
        while(playerCoins>0);
        
if(discount>0)
{
            int total=bill;
    discount=(bill/100)*10;
    total=total-discount;
    Console.WriteLine($"After discount you total bill is : {total} ");
}
    }
}

