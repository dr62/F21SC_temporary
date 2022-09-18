/*
  Exercise: implement matrix multiplication 
  See: https://en.wikipedia.org/wiki/Matrix_multiplication#Illustration

  For testing, hard-code several matrices directly into the main method.
*/

public class Matrix {

  // -----------------------------------------------------------------------------
  // The main fct to implement  
  // -----------------------------------------------------------------------------
  public static int[,] MatMult (int[,] m1, int [,] m2) {
    // Hint: use .Rank to get the dimensions of the matrix, and .GetLenth(0) the size in dimension 0 etc

    // Makes sure both matrices have 2 dimensions
    if (m1.Rank != 2 || m2.Rank != 2) {
      return null;
    }

    // Makes sure matrices are of compatible sizes
    if (m1.GetLength(0) != m2.GetLength(1) && m1.GetLength(1) != m2.GetLength(0)) {
      return null;
    }

    // Create a resultant matrix of sizes given from m1 and m2
    int[,] m3 = new int[m1.GetLength(0), m2.GetLength(1)];

    // Loop through each cell of the 2d matrix
    for (int i = 0; i < m3.GetLength(1); i++) {
      for (int j = 0; j < m3.GetLength(0); j++) {
        // Create an int to count result
        int res = 0;

        // Get result for current cell
        for (int z = 0; z < m3.GetLength(1); z++) {
          res += m1[j,z] * m2[z,i];
        }

        // Set current cells value to calculated int
        m3[j,i] = res;
      }
    }
    
    return m3;
  }

  // -----------------------------------------------------------------------------
  // Auc fcts  
  // -----------------------------------------------------------------------------
  // Turn a matrix into a string
  public static string ToString(int[,] m1) {
    int r = m1.Rank;
    if (r != 2) {
      System.Console.WriteLine("Expecting a 2-dim matrix");
      return null; // Better: use an exception here
    }
    int m = m1.GetLength(0); // no. of rows in m1
    int n = m1.GetLength(1); // no. of cols in m1
    string str = "" ;
    for (int i = 0; i < m; i++) {
      str = str + "[";
      for (int j = 0; j < n; j++) {
	if (j>0) { str = str +   ","; }
	str = str + m1[i,j].ToString();
      }
      str = str + "]\n";
    }
    return str;
  }

  // -----------------------------------------------------------------------------
    
  public static void Main() {
    int[,] m1 = new int[3,3] { {1,2,3}, {1,2,3}, {1,2,3} };
    int[,] m2 = new int[3,3] { {1,2,3}, {1,2,3}, {1,2,3} };
    int[,] m3 = Matrix.MatMult(m1,m2);
    System.Console.WriteLine("First Matrix:\n{0}", Matrix.ToString(m1));
    System.Console.WriteLine("Second Matrix:\n{0}", Matrix.ToString(m2));
    System.Console.WriteLine("Result of Matrix Multiplication:\n{0}", Matrix.ToString(m3));
    int[,] m4 = new int[2,3] { {1,2,3}, {7,3,4} };
    int[,] m5 = new int[3,3] { {5,2,1}, {7,2,1}, {4,2,8} };
    int[,] m6 = Matrix.MatMult(m4,m5);
    System.Console.WriteLine("First Matrix:\n{0}", Matrix.ToString(m4));
    System.Console.WriteLine("Second Matrix:\n{0}", Matrix.ToString(m5));
    System.Console.WriteLine("Result of Matrix Multiplication:\n{0}", Matrix.ToString(m6));
    int[,] m04 = new int[2,3] { {1,2,1}, {7,3,9} };
    int[,] m05 = new int[3,3] { {6,0,2}, {4,1,8}, {3,2,0} };
    int[,] m06 = Matrix.MatMult(m04,m05);
    if (m06 == null) {
      System.Console.WriteLine("Result of multiplication is undefined\n");
    }
    System.Console.WriteLine("First Matrix:\n{0}", Matrix.ToString(m04));
    System.Console.WriteLine("Second Matrix:\n{0}", Matrix.ToString(m05));
    System.Console.WriteLine("Result of Matrix Multiplication:\n{0}", Matrix.ToString(m06));
    int[,] m7 = new int[2,3] { {1,2,3}, {7,3,4} };
    int[,] m8 = new int[3,3] { {5,2,1}, {7,2,1}, {4,2,8} };
    int[,] m9 = Matrix.MatMult(m7,m8);
    if (m9 == null) {
      System.Console.WriteLine("Result of multiplication is undefined\n");
    }
    System.Console.WriteLine("First Matrix:\n{0}", Matrix.ToString(m7));
    System.Console.WriteLine("Second Matrix:\n{0}", Matrix.ToString(m8));
    System.Console.WriteLine("Result of Matrix Multiplication:\n{0}", Matrix.ToString(m9));
    /*
    int[] m07 = new int[2] { 1,2 };
    int[] m08 = new int[3] { 5,2,1 };
    int[] m09 = Matrix.MatMult(m07,m08);
    if (m09 == null) {
      System.Console.WriteLine("Result of multiplication is undefined\n");
    } 
    */
  }
}

/* Expect these results:
  [ [ 6, 12, 18 ]
    [ 6, 12, 18 ]
    [ 6, 12, 18 ] ]

  [ [ 31, 12, 27 ]
    [ 72, 28, 42 ] ]
*/
