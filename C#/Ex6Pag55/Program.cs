// See https://aka.ms/new-console-template for more information - Estou fazendo na nova versão do console porque não consegui achar a do laboratório ;)
Console.WriteLine("1 - Atlético/MG");
Console.WriteLine("2 - Cruzeiro/MG");
Console.WriteLine("3 - Flamengo/RJ");
Console.WriteLine("4 - Corinthians/SP");
Console.WriteLine("5 - Outros");
Console.WriteLine("6 - Sair");

string? nome;
string? sexo;
int idade = 0;
int time = 0;
double TotalAtletico = 0;
double TotalOutros = 0;
double TotalCorinthians = 0;
double TotalFlamengo = 0;
double PorcentagemTotalAtletico = 0;
double PorcentagemTotalOutros = 0;
double PorcentagemAte30Flamengo = 0;
double PorcentagemTotalAte30Flamengo = 0;
double MeninasAtletico = 0;
double Ate30Flamengo = 0;
string TimePreferido = "Os dois possuem a mesma quantidade de torcedores!";
double total = 0;
Console.Write("Time: ");
time = int.Parse(Console.ReadLine());
while (time != 6)
{
    
    Console.Write("Nome: ");
    nome = Console.ReadLine();
    Console.Write("Sexo (M/F): ");
    sexo = Console.ReadLine();
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.Write("Time: ");
    

    if (time == 1)
    {
        TotalAtletico++;
    }

    if (time == 5)
    {
        TotalOutros++;
    }

    if (time == 4)
    {
        TotalCorinthians++;
    }

    if (time == 3)
    {
        TotalFlamengo++;
    }

    if (sexo == "F" && time == 1)
    {
        MeninasAtletico++;
    }

    if (idade <= 30 && time == 3)
    {
        Ate30Flamengo++;
    }

    total++;
    time = int.Parse(Console.ReadLine());
}

PorcentagemTotalAtletico = TotalAtletico / total * 100;
PorcentagemTotalOutros = TotalOutros / total * 100;
PorcentagemAte30Flamengo = Ate30Flamengo / TotalFlamengo * 100;
PorcentagemTotalAte30Flamengo = Ate30Flamengo / total * 100;

if (TotalAtletico > TotalCorinthians)
{
    TimePreferido = "Atlético/MG";
}
else if (TotalAtletico < TotalCorinthians)
{
    TimePreferido = "Corinthians/SP";
}


Console.WriteLine("A) Número de pessoas que torcem pelo Atlético/MG, com a respectiva porcentagem: " + TotalAtletico + " | " + PorcentagemTotalAtletico.ToString("f2") + "%" );
Console.WriteLine("B) Número de pessoas que não torcem para nenhum dos quatro times apresentadis, com a respectiva porcentagem: " + TotalOutros + " | " + PorcentagemTotalOutros.ToString("f2") + "%");
Console.WriteLine("C) Entre Atlético/MG e Corinthians/SP, qual é o time preferido: " + TimePreferido);
Console.WriteLine("D) Quantidade de pessoas do sexo feminino que torcempara o Atlético/MG: " + MeninasAtletico);
Console.WriteLine("E) Porcentagem de pessoas com até 30 anos que torcem pelo Flamengo/RJ: " + PorcentagemAte30Flamengo);
//Eu entendi que a porcentagem de pessoas de ate 30 anos que torcem pelo flamengo é pelo total de pessoas que torcem pelo flamengo
Console.WriteLine("E) Porcentagem de pessoas com até 30 anos que torcem pelo Flamengo/RJ: " + PorcentagemTotalAte30Flamengo);
//Agora esse é a porcentagem sobre o total de pessoas
Console.ReadKey();