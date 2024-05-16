using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Configurator.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    /// <summary>
    /// Activity view models
    /// </summary>
    public ObservableCollection<IActivityViewModel> ActivityBarItems { get; set; }

    /// <summary>
    /// Filtered top aligned activity view models 
    /// </summary>
    public IEnumerable<IActivityViewModel> ActivityBarItemsTop => ActivityBarItems.Where(x => x.Alignment == ActivityBarAlignment.Top);

    /// <summary>
    /// Filtered bottom aligned activity view models 
    /// </summary>
    public IEnumerable<IActivityViewModel> ActivityBarItemsBottom => ActivityBarItems.Where(x => x.Alignment == ActivityBarAlignment.Bottom);

    /// <summary>
    /// Activity view model of the selected activity in the ActivityBar  
    /// </summary>
    [ObservableProperty]
    private IActivityViewModel? _selectedActivity = null;

    /// <summary>
    /// Reset IsSelected property of the view models of th deselected activity in the ActivityBar
    /// </summary>
    /// <param name="oldValue">Previous selected activity</param>
    /// <param name="newValue">Current selected activity</param>
    partial void OnSelectedActivityChanged(IActivityViewModel? oldValue, IActivityViewModel? newValue)
    {
        if (oldValue != null)
            oldValue.IsSelected = false;
    }

    [RelayCommand]
    private void SelectActivity(IActivityViewModel activity)
    {
        SelectedActivity = activity.IsSelected ? activity : null;
    }

    public MainWindowViewModel()
    {
        ActivityBarItems =
        [
            new NetworkExplorerViewModel(),
            new ConfigurationViewModel(),
            new ScopeViewModel(),
            new SettingsViewModel()
        ];
    }
}
