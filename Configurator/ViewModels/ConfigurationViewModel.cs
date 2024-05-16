using CommunityToolkit.Mvvm.ComponentModel;

namespace Configurator.ViewModels;

public partial class ConfigurationViewModel : ViewModelBase, IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-sliders";

    /// <inheritdoc/>
    public string Description => "System configuration";

    /// <inheritdoc/>
    public string SideBar => Description;

    /// <inheritdoc/>
    [ObservableProperty]
    public bool _isSelected;
}