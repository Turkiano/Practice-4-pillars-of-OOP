namespace Practice;

//polymorphism (overloading) = methods share the same name, 
//                             but different paramenter
//                             methods should have a unique signature

public class Math {

public double  Multiply(double a, double b) 
{return a * b;} //two parameters

public double  Multiply(double a, double b, double c)
{return a * b * c;} //three parameters

}
