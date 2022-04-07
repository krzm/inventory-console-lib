using System.Collections.Generic;
using System.Linq;
using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Console.Lib;

public class ItemImageReadCmd 
    : ReadCommand<IInventoryUnitOfWork, ItemImage, ItemImage>
{
    public ItemImageReadCmd(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<ItemImage> textProvider) 
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<ItemImage> Get(ItemImage model) =>
        UnitOfWork.ItemImage.Get().ToList();
}