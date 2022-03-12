namespace Emulator.Instructions
{
    internal interface IInstruction
    {
        void Execute(Memory memory);
    }
}
