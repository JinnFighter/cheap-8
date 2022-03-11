using System;

namespace Emulator
{
    public class Runtime
    {
        private readonly RegistersContainer _registersContainter;
        private readonly Memory _memory;
        private readonly AddressStack _addressStack;
        private readonly TimerRegisters _timerRegisters;

        private bool _isActive;

        public Runtime()
        {
            _registersContainter = new RegistersContainer();
            _memory = new Memory();
            _addressStack = new AddressStack();
            _timerRegisters = new TimerRegisters();
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
