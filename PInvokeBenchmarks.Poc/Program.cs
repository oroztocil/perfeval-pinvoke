namespace PInvokeBenchmarks.Poc;

public static class Program
{
    public static int Main(string[] args)
    {
        NativeFunctions.Hello();
        
        int answer = NativeFunctions.Answer();

        Console.WriteLine(answer);

        int weed = NativeFunctions.Mul2(210);

        Console.WriteLine(weed);

        NativeFunctions.ShoutAtMe("Hello, friend");

        return 0;
    }
}