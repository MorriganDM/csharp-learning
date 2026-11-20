int[] array = {4, 8, 12, 16, 20};

int sum = 0;

for (int i = 0; i < array.Length; i++){
    sum = sum + array[i];
}

Console.WriteLine("Total = " + sum);