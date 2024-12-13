using System.Windows;
using Jamesnet.Wpf.Controls;

namespace WpfExplore.Support.UI.Units
{
    public class DarkWindow : JamesWindow
    {
        static DarkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow), new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }
    }
}
