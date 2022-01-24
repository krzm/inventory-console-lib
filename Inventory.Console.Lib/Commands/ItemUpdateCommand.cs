using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemUpdateCommand : UpdateCommand<Item>
{
    public ItemUpdateCommand(
        TextCommand textCommand
        , IUpdateWizard<Item> updateWizard) 
            : base(textCommand, updateWizard)
    {
    }
}