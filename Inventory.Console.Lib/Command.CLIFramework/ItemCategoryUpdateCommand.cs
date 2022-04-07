using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemCategoryUpdateCommand 
    : UpdateCommand<ItemCategory>
{
    public ItemCategoryUpdateCommand(
        TextCommand textCommand
        , IUpdateWizard<ItemCategory> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}