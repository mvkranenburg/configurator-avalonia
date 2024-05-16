namespace Configurator.ViewModels;

public class NetworkExplorerViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-network-wired";

    /// <inheritdoc/>
    public string Description => "Network explorer";
}