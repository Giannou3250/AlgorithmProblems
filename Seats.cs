public class Solution {
    public int MaxDistToClosest(int[] seats) 
    {
        // iterate through the array 
       //wherever you are located in the array 
       // keep track of the empty seats you have spanning out to the left and right of your position
    // have a tracker of two values set LEFTSIDE and RIGHTSIDE which counts the empty seats of both sides
    // update leftside and rightside if your new position has higher leftside and rightside than before.
    // do to additional test cases that track edge cases (both ends of the array.)
        
        int maxRightSide = 0;
        int EdgeCaseLeft = 0;
        int EdgeCaseRight = 0;
        int note = 0;
        int a = 0;
        int tempRightSide = 0;
        for (int i = 0; i < seats.Length; i++)
        {

            if (seats[i] == 1)
            {
                 if (tempRightSide > maxRightSide)
                {
                    maxRightSide = tempRightSide;
                     a = note;
                    
                }
                tempRightSide = 0;
            }
            else
            {
               
                    tempRightSide++;
    
            }
            note++;
        }
        
        
        for (int i = 0; seats[i] != 1; i++)
        {
            EdgeCaseLeft++;
        }
        for (int i = seats.Length-1; seats[i] != 1; i--)
        {
            EdgeCaseRight = i;
        }
        if (EdgeCaseLeft >= EdgeCaseRight && EdgeCaseLeft >= maxRightSide)
        {
            return EdgeCaseLeft;
        }
        else if (EdgeCaseRight >= EdgeCaseLeft && EdgeCaseRight >= maxRightSide)
        {
            return EdgeCaseRight;
        }
        else if (maxRightSide % 2 == 0)
        {
            int final = (maxRightSide - maxRightSide + a) / 2;
            return final;
        }
        else
        {
            int final = (maxRightSide - maxRightSide + a) / 2;
            return final;
        }
    }
}
