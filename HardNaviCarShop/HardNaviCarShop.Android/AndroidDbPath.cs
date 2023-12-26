﻿using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HardNaviCarShop;
using HardNaviCarShop.Droid;
using Xamarin.Forms;


[assembly: Dependency(typeof(AndroidDbPath))]
namespace HardNaviCarShop.Droid
{
    public class AndroidDbPath : IDBPath
    {
        public string GetDBPath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Personal),
                filename);
        }
    }
}