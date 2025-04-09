using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TransitionsBug;

public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        Task.Run(async () => {
            while (true) {
                TestVM.Progress += 4;
                await Task.Delay(200);

                if (TestVM.Progress >= 100) {
                    TestVM.Progress = 0;
                }
            }
        });
    }
    public MyVM TestVM { get; } = new MyVM();
}

public partial class MyVM : ViewModelBase {
    private int _progress = 0;
    public int Progress {
        get => _progress;
        set {
            _progress = value;
            OnPropertyChanged();
        }
    }
}

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}