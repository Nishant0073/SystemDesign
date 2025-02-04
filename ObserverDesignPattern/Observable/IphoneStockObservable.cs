
namespace ObserverDesignPattern;

public class IphoneStockObservable : IStockObservale
{
    List<IObserver> observers = [];
    int stock = 0;
    public void addObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void notifyObserver()
    {
        foreach(var observer in observers){
            observer.Update();
        }
    }

    public void removeObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void setStock(int stk)
    {
        if(stock==0){
            stock=stk;
            notifyObserver();
        }
        else{
            stock+=stk;
        }
    }

    public int getStock(){
        return stock;
    }
}
