using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageUsingCsharp2
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new Page1() { Title = "Page 1", Icon = "abc.png" });
            Children.Add(new Page2() { Title = "Page 2", Icon = "def.png" });
        }
    }
}
