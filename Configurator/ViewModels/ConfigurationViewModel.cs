namespace Configurator.ViewModels;

public class ConfigurationViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-sliders";

    /// <inheritdoc/>
    public string Description => "System configuration";
}