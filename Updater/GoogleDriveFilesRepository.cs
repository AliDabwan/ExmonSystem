
using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Updater
{
   public class GoogleDriveFilesRepository
    {
        
        //Download file from Google Drive by fileId.

        // file save to server path
        private static void SaveStream(MemoryStream stream, string FilePath)
        {
            using (System.IO.FileStream file = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                stream.WriteTo(file);
            }
        }

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
                    MessageBox.Show(url);
                    MessageBox.Show(path);
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
                return null;
            }
        }
        public static void Seriall()
        {
            var mupdate = new myUpdate()
            {
                UriPath = "sss2",
                Vno = 1001
            };
            var json = JsonConvert.SerializeObject(mupdate);


            File.WriteAllText(@".\updater.json", json);
            //var ss = JsonConvert.DeserializeObject(json);
            //var x = (List<Rolls>)ss;

        }
        public static void ReadSeriall()
        {
            using (StreamReader r = new StreamReader(@".\updater.json"))
            {
                var json = r.ReadToEnd();
                myUpdate items = JsonConvert.DeserializeObject<myUpdate>(json);
                MessageBox.Show(items.UriPath);
                MessageBox.Show(items.Vno.ToString());

            }


            //var ss = JsonConvert.DeserializeObject(json);
            //var x = (List<Rolls>)ss;

        }
        public static void dooo()
        {
            DownloadGoogleDriveFileFromURLToPath("https://drive.google.com/file/d/1eCuo0YmO8-2zg9-MToggC406g9DH-54-/view?usp=share_link", Application.StartupPath +@"\updater.zip");
        }
        private static FileInfo DownloadGoogleDriveFileFromURLToPath(string url, string path)
        {
            // You can comment the statement below if the provided url is guaranteed to be in the following format:
            // https://drive.google.com/uc?id=FILEID&export=download
            url = GetGoogleDriveDownloadLinkFromUrl(url);
         
            
            using (CookieAwareWebClient webClient = new CookieAwareWebClient())
            {
                FileInfo downloadedFile;

                // Sometimes Drive returns an NID cookie instead of a download_warning cookie at first attempt,
                // but works in the second attempt
                for (int i = 0; i < 2; i++)
                {
                    downloadedFile = DownloadFileFromURLToPath(url, path, webClient);
                    MessageBox.Show("name: " + downloadedFile.Name);
                    MessageBox.Show("Fullname: " + downloadedFile.FullName);
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