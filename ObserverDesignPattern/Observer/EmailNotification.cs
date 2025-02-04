namespace ObserverDesignPattern;

public class EmailNotification : IObserver
{
    IStockObservale observable;
    public EmailNotification(IStockObservale stockObservale)
    {
        observable = stockObservale;
    }
    public void Update()
    {
        Console.WriteLine($"Email notification sent with stock {observable.getStock()}");
    }
}
