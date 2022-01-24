using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemImageReadCommand : ReadCommand<ItemImage>
{
    public ItemImageReadCommand(
        TextCommand textCommand
        , IReadCommand<ItemImage> readCommand)
            : base(textCommand, readCommand)
    {
    }
}