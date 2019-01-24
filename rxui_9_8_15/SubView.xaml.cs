using Windows.UI.Xaml;
using ReactiveUI;

namespace rxui_9_8_15
{
	public class SubViewBase : ReactiveUserControl<SubViewModel>
	{

	}

	public sealed partial class SubView
	{
		public SubView()
		{
			this.InitializeComponent();

			this.WhenActivated(disposable =>
			{
				TheViewModelTextBlock.Text = ViewModel == null ? "ViewModel is null" : "ViewModel is present";
				TheDummyPropertyTextBlock.Text = DummyProperty == null ? "DummyProperty is null" : $"DummyProperty is {DummyProperty}";
			});
		}

		public static readonly DependencyProperty DummyPropertyProperty = DependencyProperty.Register(
			"DummyProperty", typeof(string), typeof(SubView), new PropertyMetadata(default(string)));

		public string DummyProperty
		{
			get { return (string) GetValue(DummyPropertyProperty); }
			set { SetValue(DummyPropertyProperty, value); }
		}
	}

	public class SubViewModel : ReactiveObject
	{

	}
}
