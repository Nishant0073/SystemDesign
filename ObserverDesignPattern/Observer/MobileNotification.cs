namespace ObserverDesignPattern;

public class MobileNotification : IObserver
{
    IStockObservale observale;
    public MobileNotification(IStockObservale stockObservale)
    {
       observale = stockObservale; 
    }
    public void Update()
    {
        Console.WriteLine($"SMS set to mobile with stock {observale.getStock()}");
    }
}
