//calculadora v1

int x,y,z,d;
do
{
    Console.WriteLine("ingrese n1: ");
    string n1=Console.ReadLine();
    int.TryParse(n1, out x);
    Console.WriteLine("ingrese n2: ");
    string n2=Console.ReadLine();
    int.TryParse(n2, out y);

    Console.WriteLine("que operacion quiere hacer: ");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    string n3=Console.ReadLine();
    int.TryParse(n3, out z);

    switch(z)
    {
        case 1: 
            Console.WriteLine($"suma: {x+y}"); 
        break;
        case 2: 
            Console.WriteLine($"resta: {x-y}"); 
        break;
        case 3: 
            Console.WriteLine($"multiplicacion: {x*y}"); 
        break;
        case 4: 
            Console.WriteLine($"division: {x/y}"); 
        break;
        default:
            Console.WriteLine("ingrese un numero valido");
        break;
    }
    Console.WriteLine("desea hacer otra operacion? (1. si | 0. no)");
    string n4=Console.ReadLine();
    int.TryParse(n4, out d);
}while(d!=0);
