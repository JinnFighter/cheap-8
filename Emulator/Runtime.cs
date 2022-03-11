using System;

namespace Emulator
{
    public class Runtime
    {
        private readonly RegistersContainer _registersContainter;
        private bool _isActive;

        public Runtime()
        {
            _registersContainter = new RegistersContainer();
        }

        public void Run()
        {
            _isActive = true;
            while(_isActive)
            {
                FetchInstruction();
                DecodeInstruction();
                ExecuteInstruction();
                _isActive = false;
            }
        }

        private void FetchInstruction()
        {
            Console.WriteLine("Fetch instruction");
        }

        private void DecodeInstruction()
        {
            Console.WriteLine("Decode instruction");
        }

        private void ExecuteInstruction()
        {
            Console.WriteLine("Execute instruction");
        }
    }
}
