using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Lib;

public class ItemCategoryInsertCommand : InsertCommand<ItemCategory>
{
    public ItemCategoryInsertCommand(
        TextCommand textCommand
        , IInsertWizard<ItemCategory> itemCategoryWizard)
            : base(textCommand, itemCategoryWizard)
    {
    }
}