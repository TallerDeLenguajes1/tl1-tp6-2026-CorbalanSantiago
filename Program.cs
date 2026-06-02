Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//ejercicio 1
Console.WriteLine("ingrese un numero: ");
string n=Console.ReadLine();
if(int.TryParse(n,out a))
{
    if(a>0)
    {
        int invertido=0;
        while(a!=0)
        {
            int resto=a%10;
            invertido=invertido*10+resto;
            a=a/10;
        }
        Console.WriteLine("numero: " +n);
        Console.WriteLine("numero invertido " +invertido);
    }
    else
    {
        Console.WriteLine("debe ser mayor a 0");
    }
}
else
{
    Console.WriteLine("no es un numero");
}