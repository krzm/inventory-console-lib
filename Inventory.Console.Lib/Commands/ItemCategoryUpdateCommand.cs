using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemCategoryUpdateCommand 
    : InsertCommand<ItemCategory>
{
    public ItemCategoryUpdateCommand(
        TextCommand textCommand
        , IInsertWizard<ItemCategory> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}