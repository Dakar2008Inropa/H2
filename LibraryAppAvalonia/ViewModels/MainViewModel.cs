using CommunityToolkit.Mvvm.ComponentModel;

namespace LibraryAppAvalonia.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isPaneOpen = true;
}