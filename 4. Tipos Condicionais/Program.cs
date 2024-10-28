// Tipos Condicionais

int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// if, else if e else
if (possivelVenda == 0) {
    Console.WriteLine("Venda inválida");
} else if (possivelVenda) {
    Console.WriteLine("Venda realizada")
} else {
    Console.WriteLine("Estoque insuficiente");
}

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

// switch case
switch (letra) {
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}