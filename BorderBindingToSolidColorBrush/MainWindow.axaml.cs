using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace BorderBindingToSolidColorBrush;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e) {
        var solidColorBrush = App.Current.Resources.First().Value as SolidColorBrush;
        var random = new Random();
        solidColorBrush.Color = Color.FromRgb((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256));
    }
}