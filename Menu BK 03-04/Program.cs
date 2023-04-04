
//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional


Console.WriteLine(@$"

Escolha sua bebida pelo codigo:

Pepsi (1)
Coca Cola (2)
Guarana (3)
Fanta Uva (4)

");


int bebida = int.Parse(Console.ReadLine());
string gelo = "";

switch (bebida)
{
    case 1:
    Console.WriteLine($"Aceita sua pepsi com gelo? s/n ");
    gelo = Console.ReadLine().ToUpper(); 
    if (gelo == "S")
    {
        Console.WriteLine($"Gelo na bebida");
    }
    else if (gelo == "N")
    {Console.WriteLine($"Bebida sem gelo");
    }
    else 
    Console.WriteLine($"Comando nao aceito");
    
    break;

    case 2:
    Console.WriteLine($"Aceita sua Coca Cola com gelo? s/n ");
    gelo = Console.ReadLine().ToUpper(); 
    if (gelo == "S")
    {
        Console.WriteLine($"Gelo na bebida");
    }
    else if (gelo == "N")
    {Console.WriteLine($"Bebida sem gelo");
    }
    else 
    Console.WriteLine($"Comando nao aceito");
    
    break;

    case 3:
    Console.WriteLine($"Aceita seu Guarana com gelo? s/n ");
    gelo = Console.ReadLine().ToUpper(); 
    if (gelo == "S")
    {
        Console.WriteLine($"Gelo na bebida");
    }
    else if (gelo == "N")
    {Console.WriteLine($"Bebida sem gelo");
    }
    else 
    Console.WriteLine($"Comando nao aceito");
    break;

    case 4:
    Console.WriteLine($"Aceita sua Fanta Uva com gelo? s/n ");
    gelo = Console.ReadLine().ToUpper(); 
    if (gelo == "S")
    {
        Console.WriteLine($"Gelo na bebida");
    }
    else if (gelo == "N")
    {Console.WriteLine($"Bebida sem gelo");
    }
    else 
    Console.WriteLine($"Comando nao aceito");
    break;
    
    default:
    Console.WriteLine($"Nenhuma bebida selecionada");
    break;
}