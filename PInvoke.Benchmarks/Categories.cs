namespace PInvoke.Benchmarks;

internal static class Categories
{
    public const string Managed = nameof(Managed);

    public const string Empty = nameof(Empty);
    public const string ReturnInt = nameof(ReturnInt);
    public const string InReturnInt = nameof(InReturnInt);
    public const string InReturnBool = nameof(InReturnBool);
    public const string InArray = nameof(InArray);
    public const string OutArray = nameof(OutArray);
    public const string InDoubleArray = nameof(InDoubleArray);
    public const string InString = nameof(InString);
    public const string OutString = nameof(OutString);
    public const string InStruct = nameof(InStruct);
    public const string OutStruct = nameof(OutStruct);
    public const string NonBlittable = nameof(NonBlittable);
    public const string SGCT = nameof(SGCT);
}
