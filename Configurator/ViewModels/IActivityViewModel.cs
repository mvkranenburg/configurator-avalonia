namespace Configurator.ViewModels;

public interface IActivityViewModel
{
    /// <summary>
    /// Vertical alignment of the activity
    /// </summary>
    public ActivityBarAlignment Alignment { get; }

    /// <summary>
    /// Icon of the activity
    /// </summary>
    public string Icon { get; }

    /// <summary>
    /// Description of the activity
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// SideBar content of the activity
    /// </summary>
    public string SideBar { get; } // TODO: replace string with a control component

    /// <summary>
    /// Activity is selected
    /// </summary>
    public bool IsSelected { get; set; }
}