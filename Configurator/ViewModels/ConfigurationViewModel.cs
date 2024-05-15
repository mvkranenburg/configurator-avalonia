namespace Configurator.ViewModels;

public class ConfigurationViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityAlignment Alignment => ActivityAlignment.Top;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-sliders";
}