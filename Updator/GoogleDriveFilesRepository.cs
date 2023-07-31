
using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Threading.Tasks;
using DevComponents.DotNetBar.Controls;
using System.Globalization;
using System.Net.NetworkInformation;

namespace GigaPosUpdator
{
   public class GoogleDriveFilesRepository
    {
        private static void myPingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;

            if (e.Error != null)
                return;

            if (e.Reply.Status == IPStatus.Success)
            {
                //ok connected to internet, do something...
            }
        }

        public static bool checkInternet()
        {
            Ping myPing = new Ping();
            myPing.PingCompleted += new PingCompletedEventHandler(myPingCompletedCallback);
            try
            {
                myPing.SendAsync("google.com", 3000 /*3 secs timeout*/, new byte[32], new PingOptions(64, true));
                return true;
            }
            catch
            {
                return false;

            }
        }
        //Download file from Google Drive by fileId.

        // file save to server path
        private static void SaveStream(MemoryStream stream, string FilePath)
        {
            using (System.IO.FileStream file = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                stream.WriteTo(file);
            }
        }

        /*sbytes
        //    s
        //    s
        //    s
        /
        /
        /
        /
        /
        /
        /
        /

        //    s
        */    


        public static string GetGoogleDriveDownloadLinkFromUrl(string url)
        {
            int index = url.IndexOf("id=");
            int closingIndex;
            if (index > 0)
            {
                index += 3;
                closingIndex = url.IndexOf('&', index);
                if (closingIndex < 0)
                    closingIndex = url.Length;
            }
            else
            {
                index = url.IndexOf("file/d/");
                if (index < 0) // url is not in any of the supported forms
                    return string.Empty;

                index += 7;

                closingIndex = url.IndexOf('/', index);
                if (closingIndex < 0)
                {
                    closingIndex = url.IndexOf('?', index);
                    if (closingIndex < 0)
                        closingIndex = url.Length;
                }
            }

            return string.Format("https://drive.google.com/uc?id={0}&export=download", url.Substring(index, closingIndex - index));
        }
        private static FileInfo DownloadFileFromURLToPath(string url, string path, WebClient webClient)
        {
            try
            {
                if (webClient == null)
                {
                  
                    using (webClient = new WebClient())
                    {
                        webClient.DownloadFile(url, path);
                        return new FileInfo(path);
                    }
                }
                else
                {
                    webClient.DownloadFile(url, path);
                    return new FileInfo(path);
                }
            }
            catch (WebException)
            {
                SetLog("error on upgrade url:" + url + "; on:" + DateTime.Now, "Upgrade");
                return null;
            }
        }
        public static void ReadSeriallAndUpdateVersonNo()
        {
            if (!File.Exists(@".\updater.json"))
            {

                return;
            }
            if (!File.Exists(@".\myVersionInfo.json"))
            {

                return;
            }
            int curentNo = 0;
            using (StreamReader r = new StreamReader(@".\myVersionInfo.json"))
            {
                var jsonCurent = r.ReadToEnd();
                myVersionInfo itemsCurent = JsonConvert.DeserializeObject<myVersionInfo>(jsonCurent);
                if (itemsCurent!=null)
                {
                    curentNo = itemsCurent.Vno;
                }

                //DesktopAlert.Show("curent "+ curentNo);

            }
            using (StreamReader r = new StreamReader(@".\updater.json"))
            {
                var json = r.ReadToEnd();
                myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                if (items.Vno > curentNo)
                {
                    //Properties.Settings.Default.VersonNo = items.Vno;
                    //Properties.Settings.Default.Save();


                    DesktopAlert.Show("update successfully Done");
                    if (File.Exists(Application.StartupPath + @"\updateDone.txt"))
                    {
                        File.Delete(Application.StartupPath + @"\updateDone.txt");
                        if (File.Exists(Application.StartupPath + @"\updater.zip"))
                        {
                            File.Delete(Application.StartupPath + @"\updater.zip");
                        }
                    }
                }
                else
                {
                    DesktopAlert.Show("this is the last Version");
                    File.Delete(Application.StartupPath + @"\updateDone.txt");


                }
            }


            //var ss = JsonConvert.DeserializeObject(json);
            //var x = (List<Rolls>)ss;

        }
        public async static Task< bool> dooo()
        {
            //try
            //{

            await Task.Run(()=>    DownloadGoogleDriveFileFromURLToPath("https://drive.google.com/file/d/1eCuo0YmO8-2zg9-MToggC406g9DH-54-/view?usp=share_link", Application.StartupPath + @"\updater.json"));


            //MessageBox.Show("2 ");


            //}
            //catch 
            //{

            //    return false ;
            //}

            return await ReadSeriall();


        }
        public async static Task<bool> ReadSeriall()
        {
            if (!File.Exists(@".\updater.json"))
            {
                //MessageBox.Show("1ChecK updating Settings");

                return false;
            }
            if (!File.Exists(@".\myVersionInfo.json"))
            {

                return false;
            }
            int curentNo = 0;
            using (StreamReader r = new StreamReader(@".\myVersionInfo.json"))
            {
                var jsonCurent = r.ReadToEnd();
                myVersionInfo itemsCurent = JsonConvert.DeserializeObject<myVersionInfo>(jsonCurent);
                if (itemsCurent != null)
                {
                    curentNo = itemsCurent.Vno;
                }

                //DesktopAlert.Show("curent " + curentNo);

            }

            using (StreamReader r = new StreamReader(@".\updater.json"))
            {
                var json = await r.ReadToEndAsync();
                myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                if (items.Vno > curentNo)
                {
                    //DesktopAlert.Show("New Update Detected");
                    return true;

                }
                else
                {
                    return false;

                    //MessageBox.Show("this is the last Version");


                }
            }


            //var ss = JsonConvert.DeserializeObject(json);
            //var x = (List<Rolls>)ss;

        }



        public static myVersionInfo GetUpdateVlue()
        {
            if (!File.Exists(@".\myVersionInfo.json"))
            {

                return null;
            }
            using (StreamReader r = new StreamReader(@".\myVersionInfo.json"))
            {
                var json = r.ReadToEnd();
                myVersionInfo items = JsonConvert.DeserializeObject<myVersionInfo>(json);

                //DesktopAlert.Show("New Update Detected");

                if (items != null)
                {
                    return items;
                }
                else
                {
                    return null;
                }

            }


        }
        public static void UpdateValue(myVersionInfo items)
        {
            if (File.Exists(@".\myVersionInfo.json"))
            {
                File.Delete(@".\myVersionInfo.json");
            }
            if (items != null)
            {
                File.WriteAllText(@".\myVersionInfo.json", JsonConvert.SerializeObject(items));

            }


        }
        public static void SetUpdateValue(int vno)
        {
            var myinfo = new myVersionInfo()
            {
                Vno = vno

            };

            UpdateValue(myinfo);
        }
        public static void GetUpdateFile()
        {
            if (!File.Exists(@".\updater.json"))
            {
                MessageBox.Show("ChecK updating Settings");

                return ;
            }
            if (!File.Exists(@".\myVersionInfo.json"))
            {

                return ;
            }
            int curentNo = 0;
            using (StreamReader r = new StreamReader(@".\myVersionInfo.json"))
            {
                var jsonCurent = r.ReadToEnd();
                myVersionInfo itemsCurent = JsonConvert.DeserializeObject<myVersionInfo>(jsonCurent);
                if (itemsCurent != null)
                {
                    curentNo = itemsCurent.Vno;
                }

                //DesktopAlert.Show(" GetUpdateFile curent " + curentNo);

            }

            using (StreamReader r = new StreamReader(@".\updater.json"))
            {
                var json = r.ReadToEnd();
                myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                if (items.Vno > curentNo)
                {
                    DesktopAlert.Show("يوجد تحديث جديد ! يرجى الإنتظار قليلا");
                    DownloadGoogleDriveFileFromURLToPath(items.UriPath, Application.StartupPath + @"\updater.zip");

                    if (File.Exists(@".\updater.zip"))
                    {

                        System.Diagnostics.Process.Start(@".\Updater.exe");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم التحديث حاولا لاحقا");

                    }




                }
                else
                {
                    return ;



                }
            }
         

        }





        public static void SetLog(string errDetails,string fname)
        {
         

            var log = new myLog() { ErrorDetails = errDetails };
            if (log != null)
            {
                File.WriteAllText(@".\"+ fname + "_Log.json", JsonConvert.SerializeObject(log));

            }


        }
        private static FileInfo DownloadGoogleDriveFileFromURLToPath(string url, string path)
        {
            // You can comment the statement below if the provided url is guaranteed to be in the following format:
            // https://drive.google.com/uc?id=FILEID&export=download
            url = GetGoogleDriveDownloadLinkFromUrl(url);
         
            
            using (CookieAwareWebClient webClient = new CookieAwareWebClient())
            {
                FileInfo downloadedFile;
                //MessageBox.Show("1 ");

                // Sometimes Drive returns an NID cookie instead of a download_warning cookie at first attempt,
                // but works in the second attempt
                for (int i = 0; i < 2; i++)
                {
                    downloadedFile = DownloadFileFromURLToPath(url, path, webClient);
                    //Thread.Sleep(1000);



                    //MessageBox.Show("name: " + downloadedFile.Name);

                    if (downloadedFile == null)
                        return null;

                    // Confirmation page is around 50KB, shouldn't be larger than 60KB
                    if (downloadedFile.Length > 60000)
                        return  downloadedFile;

                    // Downloaded file might be the confirmation page, check it
                    string content;
                    using (var reader = downloadedFile.OpenText())
                    {
                        // Confirmation page starts with <!DOCTYPE html>, which can be preceeded by a newline
                        char[] header = new char[20];
                        int readCount = reader.ReadBlock(header, 0, 20);
                        if (readCount < 20 || !(new string(header).Contains("<!DOCTYPE html>")))
                            return downloadedFile;

                        content = reader.ReadToEnd();
                    }

                    int linkIndex = content.LastIndexOf("href=\"/uc?");
                    if (linkIndex < 0)
                        return downloadedFile;

                    linkIndex += 6;
                    int linkEnd = content.IndexOf('"', linkIndex);
                    if (linkEnd < 0)
                        return downloadedFile;

                    url = "https://drive.google.com" + content.Substring(linkIndex, linkEnd - linkIndex).Replace("&amp;", "&");
                }

                downloadedFile = DownloadFileFromURLToPath(url, path, webClient);
               
                return downloadedFile;
            }
        }

    }
    // Web client used for Google Drive
    public class CookieAwareWebClient : WebClient
    {
        private class CookieContainer
        {
            Dictionary<string, string> _cookies;

            public string this[Uri url]
            {
                get
                {
                    string cookie;
                    if (_cookies.TryGetValue(url.Host, out cookie))
                        return cookie;

                    return null;
                }
                set
                {
                    _cookies[url.Host] = value;
                }
            }

            public CookieContainer()
            {
                _cookies = new Dictionary<string, string>();
            }
        }

        private CookieContainer cookies;

        public CookieAwareWebClient() : base()
        {
            cookies = new CookieContainer();
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);

            if (request is HttpWebRequest)
            {
                string cookie = cookies[address];
                if (cookie != null)
                    ((HttpWebRequest)request).Headers.Set("cookie", cookie);
            }

            return request;
        }

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            WebResponse response = base.GetWebResponse(request, result);

            string[] cookies = response.Headers.GetValues("Set-Cookie");
            if (cookies != null && cookies.Length > 0)
            {
                string cookie = "";
                foreach (string c in cookies)
                    cookie += c;

                this.cookies[response.ResponseUri] = cookie;
            }

            return response;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);

            string[] cookies = response.Headers.GetValues("Set-Cookie");
            if (cookies != null && cookies.Length > 0)
            {
                string cookie = "";
                foreach (string c in cookies)
                    cookie += c;

                this.cookies[response.ResponseUri] = cookie;
            }

            return response;
        }
    }

}
//            //name="cn" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=GIGADB;User ID=sa;Password=123;

class myUpdate
{
    public string UriPath { get; set; }
    public int Vno { get; set; }

}

public class GoogleDriveFiles
{
    public string Id { get; set; }
    public string Name { get; set; }
    public long? Size { get; set; }
    public long? Version { get; set; }
    public DateTime? CreatedTime { get; set; }
}