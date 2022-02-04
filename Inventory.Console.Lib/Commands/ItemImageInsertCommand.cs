using CLIFramework;
using CLIWizardHelper;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemImageInsertCommand 
    : InsertCommand<ItemImage>
{
    public ItemImageInsertCommand(
        TextCommand textCommand
        , IInsertWizard<ItemImage> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}