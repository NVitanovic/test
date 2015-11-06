using UnityEngine;
using System.Collections;
using Andronity.Server;

public class TestConnect : MonoBehaviour
{
    public void Start()
    {
        /*
        ConnectServer.FileDownload("http://ctx.me/img/ctx.png", "ctx.png");
        ConnectServer.FileDownload("https://ctx.me/img/ctx.png", "ctxSSS.png");
        ConnectServer.FileDownload("http://cdimage.debian.org/debian-cd/8.2.0/amd64/iso-cd/debian-8.2.0-amd64-netinst.iso", "debiannet.iso");
        ConnectServer.FileDownload("http://cdimage.debian.org/debian-cd/8.2.0/amd64/iso-cd/debian-8.2.0-amd64-netinst.iso", "debianNET2.iso");*/

        DownloadManager m = new DownloadManager();
        m.FileDownload("http://ctx.me/img/ctx.png", "ctx.png");
        m.FileDownload("http://www.gettyimages.com/gi-resources/images/frontdoor/creative/Embed/hero_travel_482206371.jpg", "1.jpg");
        m.FileDownload("http://www.planwallpaper.com/static/images/Winter-Tiger-Wild-Cat-Images.jpg", "2.jpg");
        m.FileDownload("http://risehighershinebrighter.files.wordpress.com/2014/11/magic-of-blue-universe-images.jpg", "3.jpg"); //zeza server
        m.FileDownload("http://www.planwallpaper.com/static/images/background-gmail-google-images_FG2XwaO.jpg", "4.jpg");
        m.FileDownload("http://cdn.spacetelescope.org/archives/images/large/heic1509a.jpg", "5.jpg");
        m.FileDownload("http://www.indiotomato.com/images/icethumbs/1175x465/75/images/Sliders1/CAMPO2.png", "6.jpg");
    }
}


