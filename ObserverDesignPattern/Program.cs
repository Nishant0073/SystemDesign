// See https://aka.ms/new-console-template for more information

using ObserverDesignPattern;
IphoneStockObservable iphoneStockObservable = new IphoneStockObservable();
EmailNotification emailNotification = new EmailNotification(iphoneStockObservable);
MobileNotification mobileNotification = new MobileNotification(iphoneStockObservable);

iphoneStockObservable.addObserver(emailNotification);
iphoneStockObservable.addObserver(mobileNotification);

iphoneStockObservable.setStock(10);
iphoneStockObservable.setStock(-10);
iphoneStockObservable.setStock(100);
