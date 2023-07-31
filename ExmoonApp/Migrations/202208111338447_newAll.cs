namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newAll : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bills", "BillCreatedUserId", "dbo.Users");
            DropForeignKey("dbo.BillSubs", "BillId", "dbo.Bills");
            DropForeignKey("dbo.BillSubs", "ItemId", "dbo.ItemProducts");
            DropForeignKey("dbo.ItemProducts", "ItemCategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.ItemProductTransactions", "ItemProductId", "dbo.ItemProducts");
            DropForeignKey("dbo.ItemProductUnits", "ItemProductId", "dbo.ItemProducts");
            DropForeignKey("dbo.Bills", "BillCusOrSuplierId", "dbo.Accounts");
            DropForeignKey("dbo.Bills", "FromAccountId", "dbo.Accounts");
            DropForeignKey("dbo.Bills", "ToAccountId", "dbo.Accounts");
            DropForeignKey("dbo.BillSubsLogs", "LogId", "dbo.BillLogs");
            DropForeignKey("dbo.ItemProductSubs", "ItemProductId", "dbo.ItemProducts");
            DropForeignKey("dbo.ItemStockOperations", "ItemStockId", "dbo.ItemStocks");
            DropIndex("dbo.Bills", new[] { "BillCusOrSuplierId" });
            DropIndex("dbo.Bills", new[] { "FromAccountId" });
            DropIndex("dbo.Bills", new[] { "ToAccountId" });
            DropIndex("dbo.Bills", new[] { "BillCreatedUserId" });
            DropIndex("dbo.BillSubs", new[] { "BillId" });
            DropIndex("dbo.BillSubs", new[] { "ItemId" });
            DropIndex("dbo.ItemProducts", new[] { "ItemCategoryId" });
            DropIndex("dbo.ItemProductTransactions", new[] { "ItemProductId" });
            DropIndex("dbo.ItemProductUnits", new[] { "ItemProductId" });
            DropIndex("dbo.BillSubsLogs", new[] { "LogId" });
            DropIndex("dbo.ItemProductSubs", new[] { "ItemProductId" });
            DropIndex("dbo.ItemStockOperations", new[] { "ItemStockId" });
            DropTable("dbo.BillLogs");
            DropTable("dbo.Bills");
            DropTable("dbo.BillSubs");
            DropTable("dbo.ItemProducts");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.ItemProductTransactions");
            DropTable("dbo.ItemProductUnits");
            DropTable("dbo.BillSubsLogs");
            DropTable("dbo.Gigalogs");
            DropTable("dbo.ItemProductSubs");
            DropTable("dbo.ItemStocks");
            DropTable("dbo.ItemStockOperations");
            DropTable("dbo.ItemUnits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ItemUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemStockOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemStockId = c.Int(nullable: false),
                        ItemProductId = c.Int(nullable: false),
                        ItemProductName = c.String(),
                        TransDate = c.DateTime(nullable: false),
                        Unit = c.String(),
                        UntiSize = c.Double(nullable: false),
                        Qty = c.Double(nullable: false),
                        QtyinStock = c.Double(nullable: false),
                        ResultQty = c.Double(nullable: false),
                        OpType = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemProductSubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemProductId = c.Int(nullable: false),
                        ItemProductSubId = c.Int(nullable: false),
                        Name = c.String(),
                        QtySize = c.Double(nullable: false),
                        SubPrice = c.Double(nullable: false),
                        SubCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Gigalogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LogTypeCommand = c.String(),
                        LogOnTable = c.String(),
                        LogId = c.String(),
                        LogNo = c.String(),
                        LogType = c.String(),
                        userId = c.Int(nullable: false),
                        userName = c.String(),
                        LogDate = c.DateTime(nullable: false),
                        LogDateUtc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BillSubsLogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LogId = c.Guid(nullable: false),
                        BillId = c.Int(nullable: false),
                        workId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Name = c.String(),
                        Unit = c.String(),
                        ItemSerial = c.String(),
                        ItemUsage = c.String(),
                        ItemCategPrint = c.String(),
                        ItemCategName = c.String(),
                        UnitSize = c.Double(nullable: false),
                        QtyIn = c.Double(nullable: false),
                        QtyOut = c.Double(nullable: false),
                        Cost = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        DiscountValu = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        TaxValu = c.Double(nullable: false),
                        Service = c.Double(nullable: false),
                        TotalNet = c.Double(nullable: false),
                        costTotal = c.Double(nullable: false),
                        Barcode = c.String(),
                        ExpierDate = c.String(),
                        PriceIncludTax = c.Boolean(nullable: false),
                        IsExpier = c.Boolean(nullable: false),
                        ItemType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemProductUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemProductId = c.Int(nullable: false),
                        UnitID = c.Int(nullable: false),
                        UnitName = c.String(),
                        QtySize = c.Double(nullable: false),
                        QtySizeDisplay = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Baracod = c.String(),
                        IsDefault = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemProductTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemProductId = c.Int(nullable: false),
                        ItemProductName = c.String(),
                        TransType = c.String(nullable: false),
                        TransRef = c.String(nullable: false),
                        TransRefAr = c.String(),
                        RefSympol = c.String(maxLength: 10),
                        RefId = c.Int(nullable: false),
                        RefNo = c.Int(nullable: false),
                        TransDate = c.DateTime(nullable: false),
                        Unit = c.String(),
                        QtyIn = c.Double(nullable: false),
                        QtyOut = c.Double(nullable: false),
                        UntiSize = c.Double(nullable: false),
                        IsCount = c.Boolean(nullable: false),
                        Cost = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        ExpieryDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        rgbColor = c.Int(nullable: false),
                        PrintName = c.String(),
                        Image = c.Binary(),
                        Statue = c.Boolean(nullable: false),
                        IsNotPrintable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayID = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        ItemCategoryId = c.Int(nullable: false),
                        ItemType = c.String(),
                        MinQty = c.Double(nullable: false),
                        OpenQty = c.Double(nullable: false),
                        ItemPrice = c.Double(nullable: false),
                        ItemPriceWhole = c.Double(nullable: false),
                        ItemLowestPrice = c.Double(nullable: false),
                        ItemCostPrice = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        PriceIncludTax = c.Boolean(nullable: false),
                        CalcAvgCostPrice = c.Boolean(nullable: false),
                        ItemIsExpierDate = c.Boolean(nullable: false),
                        IsComplex = c.Boolean(nullable: false),
                        ItemNote = c.String(),
                        Image = c.Binary(),
                        Statue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BillSubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillId = c.Int(nullable: false),
                        workId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Name = c.String(),
                        Unit = c.String(),
                        ItemSerial = c.String(),
                        ItemUsage = c.String(),
                        ItemCategPrint = c.String(),
                        ItemCategName = c.String(),
                        UnitSize = c.Double(nullable: false),
                        QtyIn = c.Double(nullable: false),
                        QtyOut = c.Double(nullable: false),
                        Cost = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        DiscountValu = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        TaxValu = c.Double(nullable: false),
                        Service = c.Double(nullable: false),
                        TotalNet = c.Double(nullable: false),
                        costTotal = c.Double(nullable: false),
                        Barcode = c.String(),
                        ExpierDate = c.String(),
                        PriceIncludTax = c.Boolean(nullable: false),
                        IsExpier = c.Boolean(nullable: false),
                        ItemType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        BillType = c.String(nullable: false, maxLength: 100),
                        BillTypeAr = c.String(maxLength: 100),
                        BillPayMethodType = c.String(),
                        BillPayby = c.String(),
                        BillNo = c.Int(nullable: false),
                        BillRefId = c.String(),
                        BillRef = c.String(),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(maxLength: 50),
                        AttachmeedFile = c.Binary(),
                        BillCusOrSuplierId = c.Int(nullable: false),
                        BillCusOrSuplierName = c.String(),
                        BillTo = c.String(),
                        BillOrder = c.String(),
                        BillNote = c.String(),
                        BillDate = c.DateTime(nullable: false),
                        FromAccountId = c.Int(nullable: false),
                        FromAccountName = c.String(),
                        ToAccountId = c.Int(nullable: false),
                        ToAccountName = c.String(),
                        BillStatue = c.String(),
                        AmountText = c.String(),
                        TotalBill = c.Double(nullable: false),
                        TotalDiscount = c.Double(nullable: false),
                        TotalDiscountAvg = c.Double(nullable: false),
                        TotalDiscountValu = c.Double(nullable: false),
                        TotalDiscountItems = c.Double(nullable: false),
                        TotalVat = c.Double(nullable: false),
                        TotalService = c.Double(nullable: false),
                        TotalNet = c.Double(nullable: false),
                        TotalCost = c.Double(nullable: false),
                        TotalNetWords = c.String(),
                        UseDiscountBeforTaxBillNet = c.Boolean(nullable: false),
                        BillCreatedUserId = c.Int(nullable: false),
                        BillCreatedDate = c.DateTime(nullable: false),
                        BillLastUpdateDate = c.DateTime(nullable: false),
                        BillLastUpdateUserId = c.Int(nullable: false),
                        VatAccountId = c.Int(nullable: false),
                        DailySerialNo = c.Int(nullable: false),
                        DailySerialStatue = c.String(),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.BillLogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BillId = c.Int(nullable: false),
                        BillType = c.String(maxLength: 100),
                        BillTypeAr = c.String(maxLength: 100),
                        BillPayMethodType = c.String(),
                        BillPayby = c.String(),
                        BillNo = c.Int(nullable: false),
                        BillRefId = c.String(),
                        BillRef = c.String(),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(maxLength: 50),
                        AttachmeedFile = c.Binary(),
                        BillCusOrSuplierId = c.Int(nullable: false),
                        BillCusOrSuplierName = c.String(),
                        BillOrder = c.String(),
                        BillNote = c.String(),
                        BillDate = c.DateTime(nullable: false),
                        FromAccountId = c.Int(nullable: false),
                        FromAccountName = c.String(),
                        ToAccountId = c.Int(nullable: false),
                        ToAccountName = c.String(),
                        AmountText = c.String(),
                        TotalBill = c.Double(nullable: false),
                        TotalDiscount = c.Double(nullable: false),
                        TotalDiscountAvg = c.Double(nullable: false),
                        TotalDiscountValu = c.Double(nullable: false),
                        TotalDiscountItems = c.Double(nullable: false),
                        TotalVat = c.Double(nullable: false),
                        TotalService = c.Double(nullable: false),
                        TotalNet = c.Double(nullable: false),
                        TotalCost = c.Double(nullable: false),
                        TotalNetWords = c.String(),
                        UseDiscountBeforTaxBillNet = c.Boolean(nullable: false),
                        BillCreatedUserId = c.Int(nullable: false),
                        VatAccountId = c.Int(nullable: false),
                        BillCreatedDate = c.DateTime(nullable: false),
                        BillLastUpdateDate = c.DateTime(nullable: false),
                        BillLastUpdateUserId = c.Int(nullable: false),
                        DeletUserId = c.Int(nullable: false),
                        DeletDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ItemStockOperations", "ItemStockId");
            CreateIndex("dbo.ItemProductSubs", "ItemProductId");
            CreateIndex("dbo.BillSubsLogs", "LogId");
            CreateIndex("dbo.ItemProductUnits", "ItemProductId");
            CreateIndex("dbo.ItemProductTransactions", "ItemProductId");
            CreateIndex("dbo.ItemProducts", "ItemCategoryId");
            CreateIndex("dbo.BillSubs", "ItemId");
            CreateIndex("dbo.BillSubs", "BillId");
            CreateIndex("dbo.Bills", "BillCreatedUserId");
            CreateIndex("dbo.Bills", "ToAccountId");
            CreateIndex("dbo.Bills", "FromAccountId");
            CreateIndex("dbo.Bills", "BillCusOrSuplierId");
            AddForeignKey("dbo.ItemStockOperations", "ItemStockId", "dbo.ItemStocks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemProductSubs", "ItemProductId", "dbo.ItemProducts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BillSubsLogs", "LogId", "dbo.BillLogs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "ToAccountId", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "FromAccountId", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "BillCusOrSuplierId", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemProductUnits", "ItemProductId", "dbo.ItemProducts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemProductTransactions", "ItemProductId", "dbo.ItemProducts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemProducts", "ItemCategoryId", "dbo.ItemCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BillSubs", "ItemId", "dbo.ItemProducts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BillSubs", "BillId", "dbo.Bills", "BillId", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "BillCreatedUserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
