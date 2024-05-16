using CommunityToolkit.Mvvm.ComponentModel;

namespace Configurator.ViewModels;

public partial class SettingsViewModel : ViewModelBase, IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Bottom;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-gear";

    /// <inheritdoc/>
    public string Description => "Settings";

    /// <inheritdoc/>
    public string SideBar => Description;

    /// <inheritdoc/>
    [ObservableProperty]
    public bool _isSelected;
}