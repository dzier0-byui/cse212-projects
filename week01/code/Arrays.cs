using System.Data;

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

        //create an empty list to store the result
        double[] result = new double[length];

        //create a loop for how many numbers are expected to be in the final list 'length'
        for (int i = 1; i <= length; i++)
        {
            //the item being added to the list should be 'number' (the inputted parameter) multiplied by the current loop itteration
            double newListItem = number * i;

            //add the newListItem to the result array at the position of i
            result[i - 1] = newListItem;
        }

        //return the final array
        return result;
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

        //Get the last 'amount' elements that will move to the front
        List<int> listToGoToFront = data.GetRange(data.Count - amount, amount);

        //Get the remaining elements that will go to the back
        List<int> listToGoToBack = data.GetRange(0, data.Count - amount);

        //Clear the original list
        data.Clear();

        //Add the elements that go to the front
        data.AddRange(listToGoToFront);

        //Add the remaining elements to the back
        data.AddRange(listToGoToBack);
    }
}
