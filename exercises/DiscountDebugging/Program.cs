int[] nums = { 14, 7, 32, 19, 45, 11 };

if (nums.Length == 0){
    Console.WriteLine("O array está vazio.");
} else {
    int max = nums[0];

    for (int i = 0; i < nums.Length; i++) {
        if (nums[i] > max) {
            max = nums[i];
        }
    }

    Console.WriteLine("Maior valor: " + max);
}