using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 14 + .NET 10 | Unbound generic support for nameof *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();
Console.WriteLine($"nameof(List<object>) = {nameof(List<object>)}");
Console.WriteLine($"nameof(HashSet<int>) = {nameof(HashSet<int>)}");
Console.WriteLine($"nameof(IEnumerable<string>) = {nameof(IEnumerable<string>)}");

Console.WriteLine();
Console.WriteLine($"nameof(List<>) = {nameof(List<>)}");
Console.WriteLine($"nameof(HashSet<>) = {nameof(HashSet<>)}");
Console.WriteLine($"nameof(IEnumerable<>) = {nameof(IEnumerable<>)}");