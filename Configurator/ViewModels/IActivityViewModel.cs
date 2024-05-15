namespace Configurator.ViewModels;

public interface IActivityViewModel
{
    /// <summary>
    /// Vertical alignment of the activity
    /// </summary>
    public ActivityAlignment Alignment { get; }

    /// <summary>
    /// Icon of the activity
    /// </summary>
    public string Icon { get; }
}