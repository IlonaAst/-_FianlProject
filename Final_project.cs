string[] mass = {"hello", "2", "world", ":)"};
Console.Write("["); 
    for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i].Length <= 3)
            {
                Console.Write($"'{mass[i]}'");
                if (i < mass.Length - 2)
                {
                    Console.Write(", ");
                } 
            }
        }
        Console.WriteLine("]");
      
            
                