using CLIFramework;
using CRUDCommandHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemCategoryReadCommand 
    : ReadCommand<ItemCategory>
{
    public ItemCategoryReadCommand(
        TextCommand textCommand
        , IReadCommand<ItemCategory> readCommand)
            : base(textCommand, readCommand)
    {
    }
}