using Foundation;
using HardNaviCarShop.iOS;  
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOsDbPath))]
namespace HardNaviCarShop.iOS
{
    public class IOsDbPath : IDBPath
    {
        public string GetDBPath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
                filename);
        }
    }
}