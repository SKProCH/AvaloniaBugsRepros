using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace BindingsRefactorIssue;

public class MyTemplatedControl : TemplatedControl
{
    public static readonly StyledProperty<IBrush> MainBrushProperty =
        AvaloniaProperty.Register<MyTemplatedControl, IBrush>("MainBrush");

    public IBrush MainBrush
    {
        get => GetValue(MainBrushProperty);
        set => SetValue(MainBrushProperty, value);
    }
}