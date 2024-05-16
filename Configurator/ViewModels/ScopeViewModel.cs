using CommunityToolkit.Mvvm.ComponentModel;

namespace Configurator.ViewModels;

public partial class ScopeViewModel : ViewModelBase, IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-chart-line";

    /// <inheritdoc/>
    public string Description => "Scope";

    /// <inheritdoc/>
    public string SideBar => Description;

    /// <inheritdoc/>
    [ObservableProperty]
    public bool _isSelected;
}