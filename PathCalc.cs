using UnityEngine;

public class PathCalc
{
    //the y val is the same because game start at floor level 1 
    int? y = 1;

    //Each cube in Aaskaths funciton is 2x2x2 so the increment is half of that, because cubes are centered 
    int incr = 1;

    // The basic cordinots that gets adjusted and tracked by every operation 
    int[] baseCords = { 0, y, 0 };


    int j = 5
    while (j > 2){

        // First section in the spiral of j cube lenths. Going to right side in the x 
        for (int i = 1; i <= j; i++)
        { 
            baseCords[0] += 1;
            cordCollected = AppendTo2DArray(cordCollected, baseCords);
        }
        //2nd section in the spiral of j cube lenths. Going forward in the z 
        for (int i = 1; i <= j; i++)
        {
            baseCords[2] += 1;
            cordCollected = AppendTo2DArray(cordCollected, baseCords);
}
        // 3rd section in the spiral of j cube lenths. Going back to the left side in the x 
        for (int i = 1; i <= j; i++)
        {
            baseCords[0] -= 1;
            cordCollected = AppendTo2DArray(cordCollected, baseCords);
}

        // 4th section in the spiral of j cube lenths. Going backward in the z excluding one block.
        for (int i = 1; i <= (j-1); i++)
        {
            baseCords[2] -= 1;
            cordCollected = AppendTo2DArray(cordCollected, baseCords);
}

        j--;
    }


    //Holdings the cords in a 2 dimensional array each 1 dimesnion setion has a 1 dimension vector of 3 cords 
    int[,] cordCollected = {};
}

// Function to append a row (baseCords) to the 2D array
    public static int[,] AppendTo2DArray(int[,] multiArray, int[] baseCords)
{

    int rows = multiArray.GetLength(0) + 1; // original row count + 1. because everuhting is fixed 
    int cols = baseCords.Length; // number of columns in the new row. should be consistenty 

    // Create a new 2D array with the updated size
    int[,] newArray = new int[rows, cols];

    // Copy existing rows from the original 2D array to the new 2D array
    for (int i = 0; i < multiArray.GetLength(0); i++)
    {
        for (int j = 0; j < multiArray.GetLength(1); j++)
        {
            newArray[i, j] = multiArray[i, j];
        }
    }

    // Add the new row (baseCords)
    for (int i = 0; i < baseCords.Length; i++)
    {
        newArray[multiArray.GetLength(0), i] = baseCords[i];
    }

    return newArray;
}
}