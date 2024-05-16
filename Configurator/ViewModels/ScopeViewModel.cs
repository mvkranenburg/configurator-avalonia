namespace Configurator.ViewModels;

public class ScopeViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-chart-line";

    /// <inheritdoc/>
    public string Description => "Scope";
}