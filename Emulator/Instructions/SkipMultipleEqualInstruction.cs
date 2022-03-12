using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator.Instructions
{
    internal class SkipMultipleEqualInstruction
    {
        private readonly RegistersContainer _container;
        private readonly byte _opcode;
        private readonly int _xIndex;
        private readonly int _yIndex;

        public SkipMultipleEqualInstruction(RegistersContainer container, int xIndex, int yIndex)
        {
            _container = container;
            _xIndex = xIndex;
            _yIndex = yIndex;
        }

        public void Execute()
        {
            if (_container.Vs[_xIndex] == _container.Vs[_yIndex])
            {
                _container.IncreaseCounterAddress();
            }
        }
    }
}
