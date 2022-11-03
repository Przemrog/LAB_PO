namespace WebApplication3.Services.LAB2
{
    public class Calculate
    {
        public Calculate(int initVal)
        {
            Value = initVal;
        }

        private int Value { get; set; }

        public void Increase(int value)
        {
            Value += value;
        }

        public void Decrease(int value)
        {
            Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
