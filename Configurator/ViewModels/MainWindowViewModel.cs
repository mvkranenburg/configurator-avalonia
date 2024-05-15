using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
    public IEnumerable<IActivityViewModel> ActivityBarItemsTop => ActivityBarItems.Where(x => x.Alignment == ActivityAlignment.Top);

    /// <summary>
    /// Filtered bottom aligned activity view models 
    /// </summary>
    public IEnumerable<IActivityViewModel> ActivityBarItemsBottom => ActivityBarItems.Where(x => x.Alignment == ActivityAlignment.Bottom);

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
