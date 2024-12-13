using System.Windows;
using System.Windows.Controls;

namespace WpfExplore.Support.UI.Units
{
    public class DarkScreollViewer : ScrollViewer
    {
        static DarkScreollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkScreollViewer), new FrameworkPropertyMetadata(typeof(DarkScreollViewer)));
        }
    }
}
