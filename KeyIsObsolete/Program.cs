using Avalonia;
using System;
using Avalonia.Styling;

namespace KeyIsObsolete;

class Program {
    public static ThemeVariant Test1 { get; } = ThemeVariant.Dark;
    public static ThemeVariant Test2 { get; } = ThemeVariant.Light;
    
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}