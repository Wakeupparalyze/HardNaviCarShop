using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HardNaviCarShop
{
    public partial class ShellPage : Shell
    {
        public ShellPage()
        {
            InitializeComponent();
            Routing.RegisterRoute("Cars", typeof(PageCars));
            Routing.RegisterRoute("Types", typeof(PageTypes));
        }
    }
}
