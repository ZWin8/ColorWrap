using NATControl;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Windows.UI;
using Windows.UI.Xaml.Controls;

namespace ColorWrap
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            IEnumerable<PropertyInfo> propertyinfos = typeof(Colors).GetTypeInfo().DeclaredProperties;
            foreach (PropertyInfo pInfo in propertyinfos)
            {
                ColorItemCtrl ctrl = new ColorItemCtrl(pInfo.Name, (Color)pInfo.GetValue(null));
                wrapGrid.Children.Add(ctrl);
            }
        }
    }
}
