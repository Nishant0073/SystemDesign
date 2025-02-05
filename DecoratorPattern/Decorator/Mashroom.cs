namespace DecoratorPattern;

public class Mashroom : ToppingDecorator
{
    BasePizza basePizza;
    public Mashroom(BasePizza pizza)
    {
        this.basePizza = pizza;
        
    }
    public override double cost()
    {
        return basePizza.cost() + 15;
    }
}
