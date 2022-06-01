// Напишите программу, которая переводит десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void BinaryNum(int num)
{
    string i = "";
    while (num > 0)
    {
        i = num % 2 + i;
        num = num / 2;
    }
    Console.Write(i);
}
BinaryNum(45);

