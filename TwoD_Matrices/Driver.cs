namespace TwoD_Matrices
{
    public static class Common{
        public static void PrintMatrix(int[][] mat){
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write(mat[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    public class Matrix{
        public int N {get; set;}
        public int M {get; set;}
        public int[][]? mat {get; set;}
    }

    public class Driver{

            Solution s = new Solution();

             public void Options()
        {
            Console.WriteLine("Row Wise Sum of Matrix: Press 1 --");
            Console.WriteLine("Column Wise Sum of Matrix: Press 2 --");
            Console.WriteLine("Max Row Sum in Matrix: Press 3 --");
            Console.WriteLine("Min Row Sum in Matrix: Press 4 --");
            Console.WriteLine("Max Column Sum in Matrix: Press 5 --");
            Console.WriteLine("Min Column Sum in Matrix: Press 6 --");
            Console.WriteLine("Print diagonals of Matrix: Press 7 --");
            Console.WriteLine("Transpose Matrix: Press 8 --");
            Console.WriteLine("Rotate Clockwise: Press 9 --");
            // Console.WriteLine("Special Index of an array: Press 10 --");
            // Console.WriteLine("Count A G pairs in an array: Press 11 --");
            // Console.WriteLine("Closest Min Max in an array: Press 12 --");
            // Console.WriteLine("Leaders in an array: Press 13 --");
            // Console.WriteLine("All Sub Arrays in an array: Press 14 --");
            // Console.WriteLine("Max Sub Array Sum in an array: Press 15 --");
            // Console.WriteLine("All Sub Array Sum in an array: Press 16 --");
            // Console.WriteLine("Starting Index of Least Average Sub Array Sum in an array: Press 17 --");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                switch (Convert.ToInt32(input))
                {
                    case 1:
                        CallRowWiseSum();
                        break;
                    case 2: 
                        CallColWiseSum();
                        break;
                    case 3: 
                        CallMaxRowSum();
                        break;
                    case 4: 
                        CallMinRowSum();
                        break;
                    case 5: 
                        CallMaxColSum();
                        break;
                    case 6: 
                        CallMinColSum();
                        break;
                    case 7: 
                        CallPrintDiagonals();
                        break;
                    case 8: 
                        CallTransposeMatrix();
                        break;
                    case 9: 
                        CallRotateClockwise();
                        break;
                    // case 10: 
                    //     CallSpecialIndexes();
                    //     break;
                    // case 11: 
                    //     CallCountAGPairs();
                    //     break;
                    // case 12: 
                    //     CallClosestMinMax();
                    //     break;
                    // case 13: 
                    //     CallLeaders();
                    //     break;
                    // case 14: 
                    //     CallAllSubArrays();
                    //     break;
                    // case 15: 
                    //     CallmaxSubArraySum();
                    //     break;
                    // case 16: 
                    //     CallGetSumOfAllSubArrays();
                    //     break;
                    // case 17:
                    //     Call_GetIndexOfSubarrayOfSizeBWithLeastAverage();
                    //     break;
                    default: 
                        Console.Clear();    
                        break;
                }
            }
        }

        public Matrix GetMatrix(){
            #region get matrix
            Console.Clear();

            Matrix m = new Matrix();
            
            Console.WriteLine("Enter no of rows (N)");
            m.N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no of columns (M)");
            m.M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Integer Matrix of size N x M with spaces in between");

            string? line = Console.ReadLine();
            string[] n_mat_str = string.IsNullOrEmpty(line) ? new string[0] : line.Split(' ');

            m.mat = new int[m.N][];
            int counter = 1;
            for (int i = 0; i < m.N; i++)
            {
                counter--;
                int[] tempArr = new int[m.M];
                for (int j = 0; j < m.M; j++)
                {
                    tempArr[j] = Convert.ToInt32(n_mat_str[i+counter]);
                    counter++;
                }
                m.mat[i] = tempArr;
            }

            Console.WriteLine("Input Matrix is :");
            Common.PrintMatrix(m.mat);
            #endregion
            return m;
        }
        
        
        public void CallRowWiseSum(){

            Matrix m = GetMatrix();

            int[] rowWiseSum = s.GetRowWiseSum(m.mat ?? new int[m.N][], m.N, m.M);

            Console.WriteLine("Row Wise sum is :");
            for (int i = 0; i < rowWiseSum.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(rowWiseSum[i]));
            }
        }

        public void CallColWiseSum(){

            Matrix m = GetMatrix();

            int[] colWiseSum = s.GetColumnWiseSum(m.mat ?? new int[m.N][], m.N, m.M);

            Console.WriteLine("Column Wise sum is :");
            for (int i = 0; i < colWiseSum.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(colWiseSum[i]));
            }
        }

        public void CallMaxRowSum(){
            Matrix m = GetMatrix();
            int maxRowSum = s.MaxRowSum(m.mat ?? new int[m.N][], m.N, m.M);
            Console.WriteLine("Max Row sum is :" + maxRowSum);
        }

        public void CallMinRowSum(){
            Matrix m = GetMatrix();
            int minRowSum = s.MinRowSum(m.mat ?? new int[m.N][], m.N, m.M);
            Console.WriteLine("Min Row sum is :" + minRowSum);
        }

        public void CallMaxColSum(){
            Matrix m = GetMatrix();
            int maxColSum = s.MaxColSum(m.mat ?? new int[m.N][], m.N, m.M);
            Console.WriteLine("Max Column sum is :" + maxColSum);
        }

        public void CallMinColSum(){
            Matrix m = GetMatrix();
            int minColSum = s.MinColSum(m.mat ?? new int[m.N][], m.N, m.M);
            Console.WriteLine("Min Column sum is :" + minColSum);
        }

        public void CallPrintDiagonals(){
            Matrix m = GetMatrix();
            int[][] diagonals = s.PrintMainDiagonalsOfMatrix(m.mat ?? new int[m.N][], m.N, m.M);
            Console.WriteLine("Diagonals are :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < diagonals[i].Length; j++)
                {
                    Console.Write(diagonals[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void CallTransposeMatrix(){
            Matrix m = GetMatrix();
            
            int[][] tmat = s.TransposeMatrix(m.mat ?? new int[m.N][], m.N, m.M);
            Console.WriteLine("Transposed matrix is :");
            for (int i = 0; i < m.M; i++)
            {
                for (int j = 0; j < m.N; j++)
                {
                    Console.Write(tmat[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void CallRotateClockwise(){
            Matrix m = GetMatrix();

            Console.WriteLine("Enter no of rotations");
            int rotationTimes = Convert.ToInt32(Console.ReadLine());
            
            if(rotationTimes%4 > 0){
                int[][] tmat = s.RotateClockwise(m.mat ?? new int[m.N][], m.N);
                for (int i = 1; i < rotationTimes; i++)
                {
                    tmat = s.RotateClockwise(tmat, m.N);
                }
                Console.WriteLine("Rotated matrix is :");
                Common.PrintMatrix(tmat);
            }
            Console.WriteLine("Rotated matrix is :");
            Common.PrintMatrix(m.mat);

        }
    }
}