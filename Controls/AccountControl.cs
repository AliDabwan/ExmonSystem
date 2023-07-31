using DevComponents.DotNetBar.Controls;
using ExmonSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Controls
{
   public class AccountControl
    {
        Helper helper = new Helper();


        public AccountControl()
        {
        }
        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Driver> itemunit = await
                             db.Drivers.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<CompanyTorism>> GetAllCompanyTorism()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var itemunit = await
                             db.CompanyTorisms.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<AirLine>> GetAllAirLines()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<AirLine> itemunit = await
                             db.AirLines.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<AirLine> GetAirLine(int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var itemunit = await
                             db.AirLines.Where(x=>x.Id==id).FirstOrDefaultAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<Destination> GetDestination(int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemunit = await
                              db.Destinations.Where(x => x.Id == id).FirstOrDefaultAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public async Task<IEnumerable<ExCompany>> GetAllExCompanies()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<ExCompany> itemunit = await
                             db.ExCompanies.Include(d => d.Driver).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ExCompany> GetExCompany(int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var itemunit = await
                             db.ExCompanies.Include(d => d.Driver).Include(d => d.Subscriber).Where(x=>x.Id== id).FirstOrDefaultAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<ExCompany>> GetAllExCompaniesForList()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<ExCompany> itemunit = await
                             db.ExCompanies.Include(d => d.Driver).Where(x=>x.Statu==true).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<Destination>> GetAllDestinations()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Destination> itemunit = await
                             db.Destinations.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<Customer>> GetRandomCustomers(int takeRows)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Customer> itemunit = await
                             db.Customers.Take(takeRows).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Order> itemunit = await
                             db.Orders.Include(d => d.ExCompany).Include(d => d.Driver).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<OrderSub>> GetAllOrderSub(Int64 orderId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<OrderSub> itemunit = await
                             db.OrderSubs.Where(x=>x.OrderId== orderId).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<Order>GetOrder(Int64 Id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var itemunit = await
                             db.Orders.Include(d => d.ExCompany).Include(d => d.Driver).Where(x => x.Id == Id).FirstOrDefaultAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Order>> GetAllOrders(bool Isprinted)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Order> itemunit = await
                             db.Orders.Include(d => d.ExCompany).Include(d => d.Driver).Where(x=>x.IsPrinted== Isprinted).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<User>> GetWorkDayUsers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var taxes = await
                               db.Users.ToListAsync();

                    return taxes;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }
    public async Task<DataTable> Getdatatable<T>(IEnumerable<T> ien)
        {

            var vlist = ien.ToList();


            DataTable dt = ToDataTable<T>(vlist);

            return dt;
        }
     

      
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }



        public async Task<IEnumerable<Accounts>> GetPaymentAccounts(int MaccountLabel)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                        IEnumerable<Accounts> accounts = await
                                 db.account.Where(ac => ac.MAccountLabelId == MaccountLabel&& ac.IsPaymentType == true).ToListAsync();

                        return accounts;
                    

                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }



        public async Task<IEnumerable<CustomerDto>> GetCustomersDto(int takeRows)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    IEnumerable<Customer> accounts = await
                             db.Customers.Take(takeRows).ToListAsync();



                    List<CustomerDto> dlist = new List<CustomerDto>();


                    foreach (var item in accounts)

                    {
                        var mypa = new CustomerDto()
                        {
                            Id = item.Id,
                            No = item.No,
                            AttachmeedFile = item.AttachmeedFile,
                            FirstName = item.FirstName,
                            EnName = item.EnName,
                            FamilyName = item.FamilyName,
                            FullName = item.FullName,
                           Gender = item.Gender,
                           BirthDate = item.BirthDate,
                           ExpierDate = item.ExpierDate,
                           IssuedDate = item.IssuedDate,
                           LastName = item.LastName,
                           MotherName = item.MotherName,
                           PassportNo = item.PassportNo,
                           PhoneNumber = item.PhoneNumber,
                           SecondName = item.SecondName,

                        };

                        dlist.Add(mypa);
                    }



                    return dlist;


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }


        public async Task<IEnumerable<AccountsTransDTO>> GetAllAccountBlancesHasDebit22(int MAccountLabelId)
        {
            //try
            //{
            //DesktopAlert.Show("standby");

            using (MyDbContext db = new MyDbContext())
            {
                //DesktopAlert.Show("in");

                var selectedAccount2 = await
                  (from acc in db.account

                   where (acc.MAccountLabelId == MAccountLabelId)


                   select new
                   {

                       Id = acc.Id,
                       AccountID = acc.AccountID,
                       Accounttype = acc.Accounttype,
                       AccountName = acc.AccountName,
                       AccountAddress = acc.Address,
                       AccountTaxNumber = acc.taxnumber,
                       AccountPhone = acc.phone,

                       alltotalbalance = (from sub in db.AccountsTransactionSubs
                                          where (sub.AccountID == acc.Id)
                                          group sub by 1 into g
                                          select new
                                          {
                                              sumDebit = g.Sum(i => (double?)i.FromAmount),
                                              sumCredit = g.Sum(i => (double?)i.ToAmount),

                                              sumBalance = acc.Accounttype == 0 ? g.Sum(i => (double?)i.FromAmount) - g.Sum(i => (double?)i.ToAmount)
                                              : g.Sum(i => (double?)i.ToAmount) - g.Sum(i => (double?)i.FromAmount)

                                          }).FirstOrDefault()



                   }).ToListAsync();




                List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();
                foreach (var item in selectedAccount2)
                {
                    //if (item.alltotalbalance != null)
                    //{


                    var Srecord = new AccountsTransDTO()
                    {
                        Id = item.Id,
                        AccountID = item.AccountID,
                        Accounttype = item.Accounttype,
                        AccountAddress = item.AccountAddress,
                        AccountPhone = item.AccountPhone,
                        AccountTaxNumber = item.AccountTaxNumber,
                        AccountName = item.AccountName,
                        totalDebit = item.alltotalbalance != null ? item.alltotalbalance.sumDebit.HasValue ?
                        item.alltotalbalance.sumDebit.Value : 0

                        : 0,

                        totalCredit = item.alltotalbalance != null ? item.alltotalbalance.sumCredit.HasValue ?
                        item.alltotalbalance.sumCredit.Value : 0
                        : 0,

                        totalbalance = item.alltotalbalance != null ? item.alltotalbalance.sumBalance.HasValue ?
                        item.alltotalbalance.sumBalance.Value : 0
                        : 0



                    };
                    dlist.Add(Srecord);
                    //}

                }

                var result1 = dlist.Where(x => x.totalbalance > 0).ToList();
                //DesktopAlert.Show(result1.Count.ToString());
                return result1;


            }
            //}
            //catch
            //{
            //    return null;
            //}
        }


        public List<string> TravilPorpos = new List<string>();
        //.OrderBy(r => Guid.NewGuid()).Take(5)

        public async Task<IEnumerable<CustomerDto>> GetCustomersOfList(int takeRows, string destination, string exCompany)
        {

            using (MyDbContext db = new MyDbContext())
            {

                IEnumerable<Customer> accounts = await
                              db.Customers.Take(takeRows).ToListAsync();


                TravilPorpos.Clear();
                TravilPorpos.Add("علاج");
                TravilPorpos.Add("سياحة");
                //DesktopAlert.Show("TravilPorpos : " + TravilPorpos.Count);

                List<CustomerDto> dlist = new List<CustomerDto>();

                string xxRandomPorpos = "";
                string xxRandomPTorism = "";
                var companyTorism = await GetAllCompanyTorism();

                foreach (var item in accounts)

                {
                    
                     xxRandomPorpos = TravilPorpos.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();
                    xxRandomPTorism = companyTorism.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault().Name;

                    //DesktopAlert.Show("xx : " + xx);

                    var mypa = new CustomerDto()
                    {
                        Id = item.Id,
                        No = item.No,
                        AttachmeedFile = item.AttachmeedFile,
                        FirstName = item.FirstName,
                        SecondName = item.SecondName,
                        LastName = item.LastName,
                        ThirdyName = item.FirstName+" "+item.SecondName+" " + item.LastName,
                        MotherName = item.MotherName,
                        PassportNo = item.PassportNo,
                        
                        EnName = item.EnName,
                        FamilyName = item.FamilyName,
                        FullName = item.FullName,
                        Gender = item.Gender,
                        BirthDate = item.BirthDate,
                        ExpierDate = item.ExpierDate,
                        IssuedDate = item.IssuedDate,
                       
                        PhoneNumber = item.PhoneNumber,
                        CompanyExName = exCompany,
                        CompanyTorismName = xxRandomPTorism,
                        TravilPorpos = xxRandomPorpos,
                        DestnationName = destination,
                        TempPrice = 3000,

                    };

                    dlist.Add(mypa);
                }



                return dlist;


            }





        }

        public async Task<IEnumerable<OrderDto>> GetAllOrdersPrined(DateTime DateFrom, DateTime DateTo,int isExCompany)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    IEnumerable<Order> accounts = await
                             db.Orders.Include(x=>x.ExCompany).Include(s=>s.Driver).Where(ac =>
                              (DbFunctions.TruncateTime(ac.CreatedDate) >= DateFrom
                               && DbFunctions.TruncateTime(ac.CreatedDate) <= DateTo)
                                && (isExCompany == 0 || ac.ExCompanyId == isExCompany) && ac.IsPrinted==true
                             ).ToListAsync();



                    List<OrderDto> dlist = new List<OrderDto>();


                    foreach (var item in accounts)

                    {
                        var mypa = new OrderDto()
                        {
                            Id = item.Id,
                            Note          =item.Note         ,
                            DriverId      =item.DriverId     ,
                            ExCompanyId   =item.ExCompanyId  ,
                            DriverName = item.Driver.Name     ,
                            CompanyName   =item.ExCompany.Name  ,
                            CompanyNameEn = item.ExCompany.NameEn,
                            CompanyPhone = item.ExCompany.PhoneNumber,
                            OrderCount = item.OrderCount   ,
                            Price         =item.Price        ,
                            TotalAmount   =item.TotalAmount  ,
                            TotalPaid     =item.TotalPaid    ,
                            IsPrinted     =item.IsPrinted    ,
                            IsPaid        =item.IsPaid       ,
                            PaidStatue    =item.PaidStatue   ,
                            PrintedStatue =item.PrintedStatue,
                            CreatedDate=item.CreatedDate,
                            PaidDate = item.PaidDate.HasValue ? item.PaidDate.Value : item.CreatedDate,
                            

                        };

                        dlist.Add(mypa);
                    }



                    return dlist;


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }

        public async Task<IEnumerable<OrderDto>> GetAllOrders(DateTime DateFrom, DateTime DateTo, int isExCompany)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    IEnumerable<Order> accounts = await
                             db.Orders.Include(x => x.ExCompany).Include(s => s.Driver).Where(ac =>
                                  (DbFunctions.TruncateTime(ac.CreatedDate) >= DateFrom
                                   && DbFunctions.TruncateTime(ac.CreatedDate) <= DateTo)
                                    && (isExCompany == 0 || ac.ExCompanyId == isExCompany) 
                             ).ToListAsync();



                    List<OrderDto> dlist = new List<OrderDto>();


                    foreach (var item in accounts)

                    {
                        var mypa = new OrderDto()
                        {
                            Id = item.Id,
                            Note = item.Note,
                            DriverId = item.DriverId,
                            ExCompanyId = item.ExCompanyId,
                            DriverName = item.Driver.Name,
                            CompanyName = item.ExCompany.Name,
                            CompanyNameEn = item.ExCompany.NameEn,
                            CompanyPhone = item.ExCompany.PhoneNumber,
                            OrderCount = item.OrderCount,
                            Price = item.Price,
                            TotalAmount = item.TotalAmount,
                            TotalPaid = item.TotalPaid,
                            IsPrinted = item.IsPrinted,
                            IsPaid = item.IsPaid,
                            PaidStatue = item.PaidStatue,
                            PrintedStatue = item.PrintedStatue,
                            CreatedDate = item.CreatedDate,
                            PaidDate = item.PaidDate.HasValue ? item.PaidDate.Value : item.CreatedDate,


                        };

                        dlist.Add(mypa);
                    }



                    return dlist;


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }




        public IEnumerable<CustomerDto> GetCustomersDto2(int id)
        {
         
                using (MyDbContext db = new MyDbContext())
                {

                    IEnumerable<Customer> accounts = 
                             db.Customers.Where(x=>x.Id== id).ToList();



                    List<CustomerDto> dlist = new List<CustomerDto>();


                    foreach (var item in accounts)

                    {
                        var mypa = new CustomerDto()
                        {
                            Id = item.Id,
                            No = item.No,
                            AttachmeedFile = item.AttachmeedFile,
                            FirstName = item.FirstName,
                            EnName = item.EnName,
                            FamilyName = item.FamilyName,
                            FullName = item.FullName,
                            Gender = item.Gender,
                            BirthDate = item.BirthDate,
                            ExpierDate = item.ExpierDate,
                            IssuedDate = item.IssuedDate,
                            LastName = item.LastName,
                            MotherName = item.MotherName,
                            PassportNo = item.PassportNo,
                            PhoneNumber = item.PhoneNumber,
                            SecondName = item.SecondName,


                        };

                        dlist.Add(mypa);
                    }



                    return dlist;


                }
           




        }





   
     

     





       
       
        

        public async Task<IEnumerable<BillsProfitTaxDTO>> GetBillsAnalysis_Net(bool IsByUser, int showCount, DateTime DateFrom, DateTime DateTo)
        {
            try
            {

                using (MyDbContext db = new MyDbContext())
                {


                    //var groupedResult = from s in db.ItemProductTransactions
                    //                    group s by s.ExpieryDate;
                    //foreach (var item in groupedResult)
                    //{

                    //    foreach (var tr in item)
                    //    {


                    //    }

                    //}

                    //var selectedAccount = await
                    //  (db.Bills.Where(trns => trns.BillStatue != "deleted").GroupBy(tr => tr.BillDate.Date)
                    //    .Select(g => new
                    //    {


                    //        BillTotal=g.Sum(c=>c.TotalBill),
                    //        BillDiscount = g.Sum(c => c.TotalDiscount),
                    //        BillVat = g.Sum(c => c.TotalVat),
                    //        BillNet = g.Sum(c => c.TotalNet),
                    //        BillCost = g.Sum(c => c.TotalCost),


                    //        BillDate = g.Key
                    //    }


                    //    )).ToListAsync();


                    var myprofits =await GetAllOrders( DateFrom, DateTo,0);

                    var groupedProfits = (myprofits.GroupBy(e => e.CreatedDate.Date).Select(g => new
                    {


                        BillTotal = g.Sum(c => c.TotalAmount),
                       
                        BillNet = g.Sum(c => c.TotalAmount),
                        BillProfit = g.Sum(c => c.TotalAmount),


                        BillDate = g.Key
                    }


                        )).ToList();

                    //DesktopAlert.Show(groupedProfits.Count + "");

                    List<BillsProfitTaxDTO> dlist = new List<BillsProfitTaxDTO>();

                    foreach (var item in groupedProfits)
                    {

                        var Srecord = new BillsProfitTaxDTO()
                        {
                            BillTotal = item.BillTotal,
                            BillNet = item.BillNet,
                            BillProfit = item.BillProfit,
                            BillDayDate = item.BillDate.ToString("dddd", new System.Globalization.CultureInfo("ar-AE")) + " " + item.BillDate.Date.ToString("dd/MM/yyyy") + " = " + item.BillNet.ToString(SD.NumDec),

                            BillDate = item.BillDate.Date

                        };
                        dlist.Add(Srecord);
                    }

                    var result1 = new List<BillsProfitTaxDTO>();

                    if (showCount == 0)
                    {
                        result1 = dlist.OrderByDescending(x => x.BillNet).ToList();

                    }
                    else
                    {
                        result1 = dlist.OrderByDescending(x => x.BillNet).Take(showCount).ToList();

                    }

                    return result1;


                }
            }
            catch
            {
                return null;
            }
        }





        public async Task<int> GetVendorsCount()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var accounts = await
                               db.account.Where(ac => ac.MAccountLabelId == 102).CountAsync();

                    return accounts;


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return 0;
            }




        }
        public async Task<int> GetSendersCount()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var accounts = await
                               db.account.Where(ac => ac.MAccountLabelId == 103).CountAsync();

                    return accounts;


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return 0;
            }




        }
      public async Task<IEnumerable<Accounts>> GetAllVendorTasleem()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   
                        IEnumerable<Accounts> accounts =await
                                 db.account.Where(ac => ac.MAccountLabelId == 102 &&ac.IsEnabled==true &&( ac.VendorType== "مندوب تسليم" || ac.VendorType == "مندوب تسليم وتوصيل")).ToListAsync();

                        return accounts;
                    

                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }
        public async Task<IEnumerable<Accounts>> GetAllVendorTawseel()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    IEnumerable<Accounts> accounts = await
                             db.account.Where(ac => ac.MAccountLabelId == 102 && ac.IsEnabled == true && (ac.VendorType == "مندوب توصيل" || ac.VendorType == "مندوب تسليم وتوصيل")).ToListAsync();

                    return accounts;


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }
        public async Task<IEnumerable<Accounts>> GetAllAccount(int MaccountLabel)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    if (MaccountLabel==0)
                    {

                        IEnumerable<Accounts> accounts =await
                                 db.account.ToListAsync();

                        return accounts;
                    }
                    else
                    {

                        IEnumerable<Accounts> accounts =await
                                 db.account.Where(ac => ac.MAccountLabelId == MaccountLabel).ToListAsync();

                        return accounts;
                    }

                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }
        public async Task<Accounts> GetaccountByPhone(string Phone)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct = await
                               db.account.FirstOrDefaultAsync(pr => pr.phone == Phone);





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }

        public async Task<Accounts> Getaccount(int accountid)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct =await
                               db.account.Include(x => x.acctransnSub).Where(pr => pr.Id == accountid).FirstOrDefaultAsync();





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<Accounts> Getaccount(int accountid,string gover)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct =await
                               db.account.Include(x=>x.acctransnSub).Where(pr => pr.Id == accountid).FirstOrDefaultAsync();





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public  Accounts GetaccountName(int accountid)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct = 
                               db.account.FirstOrDefault(pr => pr.Id == accountid);





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<ICollection< Accounts>> Getaccounts(int accountid)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct = await
                               db.account.Where(pr => pr.Id == accountid).ToListAsync();





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<Accounts> Getaccount(string  accountName)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct =await
                               db.account.FirstOrDefaultAsync(pr => pr.AccountName == accountName);

                   


                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error@", "@"+ex.Message);
                return null;
            }
        }
        public async Task<Accounts> GetaccountForSplashScreen(string accountName)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct = await
                               db.account.FirstOrDefaultAsync(pr => pr.AccountName == accountName);




                    return itemproduct;
                }
            }
            catch
            {
                //FrmSQLConn frmSQLConn = new FrmSQLConn();
                //frmSQLConn.ShowDialog();
                return null;
            }
        }

        public async Task<AccountsLabels> GetMainaccount(string MaccountName)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct =await
                               db.accountsLabel.FirstOrDefaultAsync(pr => pr.MAccountName == MaccountName);





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<Accounts> GetSubaccount(string SaccountName)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemproduct =await
                               db.account.FirstOrDefaultAsync(pr => pr.AccountName == SaccountName);





                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }

        public async Task<DataTable> GetAllAccountRpt(int MaccountLabel)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Accounts> accounts = await
                             db.account.
                             Where(ac => ac.MAccountLabelId == MaccountLabel)
                             .ToListAsync();
                  
                    DataTable dt = ToDataTable<Accounts>(accounts);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }

        public async Task<IEnumerable<Accounts>> GetAccounts(int accountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Accounts> accounts =await
                             db.account.Where(ac => ac.Id == accountId).ToListAsync();

                    return accounts;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);

                return null;
            }




        }


        public async Task<int> GetDefaultEntryId(string TransRefType)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var entryId =await db.AccountsTransactionSubs.Where(ac => ac.TransRefType == TransRefType)
                        .Select(pr => pr.EntryId).DefaultIfEmpty(0).MaxAsync();

                    if (entryId == 0)
                    {

                        entryId = Convert.ToInt32((1));
                      return entryId;

                    }
                    else
                    {
                        return  entryId + 1;

                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }




        }
     
        string GetAmountWords(decimal amount)
        {
            List<CurrencyInfo> currencies = new List<CurrencyInfo>();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Iraq));

            ToWord toWord = new ToWord(amount, currencies[0]);

            if (Properties.Settings.Default.Language == "EN")
            {
                return toWord.ConvertToEnglish();

            }
            else
            {
                return toWord.ConvertToArabic();


            }


        }


        public async Task<int> AddToAcc(Accounts obj)
        {
            if (obj == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return -1;
            }
            int rslt = 0;
            //try
            //{
                using (MyDbContext db = new MyDbContext())
                {
                    if (db.Entry<Accounts>(obj).State == EntityState.Detached)
                    {
                        db.Set<Accounts>().Attach(obj);
                    }


                if (obj.Id == 0)
                {

                    var accountid =await db.account.Where(ac => ac.MAccountLabelId == obj.MAccountLabelId)
                      .Select(pr => pr.AccountID).DefaultIfEmpty(0).MaxAsync();

                    if (accountid == 0)
                    {

                        accountid = Convert.ToInt32((obj.MAccountLabelId + "0001"));
                        obj.AccountID = accountid;

                    }
                    else
                    {
                        obj.AccountID = accountid + 1;

                    }
                    var isUniq =await db.account.Where(x => x.AccountName == obj.AccountName).FirstOrDefaultAsync();
                    if (isUniq != null)
                    {
                        DesktopAlert.Show(" لايمكن الحفظ ! هذا الإسم موجود " + obj.AccountName + "\n" + "This Name is repiated Coludn't Saved ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                        return 0;

                    }
                    db.Entry<Accounts>(obj).State = EntityState.Added;
                    rslt = await db.SaveChangesAsync();

                    if (obj.balance > 0)
                    {
                        var acctr = new AccountsTransactionSub()
                        {
                            TransRefType = "رصيد افتتاحي",
                            TransRefTypeAr = "رصيد افتتاحي",
                            TransRefId = obj.Id,
                            TransRefNo = "1",
                            TransDate= DateTime.Now.Date,
                            EntryId = 0,
                            DetailsNote = "رصيد إفتتاحي ",
                            AccountID = obj.Id,
                            AccountName = obj.AccountName,
                            FromAmount = obj.Accounttype == 0 ? obj.balance : 0,// obj.balance,
                            ToAmount = obj.Accounttype == 1 ? obj.balance : 0,// obj.balance,
                            AmountText = GetAmountWords(obj.balance),
                            EntryType = obj.Accounttype == 0 ? "مدين" : "دائن",
                        };
                        if (db.Entry<AccountsTransactionSub>(acctr).State == EntityState.Detached)
                        {
                            db.Set<AccountsTransactionSub>().Attach(acctr);
                        }
                        db.Entry<AccountsTransactionSub>(acctr).State = EntityState.Added;
                        await db.SaveChangesAsync();
                    }


                    if (rslt > 0)
                    {
                        DesktopAlert.Show("تم إضافة الحساب بنجاح " + obj.AccountID + "\n" + " New Account Added Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                        return obj.Id;

                    }
                    else
                    {
                        return 0;


                    }
                }
                else
                {
                    db.Entry<Accounts>(obj).State = EntityState.Modified;
                    rslt = await db.SaveChangesAsync();

                    if (rslt > 0)
                    {
                        await helper.AddGigalog("Edit", "Accounts", obj.AccountName, obj.Id.ToString(), obj.AccountID.ToString());

                    }
                    if (obj.balance >= 0)
                    {
                        try
                        {
                            var prevOpBalance = await db.AccountsTransactionSubs.Where(x => x.AccountID == obj.Id &&
                            x.TransRefType == "رصيد افتتاحي" && x.TransRefId == obj.Id).ToListAsync();
                            if (prevOpBalance.Any())
                            {
                                db.AccountsTransactionSubs.RemoveRange(prevOpBalance);
                                rslt = await db.SaveChangesAsync();
                                //DesktopAlert.Show("تم تعديل الرصيد الإفتتاحي بنجاح ");
                            }
                            var acctr = new AccountsTransactionSub()
                            {
                                TransRefType = "رصيد افتتاحي",
                                TransRefTypeAr = "رصيد افتتاحي",
                                TransRefId = obj.Id,
                                TransRefNo = "1",
                                TransDate = DateTime.Now.Date,
                                EntryId = 0,
                                DetailsNote = "رصيد إفتتاحي ",
                                AccountID = obj.Id,
                                AccountName = obj.AccountName,
                                FromAmount = obj.Accounttype == 0 ? obj.balance : 0,// obj.balance,
                                ToAmount = obj.Accounttype == 1 ? obj.balance : 0,// obj.balance,
                                AmountText = GetAmountWords(obj.balance),
                                EntryType = obj.Accounttype == 0 ? "مدين" : "دائن",
                            };
                            if (db.Entry<AccountsTransactionSub>(acctr).State == EntityState.Detached)
                            {
                                db.Set<AccountsTransactionSub>().Attach(acctr);
                            }
                            db.Entry<AccountsTransactionSub>(acctr).State = EntityState.Added;
                            await db.SaveChangesAsync();

                        }
                        catch 
                        {
                            helper.SetLog("Updating the open balance error when update id"+ obj.Id, "CaluturErr");

                            if (rslt > 0)
                            {
                                DesktopAlert.Show("تم تعديل الحساب بنجاح " + obj.AccountID + "\n" + " Account updated Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                                return obj.Id;

                            }
                            else
                            {
                                return 0;


                            }
                        }
                       
                    }

                    if (rslt > 0)
                    {
                        DesktopAlert.Show("تم تعديل الحساب بنجاح " + obj.AccountID + "\n" + " Account updated Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                        return obj.Id;

                    }
                    else
                    {
                        return 0;


                    }
                }









                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                }

            //}
            //catch (Exception ex)
            //{


            //    return -1;

            //}


        }
        public async Task<int> AddToAccForImport(Accounts obj)
        {
            if (obj == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return -1;
            }
            int rslt = 0;
            //try
            //{
            using (MyDbContext db = new MyDbContext())
            {
                if (db.Entry<Accounts>(obj).State == EntityState.Detached)
                {
                    db.Set<Accounts>().Attach(obj);
                }


                if (obj.Id == 0)
                {

                    var accountid = await db.account.Where(ac => ac.MAccountLabelId == obj.MAccountLabelId)
                      .Select(pr => pr.AccountID).DefaultIfEmpty(0).MaxAsync();

                    if (accountid == 0)
                    {

                        accountid = Convert.ToInt32((obj.MAccountLabelId + "0001"));
                        obj.AccountID = accountid;

                    }
                    else
                    {
                        obj.AccountID = accountid + 1;

                    }
                    var isUniq = await db.account.Where(x => x.AccountName == obj.AccountName).FirstOrDefaultAsync();
                    if (isUniq != null)
                    {
                        return 0;

                    }
                    db.Entry<Accounts>(obj).State = EntityState.Added;
                    rslt = await db.SaveChangesAsync();

                    if (obj.balance > 0)
                    {
                        var acctr = new AccountsTransactionSub()
                        {
                            TransRefType = "رصيد افتتاحي",
                            TransRefTypeAr = "رصيد افتتاحي",
                            TransRefId = obj.Id,
                            TransRefNo = "1",
                            TransDate = DateTime.Now.Date,
                            EntryId = 0,
                            DetailsNote = "رصيد إفتتاحي ",
                            AccountID = obj.Id,
                            AccountName = obj.AccountName,
                            FromAmount = obj.Accounttype == 0 ? obj.balance : 0,// obj.balance,
                            ToAmount = obj.Accounttype == 1 ? obj.balance : 0,// obj.balance,
                            AmountText = GetAmountWords(obj.balance),
                            EntryType = obj.Accounttype == 0 ? "مدين" : "دائن",
                        };
                        if (db.Entry<AccountsTransactionSub>(acctr).State == EntityState.Detached)
                        {
                            db.Set<AccountsTransactionSub>().Attach(acctr);
                        }
                        db.Entry<AccountsTransactionSub>(acctr).State = EntityState.Added;
                        await db.SaveChangesAsync();
                    }


                    if (rslt > 0)
                    {
                        return obj.Id;

                    }
                    else
                    {
                        return 0;


                    }
                }
                else
                {
                    db.Entry<Accounts>(obj).State = EntityState.Modified;
                    rslt = await db.SaveChangesAsync();

                    if (rslt > 0)
                    {
                        await helper.AddGigalog("Edit", "Accounts", obj.AccountName, obj.Id.ToString(), obj.AccountID.ToString());

                    }
                    if (obj.balance >= 0)
                    {
                        try
                        {
                            var prevOpBalance = await db.AccountsTransactionSubs.Where(x => x.AccountID == obj.Id &&
                            x.TransRefType == "رصيد افتتاحي" && x.TransRefId == obj.Id).ToListAsync();
                            if (prevOpBalance.Any())
                            {
                                db.AccountsTransactionSubs.RemoveRange(prevOpBalance);
                                rslt = await db.SaveChangesAsync();
                                //DesktopAlert.Show("تم تعديل الرصيد الإفتتاحي بنجاح ");
                            }
                            var acctr = new AccountsTransactionSub()
                            {
                                TransRefType = "رصيد افتتاحي",
                                TransRefTypeAr = "رصيد افتتاحي",
                                TransRefId = obj.Id,
                                TransRefNo = "1",
                                TransDate = DateTime.Now.Date,
                                EntryId = 0,
                                DetailsNote = "رصيد إفتتاحي ",
                                AccountID = obj.Id,
                                AccountName = obj.AccountName,
                                FromAmount = obj.Accounttype == 0 ? obj.balance : 0,// obj.balance,
                                ToAmount = obj.Accounttype == 1 ? obj.balance : 0,// obj.balance,
                                AmountText = GetAmountWords(obj.balance),
                                EntryType = obj.Accounttype == 0 ? "مدين" : "دائن",
                            };
                            if (db.Entry<AccountsTransactionSub>(acctr).State == EntityState.Detached)
                            {
                                db.Set<AccountsTransactionSub>().Attach(acctr);
                            }
                            db.Entry<AccountsTransactionSub>(acctr).State = EntityState.Added;
                            await db.SaveChangesAsync();

                        }
                        catch
                        {
                            helper.SetLog("Updating the open balance error when update id" + obj.Id, "CaluturErr");

                            if (rslt > 0)
                            {
                                DesktopAlert.Show("تم تعديل الحساب بنجاح " + obj.AccountID + "\n" + " Account updated Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                                return obj.Id;

                            }
                            else
                            {
                                return 0;


                            }
                        }

                    }

                    if (rslt > 0)
                    {
                        DesktopAlert.Show("تم تعديل الحساب بنجاح " + obj.AccountID + "\n" + " Account updated Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                        return obj.Id;

                    }
                    else
                    {
                        return 0;


                    }
                }









                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }

            //}
            //catch (Exception ex)
            //{


            //    return -1;

            //}


        }
        public async Task<IEnumerable<AccountsTransDTO>> GetAllAccountBlances(int MAccountLabelId)
        {
            //try
            //{
            //DesktopAlert.Show("standby");

            using (MyDbContext db = new MyDbContext())
            {
                //DesktopAlert.Show("in");

                var selectedAccount2 = await
                  (from acc in db.account

                   where (acc.MAccountLabelId == MAccountLabelId)


                   select new
                   {

                       Id = acc.Id,
                       AccountID = acc.AccountID,
                       Accounttype = acc.Accounttype,
                       AccountName = acc.AccountName,
                       AccountAddress = acc.Address,
                       AccountTaxNumber = acc.taxnumber,
                       AccountPhone = acc.phone,
                       IsEnabled = acc.IsEnabled,
                       IsCustomerRequired = acc.IsCustomerRequired,
                       IsPaymentType = acc.IsPaymentType,
                       AccountResName = acc.AccountResName,
                       VendorType = acc.VendorType,
                       //CreditTotal = (from sub in db.AccountsTransactionSubs
                       //               where (sub.AccountID == acc.Id)
                       //               select (decimal?)sub.FromAmount).Sum(),
                       //DebitTotal = (from sub in db.AccountsTransactionSubs
                       //              where (sub.AccountID == acc.Id)
                       //              select (decimal?)sub.ToAmount).Sum(),

                       alltotalbalance = (from sub in db.AccountsTransactionSubs
                                          where (sub.AccountID == acc.Id)
                                          group sub by 1 into g
                                          select new
                                          {
                                              sumDebit = g.Sum(i => (double?)i.FromAmount),
                                              sumCredit = g.Sum(i => (double?)i.ToAmount),

                                              sumBalance = acc.Accounttype == 0 ? g.Sum(i => (double?)i.FromAmount) - g.Sum(i => (double?)i.ToAmount)
                                              : g.Sum(i => (double?)i.ToAmount) - g.Sum(i => (double?)i.FromAmount)

                                          }).FirstOrDefault()



                   }).ToListAsync();

                //var selectedAccount = await
                //      (from acc in db.account

                //       where(acc.MAccountLabelId== MAccountLabelId)
                //       join acctrans in db.AccountsTransactionSubs on acc.Id equals acctrans.AccountID
                //       into g
                //       from b in g.DefaultIfEmpty()
                //       select new
                //       {

                //           Id = acc.Id,
                //           AccountID = acc.AccountID,
                //           Accounttype = acc.Accounttype,
                //           AccountName = acc.AccountName,
                //           AccountAddress=acc.Address,
                //           AccountTaxNumber=acc.taxnumber,
                //           AccountPhone=acc.PhoneNumber1,
                //           CreditTotal = (g.Sum(i => (decimal?)i.FromAmount)),
                //           DebitTotal = (g.Sum(i => (decimal?)i.ToAmount)),
                //           totalbalance = acc.Accounttype == 0 ?
                //           (g.Sum(i => (decimal?)i.FromAmount)) - (g.Sum(i => (decimal?)i.ToAmount)) : (g.Sum(i => (decimal?)i.ToAmount)) - (g.Sum(i => (decimal?)i.FromAmount))

                //       }).ToListAsync();



                List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();
                foreach (var item in selectedAccount2)
                {
                    //if (item.alltotalbalance != null)
                    //{


                    var Srecord = new AccountsTransDTO()
                    {
                        Id = item.Id,
                        AccountID = item.AccountID,
                        Accounttype = item.Accounttype,
                        AccountAddress = item.AccountAddress,
                        AccountPhone = item.AccountPhone,
                        AccountTaxNumber = item.AccountTaxNumber,
                        AccountName = item.AccountName,
                        IsEnabled = item.IsEnabled,
                        IsCustomerRequired = item.IsCustomerRequired,
                        IsPaymentType = item.IsPaymentType,
                        AccountResName = item.AccountResName,
                        VendorType = item.VendorType,

                        totalDebit = item.alltotalbalance != null ? item.alltotalbalance.sumDebit.HasValue ?
                        item.alltotalbalance.sumDebit.Value : 0

                        : 0,

                        totalCredit = item.alltotalbalance != null ? item.alltotalbalance.sumCredit.HasValue ?
                        item.alltotalbalance.sumCredit.Value : 0
                        : 0,

                        totalbalance = item.alltotalbalance != null ? item.alltotalbalance.sumBalance.HasValue ?
                        item.alltotalbalance.sumBalance.Value : 0
                        : 0



                    };
                    dlist.Add(Srecord);
                    //}

                }

                var result1 = dlist.ToList();
                //DesktopAlert.Show(result1.Count.ToString());
                return result1;


            }
            //}
            //catch
            //{
            //    return null;
            //}
        }

        public async Task<IEnumerable<ExCompanyDTO>> GetAllExCompaniesBlances(int ExId,bool hasBalance)
        {
            //try
            //{
            //DesktopAlert.Show("standby");

            using (MyDbContext db = new MyDbContext())
            {
                //DesktopAlert.Show("in");

                var selectedAccount2 = await
                  (from acc in db.ExCompanies
                  where((ExId==0||acc.Id== ExId))
                   select new
                   {

                       Id = acc.Id,
                       Name = acc.Name,
                       Address = acc.Address,
                       PhoneNumber = acc.PhoneNumber,
                       Statue = acc.Statu?"فعال":"غيرفعال",

                      
                       //CreditTotal = (from sub in db.AccountsTransactionSubs
                       //               where (sub.AccountID == acc.Id)
                       //               select (decimal?)sub.FromAmount).Sum(),
                       //DebitTotal = (from sub in db.AccountsTransactionSubs
                       //              where (sub.AccountID == acc.Id)
                       //              select (decimal?)sub.ToAmount).Sum(),

                       alltotalbalance = (from sub in db.Orders
                                          where (sub.ExCompanyId == acc.Id &&sub.IsPrinted==true)
                                          group sub by 1 into g
                                          select new
                                          {
                                              OrderCount = g.Sum(i => (int?)i.OrderCount),
                                              TotalAmount = g.Sum(i => (double?)i.TotalAmount),
                                              TotalPaid = g.Sum(i => (double?)i.TotalPaid),

                                              sumBalance = g.Sum(i => (double?)i.TotalAmount) - g.Sum(i => (double?)i.TotalPaid)

                                          }).FirstOrDefault()



                   }).ToListAsync();

               

                List<ExCompanyDTO> dlist = new List<ExCompanyDTO>();
                foreach (var item in selectedAccount2)
                {
                    //if (item.alltotalbalance != null)
                    //{


                    var Srecord = new ExCompanyDTO()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Address = item.Address,
                        PhoneNumber = item.PhoneNumber,
                        Statue = item.Statue,

                        OrderCount = item.alltotalbalance != null ? item.alltotalbalance.OrderCount.HasValue ?
                        item.alltotalbalance.OrderCount.Value : 0

                        : 0,

                        TotalAmount = item.alltotalbalance != null ? item.alltotalbalance.TotalAmount.HasValue ?
                        item.alltotalbalance.TotalAmount.Value : 0
                        : 0,

                        TotalPaid = item.alltotalbalance != null ? item.alltotalbalance.TotalPaid.HasValue ?
                        item.alltotalbalance.TotalPaid.Value : 0
                        : 0,
                        Balance = item.alltotalbalance != null ? item.alltotalbalance.sumBalance.HasValue ?
                        item.alltotalbalance.sumBalance.Value : 0
                        : 0



                    };
                    dlist.Add(Srecord);
                    //}

                }

                var result1 = dlist.Where(x=>(hasBalance==true||x.Balance>0)).ToList();
                //DesktopAlert.Show(result1.Count.ToString());
                return result1;


            }
            //}
            //catch
            //{
            //    return null;
            //}
        }



        public async Task<DataTable> GetAllAccountBlancesRpt(int MAccountLabelId)
        {
            //try
            //{
            //DesktopAlert.Show("standby");

            using (MyDbContext db = new MyDbContext())
            {
                //DesktopAlert.Show("in");

                var selectedAccount2 = await
                  (from acc in db.account

                   where (acc.MAccountLabelId == MAccountLabelId)


                   select new
                   {

                       Id = acc.Id,
                       AccountID = acc.AccountID,
                       Accounttype = acc.Accounttype,
                       AccountName = acc.AccountName,
                       AccountAddress = acc.Address,
                       AccountTaxNumber = acc.taxnumber,
                       AccountPhone = acc.phone,

                       //CreditTotal = (from sub in db.AccountsTransactionSubs
                       //               where (sub.AccountID == acc.Id)
                       //               select (decimal?)sub.FromAmount).Sum(),
                       //DebitTotal = (from sub in db.AccountsTransactionSubs
                       //              where (sub.AccountID == acc.Id)
                       //              select (decimal?)sub.ToAmount).Sum(),

                       alltotalbalance = (from sub in db.AccountsTransactionSubs
                                          where (sub.AccountID == acc.Id)
                                          group sub by 1 into g
                                          select new
                                          {
                                              sumDebit = g.Sum(i => (double?)i.FromAmount),
                                              sumCredit = g.Sum(i => (double?)i.ToAmount),

                                              sumBalance = acc.Accounttype == 0 ? g.Sum(i => (double?)i.FromAmount) - g.Sum(i => (double?)i.ToAmount)
                                              : g.Sum(i => (double?)i.ToAmount) - g.Sum(i => (double?)i.FromAmount)

                                          }).FirstOrDefault()



                   }).ToListAsync();

                //var selectedAccount = await
                //      (from acc in db.account

                //       where(acc.MAccountLabelId== MAccountLabelId)
                //       join acctrans in db.AccountsTransactionSubs on acc.Id equals acctrans.AccountID
                //       into g
                //       from b in g.DefaultIfEmpty()
                //       select new
                //       {

                //           Id = acc.Id,
                //           AccountID = acc.AccountID,
                //           Accounttype = acc.Accounttype,
                //           AccountName = acc.AccountName,
                //           AccountAddress=acc.Address,
                //           AccountTaxNumber=acc.taxnumber,
                //           AccountPhone=acc.PhoneNumber1,
                //           CreditTotal = (g.Sum(i => (decimal?)i.FromAmount)),
                //           DebitTotal = (g.Sum(i => (decimal?)i.ToAmount)),
                //           totalbalance = acc.Accounttype == 0 ?
                //           (g.Sum(i => (decimal?)i.FromAmount)) - (g.Sum(i => (decimal?)i.ToAmount)) : (g.Sum(i => (decimal?)i.ToAmount)) - (g.Sum(i => (decimal?)i.FromAmount))

                //       }).ToListAsync();



                List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();
                foreach (var item in selectedAccount2)
                {
                    //if (item.alltotalbalance != null)
                    //{


                    var Srecord = new AccountsTransDTO()
                    {
                        Id = item.Id,
                        AccountID = item.AccountID,
                        Accounttype = item.Accounttype,
                        AccountAddress = item.AccountAddress,
                        AccountPhone = item.AccountPhone,
                        AccountTaxNumber = item.AccountTaxNumber,
                        AccountName = item.AccountName,
                        totalDebit = item.alltotalbalance != null ? item.alltotalbalance.sumDebit.HasValue ?
                        item.alltotalbalance.sumDebit.Value : 0

                        : 0,

                        totalCredit = item.alltotalbalance != null ? item.alltotalbalance.sumCredit.HasValue ?
                        item.alltotalbalance.sumCredit.Value : 0
                        : 0,

                        totalbalance = item.alltotalbalance != null ? item.alltotalbalance.sumBalance.HasValue ?
                        item.alltotalbalance.sumBalance.Value : 0
                        : 0



                    };
                    dlist.Add(Srecord);
                    //}

                }

                var result1 = dlist.ToList();


                DataTable dt = ToDataTable<AccountsTransDTO>(result1);

                //             var topProducts = sellingLog
                //.Where(s => s.salesYear == 2014)
                //.GroupBy(u => u.productCode)
                //.Select(g => new { productCode = g.Key, sales = g.Sum(u => u.productSales) })
                //.OrderByDescending(x => x.productCode)
                //.Take(5)
                //.ToList();
                return dt;
                //DesktopAlert.Show(result1.Count.ToString());


            }
            //}
            //catch
            //{
            //    return null;
            //}
        }

        public async Task<IEnumerable<AccountsTransDTO>> GetAllAccountBlancesHasDebit(int MAccountLabelId)
        {
            //try
            //{
            //DesktopAlert.Show("standby");

            using (MyDbContext db = new MyDbContext())
            {
                //DesktopAlert.Show("in");

                var selectedAccount2 = await
                  (from acc in db.account

                   where (acc.MAccountLabelId == MAccountLabelId)


                   select new
                   {

                       Id = acc.Id,
                       AccountID = acc.AccountID,
                       Accounttype = acc.Accounttype,
                       AccountName = acc.AccountName,
                       AccountAddress = acc.Address,
                       AccountTaxNumber = acc.taxnumber,
                       AccountPhone = acc.phone,

                       alltotalbalance = (from sub in db.AccountsTransactionSubs
                                          where (sub.AccountID == acc.Id)
                                          group sub by 1 into g
                                          select new
                                          {
                                              sumDebit = g.Sum(i => (double?)i.FromAmount),
                                              sumCredit = g.Sum(i => (double?)i.ToAmount),

                                              sumBalance = acc.Accounttype == 0 ? g.Sum(i => (double?)i.FromAmount) - g.Sum(i => (double?)i.ToAmount)
                                              : g.Sum(i => (double?)i.ToAmount) - g.Sum(i => (double?)i.FromAmount)

                                          }).FirstOrDefault()



                   }).ToListAsync();

         


                List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();
                foreach (var item in selectedAccount2)
                {
                    //if (item.alltotalbalance != null)
                    //{


                    var Srecord = new AccountsTransDTO()
                    {
                        Id = item.Id,
                        AccountID = item.AccountID,
                        Accounttype = item.Accounttype,
                        AccountAddress = item.AccountAddress,
                        AccountPhone = item.AccountPhone,
                        AccountTaxNumber = item.AccountTaxNumber,
                        AccountName = item.AccountName,
                        totalDebit = item.alltotalbalance != null ? item.alltotalbalance.sumDebit.HasValue ?
                        item.alltotalbalance.sumDebit.Value : 0

                        : 0,

                        totalCredit = item.alltotalbalance != null ? item.alltotalbalance.sumCredit.HasValue ?
                        item.alltotalbalance.sumCredit.Value : 0
                        : 0,

                        totalbalance = item.alltotalbalance != null ? item.alltotalbalance.sumBalance.HasValue ?
                        item.alltotalbalance.sumBalance.Value : 0
                        : 0



                    };
                    dlist.Add(Srecord);
                    //}

                }

                var result1 = dlist.Where(x => x.totalbalance > 0).ToList();
                //DesktopAlert.Show(result1.Count.ToString());
                return result1;


            }
            //}
            //catch
            //{
            //    return null;
            //}
        }
        public async Task<DataTable> GetAllAccountBlancesHasDebitReport(int MAccountLabelId)
        {
            //try
            //{
            //DesktopAlert.Show("standby");

            using (MyDbContext db = new MyDbContext())
            {
                //DesktopAlert.Show("in");

                var selectedAccount2 = await
                  (from acc in db.account

                   where (acc.MAccountLabelId == MAccountLabelId)


                   select new
                   {

                       Id = acc.Id,
                       AccountID = acc.AccountID,
                       Accounttype = acc.Accounttype,
                       AccountName = acc.AccountName,
                       AccountAddress = acc.Address,
                       AccountTaxNumber = acc.taxnumber,
                       AccountPhone = acc.phone,

                       alltotalbalance = (from sub in db.AccountsTransactionSubs
                                          where (sub.AccountID == acc.Id)
                                          group sub by 1 into g
                                          select new
                                          {
                                              sumDebit = g.Sum(i => (double?)i.FromAmount),
                                              sumCredit = g.Sum(i => (double?)i.ToAmount),

                                              sumBalance = acc.Accounttype == 0 ? g.Sum(i => (double?)i.FromAmount) - g.Sum(i => (double?)i.ToAmount)
                                              : g.Sum(i => (double?)i.ToAmount) - g.Sum(i => (double?)i.FromAmount)

                                          }).FirstOrDefault()



                   }).ToListAsync();




                List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();
                foreach (var item in selectedAccount2)
                {
                    //if (item.alltotalbalance != null)
                    //{


                    var Srecord = new AccountsTransDTO()
                    {
                        Id = item.Id,
                        AccountID = item.AccountID,
                        Accounttype = item.Accounttype,
                        AccountAddress = item.AccountAddress,
                        AccountPhone = item.AccountPhone,
                        AccountTaxNumber = item.AccountTaxNumber,
                        AccountName = item.AccountName,
                        totalDebit = item.alltotalbalance != null ? item.alltotalbalance.sumDebit.HasValue ?
                        item.alltotalbalance.sumDebit.Value : 0

                        : 0,

                        totalCredit = item.alltotalbalance != null ? item.alltotalbalance.sumCredit.HasValue ?
                        item.alltotalbalance.sumCredit.Value : 0
                        : 0,

                        totalbalance = item.alltotalbalance != null ? item.alltotalbalance.sumBalance.HasValue ?
                        item.alltotalbalance.sumBalance.Value : 0
                        : 0



                    };
                    dlist.Add(Srecord);
                    //}

                }

                var result1 = dlist.Where(x => x.totalbalance > 0).ToList();
                //DesktopAlert.Show(result1.Count.ToString());
                DataTable dt = ToDataTable<AccountsTransDTO>(result1);

                return dt;


            }
            //}
            //catch
            //{
            //    return null;
            //}
        }


        public async Task<int> AddToAccSubTrans(AccountsTransactionSub obj)
        {
            if (obj == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return -1;
            }
            int rslt = 0;
            //try
            //{
            using (MyDbContext db = new MyDbContext())
            {
                //var isInclud =await db.AccountsTransactionSubs.Where(x => x.TransRefType == obj.TransRefType && x.TransRefId == obj.TransRefId && x.EntryType==obj.EntryType).ToListAsync();

                //if (isInclud!=null)
                //{
                //    db.AccountsTransactionSubs.RemoveRange(isInclud);

                //}

                if (db.Entry<AccountsTransactionSub>(obj).State == EntityState.Detached)
                {
                    db.Set<AccountsTransactionSub>().Attach(obj);
                }


                if (obj.TransId == 0)
                {

                    //var entryId = db.AccountsTransactionSubs.Where(ac => ac.TransRefType == obj.TransRefType)
                    //  .Select(pr => pr.EntryId).DefaultIfEmpty(0).Max();

                    //if (entryId == 0)
                    //{

                    //    entryId = Convert.ToInt32((1));
                    //    obj.EntryId = entryId;

                    //}
                    //else
                    //{
                    //    obj.EntryId = entryId + 1;

                    //}


                    if (obj.TransRefType == "Sales Bill")
                    {
                        obj.TransRefTypeAr = "فاتورة مبيعات";
                    }
                    else if (obj.TransRefType == "Sales Quotation Bill")
                    {
                        obj.TransRefTypeAr = "فاتورة عرض سعر";


                    }
                    else if (obj.TransRefType == "Sales Return Bill")
                    {
                        obj.TransRefTypeAr = "فاتورة مرتجع مبيعات";


                    }
                    else if (obj.TransRefType == "Purchase Bill")
                    {
                        obj.TransRefTypeAr = "فاتورة مشتريات";

                    }
                    else if (obj.TransRefType == "Delivery Bill")
                    {
                        obj.TransRefTypeAr = "فاتورة توصيل";

                    }
                    else if (obj.TransRefType == "Comm Tasslem")
                    {
                        obj.TransRefTypeAr = "عمولة تسليم";

                    }
                    else if (obj.TransRefType == "Comm Tawseel")
                    {
                        obj.TransRefTypeAr = "عمولة توصيل";

                    }
                    else if (obj.TransRefType == "Purchase Return Bill")
                    {
                        obj.TransRefTypeAr = "فاتورة مرتجع مشتريات";


                    }
                    else if (obj.TransRefType == "Receipt")
                    {
                        obj.TransRefTypeAr = "سند قبض";


                    }
                    else if (obj.TransRefType == "Payment")
                    {
                        if (obj.TransRefTypeAr==null)
                        {
                            obj.TransRefTypeAr = "سند صرف";

                        }

                    } else if (obj.TransRefType == "Expens Voucher")
                    {
                        obj.TransRefTypeAr = "سند قيد مصروف";


                    }
                    else if (obj.TransRefType == "Debit Note")
                    {
                        obj.TransRefTypeAr = "اشعار مدين";


                    }
                    else if (obj.TransRefType == "Credit Note")
                    {
                        obj.TransRefTypeAr = "اشعار دائن";


                    }

                    if (obj.TransRefId ==0)
                    {
                        obj.TransRefId = obj.EntryId;
                    }
                    if (obj.FromAmount>0)
                    {
                        obj.AmountText = GetAmountWords(obj.FromAmount);
                    }
                    if (obj.ToAmount > 0)
                    {
                        obj.AmountText = GetAmountWords(obj.ToAmount);
                    }

                    //var isUniq = db.account.Where(x => x.AccountName == obj.AccountName).DefaultIfEmpty();
                    //if (isUniq != null)
                    //{
                    //    DesktopAlert.Show(" لايمكن الحفظ ! هذا الإسم موجود " + obj.AccountName + "\n" + "This Name is repiated Coludn't Saved ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                    //    return 0;

                    //}
                    db.Entry<AccountsTransactionSub>(obj).State = EntityState.Added;
                    rslt = await db.SaveChangesAsync();
                    //DesktopAlert.Show("ـم جديد");
                }
                else
                {


                    if (obj.FromAmount > 0)
                    {
                        obj.AmountText = GetAmountWords(obj.FromAmount);
                    }
                    if (obj.ToAmount > 0)
                    {
                        obj.AmountText = GetAmountWords(obj.ToAmount);
                    }
                    db.Entry<AccountsTransactionSub>(obj).State = EntityState.Modified;
                    rslt = await db.SaveChangesAsync();
                    //DesktopAlert.Show("ـم التعديل");
                    if (rslt > 0)
                    {
                        await helper.AddGigalog("Edit", "AccTrans", obj.TransRefType, obj.TransRefId.ToString(), obj.TransRefNo.ToString());

                    }
                }









                if (rslt > 0)
                {
                    //DesktopAlert.Show("تم الحفظ بنجاح " + obj.EntryId + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                    return obj.EntryId;

                }
                else
                {
                    return 0;


                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }

            //}
            //catch (Exception ex)
            //{


            //    return -1;

            //}


        }

        public async Task<string> AddAccountId(Accounts obj)
        {
            if (obj == null)
            {

                return "0";
            }
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   
                    var accountid =db.account.Where(ac=>ac.MAccountLabelId== obj.MAccountLabelId)
                        .Select(pr => pr.AccountID).Max();
                    if (string.IsNullOrEmpty(accountid.ToString()))
                    {
                        
                        accountid =Convert.ToInt32( (obj.MAccountLabelId + "0001"));
                    }
                    var isUniq = db.account.FirstOrDefault(q => q.AccountName == obj.AccountName);
                    if (isUniq != null)
                    {
                        return "0";

                    }
                    accountid = accountid + 1;
                       db.account.Attach(obj);
                    db.account.Add(obj);
                    await db.SaveChangesAsync();
                    db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Accounts OFF");
                    return (accountid + 1).ToString() ;

                }

            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);


                return "0";

            }


        }
        public async Task<int> EditOrderPay(OrderDto obj)
        {
            if (obj == null)
            {

                return 0;
            }
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] ON");

                    var ordr = await db.Orders.Where(x => x.Id == obj.Id).FirstOrDefaultAsync();
                    if (ordr!=null)
                    {

                        if (db.Entry<Order>(ordr).State == EntityState.Detached)
                        {
                            db.Set<Order>().Attach(ordr);
                        }




                        var curenttime = DateTime.Now.ToString("HH:mm:ss");
                        //DesktopAlert.Show("1curenttime   :"+ curenttime);

                        var curentdate = DateTime.Now.ToString("yyyy-MM-dd");
                        //DesktopAlert.Show("2curentdate   :" + curentdate);
                        var curentdatetime = curentdate + " " + curenttime;
                        //DesktopAlert.Show("3curentdatetime   :" + curentdatetime);

                        DateTime dt = DateTime.ParseExact(curentdatetime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                        ordr.LastUpdateDate = dt;
                        ordr.IsPaid = true;
                        ordr.PaidStatue = "مسدد";
                        ordr.PaidDate = dt;
                        ordr.TotalPaid = ordr.TotalAmount;
                        ordr.LastUpdateUserId = Program.userId;


                        //DesktopAlert.Show(obj.BillId.ToString());




                        db.Entry<Order>(ordr).State = EntityState.Modified;
                        var rslt = await db.SaveChangesAsync();

                        //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] OFF");

                        return rslt;


                    }

                    return 0;
                }

            }
            catch
            {


                return 0;

            }


        }



        public async Task<int> addListAccountsLabels(List<AccountsLabels> obj)
        {
            if (obj == null)
            {

                return 0;
            }
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] ON");

                    db.accountsLabel.AddRange(obj);
                  var rslt=  await db.SaveChangesAsync();

                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] OFF");

                    return rslt;

                }

            }
            catch
            {


                return 0;

            }


        }

        public async Task<int> AddListOfOrdersSub(Int64 OrderId,List<OrderSub> obj)
        {
            if (obj == null)
            {

                return 0;
            }
            //try
            //{
                using (MyDbContext db = new MyDbContext())
                {
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] ON");
                var myPrevSub = await db.OrderSubs.Where(o => o.OrderId == OrderId).ToListAsync();
                if (myPrevSub!=null)
                {
                    db.OrderSubs.RemoveRange(myPrevSub);

                }
                db.OrderSubs.AddRange(obj);
                    var rslt = await db.SaveChangesAsync();

                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] OFF");

                    return rslt;

                }

            //}
            //catch
            //{


            //    return 0;

            //}


        }

        public async Task<int> addListAccountsSub(List<Accounts> obj)
        {
            if (obj == null)
            {

                return 0;
            }
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] ON");

                    db.account.AddRange(obj);
                    var rslt = await db.SaveChangesAsync();

                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] OFF");

                    return rslt;

                }

            }
            catch
            {


                return 0;

            }


        }

        public async Task<int> addAccountsSub(Accounts obj)
        {
            if (obj == null)
            {

                return 0;
            }
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] ON");

                    db.account.Add(obj);
                    var rslt = await db.SaveChangesAsync();

                    //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[AccountsLabels] OFF");
                    if (rslt>0)
                    {
                        return obj.Id;
                    }
                    return rslt;

                }

            }
            catch
            {


                return 0;

            }


        }

        public async Task<bool> DeleteTransAcc(int EntryId,string TransType)
        {
            if (EntryId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                var accTrans = await db.AccountsTransactionSubs.Where(tr => tr.EntryId == EntryId && tr.TransRefType == TransType).ToListAsync();

                db.AccountsTransactionSubs.RemoveRange(accTrans);

                rslt = await db.SaveChangesAsync();

                if (rslt > 0)
                {
                   
                        await helper.AddGigalog("Delete", "ErrAddAccTrans", TransType, EntryId.ToString(), "");

                    
                    //    DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }
        public async Task<bool> DeleteTransVoucher(int TransRefId, string TransRefNo, string TransType)
        {
            if (TransRefId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                var accTrans = await db.AccountsTransactionSubs.Where(tr => tr.TransRefId == TransRefId && tr.TransRefNo == TransRefNo && tr.TransRefType == TransType).ToListAsync();

                db.AccountsTransactionSubs.RemoveRange(accTrans);

                rslt = await db.SaveChangesAsync();

                if (rslt > 0)
                {

                    await helper.AddGigalog("Delete", "AccountsTransactionSubs", TransType, TransRefId.ToString(), TransRefNo.ToString());


                    //    DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }
        public async Task<bool> DeleteTransVoucherByGroup( int groupId, string TransType)
        {
            if (groupId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                var accTrans = await db.AccountsTransactionSubs.Where(tr =>  tr.GroupId == groupId && tr.TransRefType == TransType).ToListAsync();

                db.AccountsTransactionSubs.RemoveRange(accTrans);

                rslt = await db.SaveChangesAsync();

                if (rslt > 0)
                {

                    await helper.AddGigalog("Delete by group", "AccountsTransactionSubs", TransType, groupId.ToString(), "");


                    //    DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }

        public async Task<bool> DeleteTransVoucher(int TransRefId, string TransRefNo, string TransType, string TransTypeAr)
        {
            if (TransRefId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                var accTrans = await db.AccountsTransactionSubs.Where(tr => tr.TransRefId == TransRefId && tr.TransRefNo == TransRefNo && tr.TransRefType == TransType && tr.TransRefTypeAr == TransTypeAr).ToListAsync();

                db.AccountsTransactionSubs.RemoveRange(accTrans);

                rslt = await db.SaveChangesAsync();

                if (rslt > 0)
                {

                    await helper.AddGigalog("Delete", "AccountsTransactionSubs", TransType+ TransTypeAr, TransRefId.ToString(), TransRefNo.ToString());


                    //    DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }


        public async Task<bool> addTasleemTransac(int Id, Int64 VoucherNo, int Fromaccount, double Ammount, int GroupId)
        {

            var myTsleemDelete = await DeleteTransVoucherByGroup(GroupId, "Comm Tasslem");
            if (myTsleemDelete)
            {


                {
                    var entryId = 0;
                    string pimenttypeTasleem = "Comm Tasslem";

                    //Delivery Bill to suplier
                    entryId = await GetDefaultEntryId(pimenttypeTasleem);

                    if (entryId > 0)
                    {
                        var fromAcctr = new AccountsTransactionSub()
                        {
                            EntryId = entryId,
                            TransDate = DateTime.Now.Date,

                            TransRefType = pimenttypeTasleem,
                            TransRefTypeAr = "عمولة تسليم",
                            TransRefId = Id,
                            TransRefNo = VoucherNo.ToString(),
                            DetailsNote = " :عمولة تسليم وجبة رقم " + GroupId,
                            AccountID = Fromaccount,
                            AccountName = "",
                            FromAmount = Ammount,// obj.balance,
                            ToAmount = 0,// obj.balance,
                            EntryType = "مدين",
                            GroupId = GroupId

                            //MainVoucherId= MvoucherId


                        };
                        var rslt1 = 0;
                        var rslt2 = 0;

                        if (fromAcctr != null)
                        {
                            rslt1 = await AddToAccSubTrans(fromAcctr);
                        }


                        if (rslt1 > 0)
                        {
                            var toAcctr = new AccountsTransactionSub()
                            {
                                EntryId = entryId,
                                TransDate = DateTime.Now.Date,

                                TransRefType = pimenttypeTasleem,
                                TransRefTypeAr = "عمولة تسليم",
                                TransRefId = Id,
                                TransRefNo = VoucherNo.ToString(),
                                DetailsNote = " :عمولة تسليم وجبة رقم " + GroupId,
                                AccountID = Properties.Settings.Default.PropBAccountSales,
                                AccountName = "الطرود",
                                FromAmount = 0,// obj.balance,
                                ToAmount = Ammount,// obj.balance,
                                EntryType = "دائن",
                                GroupId = GroupId

                                //MainVoucherId = MvoucherId

                            };
                            if (toAcctr != null)
                            {

                                rslt2 = await AddToAccSubTrans(toAcctr);
                            }

                        }
                        else
                        {
                            await DeleteTransAcc(entryId, pimenttypeTasleem);

                        }




                        if (rslt2 > 0)
                        {
                            return true;



                        }
                        else
                        {
                            await DeleteTransAcc(entryId, pimenttypeTasleem);
                            return false;


                        }


                    }
                    else
                    {
                        return false;
                    }

                }

            }
            else
            {
                return false;
            }





        }


        public async Task<bool> addTawseelVendorTransac(int Id,string Gover, string Reciver, Int64 VoucherNo, int Fromaccount,  double Ammount)
        {

            var myTsleemDelete = await DeleteTransVoucher(Id, VoucherNo.ToString(), "Comm Tawseel");
            if (myTsleemDelete)
            {


                {
                    var entryId = 0;
                    string pimenttypeTasleem = "Comm Tawseel";

                    //Delivery Bill to suplier
                    entryId = await GetDefaultEntryId(pimenttypeTasleem);

                    if (entryId > 0)
                    {
                        var fromAcctr = new AccountsTransactionSub()
                        {
                            EntryId = entryId,
                            TransDate = DateTime.Now.Date,

                            TransRefType = pimenttypeTasleem,
                            TransRefTypeAr = "عمولة توصيل",
                            TransRefId = Id,
                            TransRefNo = VoucherNo.ToString(),
                            DetailsNote = "عمولة توصيل طرد رقم :" + Id + ":ايصال رقم:" + VoucherNo +"- المستلم : "+ Reciver+"- "+ Gover,
                            AccountID = Fromaccount,
                            AccountName = "",
                            FromAmount = Ammount,// obj.balance,
                            ToAmount = 0,// obj.balance,
                            EntryType = "مدين",

                            //MainVoucherId= MvoucherId


                        };
                        var rslt1 = 0;
                        var rslt2 = 0;

                        if (fromAcctr != null)
                        {
                            rslt1 = await AddToAccSubTrans(fromAcctr);
                        }


                        if (rslt1 > 0)
                        {
                            var toAcctr = new AccountsTransactionSub()
                            {
                                EntryId = entryId,
                                TransDate = DateTime.Now.Date,

                                TransRefType = pimenttypeTasleem,
                                TransRefTypeAr = "عمولة تسليم",
                                TransRefId = Id,
                                TransRefNo = VoucherNo.ToString(),
                                DetailsNote = "عمولة توصيل طرد رقم :" + Id + ":ايصال رقم:" + VoucherNo + "- المستلم : " + Reciver + "- " + Gover,
                                AccountID = Properties.Settings.Default.PropBAccountSales,
                                AccountName = "الطرود",
                                FromAmount = 0,// obj.balance,
                                ToAmount = Ammount,// obj.balance,
                                EntryType = "دائن",

                                //MainVoucherId = MvoucherId

                            };
                            if (toAcctr != null)
                            {

                                rslt2 = await AddToAccSubTrans(toAcctr);
                            }

                        }
                        else
                        {
                            await DeleteTransAcc(entryId, pimenttypeTasleem);

                        }




                        if (rslt2 > 0)
                        {
                            return true;



                        }
                        else
                        {
                            await DeleteTransAcc(entryId, pimenttypeTasleem);
                            return false;


                        }


                    }
                    else
                    {
                        return false;
                    }

                }

            }
            else
            {
                return false;
            }





        }


        public async Task<bool> DeleteAcc(Accounts acc)
        {
            if (acc ==null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                db.account.Attach(acc);

                db.account.Remove(acc);

                rslt = await db.SaveChangesAsync();

                if (rslt > 0)
                {
                    await helper.AddGigalog("Delete", "Accounts", acc.AccountName, acc.Id.ToString(), acc.AccountID.ToString());

                    DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }





        #region transaction

        public async Task<double> AddMainTransAcc(AccountsTransactionSub obj)
        {
            if (obj == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return -1;
            }
            int rslt = 0;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    if (db.Entry<AccountsTransactionSub>(obj).State == EntityState.Detached)
                    {
                        db.Set<AccountsTransactionSub>().Attach(obj);
                    }


                    if (obj.TransId == 0)
                    {
                       
                        db.Entry<AccountsTransactionSub>(obj).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry<AccountsTransactionSub>(obj).State = EntityState.Modified;
                    }


                    rslt = await db.SaveChangesAsync();







                    if (rslt > 0)
                    {
                        DesktopAlert.Show("تم الحفظ بنجاح " + obj.TransId + "\n" + " Saved  Done ", eDesktopAlertColor.Blue, eAlertPosition.TopRight);
                        return obj.TransId;

                    }
                    else
                    {
                        return 0;


                    }
                    //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
                }

            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);



                return -1;

            }


        }

        public async Task<IEnumerable<AccountsTransDTO>> GetAccountsListGroups(int accid, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var trans = await
                              db.AccountsTransactionSubs
                            
                              .Where(pr => pr.AccountID == accid 
                              && DbFunctions.TruncateTime(pr.TransDate) >= DateFrom
                              && DbFunctions.TruncateTime(pr.TransDate) < DateTo)
                              .GroupBy(o => new {o.TransDate.Month, o.TransDate.Day })
                            .ToListAsync();


                    var dto = trans.Select(x => new AccountsTransDTO()
                    {

                        TransDay = x.Key.Day.ToString(),
                        TransMonth=x.Key.Month.ToString(),
                          
                        totalDebit = x.Sum(a => a.FromAmount)
                          ,
                        totalCredit = x.Sum(a => a.ToAmount)
                          ,
                          
                        totalbalance = x.Sum(a => a.FromAmount)- x.Sum(a => a.ToAmount)


                    }
                         ).ToList();

                    return dto;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<DataTable> GetAccountsListGroupsRpt(int accid, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var trans = await
                              db.AccountsTransactionSubs

                              .Where(pr => pr.AccountID == accid
                              && DbFunctions.TruncateTime(pr.TransDate) >= DateFrom
                              && DbFunctions.TruncateTime(pr.TransDate) < DateTo)
                              .GroupBy(o => new { o.TransDate.Month, o.TransDate.Day })
                            .ToListAsync();


                    var dto = trans.Select(x => new AccountsTransDTO()
                    {

                        TransDay = x.Key.Day.ToString(),
                        TransMonth = x.Key.Month.ToString(),

                        totalDebit = x.Sum(a => a.FromAmount)
                          ,
                        totalCredit = x.Sum(a => a.ToAmount)
                          ,

                        totalbalance = x.Sum(a => a.FromAmount) - x.Sum(a => a.ToAmount)


                    }
                         ).ToList();
                    DataTable dt = ToDataTable<AccountsTransDTO>(dto);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }


        public async Task<IEnumerable<AccountsTransactionSub>> GetAccountsSubtMovement(int id, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var acctrans = await
                             db.AccountsTransactionSubs.Include(ac=>ac.Account)
                             .Where(
                                 pr =>
                                   (DbFunctions.TruncateTime(pr.TransDate) >= DateFrom &&
                           DbFunctions.TruncateTime(pr.TransDate) <= DateTo)&&
                                (pr.CusSubId== id || pr.AccountID == id)
                                 ).ToListAsync();


                    var accMyaccount = await db.account.Where(a => a.Id == id).FirstOrDefaultAsync();
                    var prevTrack = await
                             db.AccountsTransactionSubs.Include(ac => ac.Account)
                             .Where(
                                 pr =>
                                  (DbFunctions.TruncateTime(pr.TransDate) < DateFrom) &&
                                (pr.CusSubId == id || pr.AccountID == id)
                                 ).ToListAsync();


                    var prevFromBalance = prevTrack.Sum(f => f.FromAmount);
                    var prevToBalance = prevTrack.Sum(f => f.ToAmount);

                    var prevBalance = accMyaccount.Accounttype == 0 ? prevFromBalance - prevToBalance : prevToBalance - prevFromBalance;
                    if (prevBalance == 0)
                    {
                        return acctrans;

                    }

                    var actualBalanceFrom = prevBalance;
                    var actualBalanceTo = prevBalance;
                    var EntryType = "";


                    if (accMyaccount.Accounttype == 0)
                    {
                        if (prevBalance > 0)
                        {
                            actualBalanceFrom = prevBalance;
                            actualBalanceTo= 0;
                            EntryType = "مدين";
                        }
                        else
                        {

                            actualBalanceFrom = 0;
                            actualBalanceTo = (prevBalance*-1);
                            EntryType = "دائن";

                        }

                    }else
                    {
                        if (prevBalance > 0)
                        {
                            actualBalanceFrom = 0;
                            actualBalanceTo = prevBalance;
                            EntryType = "دائن";
                        }
                        else
                        {
                            actualBalanceFrom = (prevBalance * -1);
                            actualBalanceTo = 0;
                            EntryType = "مدين";

                        }
                    }
                    if (prevBalance != 0)
                    {
                        var accsubNew = new AccountsTransactionSub
                        {
                            TransId = 0,
                            TransRefId = 0,
                            EntryId = 0,
                            TransDate = DateFrom,
                            TransRefType = "Prev-Balance",
                            TransRefTypeAr = "رصيد مرحل",
                            TransRefNo = "0",
                            FromAmount = actualBalanceFrom,
                            ToAmount = actualBalanceTo,
                            EntryType = EntryType,
                            DetailsNote = "رصيد مرحل قبل : " + DateFrom.Date,
                            AccountID = accMyaccount.Id,
                            AmountText = "",
                            AccountName = accMyaccount.AccountName

                        };
                        acctrans.Add(accsubNew);

                    }





                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }


        public async Task<DataTable> GetAccountsSubtMovementReport(int id, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<AccountsTransactionSub> acctrans = await
                             db.AccountsTransactionSubs.Include(ac => ac.Account)
                             .Where(
                                 pr =>
                                    (DbFunctions.TruncateTime(pr.TransDate) >= DateFrom &&
                           DbFunctions.TruncateTime(pr.TransDate) <= DateTo) &&
                                (pr.CusSubId == id || pr.AccountID == id)
                                 ).ToListAsync();

                    var accMyaccount = await db.account.Where(a=>a.Id== id).FirstOrDefaultAsync();
                 
                    
                    var prevTrack = await
                          db.AccountsTransactionSubs.Include(ac => ac.Account)
                          .Where(
                              pr =>
                               (DbFunctions.TruncateTime(pr.TransDate) < DateFrom) &&
                             (pr.CusSubId == id || pr.AccountID == id)
                              ).ToListAsync();


                    var prevFromBalance = prevTrack.Sum(f=>f.FromAmount);
                    var prevToBalance = prevTrack.Sum(f=>f.ToAmount);

                    var prevBalance = accMyaccount.Accounttype == 0 ? prevFromBalance - prevToBalance : prevToBalance- prevFromBalance;
                  
                 
                    
                    var actualBalanceFrom = prevBalance;
                    var actualBalanceTo = prevBalance;
                    var EntryType = "";


                    if (accMyaccount.Accounttype == 0)
                    {
                        if (prevBalance > 0)
                        {
                            actualBalanceFrom = prevBalance;
                            actualBalanceTo = 0;
                            EntryType = "مدين";
                        }
                        else
                        {

                            actualBalanceFrom = 0;
                            actualBalanceTo = (prevBalance * -1);
                            EntryType = "دائن";

                        }

                    }
                    else
                    {
                        if (prevBalance > 0)
                        {
                            actualBalanceFrom = 0;
                            actualBalanceTo = prevBalance;
                            EntryType = "دائن";
                        }
                        else
                        {
                            actualBalanceFrom = (prevBalance * -1);
                            actualBalanceTo = 0;
                            EntryType = "مدين";

                        }
                    }
                    if (prevBalance != 0)
                    {
                        var accsubNew = new AccountsTransactionSub
                        {
                            TransId=0,
                            TransRefId=0,
                            EntryId = 0,
                            
                            TransDate = DateFrom.Date.AddDays(-1),
                            TransRefType = "Prev-Balance",
                            TransRefTypeAr = "رصيد مرحل",
                            TransRefNo = "0",
                            FromAmount = actualBalanceFrom,
                            ToAmount = actualBalanceTo,
                            EntryType = EntryType,
                            DetailsNote = "رصيد مرحل قبل : " + DateFrom.Date,
                            AccountID = accMyaccount.Id,
                            AmountText = "",
                            AccountName = accMyaccount.AccountName,
                            Account= accMyaccount

                        };
                        acctrans.Add(accsubNew);

                    }




                    var d = acctrans
                     .Select(x => new AccountsTransactionSub
                     {TransId=x.TransId,
                     
                     TransRefId=x.TransRefId,
                         EntryId = x.EntryId,
                         TransDate = x.TransDate,
                         TransRefType = x.TransRefType,
                         TransRefTypeAr = x.TransRefTypeAr,
                         TransRefNo = x.TransRefNo,
                         FromAmount = x.FromAmount,
                         ToAmount = x.ToAmount,
                         EntryType = x.EntryType,
                         DetailsNote = x.DetailsNote,
                         AccountID = x.AccountID,
                         AmountText=x.AmountText,
                         AccountName = x.Account.AccountName,
                         Details=x.Details

                     }).OrderBy(x=>x.TransDate)
                .ToList();




                    DataTable dt = ToDataTable<AccountsTransactionSub>(d);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }




        public async Task<IEnumerable<AccountsTransactionSub>> GetAccountsSubtMovementByMain(int id, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<AccountsTransactionSub> acctrans = await
                             db.AccountsTransactionSubs
                             .Where(
                                 pr => pr.Account.MAccountLabelId == id
                                 && pr.TransDate >= DateFrom && pr.TransDate <= DateTo
                                 ).ToListAsync();



                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }

        public async Task<Order> GetTransByUseer(int userId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var acctrans = await
                               db.Orders.Where(pr => pr.CreatedUserId == userId)
                                .FirstOrDefaultAsync();



                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<AccountsTransactionSub>> GetAccountsSubtMovementBytransType(string transType, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<AccountsTransactionSub> acctrans = await
                             db.AccountsTransactionSubs
                             .Where(
                                 pr => pr.TransRefType == transType
                                 && pr.TransDate >= DateFrom && pr.TransDate <= DateTo
                                 ).ToListAsync();



                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<AccountsTransactionSub>> GetAccountsSubtMovementBytransType(string transType,string EntryType, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<AccountsTransactionSub> acctrans = await
                             db.AccountsTransactionSubs.Include(x=>x.Account)
                             .Where(
                                 pr => (DbFunctions.TruncateTime(pr.TransDate) >= DateFrom &&
                           DbFunctions.TruncateTime(pr.TransDate) <= DateTo) && pr.TransRefType == transType && pr.EntryType== EntryType).ToListAsync();
                          

       //             var topProducts = sellingLog
       //.Where(s => s.salesYear == 2014)
       //.GroupBy(u => u.productCode)
       //.Select(g => new { productCode = g.Key, sales = g.Sum(u => u.productSales) })
       //.OrderByDescending(x => x.productCode)
       //.Take(5)
       //.ToList();
                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<IEnumerable<AccountsTransactionSub>> GetAccountsSubtMovementBytransType(string transType, string transTypeAr, string EntryType, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<AccountsTransactionSub> acctrans = await
                             db.AccountsTransactionSubs.Include(x => x.Account)
                             .Where(
                                 pr => (DbFunctions.TruncateTime(pr.TransDate) >= DateFrom &&
                           DbFunctions.TruncateTime(pr.TransDate) <= DateTo) && pr.TransRefType == transType && pr.TransRefTypeAr == transTypeAr && pr.EntryType == EntryType).ToListAsync();


                    //             var topProducts = sellingLog
                    //.Where(s => s.salesYear == 2014)
                    //.GroupBy(u => u.productCode)
                    //.Select(g => new { productCode = g.Key, sales = g.Sum(u => u.productSales) })
                    //.OrderByDescending(x => x.productCode)
                    //.Take(5)
                    //.ToList();
                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }


        public async Task<DataTable> GetAccountsSubtMovementBytransTypeReport(string transType,string EntryType, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var acctrans = await
                             db.AccountsTransactionSubs.Include(x => x.Account)
                             .Where(
                                 pr => (DbFunctions.TruncateTime(pr.TransDate) >= DateFrom &&
                           DbFunctions.TruncateTime(pr.TransDate) <= DateTo) && pr.TransRefType == transType && pr.EntryType == EntryType).ToListAsync();


                    DataTable dt = ToDataTable<AccountsTransactionSub>(acctrans);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }

        public async Task<DataTable> GetAccountsSubtMovementBytransTypeReport(string transType, string transTypeAr, string EntryType, DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var acctrans = await
                              db.AccountsTransactionSubs.Include(x => x.Account)
                              .Where(
                                  pr => (DbFunctions.TruncateTime(pr.TransDate) >= DateFrom &&
                            DbFunctions.TruncateTime(pr.TransDate) <= DateTo) && pr.TransRefType == transType&& pr.TransRefTypeAr == transTypeAr && pr.EntryType == EntryType).ToListAsync();


                    DataTable dt = ToDataTable<AccountsTransactionSub>(acctrans);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }




        public async Task<DataTable> GetVoucher(string transType,int id,string EntryType)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   List<AccountsTransactionSub> acctrans = await
                             db.AccountsTransactionSubs.Include(v=>v.Account)
                             .Where(
                                 pr => pr.TransRefType == transType && pr.EntryId== id && pr.EntryType == EntryType).ToListAsync();


                    var d = acctrans
                     .Select(x => new AccountsTransactionSub
                     {
                         EntryId = x.EntryId,
                         TransDate = x.TransDate,
                         TransRefType = x.TransRefType,
                         TransRefTypeAr = x.TransRefTypeAr,
                         TransRefNo = x.TransRefNo,
                         FromAmount = x.FromAmount,
                         ToAmount = x.ToAmount,
                         EntryType = x.EntryType,
                         DetailsNote = x.DetailsNote,
                         AccountID = x.AccountID,
                         AmountText=x.AmountText,
                         AccountName = x.Account.AccountName

                     })
                .OrderBy(x => x.EntryId).ToList();

                    DataTable dt = ToDataTable<AccountsTransactionSub>(d);

                    //             var topProducts = sellingLog
                    //.Where(s => s.salesYear == 2014)
                    //.GroupBy(u => u.productCode)
                    //.Select(g => new { productCode = g.Key, sales = g.Sum(u => u.productSales) })
                    //.OrderByDescending(x => x.productCode)
                    //.Take(5)
                    //.ToList();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<DataTable> GetVouchersForXml(string transType, int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<AccountsTransactionSub> acctrans = await
                              db.AccountsTransactionSubs.Include(v => v.Account)
                              .Where(
                                  pr => pr.TransRefType == transType && pr.EntryId == id ).ToListAsync();


                    var d = acctrans
                     .Select(x => new AccountsTransactionSub
                     {
                         EntryId = x.EntryId,
                         TransDate = x.TransDate,
                         TransRefType = x.TransRefType,
                         TransRefTypeAr = x.TransRefTypeAr,
                         TransRefNo = x.TransRefNo,
                         FromAmount = x.FromAmount,
                         ToAmount = x.ToAmount,
                         EntryType = x.EntryType,
                         DetailsNote = x.DetailsNote,
                         AccountID = x.AccountID,
                         AmountText = x.AmountText,
                         AccountName = x.Account.AccountName

                     })
                .OrderBy(x => x.EntryId).ToList();

                    DataTable dt = ToDataTable<AccountsTransactionSub>(d);

                    //             var topProducts = sellingLog
                    //.Where(s => s.salesYear == 2014)
                    //.GroupBy(u => u.productCode)
                    //.Select(g => new { productCode = g.Key, sales = g.Sum(u => u.productSales) })
                    //.OrderByDescending(x => x.productCode)
                    //.Take(5)
                    //.ToList();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
        public async Task<AccountsTransactionSub> GetVoucherForm(string transType, int id,string EntryType)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    AccountsTransactionSub acctrans = await
                              db.AccountsTransactionSubs.Include(v => v.Account)
                              .FirstOrDefaultAsync(
                                  pr => pr.TransRefType == transType && pr.EntryId == id && pr.EntryType== EntryType);


                    //             var topProducts = sellingLog
                    //.Where(s => s.salesYear == 2014)
                    //.GroupBy(u => u.productCode)
                    //.Select(g => new { productCode = g.Key, sales = g.Sum(u => u.productSales) })
                    //.OrderByDescending(x => x.productCode)
                    //.Take(5)
                    //.ToList();
                    return acctrans;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }
       

        public async Task<double> GetAccountsSubBalance(int accountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var selectedAccount = await
                      (from acc in db.account
                       where (acc.Id == accountId )
                       join acctrans in db.AccountsTransactionSubs on acc.Id equals acctrans.AccountID

                       into g
                       select new
                       {

                           Id = acc.Id,
                           AccountID = acc.AccountID,
                           Accounttype = acc.Accounttype,
                           AccountName = acc.AccountName,
                           totalbalance = acc.Accounttype == 0 ?
                           (g.Sum(i => i.FromAmount)) - (g.Sum(i => i.ToAmount)) : (g.Sum(i => i.ToAmount)) - (g.Sum(i => i.FromAmount))

                       }).ToListAsync();
                    List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();
                    
                    foreach (var item in selectedAccount)
                    {
                        var Srecord = new AccountsTransDTO()
                        {
                            Id = item.Id,
                            AccountID = item.AccountID,
                            Accounttype = item.Accounttype,
                            AccountName = item.AccountName,
                            totalbalance = item.totalbalance

                        };
                        dlist.Add(Srecord);
                    }

                    var result1 = dlist.Where(dli => dli.Id == accountId).FirstOrDefault();

                    return result1.totalbalance;


                }
            }
            catch
            {
                return 0;
            }
        }
        public async Task<AccountsTransDTO> GetAccountBalance(int accountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var selectedAccount = await
                      (from acc in db.account
                       where (acc.Id == accountId )
                       join acctrans in db.AccountsTransactionSubs on acc.Id equals acctrans.AccountID

                       into g
                       select new
                       {

                           Id = acc.Id,
                           AccountID = acc.AccountID,
                           Accounttype = acc.Accounttype,
                           AccountName = acc.AccountName,
                           fromAmmount = (g.Sum(i => i.FromAmount)),
                           toAmmount = (g.Sum(i => i.ToAmount)),
                           totalbalance = acc.Accounttype == 0 ?(g.Sum(i => i.FromAmount)) - (g.Sum(i => i.ToAmount)) : (g.Sum(i => i.ToAmount)) - (g.Sum(i => i.FromAmount))

                       }).FirstOrDefaultAsync();

                    //foreach (var item in selectedAccount)
                    //{
                    var Srecord = new AccountsTransDTO()
                    {
                        Id = selectedAccount.Id,
                        AccountID = selectedAccount.AccountID,
                        Accounttype = selectedAccount.Accounttype,
                        AccountName = selectedAccount.AccountName,
                        totalbalance = selectedAccount.totalbalance,
                        totalDebit = selectedAccount.toAmmount,
                        totalCredit = selectedAccount.fromAmmount,
                    };
                    //    };
                    //    dlist.Add(Srecord);
                    //}

                    //var result1 = dlist.Where(dli => dli.Id == accountId).FirstOrDefault();

                    return Srecord;


                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<double> GetAccountsSubBalanceOnlyPrePaid(int accountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var selectedAccount = await
                      (from acc in db.account
                       where (acc.Id == accountId )
                       join acctrans in db.AccountsTransactionSubs.Where(s=>s.TransRefType== "Payment" &&s.TransRefTypeAr== "دفعة مقدم") on acc.Id equals acctrans.AccountID
                       into g   

                       select new
                       {

                           Id = acc.Id,
                           AccountID = acc.AccountID,
                           Accounttype = acc.Accounttype,
                           AccountName = acc.AccountName,
                           totalbalance = acc.Accounttype == 0 ?
                           (g.Sum(i => i.ToAmount)) : (g.Sum(i => i.FromAmount))

                       }).ToListAsync();
                    List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();

                    foreach (var item in selectedAccount)
                    {
                        var Srecord = new AccountsTransDTO()
                        {
                            Id = item.Id,
                            AccountID = item.AccountID,
                            Accounttype = item.Accounttype,
                            AccountName = item.AccountName,
                            totalbalance = item.totalbalance

                        };
                        dlist.Add(Srecord);
                    }

                    var result1 = dlist.Where(dli => dli.Id == accountId).FirstOrDefault();

                    return result1.totalbalance;


                }
            }
            catch
            {
                return 0;
            }
        }
        public async Task<double> GetAccountsSubBalanceOnlySubPaid(int accountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var selectedAccount = await
                      (from acc in db.account
                       where (acc.Id == accountId)
                       join acctrans in db.AccountsTransactionSubs.Where(s => s.TransRefType == "Payment" &&( s.TransRefTypeAr == "تسديد دفعة" || s.TransRefTypeAr == "تسديد طرد")) on acc.Id equals acctrans.AccountID
                       into g

                       select new
                       {

                           Id = acc.Id,
                           AccountID = acc.AccountID,
                           Accounttype = acc.Accounttype,
                           AccountName = acc.AccountName,
                           totalbalance = acc.Accounttype == 0 ?
                           (g.Sum(i => i.ToAmount))  : (g.Sum(i => i.FromAmount)) 

                       }).ToListAsync();
                    List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();

                    foreach (var item in selectedAccount)
                    {
                        var Srecord = new AccountsTransDTO()
                        {
                            Id = item.Id,
                            AccountID = item.AccountID,
                            Accounttype = item.Accounttype,
                            AccountName = item.AccountName,
                            totalbalance = item.totalbalance

                        };
                        dlist.Add(Srecord);
                    }

                    var result1 = dlist.Where(dli => dli.Id == accountId).FirstOrDefault();

                    return result1.totalbalance;


                }
            }
            catch
            {
                return 0;
            }
        }
        public async Task<double> GetAccountsPaidForVendors(int accountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var selectedAccount = await
                      (from acc in db.account
                       where (acc.Id == accountId)
                       join acctrans in db.AccountsTransactionSubs.Where(s => s.TransRefType == "Payment" ) on acc.Id equals acctrans.AccountID
                       into g

                       select new
                       {

                           Id = acc.Id,
                           AccountID = acc.AccountID,
                           Accounttype = acc.Accounttype,
                           AccountName = acc.AccountName,
                           totalbalance = acc.Accounttype == 0 ?
                           (g.Sum(i => i.ToAmount)) : (g.Sum(i => i.FromAmount))

                       }).ToListAsync();
                    List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();

                    foreach (var item in selectedAccount)
                    {
                        var Srecord = new AccountsTransDTO()
                        {
                            Id = item.Id,
                            AccountID = item.AccountID,
                            Accounttype = item.Accounttype,
                            AccountName = item.AccountName,
                            totalbalance = item.totalbalance

                        };
                        dlist.Add(Srecord);
                    }

                    var result1 = dlist.Where(dli => dli.Id == accountId).FirstOrDefault();

                    return result1.totalbalance;


                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<IEnumerable<AccountsTransDTO>> GetAccountsDto(int MaccountId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {

                    var selectedAccount = await
                      (from acc in db.account
                       where (acc.MAccountLabelId == MaccountId)
                       join acctrans in db.AccountsTransactionSubs on acc.Id equals acctrans.AccountID
                    
                       into g
                       select new
                       {

                           Id = acc.Id,
                           AccountID = acc.AccountID,
                           Accounttype = acc.Accounttype,
                           AccountName = acc.AccountName,
                           totalbalance = acc.Accounttype==0?
                           (g.Sum(i => i.FromAmount)) - (g.Sum(i => i.ToAmount)) : (g.Sum(i => i.ToAmount)) - (g.Sum(i => i.FromAmount))

                       }).ToListAsync();
                    List<AccountsTransDTO> dlist = new List<AccountsTransDTO>();

                    foreach (var item in selectedAccount)
                    {
                        var Srecord = new AccountsTransDTO()
                        {
                            Id = item.Id,
                            AccountID = item.AccountID,
                            Accounttype = item.Accounttype,
                            AccountName = item.AccountName,
                            totalbalance=item.totalbalance

                        };
                        dlist.Add(Srecord);
                    }
                    return dlist.AsEnumerable();


                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }




        #endregion







        #region helper


        string GetAmountWords(double amount)
        {
            List<CurrencyInfo> currencies = new List<CurrencyInfo>();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Iraq));

            ToWord toWord = new ToWord(Convert.ToDecimal(amount), currencies[0]);

            if (Properties.Settings.Default.Language == "EN")
            {
                return toWord.ConvertToEnglish();

            }
            else
            {
                return toWord.ConvertToArabic();


            }


        }




        #endregion


    }
}
