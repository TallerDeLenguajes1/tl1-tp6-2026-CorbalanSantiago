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

//ejercicio 4

Console.WriteLine("ingrese cadena 1: ");
string cadena1=Console.ReadLine();
Console.WriteLine($"longitud de cadena 1: {cadena1.Length}");
Console.WriteLine("ingrese cadena 2: ");
string cadena2=Console.ReadLine();
Console.WriteLine($"cadenas concatenadas: {cadena1 + cadena2}");
Console.WriteLine($"subcadena de cadena 1: {cadena1.Substring(0, cadena1.Length/2)}");

int x,y,z;
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

switch (z)
{
    case 1: 
        Console.WriteLine($"suma de {x.ToString()} + {y.ToString()} = {(x+y).ToString()}"); 
    break;
    case 2: 
        Console.WriteLine($"resta de {x.ToString()} - {y.ToString()} = {(x-y).ToString()}"); 
    break;
    case 3: 
        Console.WriteLine($"multiplicacion de {x.ToString()} * {y.ToString()} = {(x*y).ToString()}"); 
    break;
    case 4: 
        Console.WriteLine($"division de {x.ToString()} / {y.ToString()} = {(x/y).ToString()}"); 
    break;
    default:
        Console.WriteLine("ingrese un numero valido");
    break;
}

foreach(char letra in cadena1)
{
    Console.WriteLine(letra);
}

Console.WriteLine("ingrese que ocurrencia quiere buscar: ");
string ocurrencia=Console.ReadLine();
int position=cadena1.IndexOf(ocurrencia);

if(position>=0)
{
    Console.WriteLine($"la ocurrencia {ocurrencia} se encuentra en la posicion {position}");
}
else
{
    Console.WriteLine("no se encuentra la ocurrencia");
}

Console.WriteLine($"cadena en mayuscula: {cadena1.ToUpper()}");
Console.WriteLine($"cadena en minuscula: {cadena1.ToLower()}");

Console.WriteLine("ingrese nueva cadena: ");
string cadena3=Console.ReadLine();

foreach(string cosas in cadena3.Split(","))
{
    Console.WriteLine(cosas);
}

Console.WriteLine("ingrese una operacion: ");
string ecuacion=Console.ReadLine();
char operador=' ';

if(ecuacion.IndexOf('+')>=0)
{
    operador='+';
}
if(ecuacion.IndexOf('-')>=0)
{
    operador='-';
}
if(ecuacion.IndexOf('*')>=0)
{
    operador='*';
}
if(ecuacion.IndexOf('/')>=0)
{
    operador='/';
}

string[] partes=ecuacion.Split(operador);
int.TryParse(partes[0], out int num1);
int.TryParse(partes[1], out int num2);

switch (operador)
{
    case '+':
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");   
    break;   
    case '-':   
        Console.WriteLine($"{num1} - {num2} = {num1-num2}");   
    break;   
    case '*':   
        Console.WriteLine($"{num1} * {num2} = {num1*num2}");   
    break;   
    case '/':   
        Console.WriteLine($"{num1} / {num2} = {num1/num2}");   
    break;   
}
