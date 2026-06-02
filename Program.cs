//calculadora v2

int a,b,z,d;
float x;
do
{    
    Console.WriteLine("ingrese numero: ");
    string n1=Console.ReadLine();
    float.TryParse(n1, out x);

    Console.WriteLine("que operacion quiere hacer: ");
    Console.WriteLine("1. valor absoluto");
    Console.WriteLine("2. cuadrado");
    Console.WriteLine("3. raiz cuadrada");
    Console.WriteLine("4. seno");
    Console.WriteLine("5. coseno");
    Console.WriteLine("6. parte entera de tipo float\n");
    string n3=Console.ReadLine();
    int.TryParse(n3, out z);
    switch (z)
    {
        case 1: 
            Console.WriteLine($"valor absoluto: {Math.Abs(x)}");
        break;
        case 2: 
            Console.WriteLine($"cuadrado: {Math.Pow(x,2)}");
        break;
        case 3: 
            Console.WriteLine($"raiz cuadrada: {Math.Sqrt(x)}");
        break;
        case 4: 
            Console.WriteLine($"seno: {Math.Sin(x)}");
        break;
        case 5: 
            Console.WriteLine($"coseno: {Math.Cos(x)}");
        break;
        case 6: 
            Console.WriteLine($"parte entera: {Math.Truncate(x)}\n");
        break;
    }
    Console.WriteLine("ingrese numero n1: ");
    string n2=Console.ReadLine();
    int.TryParse(n2, out a);
    Console.WriteLine("ingrese numero n2 : ");
    string ne=Console.ReadLine();
    int.TryParse(ne, out b);
    Console.WriteLine($"el maximo entre esos num: {Math.Max(a,b)}");
    Console.WriteLine($"el minimo entre esos num: {Math.Min(a,b)}");
    Console.WriteLine("desea hacer otra operacion? (1. si | 0. no)");
    string n4=Console.ReadLine();
    int.TryParse(n4,out d);
}while(d!=0);









