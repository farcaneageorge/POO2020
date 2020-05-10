using System;
using System.Text;

namespace Matrici
{
    class Matrix
    {
        private int columns;
        private int rows;
        private double[,] matrix;
        private static Random rnd = new Random();

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.matrix = new double[this.rows, this.columns];
        }
        public Matrix(int rowsandcolumns) : this(rowsandcolumns, rowsandcolumns)
        {

        }
        public void RandomMatrix()
        {
            int r = rnd.Next(10);
            int col = rnd.Next(10);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(25);
                }
            }
        }
        public void RandomMatrix(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(25);
                }
            }
        }
        public void RandomMatrix(int rowsandcolumns)
        {
            for (int i = 0; i < rowsandcolumns; i++)
            {
                for (int j = 0; j < rowsandcolumns; j++)
                {
                    matrix[i, j] = rnd.Next(25);
                }
            }
        }
        public Matrix AddMatrix(Matrix matrix2)
        {
            Matrix finalsum = new Matrix(this.rows, this.columns);
            double sum = 0;
            if ((this.rows != matrix2.rows) || (this.columns != matrix2.columns))
                throw new System.InvalidOperationException("UNABLE TO SUM");
            else
            {
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.columns; j++)
                    {

                        sum = matrix[i, j] + matrix2.GetElement(i, j);
                        finalsum.SetElement(i, j, sum);
                    }
                }
            }
            return finalsum;

        }
        public Matrix SubstractMatrix(Matrix matrix2)
        {
            Matrix finalSubstraction = new Matrix(this.rows, this.columns);
            double substraction;
            if ((this.rows != matrix2.rows) || (this.columns != matrix2.columns))
                throw new System.InvalidOperationException("UNABLE TO SUBSTRACT");
            else
            {
                for (int i = 0; i < this.rows; i++)
                {
                    for (int j = 0; j < this.columns; j++)
                    {

                        substraction = matrix[i, j] - matrix2.GetElement(i, j);
                        finalSubstraction.SetElement(i, j, substraction);
                    }
                }
            }
            return finalSubstraction;

        }

        private void SetElement(int i, int j, double sum)
        {
            matrix[i, j] = sum;
        }

        private double GetElement(int i, int j)
        {
            return matrix[i, j];
        }

        /* public void Print()
         {
             for (int i = 0; i < this.matrix.GetLength(0); i++)
             {
                 for (int j = 0; j < this.matrix.GetLength(1); j++)
                     System.Console.Write(matrix[i,j]+ " ");
                     System.Console.WriteLine();

             }
         }*/
        public Matrix Multiply(Matrix matrix2)
        {
            Matrix Result = new Matrix(this.rows, matrix2.columns);
            if (this.rows != matrix2.columns)
                throw new System.InvalidOperationException("UNABLE TO MULTIPLY");
            double aux1;
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < matrix2.columns; j++)
                {
                    aux1 = 0;
                    for (int k = 0; k < this.columns; k++)
                    {
                        aux1 += matrix[i, k] * matrix2.GetElement(k, j);

                    }
                    Result.SetElement(i, j, aux1);
                }
            }
            return Result;
        }
        public Matrix Pow(int power)
        {
            Matrix result = this;
            if (power == 1)
                return this;
            else
                for (int i = 0; i < power - 1; i++)
                {
                    result = result.Multiply(this);
                }
            return result;
        }
        public Matrix TransposedMatrix()
        {
            Matrix result = new Matrix(this.rows, this.columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result.SetElement(i, j, matrix[j, i]);
                }

            }
            return result;
        }
        public Matrix Reduce(Matrix old, int row, int column)
        {
            int n = old.rows;
            //int m = old.columns;
            Matrix result = new Matrix(n - 1, n - 1);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    result.SetElement(i, j, old.GetElement(i, j));

            for (int i = row + 1; i < n; i++)
                for (int j = 0; j < column; j++)
                    result.SetElement(i - 1, j, old.GetElement(i, j));

            for (int i = 0; i < row; i++)
                for (int j = column + 1; j < n; j++)
                    result.SetElement(i, j - 1, old.GetElement(i, j));

            for (int i = row + 1; i < n; i++)
                for (int j = column + 1; j < n; j++)
                    result.SetElement(i - 1, j - 1, old.GetElement(i, j));
            return result;


        }
        public double GetDeterminant(Matrix m, int rows)
        {

            /* if(rows!=columns)
                 throw new System.InvalidOperationException("UNABLE TO CALCULATE DETERMINANT");
             int n = rows;
             if (n == 1)
                 return matrix[0, 0];
             else
             {
                 double s = 0;
                 for (int i = 0; i < n; i++)
                 {
                     s += Math.Pow(-1, i) * a.GetElement(0, i) * GetDeterminant(Reduce(a, 0, i));
                 }
                 return s;
             }
             */
            if (rows == 1)
            {
                return m.GetElement(0, 0);
            }

            if (rows == 2)
            {
                return (m.GetElement(0, 0) * m.GetElement(1, 1) - m.GetElement(0, 1) * m.GetElement(1, 0));
            }
            if (rows == 3)
            {
                return (m.GetElement(0, 0) * m.GetElement(1, 1) * m.GetElement(2, 2) + m.GetElement(1, 0) * m.GetElement(2, 1) * m.GetElement(0, 2) + m.GetElement(0, 1) * m.GetElement(1, 2) * m.GetElement(2, 0)) -
                    (m.GetElement(0, 2) * m.GetElement(1, 1) * m.GetElement(2, 0) + m.GetElement(0, 1) * m.GetElement(1, 0) * m.GetElement(2, 2) + m.GetElement(1, 2) * m.GetElement(2, 1) * m.GetElement(0, 0));
            }

            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                Matrix aux = new Matrix(rows - 1, rows - 1);
                int p = 0;
                int q = 0;
                for (int k = 1; k < rows; k++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        if (j != i)
                        {
                            aux.SetElement(p, q, m.GetElement(k, j));
                            q++;
                        }
                    }
                    q = 0;
                    p++;
                }
                if ((i + 2) % 2 == 0)
                {
                    sum += m.GetElement(0, 1) * GetDeterminant(aux, rows - 1);
                }
                else
                {
                    sum -= m.GetElement(0, 1) * GetDeterminant(aux, rows - 1);
                }
            }


            return sum;

        }

        public Matrix AdjugateMatrix()
        {
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    Matrix b = this.Reduce(this, i, j);
                    result.SetElement(i, j, (int)Math.Pow(-1, (i + j)) * GetDeterminant(b, b.rows));
                }
            }
            return result;
        }
        internal Matrix GetInverseMatrix(double det)
        {
            int n = this.rows;
            Matrix transpose = this.TransposedMatrix();

            Matrix adjugate = transpose.AdjugateMatrix();
            Matrix result = new Matrix(n, n);


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result.SetElement(i, j, (adjugate.GetElement(i, j)) / det);
                }
            }
            return result;
        }
        /* private Exception ImpossibleOperationException()
         {
             throw new NotImplementedException();
         }*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sb.Append($"{matrix[i, j]} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}