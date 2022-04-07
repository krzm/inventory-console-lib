using System.Collections.Generic;
using System.Linq;
using CLIHelper;
using CRUDCommandHelper;
using DataToTable;
using Inventory.Data;
using Serilog;

namespace Inventory.Console.Lib;

public class ItemCategoryReadCmd 
    : ReadCommand<IInventoryUnitOfWork, ItemCategory, ItemCategory>
{
    public ItemCategoryReadCmd(
        IInventoryUnitOfWork unitOfWork
        , IOutput output
        , ILogger log
        , IDataToText<ItemCategory> textProvider) 
            : base(unitOfWork, output, log, textProvider)
    {
    }

    protected override List<ItemCategory> Get(ItemCategory model) =>
        UnitOfWork.ItemCategory.Get().ToList();
}