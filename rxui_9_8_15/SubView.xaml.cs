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
				TheTextBlock.Text = ViewModel == null ? "ViewModel is null" : "ViewModel is present";
			});
		}
	}

	public class SubViewModel : ReactiveObject
	{

	}
}
