using System.IO;
using System;

public static class NumberLineJump
{
        public static string solution(int x1, int v1, int x2, int v2) {
        var startDiff = Math.Abs(x1-x2);
        var jumpDiff = Math.Abs(v1-v2);
        if(startDiff != 0 && jumpDiff != 0){
            double aa = startDiff / jumpDiff;
            if(aa.Equals(Math.Ceiling(aa))){
                if((aa*v1)+x1 == (aa*v2)+x2){
                    return "YES";
                }
                else{
                    return "NO";
                }
                
            }
            else {
                return "NO";
            }
        }
        else{
            return "NO";
        }

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
