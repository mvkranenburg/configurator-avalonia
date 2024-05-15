namespace Configurator.ViewModels;

public class ScopeViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityAlignment Alignment => ActivityAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-chart-line";
}