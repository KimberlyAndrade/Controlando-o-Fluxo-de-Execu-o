int[] lista = {1,2,3,4,5};
foreach(int numero in lista)
{
    Console.WriteLine(numero);
}


static void Exemplo1()
{
    Boolean condicao = true;
    int valor;

    while (condicao == true)
    {
        Console.WriteLine("Digite um valor, 0 para sair");
        valor = int.Parse(Console.ReadLine());
        if (valor == 0)
        {
            Console.WriteLine("Você saiu da aplicação");
            condicao = false;
        }
        else
        {
            Console.WriteLine($"O valor informado é {valor}");
        }
    }
}

static void Exemplo2()
{
    Boolean condicao = true;
    int valor;

    do
    {
        Console.WriteLine("Digite um valor, 0 para sair");
        valor = int.Parse(Console.ReadLine());
        if (valor == 0)
        {
            Console.WriteLine("Você saiu da aplicação");
            condicao = false;
        }
        else
        {
            Console.WriteLine($"O valor informado é {valor}");
        }
    } while (condicao == true);
}

static void Exemplo3()
{
    int valor;
    Console.WriteLine("Digite um valor: ");
    valor = int.Parse(Console.ReadLine());

    for (int i = valor; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}