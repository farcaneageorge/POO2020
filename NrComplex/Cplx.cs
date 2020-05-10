namespace NrComplex
{
    public class Cplx
    {
        private int Re;
        private int Im;

        public Cplx()
        {
            this.Re = 0;
            this.Im = 0;
        }
        public Cplx(int Re)
        {
            this.Re = Re;
            this.Im = 0;
        }
        public Cplx(int Re, int Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public Cplx Sum(Cplx b)
        {
            Cplx result = new Cplx();

            result.Re = Re + b.Re;
            result.Im = Im + b.Im;

            return result;
        }
        public Cplx Substract(Cplx b)
        {
            Cplx result = new Cplx();
            result.Re = Re - b.Re;
            result.Im = Im - b.Im;

            return result;
        }
        public Cplx Multiply(Cplx b)
        {
            Cplx result = new Cplx();
            result.Re = Re * b.Re - Im * b.Im;
            result.Im = Re * b.Im + Im * b.Re;

            return result;
        }

        public void TrigonometricForm()
        {
            double r = System.Math.Sqrt(Re * Re + Im * Im);
            double teta = System.Math.Atan(Im / Re);
            System.Console.WriteLine($" Forma trigonometrica : {r}(cos({teta})+isin({teta}))");
        }
        public void PowTrigonometricForm(int pow)
        {
            double r = System.Math.Sqrt(Re * Re + Im * Im);
            double teta = System.Math.Atan(Im / Re);
            System.Console.WriteLine($" Forma trigonometrica : {r * pow}(cos({teta * pow})+isin({teta * pow}))");
        }
        public Cplx Pow(int power)
        {
            Cplx result = new Cplx();

            double r = System.Math.Sqrt(Re * Re + Im * Im);
            double teta = System.Math.Atan(Im / Re);
            result.Re = (int)(r * power * (System.Math.Cos(teta * power)));
            result.Im = (int)(r * power * (System.Math.Sin(teta * power)));

            return result;


        }
        public override string ToString()
        {
            if (Im < 0)
                return string.Format($"{Re} - {System.Math.Abs(Im)}i");
            else
                return string.Format($"{Re} + {Im}i");
        }
    }
}