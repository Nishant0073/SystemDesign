// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Decortor pattern");


BasePizza vegDelight = new VegDelight();

Console.WriteLine(vegDelight.cost());
//Add Extrachees 
BasePizza pizzaWithExtraCheese = new ExtraCheese(vegDelight);

Console.WriteLine(pizzaWithExtraCheese.cost());

//Add mashroom
BasePizza pizzaWithMashroom = new Mashroom(pizzaWithExtraCheese);

Console.WriteLine(pizzaWithMashroom.cost());
