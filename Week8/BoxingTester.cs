namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; 
        
        object b = a; 
        
        int c = (int)b; 
        
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"c: {c}");
  
        // створено int а, яка зберігається у stack
        // новий об'єкт b додається до heap (boxing) і зберігає посилання на значення а 
        // витягується змінна з heap і вставляється у с (unboxing)
    }
}