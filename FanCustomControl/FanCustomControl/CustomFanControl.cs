using System;
using System.Windows;
using System.Windows.Controls;

namespace FanCustomControl;

public class CustomFanControl : Control
{
    public bool FanOn
    {
        get { return (bool)GetValue(FanOnProperty); }
        set { SetValue(FanOnProperty, value); }
    }

    public static readonly DependencyProperty FanOnProperty = DependencyProperty.Register("FanOn", typeof(bool), typeof(CustomFanControl), new PropertyMetadata(false));

    static CustomFanControl()
    {

        DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomFanControl), new FrameworkPropertyMetadata(typeof(CustomFanControl)));
    }
}