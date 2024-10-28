// Tipos de Operadores

// Operador Lógico "="
int a = 10;
int b = 5;

int c = a + b;

Console.WriteLine("O valor de a + b é igual a: " + c);

// Combinando Operadores

c += 5; // 15 + 5

Console.WriteLine("O valor de c é agora: " + c);

// Convertendo Tipos de Variáveis

// O nome dado para o processo de converção de um string para inteiro, se chama "Cast" ou "Casting"

// Exemplo 1:
int d = Convert.ToInt32("5");

Console.WriteLine("O valor de d é: " + d);

// Exemplo 2:
int e = int.Parse("30");

Console.WriteLine("O valor de e é: " + e);

// Diferença entre Parse e Convert
// A diferença está no tratamento de valores nulos

// Parse: Retorna um valor inteiro caso o argumento seja um número válido, caso contrário, gera uma exceção
// Exemplo 1:

// int f = int.Parse(null);

// Console.WriteLine("O valor de f é: " + f);

// Retorna erro e encerra o programa

// Convert: Retorna um valor inteiro caso o argumento seja um número válido, caso contrário, retorna 0

int g = Convert.ToInt32(null);

Console.WriteLine("O valor de f é: " + g);

// Conversão para o tipo string

string h = a.ToString();

Console.WriteLine("O valor da string h é: " + h);

// Cast Implícito

int i = 7;
double j = i;

Console.WriteLine("O valor de j é: " + j);

// Ordem dos operadores
// C# segue a mesma ordem dos operadores matemáticos
// São eles:
// () | ^ | * | / | + | -

int k = (5 + 3) * 2 - 1;

Console.WriteLine("O valor de k é: " + k);