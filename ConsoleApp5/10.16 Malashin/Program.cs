var size = 200;
List<int> items = new List<int>();

for (int i = 0; i < size; i++)
    if (IsSimple(i))
        items.Add(i);

Console.WriteLine("Found simple numbers:/Найдем простые числа");
Console.WriteLine(string.Join(" ", items));
Console.WriteLine("Found pairs:/Найдены пары:");
for (int i = 0; i < items.Count; i++)
{
    for (int j = i + 1; j < items.Count; j++)
    {
        if (Math.Abs(items[i] - items[j]) == 2)
            Console.WriteLine("{0} {1}", items[i], items[j]);
    }
}
        
 
        static bool IsSimple(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= n / 2; i++)
        if (n % i == 0)
            return false;
    return true;
}
    