using CLI.Core.Lib;
using Console.Lib;
using Inventory.Data;

namespace Inventory.Console.Lib;

public class ItemImageUpdateCommand : UpdateCommand<ItemImage>
{
	public ItemImageUpdateCommand(
		TextCommand command
		, IUpdateWizard<ItemImage> updateWizard)
			: base(command, updateWizard)
	{
	}
}