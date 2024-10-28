// Convertendo de Maneira Segura

string a = "15";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);

// Agora tentando com um valor inválido

string c = "15g";

int.TryParse(c, out int d);

Console.WriteLine(d); // Imprime 0, pois o TryParse não lida com caracteres inválidos