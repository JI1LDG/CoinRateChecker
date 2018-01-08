using System.Windows.Controls;

namespace RateChecker {
	/// <summary>
	/// Ticker.xaml の相互作用ロジック
	/// </summary>
	public partial class Ticker : UserControl {
		public Ticker(BbValues values) {
			InitializeComponent();

			this.DataContext = values;
		}
	}
}
