namespace CoffeeShopSystem.Models;

public class Espresso: ICoffee
{
    public string GetDescription()=> "Espresso";
    public decimal GetCost()=> 40.00m;
}

public class Latte: ICoffee
{
    public string GetDescription()=> "Latte";
    public decimal GetCost()=> 45.00m;
}

public class Cappuccino: ICoffee
{
    public string GetDescription()=> "Cappuccino";
    public decimal GetCost()=> 50.00m;
}

public class RegularCoffee:ICoffee
{
    public string GetDescription()=> "Regular Coffee";
    public decimal GetCost()=> 30.00m;
}