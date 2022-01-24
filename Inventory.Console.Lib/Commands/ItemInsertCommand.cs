using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemInsertCommand : InsertCommand<Item>
{
    public ItemInsertCommand(
        TextCommand textCommand
        , IInsertWizard<Item> modelAInsertWizard) 
            : base(textCommand, modelAInsertWizard)
    {
    }
}