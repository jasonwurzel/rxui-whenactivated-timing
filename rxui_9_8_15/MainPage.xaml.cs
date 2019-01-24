using Windows.UI.Xaml.Controls;

namespace rxui_9_8_15
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

			TheViewHost.ViewModel = new SubViewModel();
        }
    }
}
