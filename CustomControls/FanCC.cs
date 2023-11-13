using System.Windows;
using System.Windows.Controls;

namespace CustomControls;

public class FanCC : Control
{
    public bool FanOn
    {
        get { return (bool)GetValue(FanOnProperty); }
        set { SetValue(FanOnProperty, value); }
    }

    public static readonly DependencyProperty FanOnProperty =
      DependencyProperty.Register("FanOn", typeof(bool), typeof(FanCC), new PropertyMetadata(false));

    static FanCC()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(FanCC), new FrameworkPropertyMetadata(typeof(FanCC)));
    }
}