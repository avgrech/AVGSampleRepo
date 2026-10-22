public static class Calculator
{
    // Return a floating-point average; empty input is rejected.
    public static double Average(int[] values)
    {
        if (values.Length == 0) throw new ArgumentException("Empty input");
        return values.Sum() / values.Length;
    }

    // Return an item by zero-based index; invalid indexes return null.
    public static string? ItemAt(string[] values, int index)
    {
        if (index < 0 || index > values.Length) return null;
        return values[index];
    }
}
