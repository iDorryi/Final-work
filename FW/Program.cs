Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк длинна которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключетльно массивами: ");
// 1. Создаем и заполняем стартовый массив при помощи заданных строковых значений //
string [] StartArray = new string[4] {";/", "hello", "world","-3"};
// 2. Функция для печати массива
void PrintArray(string[] StartArray)
{
    int l = StartArray.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write($"{StartArray[i]}, ");
    }
    Console.WriteLine();
}
// 3. Создаем новый массив
string[] FinalArray = new string[StartArray.Length];
// 4. Создаем функцию для ввода нового массива, в котором длинна строк <= 3 символам
void Result(string[] StartArray, string[] FinalArray)
{
int count = 0;
  for(int i = 0; i < StartArray.Length; i++)
 {
  if (StartArray[i].Length <= 3) 
   {
    FinalArray[count] = StartArray[i]; 
    count++;
   }
 }
}
Result(StartArray, FinalArray);
PrintArray(StartArray);
PrintArray(FinalArray);

 




