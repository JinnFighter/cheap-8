namespace Emulator
{
    public class Runtime
    {
        private bool _isActive;

        public Runtime()
        {

        }

        public void Run()
        {
            while(_isActive)
            {
                FetchInstruction();
                DecodeInstruction();
                ExecuteInstruction();
            }
        }

        private void FetchInstruction()
        {

        }

        private void DecodeInstruction()
        {

        }

        private void ExecuteInstruction()
        {

        }
    }
}
