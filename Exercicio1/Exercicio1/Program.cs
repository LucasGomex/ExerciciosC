double area, valor, valordesconto, dezdesconto, resultado;
string pulverizacao;

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Tipo 1 – ervas daninhas R$ 50,00 por acre;  ");
Console.WriteLine("Tipo 2 – gafanhotos R$ 100,00 por acre;  ");
Console.WriteLine("Tipo 3 – broca R$ 150,00 por acre;  ");
Console.WriteLine("Tipo 4 – todos acima R$ 250,00 por acre.  ");
Console.WriteLine("-------------------------------------------------------");

Console.Write("Digite o Tipo de Pulverização:  ");
pulverizacao = Console.ReadLine();

Console.Write("Digite a area a ser pulverizada em Acres:  ");
area = double.Parse(Console.ReadLine());

if (pulverizacao == "1")
{
    if (area > 1000)
    {
        valor = (area * 50);
        valordesconto = valor * 0.05;
        dezdesconto = (valor - 750) * 0.1;
        resultado = valor - (valordesconto + dezdesconto);

        Console.Write("O valor a ser pago é de:   " + resultado);
    }
    else
    {
        Console.Write("Sem desconto!!!");
    }
}
else if (pulverizacao == "2")
{
    if (area > 1000)
    {
        valor = (area * 100);
        valordesconto = valor * 0.05;
        dezdesconto = (valor - 750) * 0.1;
        resultado = valor - (valordesconto + dezdesconto);

        Console.Write("O valor a ser pago é de:   " + resultado);
    }
    else
    {
        Console.Write("Sem desconto!!!");
    }
}
else if (pulverizacao == "3")
{
    if (area > 1000)
    {
        valor = (area * 150);
        valordesconto = valor * 0.05;
        dezdesconto = (valor - 750) * 0.1;
        resultado = valor - (valordesconto + dezdesconto);

        Console.Write("O valor a ser pago é de:   " + resultado);
    }
    else
    {
        Console.Write("Sem desconto!!!");
    }
}
else if (pulverizacao == "4")
{
    if (area > 1000)
    {
        valor = (area * 250);
        valordesconto = valor * 0.05;
        dezdesconto = (valor - 750) * 0.1;
        resultado = valor - (valordesconto + dezdesconto);

        Console.Write("O valor a ser pago é de:   " + resultado);
    }
    else
    {
        Console.Write("Sem desconto!!!");
    }
}

Console.ReadKey();
