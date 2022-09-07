using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sidebar_Navigation
{
   
    public class Navbutton : ListBoxItem
    {
         static Navbutton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Navbutton), new FrameworkPropertyMetadata(typeof(Navbutton)));
        }

        public static readonly DependencyProperty NavLinkProperty = DependencyProperty.Register("NavLink", typeof(Uri), typeof(Navbutton), new PropertyMetadata(null));
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(Geometry), typeof(Navbutton), new PropertyMetadata(null));
      
      /*********** Dependency Property For the Name Property ***********/
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Navbutton), new PropertyMetadata(null));

        public string Name
        {
            get { return (Uri)GetValue(NameProperty); }
            set { SetValue(Nameroperty, value); }
        }        


        public Uri NavLink
        {
            get { return (Uri)GetValue(NavLinkProperty); }
            set { SetValue(NavLinkProperty, value); }
        }        


        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
    }

}
