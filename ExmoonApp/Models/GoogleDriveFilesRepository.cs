
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
using ExmonSystem.Models;

namespace ExmonSystem
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





        //public  static void  Authorize(string filepath)
        //{

        //    try
        //    {
        //        DesktopAlert.Show("سيتم رفع النسخة الى قوقل درايف ! يرجى الانتظار " + "\n" + "Please wait While uploading to Google Drive ! ", eDesktopAlertColor.BlueGray, eAlertPosition.TopRight);


        //        //DesktopAlert.Show("1");
        //        string[] scopes = new string[] { DriveService.Scope.Drive,
        //                       DriveService.Scope.DriveFile,};
        //    var clientId = Properties.Settings.Default.PropGoogleDriveClientId;// "780623042881-et9n6um9mthhllpuuo7heupruno2ctl2.apps.googleusercontent.com";      // From https://console.developers.google.com  
        //    var clientSecret = Properties.Settings.Default.PropGoogleDriveClientSecret; //"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";          // From https://console.developers.google.com  
        //                                                                 // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%  
        //    var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
        //    {
        //        ClientId = clientId,
        //        ClientSecret = clientSecret
        //    }, scopes,
        //    Environment.UserName, CancellationToken.None, new FileDataStore("MyAppsToken")).Result;
        //    //Once consent is recieved, your token will be stored locally on the AppData directory, so that next time you wont be prompted for consent.   

        //    DriveService service = new DriveService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = "MyAppName",

        //    });
        //    service.HttpClient.Timeout = TimeSpan.FromMinutes(100);
        //    //Long Operations like file uploads might timeout. 100 is just precautionary value, can be set to any reasonable value depending on what you use your service for  

        //    // team drive root https://drive.google.com/drive/folders/0AAE83zjNwK-GUk9PVA   
        //    //DesktopAlert.Show("2");

        //    var respocne = uploadFile(service, filepath, "");

        //    //DesktopAlert.Show("3");

        //    // Third parameter is empty it means it would upload to root directory, if you want to upload under a folder, pass folder's id here.
        //    //MessageBox.Show("Process completed--- Response--" + respocne);
        //    DesktopAlert.Show("تم رفع النسخة بنجاح " + "\n" + "Backuped Successfully to google drive ! ", eDesktopAlertColor.Black, eAlertPosition.TopRight);
        //    }
        //    catch 
        //    {

        //        DesktopAlert.Show("خطا #" + "\n" + "# Error ! ", eDesktopAlertColor.Black, eAlertPosition.TopRight);
        //        return ;
        //    }
        //}
        //public  static  Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service, string _uploadFile, string _parent, string _descrp = "Uploaded with .NET!")
        //{
        //    //DesktopAlert.Show("2.1");
        //    try
        //    {


        //    if (System.IO.File.Exists(_uploadFile))
        //    {
        //        Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
        //        body.Name = System.IO.Path.GetFileName(_uploadFile);
        //        body.Description = _descrp;
        //        body.MimeType = MimeMapping.GetMimeMapping(_uploadFile);// GetMimeType(_uploadFile);
        //        // body.Parents = new List<string> { _parent };// UN comment if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
        //        byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
        //        System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
        //        try
        //        {
        //            FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, MimeMapping.GetMimeMapping(_uploadFile));
        //            request.SupportsTeamDrives = true;
        //            // You can bind event handler with progress changed event and response recieved(completed event)
        //            //request.ProgressChanged += Request_ProgressChanged;
        //            //request.ResponseReceived += Request_ResponseReceived;
        //            //DesktopAlert.Show("2.2");

        //           /* await Task.Run(()=>*/   request.Upload();
        //            //DesktopAlert.Show("2.3");

        //            return request.ResponseBody;
        //        }
        //        catch (Exception e)
        //        {
        //            DesktopAlert.Show("خطا " + "\n" + "Error Backup to drive  ! ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        DesktopAlert.Show("خطا في الملف " + "\n" + "Error Backup to drive2  ! ", eDesktopAlertColor.DarkRed, eAlertPosition.TopRight);
        //        return null;
        //    }
        //    }
        //    catch (Exception)
        //    {

        //        DesktopAlert.Show("خطا في الملف #" + "\n" + "# Error Backup to drive2  ! ", eDesktopAlertColor.Black, eAlertPosition.TopRight);
        //        return null;
        //    }
        //}
        //private void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        //{
        //   MessageBox.Show( obj.Status + " " + obj.BytesSent);
        //}

        //private void Request_ResponseReceived(Google.Apis.Drive.v3.Data.File obj)
        //{
        //    if (obj != null)
        //    {
        //        MessageBox.Show("File was uploaded sucessfully--" + obj.Id);
        //    }
        //}
        //public static string[] Scopes = { DriveService.Scope.Drive };

        //public static DriveService GetService()
        //{
        //    //get Credentials from client_secret.json file 
        //    UserCredential credential;
        //    using (var stream = new FileStream(Application.StartupPath + @"\client_secret.json", FileMode.Open, FileAccess.Read))
        //    {
        //        String FolderPath = Application.StartupPath;
        //        String FilePath = Path.Combine(FolderPath, "DriveServiceCredentials.json");

        //        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //            GoogleClientSecrets.Load(stream).Secrets,
        //            Scopes,
        //            "user",
        //            CancellationToken.None,
        //            new FileDataStore(FilePath, true)).Result;
        //    }

        //    //create Drive API service.
        //    DriveService service = new DriveService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = "GoogleDriveRestAPI-v3",
        //    });
        //    return service;
        //}
        //public static void FileUpload(FileInfo file)
        //{
        //    if (file != null) /*&& file.ContentLength > 0)*/
        //    {
        //        DriveService service = GetService();

        //        string path = Path.Combine(HttpContext.Current.Server.MapPath("~/GoogleDriveFiles"),




        //        //Path.GetFileName(file.FileName));
        //        Path.GetFileName(file.FullName));
        //        //file.SaveAs(path);

        //        var FileMetaData = new Google.Apis.Drive.v3.Data.File();
        //        FileMetaData.Name = Path.GetFileName(file.FullName);
        //        FileMetaData.MimeType = MimeMapping.GetMimeMapping(path);

        //        FilesResource.CreateMediaUpload request;

        //        using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
        //        {
        //            request = service.Files.Create(FileMetaData, stream, FileMetaData.MimeType);
        //            request.Fields = "id";
        //            request.Upload();
        //        }
        //    }
        //}


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

            using (StreamReader r = new StreamReader(@".\updater.json"))
            {
                var json = r.ReadToEnd();
                myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                if (items.Vno > Properties.Settings.Default.VersonNo)
                {
                    Properties.Settings.Default.VersonNo = items.Vno;
                    Properties.Settings.Default.Save();


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
        public async static Task<bool> dooo()
        {
            //try
            //{

            await Task.Run(() => DownloadGoogleDriveFileFromURLToPath("https://drive.google.com/file/d/1eCuo0YmO8-2zg9-MToggC406g9DH-54-/view?usp=share_link", Application.StartupPath + @"\updater.json"));


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
            try
            {
                using (StreamReader r = new StreamReader(@".\updater.json"))
                {
                    var json = await r.ReadToEndAsync();
                    myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                    if (items.Vno > Properties.Settings.Default.VersonNo)
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


            }
            catch
            {
                if (File.Exists(@".\updater.json"))
                {
                    File.Delete(@".\updater.json");
                }
                return false;

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

                return;
            }

            using (StreamReader r = new StreamReader(@".\updater.json"))
            {
                var json = r.ReadToEnd();
                myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                if (items.Vno > Properties.Settings.Default.VersonNo)
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
                    return;



                }
            }


        }


        public static myserverCon GetServerCon()
        {
            if (!File.Exists(@".\serverCon.json"))
            {

                return null;
            }
            using (StreamReader r = new StreamReader(@".\serverCon.json"))
            {
                var json = r.ReadToEnd();
                myserverCon items = JsonConvert.DeserializeObject<myserverCon>(json);

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
        public static void SetServerCon(myserverCon items)
        {
            if (File.Exists(@".\serverCon.json"))
            {
                File.Delete(@".\serverCon.json");
            }
            if (items != null)
            {
                File.WriteAllText(@".\serverCon.json", JsonConvert.SerializeObject(items));

            }


        }



        public static void SetLog(string errDetails, string fname)
        {


            var log = new myLog() { ErrorDetails = errDetails };
            if (log != null)
            {
                File.WriteAllText(@".\" + fname + "_Log.json", JsonConvert.SerializeObject(log));

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
                        return downloadedFile;

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