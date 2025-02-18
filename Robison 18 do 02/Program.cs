double A, B, C, R, S, O;

Console.WriteLine("Escreva A:");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva B:");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva C:");
C = int.Parse(Console.ReadLine());

R = Math.Pow(A + B, 2);
S = Math.Pow(B + C, 2);
O = (R + S) / 2;
Console.WriteLine("Resultado:");
Console.WriteLine(O);

if (O <= 100)
  
{
    Console.WriteLine("Menor que 100");
}
else
{
    Console.WriteLine("Maior que 100");
}