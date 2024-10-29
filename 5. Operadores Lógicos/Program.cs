// Operador OR

bool maiorDeIdade = true;
bool possuiAutorizacao = false;

if (maiorDeIdade || possuiAutorizacao) {
    Console.WriteLine("Entrada liberada");
} else {
    Console.WriteLine("Entrada negada");
}

// Operador AND

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7) {
    Console.WriteLine("Aprovado");
} else {
    Console.WriteLine("Reprovado");
}

// Operador NOT

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde) { // Para negar uma variável, basta apenas adicionar o sinal de "!" antes dela
    Console.WriteLine("Vou pedalar");
} else {
    Console.WriteLine("Não vou pedalar");
}