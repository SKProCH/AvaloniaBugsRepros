using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace AttachedPropertyBindingRepro; 

public static class MyAttachedProperties {
    public static readonly AttachedProperty<string?> TestWatermarkProperty 
        = AvaloniaProperty.RegisterAttached<TextBox, string?>("TestWatermark", typeof(MyAttachedProperties));

    public static string? GetTestWatermark(TextBox element) {
        return element.GetValue(TestWatermarkProperty);
    }

    public static void SetTestWatermark(TextBox element, string? value) {
        element.SetValue(TestWatermarkProperty, value);
    }
}