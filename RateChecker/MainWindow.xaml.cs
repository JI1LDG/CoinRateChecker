using System.Windows;
using System.Windows.Controls;

namespace RateChecker {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		BitBankTicker bbt = new BitBankTicker();
		public MainWindow() {
			InitializeComponent();
			var tk = new Ticker(bbt.bv);
			Grid.SetRow(tk, 0);
			GdLayout.Children.Add(tk);
			var cc = new Calcer(bbt.bv);
			Grid.SetRow(cc, 2);
			GdLayout.Children.Add(cc);
			GdLayout.RowDefinitions[2].Height = new GridLength(0);
			bbt.Execute();
		}

		private void BtCalcOc_Click(object sender, RoutedEventArgs e) {
			if (GdLayout.RowDefinitions[2].Height.Value == 0) {
				GdLayout.RowDefinitions[2].Height = GridLength.Auto;
			} else {
				GdLayout.RowDefinitions[2].Height = new GridLength(0);
			}
		}
	}
}
