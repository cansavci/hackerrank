using System;
using System.Collections.Generic;

namespace HackerRank
{
    public static class DiagonalDifference
    {
        public static int solution(List<List<int>> arr)
        {
            int leftDiagonal = 0 ;
            int rightDiagonal = 0 ;
            int n = arr.Count;

            for(int i = 0 ; i<n ; i++){
                leftDiagonal = leftDiagonal + arr[i][i];
            }
            
            int size = n-1;
            for(int j = 0; j < n; j++){
                rightDiagonal = rightDiagonal + arr[j][size];
                size--;
            }
            return Math.Abs(leftDiagonal-rightDiagonal);
        }

    }
}
