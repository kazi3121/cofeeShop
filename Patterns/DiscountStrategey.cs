namespace CoffeeShopSystem.Patterns;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal total);

}
public class NoDiscount: IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total)=> total;
}

public class HappyHours: IDiscountStrategy
{
    public decimal ApplyDiscount(decimal total) => total*.90m;
}