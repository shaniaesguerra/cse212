public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //store the multiples of the numer in an array of doubles
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple of 'number'
            // Formula: number times (i + 1) to get the next multiple (starts from 1, not 0)
            double multiple = number * (i + 1); 
            // Store the result in the array at index 'i'
            multiples[i] = multiple;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Get the list of data at the end of the list depending on the amount
        var dataToFront = data.GetRange(data.Count - amount, amount);
        //Remove the data from the end of the list
        data.RemoveRange(data.Count - amount, amount);
        //Insert the data at the front of the list
        data.InsertRange(0, dataToFront);
    }
}
