using DevComponents.DotNetBar.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ExmonSystem.Controls
{
    public class ItemGoverControl
    {

        public ItemGoverControl()
        {
        }

        public async Task<IEnumerable<ItemGover>> GetAllItemGover()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<ItemGover> itemunit =await
                             db.ItemGovers.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<AirLine>> GetAllAirlines()
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
        public async Task<IEnumerable<Subscriber>> GetAllSubscribers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Subscriber> itemunit = await
                             db.Subscribers.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<Subscriber> GetSubscribers(int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemunit = await
                             db.Subscribers.Where(x=>x.Id== id).FirstOrDefaultAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<bool> GetSubscriberCheck(int Id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemunit = await
                             db.Subscribers.FindAsync(Id);
                    if (itemunit!=null)
                    {
                        return true;

                    }
                    else { return false; }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<ExCompany> GetExCompany(int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var itemunit = await
                              db.ExCompanies.Include(d => d.Driver).Include(d => d.Subscriber).Where(x => x.Id == id).FirstOrDefaultAsync();

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
                             db.ExCompanies.Include(x=>x.Subscriber).Include(d=>d.Driver).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<Order>> GetOrders(int ExCompanyId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Order> itemunit = await
                             db.Orders.Where(x=>x.ExCompanyId== ExCompanyId).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<OrderSub>> GetSubOrders(int DestnationId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<OrderSub> itemunit = await
                             db.OrderSubs.Where(x => x.DestinationId == DestnationId).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<OrderSub>> GetSubOrderByAirlines(int airLineId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<OrderSub> itemunit = await
                             db.OrderSubs.Where(x => x.AirlineId == airLineId).ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Driver> itemunit =await
                             db.Drivers.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<District>> GetAllDistricts()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<District> itemunit = await
                             db.Districts.ToListAsync();

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
            catch
            {
                return null;
            }
        }
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Customer> itemunit = await
                             db.Customers.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<IEnumerable<CompanyTorism>> GetAllCompanyTorisms()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<CompanyTorism> itemunit = await
                             db.CompanyTorisms.ToListAsync();

                    return itemunit;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<int> AddUntsDirect(ItemGover obj)
        {
            if (obj == null)
            {

                return 0;
            }
            int rslt = 0;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var isUniq = db.ItemGovers.FirstOrDefault(q => q.Name == obj.Name);
                    if (isUniq != null)
                    {
                        return 0;

                    }
                    db.ItemGovers.Attach(obj);

                    db.ItemGovers.Add(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return obj.Id;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }
        public async Task<bool> DeleteDriver(int GoverId)
        {
            if (GoverId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {

                var itemObj = await db.Drivers.FindAsync(GoverId);
                if (itemObj != null)
                {

                    db.Drivers.Attach(itemObj);

                    db.Drivers.Remove(itemObj);

                    rslt = await db.SaveChangesAsync();

                    if (rslt > 0)
                    {
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                    }
                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }

        public async Task<bool> DeleteGover(int GoverId)
        {
            if (GoverId == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;
            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {

                var itemObj = await db.ItemGovers.FindAsync(GoverId);
                if (itemObj != null)
                {

                    db.ItemGovers.Attach(itemObj);

                    db.ItemGovers.Remove(itemObj);

                    rslt = await db.SaveChangesAsync();

                    if (rslt > 0)
                    {
                        DesktopAlert.Show("تم الحذف بنجاح " + "\n" + " Deleted  Done ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);

                    }
                }
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }













    }
}
