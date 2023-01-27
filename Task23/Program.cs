// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)

{
  int answer = 1;
  int length = cube.Length;
  while (answer <  length){
    cube[answer] = Convert.ToInt32(Math.Pow(answer, 3));
    answer++;
  }
}

void PrintNum(int[] coll)

{
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] num = new int[cube+1];
Cube(num);
PrintNum(num);