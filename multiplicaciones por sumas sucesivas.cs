// See https://aka.ms/new-console-template for more information
Console.WriteLine("MULTIPLICACIONES POR SUMAS SUCESIVAS");
int MultPorSumas(int num1, int num2)
{
    int resultado = 0;
    for (int i = 0; i < num2; i++)
    {
        resultado = resultado + num1;
    }
    return resultado;
}
void multi()
{
    Console.WriteLine("Ingrese el primer número para multiplicar:");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número para multiplicar:");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int resultado = MultPorSumas(n1, n2);
    Console.WriteLine("El resultado de la multiplicación es: " + resultado);


}
multi();
