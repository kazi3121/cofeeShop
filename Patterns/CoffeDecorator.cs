using CoffeeShopSystem.Models;
namespace CoffeeShopSystem.Patterns;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee= coffee;
    }
    public virtual string GetDescription()=>_coffee.GetDescription();
    public virtual decimal GetCost()=> _coffee.GetCost();
}

public class MilkDecorator: CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee): base(coffee){}

    public override string GetDescription()
    {
        return base.GetDescription()+", Milk";
    }

    public override decimal GetCost()
    {
        return base.GetCost()+20.00m;
    }
}

public class SugarDecorator: CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee): base(coffee){}

    public override string GetDescription()
    {
        return base.GetDescription()+", Sugar";
    }

    public override decimal GetCost()
    {
        return base.GetCost()+10.00m;
    }
}