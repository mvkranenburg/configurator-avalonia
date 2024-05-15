namespace Configurator.ViewModels;

public class NetworkExplorerViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityAlignment Alignment => ActivityAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-network-wired";
}