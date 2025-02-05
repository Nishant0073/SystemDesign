namespace DecoratorPattern;

public class ExtraCheese : ToppingDecorator
{
    BasePizza basePizza;
    public ExtraCheese(BasePizza pizza)
    {
        this.basePizza = pizza;
    }
    public override double cost()
    {
        return this.basePizza.cost() + 10;
    }
}
