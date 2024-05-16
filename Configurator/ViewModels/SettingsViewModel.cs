namespace Configurator.ViewModels;

public class SettingsViewModel : IActivityViewModel
{
    /// <inheritdoc/>
    public ActivityBarAlignment Alignment => ActivityBarAlignment.Bottom;

    /// <inheritdoc/>
    public string Icon => "fa-solid fa-gear";

    /// <inheritdoc/>
    public string Description => "Settings";
}