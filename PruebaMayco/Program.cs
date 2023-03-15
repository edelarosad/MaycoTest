// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Data.Common;

string mensaje = string.Empty;
bool flag3 = false;
bool flag5 = false;

for(int i = 1;i <= 150; i++)
{
    flag3 = false; flag5 = false ;

    if(i%3 == 0)
    {
        mensaje= "Mayco";
        flag3 = true;
    }
    
    if(i%5 == 0)
    {
        mensaje = "Dupplo";
        flag5 = true;
    }

    if(flag3 && flag5) 
    {
        Console.WriteLine("MaycoDupplo");
    }

    if(flag3 && !flag5)
    {
        Console.WriteLine(mensaje);
    }

    if(flag5 && !flag3)
    {
        Console.WriteLine(mensaje);
    }

    if(!flag3 && !flag5)
    {
        Console.WriteLine(i.ToString());
    }

    
}