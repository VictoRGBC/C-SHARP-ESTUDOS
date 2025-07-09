// ESTRUTURA SEQUENCIAL

// Exercicio 1.1:

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int c1,c2,n1,n2;
        double v1,v2;
        
        string[] p1 = Console.ReadLine().Split(' ');
        c1 = int.Parse(p1[0]);
        n1 = int.Parse(p1[1]);
        v1 = double.Parse(p1[2]);
        string[] p2 = Console.ReadLine().Split(' ');
        c2 = int.Parse(p1[0]);
        n2 = int.Parse(p1[1]);
        v2 = double.Parse(p1[2]);
        
        double resultado = ((n1*v1)+(n2*v2));
        
        Console.WriteLine("VALOR A PAGAR: " + resultado.ToString("F2"));
    }
}


Exercico 1.2:

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    double r;
    
    r = double.Parse(Console.ReadLine());
    
    double area = 3.14159 * Math.Pow(r,2);
    
    Console.WriteLine("A=" + area.ToString("F4"));
    }
}

// Estruturas Condicionais

//Exercico 2.1

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    int codigo, quantidade;
    double total = 0.0;
    
    string[] vet = Console.ReadLine().Split(' ');
    codigo = int.Parse(vet[0]);
    quantidade = int.Parse(vet[1]);
    
    if(codigo == 1)
    {
        total = quantidade * 4.00;
    }
    else if(codigo == 2)
    {
            total = quantidade * 4.50;
    }
    else if(codigo == 3){
        total = quantidade * 5.00;
    }
    else if(codigo == 4){
        total = quantidade * 2.00;
    }
    else if(codigo == 5){
        total = quantidade * 1.50;
    }
    else{
        Console.WriteLine("Codigo Invalido");
    }
    Console.WriteLine("Total: " + total.ToString("F2"));
    }
}

// Exercicio 2.2:

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    double a, b, c;
    double delta;
    double x1 = 0.0;
    double x2 = 0.0;
    
    string[] vet = Console.ReadLine().Split(' ');
    a = double.Parse(vet[0]);
    b = double.Parse(vet[1]);
    c = double.Parse(vet[2]);
    
    if(a == 0){
        Console.WriteLine("Impossivel calcular");
    }
    else{
        delta = (Math.Pow(b,2))-(4*a*c);
        if(delta < 0){
            Console.WriteLine("Impossivel calcular");
        }
        else{
            x1 = (-b + Math.Sqrt(delta))/(2.00*a);
            x2 = (-b - Math.Sqrt(delta))/(2.00*a);
            
            Console.WriteLine("X1 = " + x1.ToString("F5"));
            Console.WriteLine("X2 = " + x2.ToString("F5"));
        }
    }
    }
}

//ESTRUTURAS REPETITIVAS

// Exercicio 3.1

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int senha;
        
        senha = int.Parse(Console.ReadLine());
        
        while(senha != 2002){
         Console.WriteLine("Senha Invalida");
         senha = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Acesso Permitido");
    }
}

// Exercicio 3.2

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    int x, valores;
    int fora = 0;
    int dentro = 0;
    
    x = int.Parse(Console.ReadLine());
    
    for(int i = 0; i < x; i++){
        valores = int.Parse(Console.ReadLine());
        if(valores < 10){
            fora = fora + 1;
        }
        else if(valores > 20){
            fora = fora + 1;
        }
        else{
            dentro = dentro + 1;
        }
    }
    Console.WriteLine(dentro + " in");
    Console.WriteLine(fora + " out");    
    }
}