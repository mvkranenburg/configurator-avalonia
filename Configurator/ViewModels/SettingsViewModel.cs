namespace Configurator.ViewModels;

public class SettingsViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityAlignment Alignment => ActivityAlignment.Bottom;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-gear";
}