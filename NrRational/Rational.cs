namespace NrRational
{
    internal class Rational
    {
        private int numarator;
        private int numitor;

        public Rational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }
        public Rational(int numarator)
        {
            this.numarator = numarator;
            this.numitor = 1;
        }
        public Rational()
        {
            this.numitor = 0;
            this.numarator = 0;
        }
        public static bool operator ==(Rational a, Rational b)
        {
            if (a.numarator * b.numitor == a.numitor * b.numarator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            if (a.numarator * b.numitor == a.numitor * b.numarator)
            {
                return false;
            }

            return true;
        }
        public static bool operator >(Rational a, Rational b)
        {
            if (a.numarator * b.numitor > a.numitor * b.numarator)
            {
                return true;
            }

            return false;
        }
        public static bool operator <(Rational a, Rational b)
        {
            if (a.numarator * b.numitor < a.numitor * b.numarator)
            {
                return true;
            }

            return false; ;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            if (a.numarator * b.numitor <= a.numitor * b.numarator)
            {
                return true;
            }

            return false; ;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            if (a.numarator * b.numitor >= a.numitor * b.numarator)
            {
                return true;
            }

            return false; ;
        }
        public Rational Sum(Rational b)
        {
            Rational result = new Rational();
            result.numitor = numitor * b.numitor;
            result.numarator = numarator * b.numitor + b.numarator * numitor;

            return result;
        }
        public Rational Substract(Rational b)
        {
            Rational result = new Rational();
            result.numitor = numitor * b.numitor;
            result.numarator = numarator * b.numitor - b.numarator * numitor;

            return result;
        }
        public Rational Multiply(Rational r1)
        {
            Rational result = new Rational();
            result.numitor = numitor * r1.numitor;
            result.numarator = numarator * r1.numarator;
            return result;
        }
        public Rational Inverse()
        {
            return new Rational(numitor, numarator);
        }
        public Rational Divide(Rational r1)
        {
            return this.Multiply(r1.Inverse());
        }
        public Rational Pow(int pow)
        {
            return new Rational((int)System.Math.Pow(numarator, pow), (int)System.Math.Pow(numitor, pow));
        }
        public int cmmdc(int nr1, int nr2)
        {
            int aux1 = System.Math.Abs(nr1);
            int aux2 = System.Math.Abs(nr2);
            while (aux1 != aux2)
            {
                if (aux1 > aux2)
                    aux1 = aux1 - aux2;
                else
                    aux2 = aux2 - aux1;
            }
            return aux1;
        }
        public override string ToString()
        {
            return string.Format($"[{numarator / (cmmdc(numarator, numitor))} / {numitor / (cmmdc(numarator, numitor))}]");
        }

    }
}