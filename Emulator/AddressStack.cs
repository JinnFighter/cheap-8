using System.Collections.Generic;

namespace Emulator
{
    internal class AddressStack
    {
        private readonly Stack<ushort> _addresses;

        public ushort TopAddress { get => _addresses.Peek(); }

        public AddressStack()
        {
            _addresses = new Stack<ushort>(16);
        }

        public void PushAddress(ushort address) => _addresses.Push(address);

        public ushort PopAddress() => _addresses.Pop();
    }
}
