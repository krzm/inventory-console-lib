using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Lib;

public class ItemReadCommand : ReadCommand<Item>
{
    public ItemReadCommand(
        TextCommand textCommand
        , IReadCommand<Item> entityReadCommand) 
            : base(textCommand, entityReadCommand)
    {
    }
}