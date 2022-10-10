Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк длинна которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключетльно массивами: ");
// Создаем и заполняем массив при помощи введения его с клавиатуры: //

string [] StartArray = new string[4] {";/", "2", "world","-3"};
void PrintStartArray(string[] StartArray)
{
    int l = StartArray.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write($"{StartArray[i]}, ");
    }
    Console.WriteLine();
}
PrintStartArray(StartArray);


