using Azure.Core.Pipeline;

namespace PersonsRegister.Services
{
    public class Numbers
    {
        private int _a;
        private int _b; 
        public Numbers(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int AddNumbers() 
        { 
            return _a + _b; 
        }
        
    }
}
