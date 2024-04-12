using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BindingsRefactorIssue;

public class ColoredBindingExtension : MarkupExtension
{
    public string BrushName { get; set; }
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return Application.Current!.Resources.GetResourceObservable(BrushName).ToBinding();
    }
}