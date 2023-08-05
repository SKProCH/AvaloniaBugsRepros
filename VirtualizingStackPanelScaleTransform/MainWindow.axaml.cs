using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace VirtualizingStackPanelScaleTransform;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }
    private void Button_OnClick_AddNewListBox(object? sender, RoutedEventArgs e) {
        ContentPresenter1.Content = new ListBox() {
            ItemsSource = new List<object>() {
                new ListBoxItem() { Content = 1 }
            }
        };
    }
}