// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.

 int[,] m = new int[5, 5];
            bool flag = false;
            for (int i = 0; i < 5; i++) 
                for (int j = 0; j < 5; j++)
                {
                  // Console.WriteLine("Введите a[" + i + "," + j + "]:");
                    m[i, j]=Random.Next(1,10);//int.Parse(Console.ReadLine());
                    if (m[i, j] != m[j, i]) 
                        flag = false;
                    else 
                        flag = true;
                }
 
 
            if (flag) 
                Console.WriteLine("Симметрична");
            else 
                Console.WriteLine("Не симметрична");
        
