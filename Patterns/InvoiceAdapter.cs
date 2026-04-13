namespace CoffeeShopSystem.Patterns;

public interface IInvoiceService
{
    public string GenerateInvoice( decimal amount, string customer);
}

public class LegacyInvoiceSystem
{
    public string CreateLegacyInvoice(decimal amount, string customer)
    {
        return $"Legacy Invoice is Generated for {customer}: {amount: 0.00} BDT";
    }
}
public class InvoiceAdapter: IInvoiceService
{
    private readonly LegacyInvoiceSystem _legacySystem;

    public InvoiceAdapter( LegacyInvoiceSystem legacyInvoiceSystem)
    {
        _legacySystem= legacyInvoiceSystem;
    }

    public string GenerateInvoice(decimal amount, string customer)
    {
        return _legacySystem.CreateLegacyInvoice(amount, customer);
    }
}