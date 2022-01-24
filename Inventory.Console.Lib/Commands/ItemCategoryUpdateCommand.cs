using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemCategoryUpdateCommand : InsertCommand<ItemCategory>
{
    public ItemCategoryUpdateCommand(
        TextCommand textCommand
        , IInsertWizard<ItemCategory> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}