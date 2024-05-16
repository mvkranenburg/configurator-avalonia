using CommunityToolkit.Mvvm.ComponentModel;

namespace Configurator.ViewModels;

public partial class NetworkExplorerViewModel : ViewModelBase, IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-network-wired";

    /// <inheritdoc/>
    public string Description => "Network explorer";

    /// <inheritdoc/>
    public string SideBar => Description;

    /// <inheritdoc/>
    [ObservableProperty]
    public bool _isSelected;
}