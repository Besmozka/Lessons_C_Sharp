public static int StrangeSum(int[] inputArray)
{
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++) // N * N * N
    {
        for (int j = 0; j < inputArray.Length; j++) // N * N
        {
            for (int k = 0; k < inputArray.Length; k++) // N
            {
                int y = 0;  // 1

                if (j != 0)     // 1
                {
                    y = k / j;  // 1
                }

                sum += inputArray[i] + i + k + j + y;  // 1
            }
        }
    }

    return sum;
}


Итоговая асимптотическая сложность равна О(N*N*N)