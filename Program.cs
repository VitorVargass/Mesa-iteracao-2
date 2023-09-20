using System.Transactions;

static void Problema_1()
{
    Console.WriteLine("Digite o valor presente em mãos: ");
    int valorP = int.Parse(Console.ReadLine());
     double taxa = 5.30 / 100;
    Console.WriteLine("Digite o numero de meses da aplicação: ");
    int numeroMeses = int.Parse(Console.ReadLine());
    double calc = valorP * Math.Pow(1 + taxa, numeroMeses);
    Console.WriteLine($"O valor ao fim do rendimento é: {calc:C}");
}
static void Problema_2()
{
    int valorP = 3800;
    double taxa = 1.25 / 100;
    int numeroMeses = 6;
    double[] somado = new double[12];
    for (int i = 1; i <= numeroMeses; i++)
    {
        somado[i] = valorP * Math.Pow(1 + taxa, i + 1);
        Console.WriteLine($"O valor no mes {i} é {somado[i]:C} ");
    }
}
static void Problema_3()
{
    Console.WriteLine("Digite o valor inicial:");
    double ValorDigitado = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite qual a taxa de juros: ");
    double JurosDigitado = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Digite o quanto tempo durará a aplicação em anos: ");
    double AnosDigitado = Convert.ToInt32(Console.ReadLine());
    double valorFinal = ValorDigitado * Math.Pow(1 + JurosDigitado / 100, AnosDigitado);
    Console.WriteLine($"O Valor {ValorDigitado:C} sendo aplicado {JurosDigitado}% de juros durante " +
        $"{AnosDigitado} anos resultará no valor final {valorFinal:C}");
}
static void Problema_4()
{
    Console.WriteLine("Digite o valor presente:");
    double valorP = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o valor da taxa de juros a ser aplicado:");
    double taxa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o numero de meses da aplicação:");
    int numeroMeses = Convert.ToInt32(Console.ReadLine());
    double[] somado = new double[12];
    for (int i = 1; i <= numeroMeses; i++)
    {
        somado[i] = valorP * Math.Pow(1 + taxa / 100, i);
        Console.WriteLine($"O valor acumulado no mes {i} é {somado[i]:C}");
    }
    Console.WriteLine("Digite quanto sera o valor do resgate no 5º mes:");
    double resgate = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"O saldo apos o resgate de {resgate:C} no 5º mes é {somado[5] - resgate:C}") ;
}
static void Problema_5()                    //VP = VF/(1+i)t  7390,61
                                        
{
    Console.WriteLine("Digite em reais o valor futuro que deseja obter: ");
    double VF = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite em anos o periodo: ");
    double periodo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o valor da taxa em %");
    double taxa = Convert.ToDouble(Console.ReadLine());  // obs: precisa usar o virgula para digitar                                                        // a taxa, com o ponto ele buga 
    double VP = VF / Math.Pow(1 + taxa / 100, periodo);  // a taxa, com o ponto ele buga 
    Console.WriteLine($"O Valor presente necessario é {VP:C} com {taxa}% de juros aplicado durante " +
        $"{periodo} anos para que chegue no valor futuro {VF:C}");

}
static void Load()
{
    Console.WriteLine("Digite o numero do exercicio de 1 ao 5:");
    string cond = Console.ReadLine();
    switch(cond)
    {
        case "1":
            {
               Problema_1();
                break;
            }
        case "2": {
                Problema_2();
                break;
            }
        case "3": {
                Problema_3();
                break;
            }
        case "4":
            {
                Problema_4();
                break;
            }
        case "5":
            {
                Problema_5();
                break;
            }
    }
}
Load();

