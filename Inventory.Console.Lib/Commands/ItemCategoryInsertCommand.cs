using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemCategoryInsertCommand 
    : InsertCommand<ItemCategory>
{
    public ItemCategoryInsertCommand(
        TextCommand textCommand
        , IInsertWizard<ItemCategory> itemCategoryWizard)
            : base(textCommand, itemCategoryWizard)
    {
    }
}