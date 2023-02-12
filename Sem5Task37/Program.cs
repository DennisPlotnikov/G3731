// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] Gen1DArr(int len, int b, int e)
{
    int[] arr = new int[len];

    Random gen = new Random();

    for (int i = 0; i < len; i++)
    {
        arr[i] = gen.Next(b, e);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] NumberProduct(int [] arr)

{
    int[] resArr = new int[arr.Length/2+1];
    for (int i = 0; i < resArr.Length; i++)
    {
            resArr[i]=arr[i]*arr[arr.Length-i-1];
    }
    return resArr;
}

int[] arr = Gen1DArr(10, 0, 10);

int[] result = NumberProduct(arr);

Print1DArr(arr);
Print1DArr(result);