//calculadora v1

int a,b,c,d,f,g,h;
float e;
do
{
    Console.WriteLine("primera calculadora\n");
    Console.WriteLine("ingrese n1: ");
    string n1=Console.ReadLine();
    int.TryParse(n1, out a);
    Console.WriteLine("ingrese n2: ");
    string n2=Console.ReadLine();
    int.TryParse(n2, out b);

    Console.WriteLine("que operacion quiere hacer: ");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    
    string n3=Console.ReadLine();
    int.TryParse(n3, out c);

    switch (c)
    {
        case 1: 
            Console.WriteLine($"suma: {a+b}"); 
        break;
        case 2: 
            Console.WriteLine($"resta: {a-b}"); 
        break;
        case 3: 
            Console.WriteLine($"multiplicacion: {a*b}"); 
        break;
        case 4: 
            Console.WriteLine($"division: {a/b}"); 
        break;
        default:
            Console.WriteLine("ingrese un numero valido");
        break;
    }

    Console.WriteLine("\nsegunda calculadora\n");
    Console.WriteLine("ingrese numero: ");
    string n4=Console.ReadLine();
    float.TryParse(n4, out e);

    Console.WriteLine("que operacion quiere hacer: ");
    Console.WriteLine("1. valor absoluto");
    Console.WriteLine("2. cuadrado");
    Console.WriteLine("3. raiz cuadrada");
    Console.WriteLine("4. seno");
    Console.WriteLine("5. coseno");
    Console.WriteLine("6. parte entera de tipo float\n");
    
    string n5=Console.ReadLine();
    int.TryParse(n5, out d);

    switch(d)
    {
        case 1: 
            Console.WriteLine($"valor absoluto: {Math.Abs(e)}");
        break;
        case 2: 
            Console.WriteLine($"cuadrado: {Math.Pow(e,2)}");
        break;
        case 3: 
            Console.WriteLine($"raiz cuadrada: {Math.Sqrt(e)}");
        break;
        case 4: 
            Console.WriteLine($"seno: {Math.Sin(e)}");
        break;
        case 5: 
            Console.WriteLine($"coseno: {Math.Cos(e)}");
        break;
        case 6: 
            Console.WriteLine($"parte entera: {Math.Truncate(e)}\n");
        break;
        default:
            Console.WriteLine("ingrese un numero valido");
        break;
    }

    Console.WriteLine("ingrese numero n1: ");
    string n6=Console.ReadLine();
    int.TryParse(n6, out f);
    Console.WriteLine("ingrese numero n2 : ");
    string n7=Console.ReadLine();
    int.TryParse(n7, out g);
    Console.WriteLine($"el maximo entre esos num: {Math.Max(f,g)}");
    Console.WriteLine($"el minimo entre esos num: {Math.Min(f,g)}");
    
    Console.WriteLine("desea hacer otra operacion? (1. si | 0. no)");
    string n8=Console.ReadLine();
    int.TryParse(n8, out h);

}while(h!=0);









