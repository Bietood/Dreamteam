int anterior, nr, car;
int[] top3 = new int[3];
 
string[] lista = {
    "1º Koenigsegg Jesko Absolut (531 km/h)",
    "2º Hennessey Venom F5 (500 km/h)",
    "3º Bugatti Chiron Super Sport 300+ (489 km/h)",
    "4º SSC Tuatara (470 km/h)",
    "5º Koenigsegg Agera RS (440 km/h)",
    "6º Hennessey Venom GT (434 km/h)",
    "7º Bugatti Veyron Super Sport (428 km/h)",
    "8º Bugatti Chiron (421 km/h)",
    "9º Koenigsegg Agera R (420 km/h)",
    "10º Rimac Nevila (411 km/h)",
};
 
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("**Top 10 Carros mais rápidos do mundo** ");
Console.ResetColor();
Console.WriteLine();
 
for (nr = 0; nr < 10; nr++)
{
    Console.WriteLine($"   {lista[nr]}");
}
 
Console.WriteLine();
Console.WriteLine("Entre os 10 carros listados, selecione 3 dos seus preferidos");
 
for (nr = 0; nr < 3; nr++)
{
    while (true)
    {
        Console.Write($"({nr} escolhidos) Adicione a Sua Lista o Top: ");
        car = Convert.ToInt32(Console.ReadLine());
 
        car--;
 
        if (car < 0 || car >= 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!Digite somente os números do Top 10!!!!");
            Console.ResetColor();
            continue;
        }
 
        bool jaEscolhido = false;
        for (anterior = 0; anterior < nr; anterior++)
        {
            jaEscolhido = top3[anterior] == car;
            if (jaEscolhido) break;
        }
 
        if (jaEscolhido)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!Carro já incluído no seu top 3!!!");
            Console.ResetColor();
            continue;
        }
 
        break;
    }
 
    top3[nr] = car;
}
 
Console.WriteLine(" Seu top 3 é: ");
for (nr = 0; nr < 3; nr++)
{
    Console.WriteLine($"  {nr + 1} - {lista[top3[nr]]}");
}