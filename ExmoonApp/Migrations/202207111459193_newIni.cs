namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newIni : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        Accounttype = c.Int(nullable: false),
                        AccountName = c.String(),
                        AccountResName = c.String(),
                        Address = c.String(),
                        phone = c.String(),
                        email = c.String(),
                        note = c.String(),
                        mobile = c.String(),
                        taxnumber = c.String(),
                        creditlimit = c.Double(nullable: false),
                        balance = c.Double(nullable: false),
                        IsVendorType = c.Boolean(nullable: false),
                        PriceBaghdadCenterTawseel = c.Double(nullable: false),
                        PriceBaghdadSuburbTawseel = c.Double(nullable: false),
                        PriceOthersTawseel = c.Double(nullable: false),
                        PriceBaghdadCenterTasleem = c.Double(nullable: false),
                        PriceBaghdadSuburbTasleem = c.Double(nullable: false),
                        PriceOthersTasleem = c.Double(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        IsCustomerRequired = c.Boolean(nullable: false),
                        IsPaymentType = c.Boolean(nullable: false),
                        IsHasTax = c.Boolean(nullable: false),
                        MAccountLabelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountsLabels", t => t.MAccountLabelId, cascadeDelete: true)
                .Index(t => t.MAccountLabelId);
            
            CreateTable(
                "dbo.AccountsLabels",
                c => new
                    {
                        MAccountId = c.Int(nullable: false),
                        MAccountName = c.String(),
                    })
                .PrimaryKey(t => t.MAccountId);
            
            CreateTable(
                "dbo.AccountsTransactionSubs",
                c => new
                    {
                        TransId = c.Int(nullable: false, identity: true),
                        TransRefType = c.String(nullable: false, maxLength: 100),
                        TransRefTypeAr = c.String(nullable: false, maxLength: 100),
                        TransRefId = c.Double(nullable: false),
                        TransRefNo = c.String(maxLength: 200),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(maxLength: 50),
                        AttachmeedFile = c.Binary(),
                        TransDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CusSubId = c.Int(nullable: false),
                        EntryId = c.Int(nullable: false),
                        DetailsNote = c.String(),
                        ObsitAccountID = c.Int(nullable: false),
                        ObsitAccountName = c.String(),
                        AccountID = c.Int(nullable: false),
                        AccountName = c.String(),
                        EntryType = c.String(maxLength: 10),
                        FromAmount = c.Double(nullable: false),
                        ToAmount = c.Double(nullable: false),
                        AmountText = c.String(),
                    })
                .PrimaryKey(t => t.TransId)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Pwd = c.String(),
                        FullName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        SecurityQuestion = c.String(),
                        SecurityAnswer = c.String(),
                        IsEncrept = c.Boolean(nullable: false),
                        CashAccountId = c.Int(nullable: false),
                        IsHasCashAccount = c.Boolean(nullable: false),
                        groupRollId = c.Int(nullable: false),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RollGroups", t => t.groupRollId, cascadeDelete: true)
                .Index(t => t.groupRollId);
            
            CreateTable(
                "dbo.RollGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupRollName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rolls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RollTitle = c.String(nullable: false),
                        groupRollId = c.Int(nullable: false),
                        IsChecked = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RollGroups", t => t.groupRollId, cascadeDelete: true)
                .Index(t => t.groupRollId);
            
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
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.Users", t => t.BillCreatedUserId)
                .ForeignKey("dbo.Accounts", t => t.BillCusOrSuplierId)
                .ForeignKey("dbo.Accounts", t => t.FromAccountId)
                .ForeignKey("dbo.Accounts", t => t.ToAccountId)
                .Index(t => t.BillCusOrSuplierId)
                .Index(t => t.FromAccountId)
                .Index(t => t.ToAccountId)
                .Index(t => t.BillCreatedUserId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.ItemProducts", t => t.ItemId)
                .Index(t => t.BillId)
                .Index(t => t.ItemId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategoryId, cascadeDelete: true)
                .Index(t => t.ItemCategoryId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemProducts", t => t.ItemProductId, cascadeDelete: true)
                .Index(t => t.ItemProductId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemProducts", t => t.ItemProductId, cascadeDelete: true)
                .Index(t => t.ItemProductId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BillLogs", t => t.LogId, cascadeDelete: true)
                .Index(t => t.LogId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameAr = c.String(),
                        NameEn = c.String(),
                        DetailsAr = c.String(),
                        DetailsEn = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Phone3 = c.String(),
                        Email = c.String(),
                        AdressAr = c.String(),
                        AdressEn = c.String(),
                        TaxNumber = c.String(),
                        Image = c.Binary(),
                        AllowSaleNegativeQty = c.Boolean(nullable: false),
                        AllowSaleUnderCost = c.Boolean(nullable: false),
                        AllowSaleUnderLessPrice = c.Boolean(nullable: false),
                        AllowBillEditDate = c.Boolean(nullable: false),
                        AllowBillPurchaseEditDate = c.Boolean(nullable: false),
                        ShowSerialColumn = c.Boolean(nullable: false),
                        ShowDiscountColumn = c.Boolean(nullable: false),
                        SalesAppTax = c.Boolean(nullable: false),
                        PurchaseAppTax = c.Boolean(nullable: false),
                        PropValueTaxSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PropValueTaxPurchase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostUpdateWithPurchase = c.Boolean(nullable: false),
                        PricesUpdateWithPurchase = c.Boolean(nullable: false),
                        PropUseMizan = c.Boolean(nullable: false),
                        PropMizanType = c.Int(nullable: false),
                        PropMizanStarts = c.Int(nullable: false),
                        PropMizanLength = c.Int(nullable: false),
                        PropMizanStartLength = c.Int(nullable: false),
                        PropMizanQtyStarts = c.Int(nullable: false),
                        PropMizanQtyLength = c.Int(nullable: false),
                        PropMizanQtyDecimel = c.Int(nullable: false),
                        UserDiscountBeforTaxBillNet = c.Boolean(nullable: false),
                        ChangePOSButtonToTouchPos = c.Boolean(nullable: false),
                        UseWorkDay = c.Boolean(nullable: false),
                        UseResurantMode = c.Boolean(nullable: false),
                        ResetTalapInEndDay = c.Int(nullable: false),
                        UseSectionPrinter = c.Boolean(nullable: false),
                        TalapPrintBy = c.Int(nullable: false),
                        PropAccAtmAccountId = c.Int(nullable: false),
                        PropAccNoteDebitId = c.Int(nullable: false),
                        PropAccNoteDebitDiscountId = c.Int(nullable: false),
                        PropAccNoteCreditId = c.Int(nullable: false),
                        PropAccNoteCreditDiscountId = c.Int(nullable: false),
                        AllowRepeatItemsInBill = c.Boolean(nullable: false),
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemProducts", t => t.ItemProductId, cascadeDelete: true)
                .Index(t => t.ItemProductId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemStocks", t => t.ItemStockId, cascadeDelete: true)
                .Index(t => t.ItemStockId);
            
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
                "dbo.myVersionInfoes",
                c => new
                    {
                        Vno = c.Int(nullable: false, identity: true),
                        UpdateNo = c.Int(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Vno);
            
            CreateTable(
                "dbo.RollNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RollName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemStockOperations", "ItemStockId", "dbo.ItemStocks");
            DropForeignKey("dbo.ItemProductSubs", "ItemProductId", "dbo.ItemProducts");
            DropForeignKey("dbo.BillSubsLogs", "LogId", "dbo.BillLogs");
            DropForeignKey("dbo.Bills", "ToAccountId", "dbo.Accounts");
            DropForeignKey("dbo.Bills", "FromAccountId", "dbo.Accounts");
            DropForeignKey("dbo.Bills", "BillCusOrSuplierId", "dbo.Accounts");
            DropForeignKey("dbo.ItemProductUnits", "ItemProductId", "dbo.ItemProducts");
            DropForeignKey("dbo.ItemProductTransactions", "ItemProductId", "dbo.ItemProducts");
            DropForeignKey("dbo.ItemProducts", "ItemCategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.BillSubs", "ItemId", "dbo.ItemProducts");
            DropForeignKey("dbo.BillSubs", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "BillCreatedUserId", "dbo.Users");
            DropForeignKey("dbo.AccountsTransactionSubs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "groupRollId", "dbo.RollGroups");
            DropForeignKey("dbo.Rolls", "groupRollId", "dbo.RollGroups");
            DropForeignKey("dbo.AccountsTransactionSubs", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "MAccountLabelId", "dbo.AccountsLabels");
            DropIndex("dbo.ItemStockOperations", new[] { "ItemStockId" });
            DropIndex("dbo.ItemProductSubs", new[] { "ItemProductId" });
            DropIndex("dbo.BillSubsLogs", new[] { "LogId" });
            DropIndex("dbo.ItemProductUnits", new[] { "ItemProductId" });
            DropIndex("dbo.ItemProductTransactions", new[] { "ItemProductId" });
            DropIndex("dbo.ItemProducts", new[] { "ItemCategoryId" });
            DropIndex("dbo.BillSubs", new[] { "ItemId" });
            DropIndex("dbo.BillSubs", new[] { "BillId" });
            DropIndex("dbo.Bills", new[] { "BillCreatedUserId" });
            DropIndex("dbo.Bills", new[] { "ToAccountId" });
            DropIndex("dbo.Bills", new[] { "FromAccountId" });
            DropIndex("dbo.Bills", new[] { "BillCusOrSuplierId" });
            DropIndex("dbo.Rolls", new[] { "groupRollId" });
            DropIndex("dbo.Users", new[] { "groupRollId" });
            DropIndex("dbo.AccountsTransactionSubs", new[] { "AccountID" });
            DropIndex("dbo.AccountsTransactionSubs", new[] { "UserId" });
            DropIndex("dbo.Accounts", new[] { "MAccountLabelId" });
            DropTable("dbo.RollNames");
            DropTable("dbo.myVersionInfoes");
            DropTable("dbo.ItemUnits");
            DropTable("dbo.ItemStockOperations");
            DropTable("dbo.ItemStocks");
            DropTable("dbo.ItemProductSubs");
            DropTable("dbo.Gigalogs");
            DropTable("dbo.Companies");
            DropTable("dbo.BillSubsLogs");
            DropTable("dbo.ItemProductUnits");
            DropTable("dbo.ItemProductTransactions");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.ItemProducts");
            DropTable("dbo.BillSubs");
            DropTable("dbo.Bills");
            DropTable("dbo.BillLogs");
            DropTable("dbo.Rolls");
            DropTable("dbo.RollGroups");
            DropTable("dbo.Users");
            DropTable("dbo.AccountsTransactionSubs");
            DropTable("dbo.AccountsLabels");
            DropTable("dbo.Accounts");
        }
    }
}
