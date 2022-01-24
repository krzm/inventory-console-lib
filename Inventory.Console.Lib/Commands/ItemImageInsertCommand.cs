using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemImageInsertCommand : InsertCommand<ItemImage>
{
    public ItemImageInsertCommand(
        TextCommand textCommand
        , IInsertWizard<ItemImage> categoryWizard)
            : base(textCommand, categoryWizard)
    {
    }
}