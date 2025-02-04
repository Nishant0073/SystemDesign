namespace ObserverDesignPattern;

public interface IStockObservale
{
    public void addObserver(IObserver observer);
    public void removeObserver(IObserver observer);
    public void notifyObserver();
    public void setStock(int stock);
    public int getStock();

}
