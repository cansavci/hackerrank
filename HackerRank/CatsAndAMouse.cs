using System;

namespace HackerRank
{
    public static class CatsAndAMouse
    {
        public static string solution(int x, int y, int z) {
            var catADistance = Math.Abs(x-z);
            var catBDistance = Math.Abs(y-z);
            var resultString = "";
            if(catADistance < catBDistance){
                resultString = "Cat A";
            }
            else if(catADistance > catBDistance){
                resultString = "Cat B";
            }
            else {
                resultString = "Mouse C"; 
            }
            return resultString;
        }
    
    }
}
