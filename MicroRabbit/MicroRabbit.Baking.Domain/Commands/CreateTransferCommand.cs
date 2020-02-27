namespace MicroRabbit.Baking.Domain.Commands
{
    public class CreateTransferCommand : TrasnferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}