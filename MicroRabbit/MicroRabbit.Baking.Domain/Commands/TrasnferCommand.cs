using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Baking.Domain.Commands
{
    public abstract class TrasnferCommand : Command
    {
        public int From { get; protected set; }

        public int To { get; protected set; }

        public decimal Amount { get; protected set; }
    }
}