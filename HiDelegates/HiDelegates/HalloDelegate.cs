namespace HiDelegates
{
    delegate void EinfacherDelegate();
    delegate void DelegateMitPara(string name);
    delegate long CalcDelegate(int a, int b);

    internal class HalloDelegate
    {
        public HalloDelegate()
        {
            EinfacherDelegate meinDele = SagHallo;
            Action actionAlsDele = SagHallo;
            Action actionAlsLambda = delegate () { Console.WriteLine("Hallo"); };
            Action actionAlsLambda2 = () => Console.WriteLine("Hallo");

            DelegateMitPara deleMitPara = SagHalloMitPara;
            Action<string> actionMitPara = SagHalloMitPara;
            DelegateMitPara actLambda = (string x) => { Console.WriteLine("Hallo " + x); };
            DelegateMitPara actLambda2 = (x) => Console.WriteLine("Hallo " + x);
            DelegateMitPara actLambda3 = x => Console.WriteLine("Hallo " + x);

            CalcDelegate calc = Minus;
            Func<int, int, long> calcFunc = Sum;
            CalcDelegate calcLamb = (int a, int b) => { return a * b; };
            CalcDelegate calcLamb2 = (a, b) => { return a * b; };
            CalcDelegate calcLamb3 = (a, b) => a * b;

            string text = "Hallo Welt";

            text.Where(x => x == 'b');
            text.Where(Filter);


        }

        private bool Filter(char arg)
        {
            if (arg == 'a') 
                return true;
            else
                return false;
        }

        private long Minus(int a, int b)
        {
            return a - b;
        }

        private long Sum(int a, int b)
        {
            return a + b;
        }

        private void SagHallo()
        {
            Console.WriteLine("Hallo");
        }


        private void SagHalloMitPara(string text)
        {
            Console.WriteLine("Hallo " + text);
        }
    }
}
