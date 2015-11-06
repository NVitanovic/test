using UnityEngine;
using System.Collections;
using System.Net;
using System;
using System.ComponentModel;
using System.Collections.Generic;
namespace Andronity.Server
{
    public class CurrentDownload
    {
        public int id;
        bool completed;
        string URL;
        bool primaryClient;
        public CurrentDownload(int id, string URL)
        {
            this.id = id;
            this.URL = URL;
            completed = false;
        }
        public bool isCompleted() { return completed; }
        public void setCompleted() { completed = true; }
        public override string ToString()
        {
            return String.Format("{0}# - {1} - Completed:{2} - Primary:{3}", id.ToString(), URL, completed.ToString(), primaryClient.ToString());
        }
    }
    public class DownloadManager
    {
        static int id = 0;
        // private WebClient clientPrimary = new WebClient();
        private WebClient clientSecondary = new WebClient();    //DL dva fajla odjednom
        private List<CurrentDownload> lista = new List<CurrentDownload>();
        public void FileDownload(string fileURL, string localFilePath)
        {
            id++;
            
            using (WebClient clientPrimary = new WebClient())
            {
                clientPrimary.DownloadFileAsync(new Uri(fileURL), localFilePath);
                lista.Add(new CurrentDownload(id, fileURL));
                clientPrimary.DownloadFileCompleted += new AsyncCompletedEventHandler((sender, e) => FileDownloadComeplete(sender, e, lista[lista.Count - 1]));
                clientPrimary.DownloadProgressChanged += new DownloadProgressChangedEventHandler((sender, e) => FileDownloadProgress(sender, e, lista[lista.Count - 1]));
            }
        }
        private static void FileDownloadComeplete(object sender, System.ComponentModel.AsyncCompletedEventArgs e, CurrentDownload d)
        {
            Debug.Log(d.ToString());
            d.setCompleted();
        }
        private static void FileDownloadProgress(object sender, DownloadProgressChangedEventArgs e, CurrentDownload d)
        {
            // Displays the operation identifier, and the transfer progress.
            Debug.Log(string.Format("{0}    downloaded {1} of {2} bytes. {3} % complete...",
                              d.id,
                              e.BytesReceived,
                              e.TotalBytesToReceive,
                              e.ProgressPercentage));
        }

        
    }

}