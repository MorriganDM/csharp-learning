int[] nums = {5, 10, 15, 20, 25, 30};

int counter = 0;

for (int i = 0; i < nums.Length; i += 2) {
    Console.WriteLine(nums[i]);
    counter ++;
}

Console.WriteLine("Total elements printed: " + counter);a