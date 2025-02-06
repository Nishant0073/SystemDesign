
using FactoryPattern;
ShapeFactory shapeFactory = new ShapeFactory();
IShape circle = shapeFactory.GetShape("CIRCLE");
IShape square = shapeFactory.GetShape("SQUARE");
circle.draw();
square.draw();
