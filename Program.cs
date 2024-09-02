using static System.Console;

string mes = "";
WriteLine("Digite um número de um mês: ");
mes = ReadLine();

switch (mes)
{
    case "1":
        WriteLine("Janeiro");
        break;
    case "2":
        WriteLine("Fevereiro");
        break;
    case "3":
        WriteLine("Março");
        break;
    case "4":
        WriteLine("Abril");
        break;
    case "5":
        WriteLine("Maio");
        break;
    case "6":
        WriteLine("Junho");
        break;
    case "7":
        WriteLine("Julho");
        break;
    case "8":
        WriteLine("Agosto");
        break;
    case "9":
        WriteLine("Setembro");
        break;
    case "10":
        WriteLine("Outubro");
        break;
    case "11":
        WriteLine("Novembro");
        break;
    case "12":
        WriteLine("Dezembro");
        break;
    default:
        WriteLine("Digite um mês válido");
        break;
}

