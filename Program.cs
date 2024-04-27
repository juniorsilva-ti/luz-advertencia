string valorTemperatura, valorPressao, valorRotacao;
bool sensorTemperatura, sensorPressao, sensorRotacao, luzAdvertencia;

Console.Clear();
Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
Console.WriteLine("[A]tivado, [D]esativado\n");

Console.Write("Sensor de temperatura...: ");
valorTemperatura = Console.ReadLine()!.Substring(0, 1).ToUpper();

if (valorTemperatura != "A" && valorTemperatura != "D")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido - temperatura!!");
    Console.ResetColor();
    return;
}
sensorTemperatura = (valorTemperatura == "A");

Console.Write("Sensor de pressão.......: ");
valorPressao = Console.ReadLine()!.Substring(0, 1).ToUpper();

if (valorPressao != "A" && valorPressao != "D")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido - pressão!!");
    Console.ResetColor();
    return;
}
sensorPressao = (valorPressao == "A");

Console.Write("Sensor de rotação.......: ");
valorRotacao = Console.ReadLine()!.Substring(0, 1).ToUpper();

if (valorRotacao != "A" && valorRotacao != "D")
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido - rotação!!");
    Console.ResetColor();
    return;
}
sensorRotacao = (valorRotacao == "A");

luzAdvertencia = sensorTemperatura && (sensorPressao || !sensorRotacao);

Console.WriteLine($"\nA luz de advertência estará {(luzAdvertencia ? "ATIVADA" : "DESATIVADA")}");

// Console.Write("A luz de advertência estará ");
// if (luzAdvertencia)
// {
//     Console.WriteLine("ATIVADA");
// }
// else
// {
//     Console.WriteLine("DESATIVADA");
// }