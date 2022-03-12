namespace Emulator
{
    internal class RegistersContainer
    {
        private readonly byte[] _vRegisters;
        public byte[] Vs { get; }
        private ushort _iRegister;
        private ushort _programCounter;


        public RegistersContainer()
        {
            _vRegisters = new byte[16];
            Vs = new byte[16];
        }

        public void WriteRegularRegister(int index, byte info)
        {
            if(index >= 0 && index < _vRegisters.Length - 1)
            {
                _vRegisters[index] = info;
            }
        }

        public void WriteVFRegister(byte info) => _vRegisters[15] = info;

        public void WriteIRegister(ushort info) => _iRegister = info;

        public ushort GetProgramCounter() => _programCounter;

        public void SetProgramCounter(ushort address) => _programCounter = address;

        public void IncreaseCounterAddress() => _programCounter += 2;
    }
}
