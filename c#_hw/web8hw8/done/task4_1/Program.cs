int[,] mass = new int[4,4];

mass = FullWithMinus1(mass);

System.Console.WriteLine();

mass = FullMass(mass);
Print2DArray(mass);




int[,] FullWithMinus1(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = -1;
        }
    }
    return mass;
}

int [,] FullMass(int[,] mass)
{
    int index = 1;
    int turn = 1;
    int falseIndex1 = 0;
    int falseIndex2 = 0;
    int falseIndex3 = 0;
    int falseIndex4 = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        if (turn % 4 == 1)
        {
            for (int j = turn/4  ; j < mass.GetLength(1) - turn/4; j++)
            {
                if (mass[i ,j] == -1)
                    mass[i ,j] = index++;
                falseIndex1 = j ;
            } 
            turn++;  
        }
        if (turn % 4 == 2)
        {
            for (int k = turn/4; k < mass.GetLength(1) - turn/4; k++)
            {
                if (mass[k,falseIndex1] == -1)
                    mass[k,falseIndex1] = index++;
                falseIndex2 = k ;
            } 
            turn++;    
        }
        if (turn % 4 == 3)
        {
            for (int t = mass.GetLength(0) - turn/4 - 1; t >= 0; t--)
            {
                if (mass[falseIndex2,t] == -1)
                    mass[falseIndex2,t] = index++;
                falseIndex3 = t ;
            } 
            turn++;  
        }
        if (turn % 4 == 0)
        {
            for (int r = mass.GetLength(1) -1 ; r > 0; r--)
            {
                
                if (mass[r, falseIndex3] == -1)
                    mass[r, falseIndex3] = index++;
                
                falseIndex4 = r;
            }  
            turn++;             
        }
        
        

      
    }
   
    return mass;

}


void Print2DArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}