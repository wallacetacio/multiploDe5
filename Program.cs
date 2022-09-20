Console.Write("Digite um número: ");

double num = Convert.ToDouble(Console.ReadLine());

if(num%5 == 0){
    Console.WriteLine($"O número {num} é múltiplo de 5.");
} else {
    Console.WriteLine($"O número {num} não é múltiplo de 5.");
}
Console.ReadKey();