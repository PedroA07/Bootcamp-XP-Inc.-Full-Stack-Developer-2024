// Tipos de dados:

string apresentacao = "Olá, Mundo!"; // Cadeia de caracteres

int quantidade = 1; // Valor numérico inteiro

double altura = 1.70; // Valor com casas decimais
// OBS.: porém o tipo double ignora o zero

decimal preco = 2.99M; // Valor monetário
// OBS.: Quando passado o valor assim que declarado no tipo decimal, deverá ser inserido o "M" logo em seguida

bool condicao = true; // Valor condicional para verdadeiro ou falso

Console.WriteLine("Valor da variável apresentacao: " + apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// "ToString("0.00")", usado para mostrar obrigatoriamente a quandtidade de casas decimais
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variávelcondicao: " + condicao);

// Tipo DateTime
DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data e hora atual: " + dataAtual);
Console.WriteLine("Data e hora sem milisegundos: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine("Apenas data: " + dataAtual.ToString("dd/MM/yyyy"));