namespace Emulator
{
    public class RegistersContainer
    {
        private readonly byte[] _vRegisters;
        private ushort _iRegister;
        private ushort _programCounter;


        public RegistersContainer()
        {
            _vRegisters = new byte[16];
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

        public void WriteProgramCounter(ushort count) => _programCounter = count;
    }
}
