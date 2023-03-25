//Um progrrama que exiba o primeiro caractere digitado, ignorando espaços em branco.

String Texto;

Console.Write("Digite algo que...: ");
Texto = Console.ReadLine()!;

Console.WriteLine(Texto.Trim().Substring(0, 1));

