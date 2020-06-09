using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    class BigNumber
    {
        private int[] vector;
        private int length;
        public BigNumber(string bignum)
        {
            // this constructor is used when we know the value of the big number
            this.length = bignum.Length;
            this.vector = new int[this.length];
            for (int i = 0; i < this.length; i++)
            {
                this.vector[i] = int.Parse(bignum[i].ToString());
            }
        }
        public BigNumber(int length)
        {
            // this construtor is used when we create a new big number whose value is not given
            this.vector = new int[length];
            this.length = length;
        }

        private void setIndexValue(int index, int value)
        {
            this.vector[index] = value;
        }

        private int getIndexValue(int index)
        {
            if (index < this.length && index > -1)
                return this.vector[index];
            else
                return 0;
        }
        internal BigNumber Add(BigNumber b)
        {
            BigNumber maxBigNumber = Util.max(this, b);
            int resultlenght = maxBigNumber.getLength() + 1;
            BigNumber result = new BigNumber(resultlenght);

            int sum, carry;
            carry = 0;
            int j;

            int offsetThis = 0, offsetB = 0;
            if (this.length >= b.length)
            {
                offsetB = this.length - b.length;
            }
            else
            {
                offsetThis = -this.length + b.length;
            }

            for (int i = resultlenght - 1; i > 0; i--)
            {
                // we adjust the index cuz of result legnth
                j = i - 1;
                sum = this.getIndexValue(j - offsetThis) + b.getIndexValue(j - offsetB) + carry;
                result.setIndexValue(i, sum % 10);
                carry = sum / 10;
            }

            return result;
        }

        public BigNumber Multiply(BigNumber n1)
        {
            BigNumber result = new BigNumber(n1.getLength() + this.getLength());

            for (int j = this.getLength() - 1; j >= 0; j--)
            {
                int p2 = this.getLength() - j - 1;

                for (int i = n1.getLength() - 1; i >= 0; i--)
                {
                    int p1 = n1.getLength() - i - 1;

                    int p = p1 + p2;

                    int r = this.getIndexValue(j) * n1.getIndexValue(i);

                    int newR = r + result.getIndexValue(result.getLength() - p - 1);
                    if (newR <= 9)
                    {
                        result.setIndexValue(result.getLength() - p - 1, newR);
                    }
                    else
                    {
                        // set the querry
                        result.setIndexValue(result.getLength() - p - 1 - 1, result.getIndexValue(result.getLength() - p - 1 - 1) + newR / 10);

                        // set the value
                        result.setIndexValue(result.getLength() - p - 1, newR % 10);
                    }
                }
            }

            return result;
        }

        public void display()
        {
            int i = 0;
            while (true)
            {
                if (this.vector[i] == 0)
                {
                    i++;

                }
                else
                    break;
            }
            if (this.vector[0] != 0)
            {
                Console.Write(this.vector[0]);
            }

            for (; i < this.length; i++)
            {
                Console.Write(this.vector[i]);
            }
            Console.WriteLine();
        }

        public int getLength()
        {
            return this.length;
        }
    }
}