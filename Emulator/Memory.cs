namespace Emulator
{
    internal class Memory
    {
        private readonly byte[] _memoryBytes;
        private readonly int _internalMemorySize;

        private readonly byte[] _vRegisters;
        public byte[] Vs { get; }
        private ushort _iRegister;
        private ushort _programCounter;
        public byte DelayTimer { get; set; }
        public byte SoundTimer { get; set; }

        public Memory()
        {
            _memoryBytes = new byte[4096];
            _internalMemorySize = 512;
            _vRegisters = new byte[16];
            Vs = new byte[16];
        }

        public byte GetIndex(int index) => _memoryBytes[index];

        public ushort GetInstruction(int index) => (ushort)(_memoryBytes[index] << 8 | _memoryBytes[index + 1]);

        public void WriteInternal(int index, byte info)
        {
            if(index >= 0 && index < _internalMemorySize)
            {
                _memoryBytes[index] = info;
            }
        }

        public void WriteCommon(int index, byte info)
        {
            if (index >= _internalMemorySize && index < _memoryBytes.Length)
            {
                _memoryBytes[index] = info;
            }
        }

        public void WriteRegularRegister(int index, byte info)
        {
            if (index >= 0 && index < _vRegisters.Length - 1)
            {
                _vRegisters[index] = info;
            }
        }

        public ushort GetProgramCounter() => _programCounter;

        public void SetProgramCounter(ushort address) => _programCounter = address;

        public void IncreaseCounterAddress() => _programCounter += 2;

        public void WriteIRegister(ushort info) => _iRegister = info;
    }
}
