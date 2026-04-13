using CoffeeShopSystem.Models;
namespace CoffeeShopSystem.Patterns;

public static class CoffeeFactory
{
    public static ICoffee CreateCoffee(string type)
    {
        return type.ToLower() switch
        {
            "lattee"=> new Latte(),
            "espresso"=> new Espresso(),
            "cappuccino"=> new Cappuccino(),
            _=> new RegularCoffee()
        };
    }
}