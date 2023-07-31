using DevComponents.DotNetBar.Controls;
using ExmonSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Controls
{
   public class RollsControl
    {
        Helper helper = new Helper();


        public RollsControl()
        {
        }

        public async Task<IEnumerable<RollNames>> GetAllNames()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<RollNames> rollNames =await
                             db.RollName.ToListAsync();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }
        public async Task<IEnumerable<RollGroups>> GetGroups()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<RollGroups> rollNames = await
                             db.RollGroup.ToListAsync();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }

        public async Task<RollGroups> GetGroup()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var rollNames = 
                             db.RollGroup.FirstOrDefault();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }




        public async Task<RollNames>GetRollName()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var rollNames = 
                             db.RollName.FirstOrDefault();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }

        public async Task<RollNames> GetRollName(string roolName)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var rollNames =
                             db.RollName.Where(x=>x.RollName==roolName).FirstOrDefault();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }


        public async Task<int> AddRollNamesDirect(RollNames obj)
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
                    var isUniq = db.RollName.FirstOrDefault(q => q.RollName == obj.RollName);
                    if (isUniq!=null)
                    {
                        return 0;

                    }
                    db.RollName.Attach(obj);

                    db.RollName.Add(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return obj.Id;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }


        public async Task<int> AddListRollNamesDirect(List< RollNames> obj)
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
                   
                    db.RollName.AddRange(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return rslt;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }


        public async Task<int> AddListGroupsDirect(List<RollGroups> obj)
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
                   

                    db.RollGroup.AddRange(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return rslt;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }

        public async Task<int> AddListRollDirect(List<Rolls> obj)
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
                   
                    db.Roll.AddRange(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return rslt;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }




        public async Task<bool> DeleteRollName(IEnumerable<RollNames> SubRollNames)
        {

            if (SubRollNames == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;

            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                foreach (var item in SubRollNames)
                {
                    db.RollName.Attach(item);

                    db.RollName.Remove(item);
                    rslt = await db.SaveChangesAsync();


                }


                //if (rslt > 0)
                //{

                //}
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }



        public async Task<IEnumerable<Rolls>> getMyRoll(int groupId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Rolls> rollNames = await
                             db.Roll.Where(r=>r.groupRollId== groupId).ToListAsync();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }


        public async Task<Rolls> getMyRoll(int groupId,string roolTitle)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                  var rollNames = 
                             db.Roll.Where(r => r.groupRollId == groupId && r.RollTitle== roolTitle).FirstOrDefault();

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }




        public async Task<RollGroups> GetGroups(string GroupName)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                  RollGroups rollNames = await
                             db.RollGroup.FirstOrDefaultAsync(g=>g.GroupRollName== GroupName);

                    return rollNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }


        public async Task<IEnumerable<User>> GetUsers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<User> UserNames =
                             db.Users.ToList();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }
        public async Task<IEnumerable<User>> GetUsersSettings()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<User> UserNames =
                             db.Users.Include(x=>x.groupRoll).ToList();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }

        public async Task<IEnumerable<User>> GetUsers(string rool1,string rool2)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<User> UserNames =
                             db.Users.Include(x=>x.groupRoll).Where(x=>x.groupRoll.GroupRollName== rool1 || x.groupRoll.GroupRollName==rool2).ToList();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }
        public async Task<User> GetUser()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var UserNames =
                             db.Users.FirstOrDefault();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }

        public async Task <User> GetUsers(int id)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                   var  UserNames =await
                             db.Users.Include(x=>x.groupRoll).Where(s=>s.Id==id).FirstOrDefaultAsync();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }
        public async Task<User> GetUsers(string name)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    var UserNames = await
                              db.Users.Where(s => s.UserName == name).FirstOrDefaultAsync();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<User> UserNames =await
                             db.Users.ToListAsync();

                    return UserNames;
                }
            }
            catch (Exception ex)
            {
                return null;
            }




        }
        public async Task<bool> CheckLogin(string UserId,string password)
        {
            var isAuthent = false;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                     isAuthent = db.Users.Any(q => q.UserName == UserId&&q.Pwd== password);
                
                }
                return isAuthent;

            }
            catch (Exception ex)
            {


                return isAuthent;

            }


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


        public async Task<IEnumerable<Rolls>> GetGroupRolls(int GroupId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    IEnumerable<Rolls> itemproduct =  
                             db.Roll
                             .Where(pr => pr.groupRollId==GroupId).ToList();



                    return itemproduct;
                }
            }
            catch (Exception ex)
            {
                helper.ShowMessage(MainMenu.ActiveForm, "خطأ Error", ex.Message);
                return null;
            }
        }


        public async Task<int> AddGroupsDirect(RollGroups obj)
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
                    var isUniq = db.RollGroup.FirstOrDefault(q => q.GroupRollName == obj.GroupRollName);
                    if (isUniq != null)
                    {
                        return 0;

                    }
                    db.RollGroup.Attach(obj);

                    db.RollGroup.Add(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return obj.Id;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }

        

        public async Task<int> AddGroupsRollDirect(Rolls obj)
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
                    var isUniq = db.Roll.FirstOrDefault(q => q.RollTitle == obj.RollTitle && q.groupRollId==obj.groupRollId);
                    if (isUniq != null)
                    {
                        return 0;

                    }
                    db.Roll.Attach(obj);

                    db.Roll.Add(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return obj.Id;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }
        public async Task<int> AddUserDirect(User obj)
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
                    var isUniq =await db.Users.FirstOrDefaultAsync(q => q.UserName == obj.UserName );
                    if (isUniq != null)
                    {
                        return 0;

                    }
                    db.Users.Attach(obj);

                    db.Users.Add(obj);

                    rslt = await db.SaveChangesAsync();

                }
                return obj.Id;

            }
            catch (Exception ex)
            {


                return 0;

            }


        }
        public async Task<int> EditUserDirect(User obj)
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
                    db.Set<User>().Attach(obj);
                    db.Entry<User>(obj).State = EntityState.Modified;
                    await db.SaveChangesAsync();


                }
                return obj.Id;

            }
            catch
            {


                return 0;

            }


        }
        public async Task<int> AddUser(User obj)
        {
            if (obj == null)
            {

                return 0;
            }
            int rslt = 0;
            //try
            //{
                using (MyDbContext db = new MyDbContext())
                {
                   

                    if (db.Entry<User>(obj).State == EntityState.Detached)
                        db.Set<User>().Attach(obj);

                    if (obj.Id == 0)
                    {
                    var isUniq = await db.Users.FirstOrDefaultAsync(q => q.UserName == obj.UserName);
                    if (isUniq != null)
                    {
                        return 0;

                    }
                    db.Entry<User>(obj).State = EntityState.Added;

                    }
                    else
                    {
                        db.Entry<User>(obj).State = EntityState.Modified;
                    }
                    rslt = await db.SaveChangesAsync();

                }
                return obj.Id;

            //}
            //catch (Exception ex)
            //{


            //    return 0;

            //}


        }

        public async Task<bool> DeleteRolls(int groupID)
        {

            if (groupID == 0)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;

            }
            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                var roll = db.Roll.Where(r => r.groupRollId == groupID).ToList();

                foreach (var item in roll)
                {
                    db.Roll.Attach(item);

                    db.Roll.Remove(item);
                    rslt = await db.SaveChangesAsync();


                }


                //if (rslt > 0)
                //{

                //}
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }

        public async Task<bool> DeleteRollGroup(IEnumerable<RollGroups> SubRollNames)
        {

            if (SubRollNames == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;

            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
                foreach (var item in SubRollNames)
                {
                    db.RollGroup.Attach(item);

                    db.RollGroup.Remove(item);
                    rslt = await db.SaveChangesAsync();


                }


                //if (rslt > 0)
                //{

                //}
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }

        public async Task<bool> DeleteRollGroup(RollGroups SubRollNames)
        {

            if (SubRollNames == null)
            {
                DesktopAlert.Show("لم يتم تحديد اي سجل  " + "\n" + " No Selected Record ", eDesktopAlertColor.Default, eAlertPosition.TopRight);

                return false;

            }

            int rslt = 0;
            using (MyDbContext db = new MyDbContext())
            {
              
                    db.RollGroup.Attach(SubRollNames);

                    db.RollGroup.Remove(SubRollNames);
                    rslt = await db.SaveChangesAsync();


               


                //if (rslt > 0)
                //{

                //}
                //helper.ShowMessage(this, "", "تم الحفظ بنجاح " + "\n" + "Saved  Done ");
            }
            return true;


        }




    }
}
