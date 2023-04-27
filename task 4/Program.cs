/*** Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */
Console.Clear();
string [] MassivCompletion(int N){
    string [] result = new string [N];
    for(int i =0; i<N; i++){
        Console.WriteLine($"Введите {i+1} элемент массива строк");
        result[i] = Console.ReadLine();
    }
    return result;
}
void MassivPrint (string[] array){
    Console.Write("[");
    for(int i =0; i<array.Length; i++){
         Console.Write($"'{array[i]}' ");}
         Console.Write("]");
}
string[] FormingNewMassiv (string [] array){
int N =0;
   for(int i =0; i<array.Length; i++){
    if (((array[i]).Length) <= 3){
    N++;
    }}
string [] result = new string [N]; 
int j =0;
for(int i =0; i<array.Length; i++){
    if (((array[i]).Length) <= 3){
result[j]=array[i];
j++;
    }
   }
   return result;}
Console.WriteLine("Введите количество элементов массива строк:");
int N = int.Parse(Console.ReadLine());
string [] Array = MassivCompletion(N);
MassivPrint(Array);
Console.Write("->");
MassivPrint(FormingNewMassiv(Array));