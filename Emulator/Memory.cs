namespace Emulator
{
    internal class Memory
    {
        private readonly byte[] _memoryBytes;
        private readonly int _internalMemorySize;

        public Memory()
        {
            _memoryBytes = new byte[4096];
            _internalMemorySize = 512;
        }

        public byte GetIndex(int index) => _memoryBytes[index];

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
    }
}
