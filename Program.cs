System.Console.WriteLine("Введите размер массива");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] arrey = new string[sizeArr];
var rand = new Random();
for (int i = 0; i < arrey.Length; i++)
{
    int stringSize = rand.Next(1, 5);
    for (int j = 0; j < stringSize; j++)
    {
        arrey[i] += (char)rand.Next('a', 'z');
    }
}
System.Console.WriteLine("[" + string.Join(", ", arrey) + "]");
int sizeSecondArr = 0;
string[] arrThreeSize = new string[sizeSecondArr];
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i].Length == 3)
    {
        sizeSecondArr++;
        Array.Resize(ref arrThreeSize, sizeSecondArr);
        arrThreeSize[sizeSecondArr - 1] = arrey[i];
    }
}
System.Console.WriteLine("[" + string.Join(", ", arrThreeSize) + "]");