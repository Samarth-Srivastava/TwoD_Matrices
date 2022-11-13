namespace TwoD_Matrices{
	partial class Solution{

		Arrays.Solution customMath = new Arrays.Solution();
		public int[] GetRowWiseSum(int[][] mat, int N, int M){
			int[] rowWiseSum = new int[N];
			for (int i = 0; i < N; i++)
			{
				int rowSum = 0;
				for (int j = 0; j < M; j++)
				{
					rowSum += mat[i][j];
				}
				rowWiseSum[i] = rowSum;
			}
			return rowWiseSum;
		}

		public int[] GetColumnWiseSum(int[][] mat, int N, int M){
			int[] colWiseSum = new int[M];
			for (int i = 0; i < M; i++)
			{
				int colSum = 0;
				for (int j = 0; j < N; j++)
				{
					 colSum += mat[j][i];
				}
				colWiseSum[i] = colSum;
			}
			return colWiseSum;
		}

		// public int Max(int a, int b){
		// 	if (a >= b)
		// 		return a;
		// 	else
		// 		return b;
		// }

		// public int Min(int a, int b){
		// 	if (a <= b)
		// 		return a;
		// 	else
		// 		return b;
		// }

		public int MaxRowSum(int[][] mat, int N, int M){
			int maxRowWiseSum = int.MinValue;
			for (int i = 0; i < N; i++)
			{
				int rowSum = 0;
				for (int j = 0; j < M; j++)
				{
					rowSum += mat[i][j];
				}
				maxRowWiseSum = customMath.Max(maxRowWiseSum, rowSum);
			}
			return maxRowWiseSum;
		}

		public int MinRowSum(int[][] mat, int N, int M){
			int minRowWiseSum = int.MaxValue;
			for (int i = 0; i < N; i++)
			{
				int rowSum = 0;
				for (int j = 0; j < M; j++)
				{
					rowSum += mat[i][j];
				}
				minRowWiseSum = customMath.Min(minRowWiseSum, rowSum);
			}
			return minRowWiseSum;
		}

		public int MaxColSum(int[][] mat, int N, int M){
			int maxColWiseSum = int.MinValue;
			for (int i = 0; i < M; i++)
			{
				int colSum = 0;
				for (int j = 0; j < N; j++)
				{
					colSum += mat[j][i];
				}
				maxColWiseSum = customMath.Max(maxColWiseSum, colSum);
			}
			return maxColWiseSum;
		}

		public int MinColSum(int[][] mat, int N, int M){
			int minColWiseSum = int.MaxValue;
			for (int i = 0; i < M; i++)
			{
				int colSum = 0;
				for (int j = 0; j < N; j++)
				{
					colSum += mat[j][i];
				}
				minColWiseSum = customMath.Min(minColWiseSum, colSum);
			}
			return minColWiseSum;
		}

		public int[][] PrintMainDiagonalsOfMatrix(int[][] mat, int N, int M){
			int[][] diagonals = new int[2][];
			int counter = customMath.Min(N,M);

			int[] d1 = new int[counter]; 
			for (int i = 0; i < counter; i++)
			{
				d1[i] = mat[i][i];
			}
			diagonals[0] = d1;
			int[] d2 = new int[counter]; 
			for (int i = 0; i < counter; i++)
			{
				d2[i] = mat[i][counter - i -1];
			}
			diagonals[1] = d2;
			return diagonals;
		}

		public int[][] TransposeMatrix(int[][] mat, int N, int M){
			
			int[][] transposedMatrix = new int[M][];
			// brute force
			// for square matrix in place
			// for (int i = 0; i < N; i++)
			// {
			// 	for (int j = i; j < M; j++)
			// 	{
			// 		//swap
			// 		int temp = mat[i][j];
			// 		mat[i][j] = mat[j][i];
			// 		mat[j][i] = temp;
			// 	}
			// }

			// for all matrices
			for (int j = 0; j < M; j++)
			{
				int[] temp = new int[N]; 
				for (int i = 0; i < N; i++)
				{
					temp[i] = mat[i][j];
				}
				transposedMatrix[j] = temp;
			}
			return transposedMatrix;
		}

		public int[][] RotateClockwise(int[][] mat, int N){
		
			int[][] transpose = new int[N][];
			for (int i = 0; i < N; i++)
			{
				int[] temp = new int[N];
				for (int j = 0; j < N; j++)
				{
					temp[j] = mat[j][i];
				}
				transpose[i] = temp;
			}

			for (int i = 0; i < N; i++)
			{
				transpose[i] = customMath.Reverse(transpose[i], 0, N-1);
			}
			return transpose;
		}

		public int[][] Add2Matrices(int[][] mat1, int[][] mat2){
			int[][] mat3 = new int[mat1.Length][];
			for (int i = 0; i < mat1.Length; i++)
			{
				for (int j = 0; j < mat1[i].Length; j++)
				{
					mat3[i][j] = mat1[i][j] + mat2[i][j];
				}
			}
			return mat3;
		}

		public int[][] Subtract2Matrices(int[][] mat1, int[][] mat2){
			int[][] mat3 = new int[mat1.Length][];
			for (int i = 0; i < mat1.Length; i++)
			{
				for (int j = 0; j < mat1[i].Length; j++)
				{
					mat3[i][j] = mat1[i][j] - mat2[i][j];
				}
			}
			return mat3;
		}

		public int[][] Multiply2Matrices(int[][] mat1, int[][] mat2){
			int[][] mat3 = new int[mat1.Length][];
			for (int i = 0; i < mat1.Length; i++)
			{
				for (int j = 0; j < mat2[0].Length; j++)
				{
					int sum = 0;
					for(int k = 0; k < mat1[0].Length; k++){
                    	sum = sum + (mat1[i][k] * mat2[k][j]);
                	}
					mat3[i][j] = sum;
				}
			}
			return mat3;
		}

		public int[][] SpiralOrderMatrix(int N){
			int[][] mat = new int[N][];
			// initialise matrix
			for (int x = 0; x < N; x++)
			{
				mat[x] = new int[N];
			}

			int i = 0, j = 0;
			int noOfTimesLoopRun = 0;
			int counter = 1; //1 to N2
			while(N > 1){
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					j++;
				}
				noOfTimesLoopRun = 0;
				//at this point i = 0, j = N-1
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					i++;
				}
				noOfTimesLoopRun = 0;
				// at this point i = N-1, j = N-1
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					j--;
				}
				noOfTimesLoopRun = 0;
				// at this point i = N-1, j = 0
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					i--;
				}
				noOfTimesLoopRun = 0;
				// at this point i = 0, j = 0
				N = N-2;
				i++;
				j++;
			}
			if(N == 1)
				mat[i][j] = counter;
			return mat;
		}
	
		public List<List<int>> SpiralOrderMatrixList(int N){
			List<List<int>> mat = new List<List<int>>(N);
			// initialise matrix
			for (int x = 0; x < N; x++)
			{
				List<int> temp = new List<int>();
				for (int y = 0; y < N; y++)
				{
					temp.Add(0);
				}
				mat.Add(temp);
			}

			int i = 0, j = 0;
			int noOfTimesLoopRun = 0;
			int counter = 1; //1 to N2
			while(N > 1){
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					j++;
				}
				noOfTimesLoopRun = 0;
				//at this point i = 0, j = N-1
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					i++;
				}
				noOfTimesLoopRun = 0;
				// at this point i = N-1, j = N-1
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					j--;
				}
				noOfTimesLoopRun = 0;
				// at this point i = N-1, j = 0
				while(noOfTimesLoopRun < N-1){
					mat[i][j] = counter++;
					noOfTimesLoopRun++;
					i--;
				}
				noOfTimesLoopRun = 0;
				// at this point i = 0, j = 0
				N = N-2;
				i++;
				j++;
			}
			if(N == 1)
				mat[i][j] = counter;
			return mat;
		}
	
	}

	
}
