using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace RateChecker {
	/// <summary>
	/// Calcer.xaml の相互作用ロジック
	/// </summary>
	public partial class Calcer : UserControl {
		private bool isBe = false;
		private CalcValue cv;

		public Calcer(BbValues values) {
			InitializeComponent();

			cv = new CalcValue(values);
			this.DataContext = cv;
		}

		private void TextBox_OnKeyDown(object sender, KeyEventArgs e) {
			if (e.Key != Key.Return) return;
			if (sender == null) return;
			var tb = sender as TextBox;

			if (isBe) return;
			isBe = true;
			switch (tb.Name) {
				case "TbJpy":
					cv.JpyTrans();
					break;
				case "TbBtc":
					cv.BtcTrans();
					break;
				case "TbLtc":
					cv.LtcTrans();
					break;
				case "TbEth":
					cv.EthTrans();
					break;
				case "TbMoj":
					cv.MonaTrans();
					break;
				case "TbMot":
					cv.MonatTrans();
					break;
				case "TbMoc":
					cv.MonacTrans();
					break;
				case "TbXrp":
					cv.XrpTrans();
					break;
				case "TbBcj":
					cv.BccjTrans();
					break;
				case "TbBct":
					cv.BcctTrans();
					break;
			}
			isBe = false;
		}
	}

	public class CalcValue : NotifyChanged {
		private BbValues bv;
		public CalcValue(BbValues values) {
			bv = values;
		}

		private string _Jpy = "0";
		public string Jpy {
			get { return _Jpy; }
			set {
				if (_Jpy != value) {
					_Jpy = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Btc = "0";
		public string Btc {
			get { return _Btc; }
			set {
				if (_Btc != value) {
					_Btc = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Ltc = "0";
		public string Ltc {
			get { return _Ltc; }
			set {
				if (_Ltc != value) {
					_Ltc = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Xrp = "0";
		public string Xrp {
			get { return _Xrp; }
			set {
				if (_Xrp != value) {
					_Xrp = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Eth = "0";
		public string Eth {
			get { return _Eth; }
			set {
				if (_Eth != value) {
					_Eth = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Mona = "0";
		public string Mona {
			get { return _Mona; }
			set {
				if (_Mona != value) {
					_Mona = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Monat = "0";
		public string Monat {
			get { return _Monat; }
			set {
				if (_Monat != value) {
					_Monat = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Monac = "0";
		public string Monac {
			get { return _Monac; }
			set {
				if (_Monac != value) {
					_Monac = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Bccj = "0";
		public string Bccj {
			get { return _Bccj; }
			set {
				if (_Bccj != value) {
					_Bccj = value;
					OnPropertyChanged();
				}
			}
		}

		private string _Bcct = "0";
		public string Bcct {
			get { return _Bcct; }
			set {
				if (_Bcct != value) {
					_Bcct = value;
					OnPropertyChanged();
				}
			}
		}

		private double JpyToBtc(double jpy) {
			try {
				return jpy / bv.JpybtcVal;
			} catch {
				return double.NaN;
			}
		}

		private double JpyToXrp(double jpy) {
			try {
				return jpy / bv.JpyxrpVal;
			} catch {
				return double.NaN;
			}
		}

		private double JpyToMona(double jpy) {
			try {
				return jpy / bv.JpymonaVal;
			} catch {
				return double.NaN;
			}
		}

		private double JpyToBcc(double jpy) {
			try {
				return jpy / bv.JpybccVal;
			} catch {
				return double.NaN;
			}
		}

		private double XrpToJpy(double xrp) {
			try {
				return xrp * bv.JpyxrpVal;
			} catch {
				return double.NaN;
			}
		}

		private double MonaToJpy(double mona) {
			try {
				return mona * bv.JpymonaVal;
			} catch {
				return double.NaN;
			}
		}

		private double BccToJpy(double bcc) {
			try {
				return bcc * bv.JpybccVal;
			} catch {
				return double.NaN;
			}
		}

		private double BtcToJpy(double btc) {
			try {
				return btc * bv.JpybtcVal;
			} catch {
				return double.NaN;
			}
		}

		private double BtcToLtc(double btc) {
			try {
				return btc / bv.BtcltcVal;
			} catch {
				return double.NaN;
			}
		}

		private double BtcToEth(double btc) {
			try {
				return btc / bv.BtcethVal;
			} catch {
				return double.NaN;
			}
		}

		private double BtcToMona(double btc) {
			try {
				return btc / bv.BtcmonaVal;
			} catch {
				return double.NaN;
			}
		}

		private double BtcToBcc(double btc) {
			try	{
				return btc / bv.BtcbccVal;
			} catch {
				return double.NaN;
			}
		}

		private double LtcToBtc(double ltc) {
			try {
				return ltc * bv.BtcltcVal;
			} catch {
				return double.NaN;
			}
		}

		private double EthToBtc(double eth) {
			try {
				return eth * bv.BtcethVal;
			} catch {
				return double.NaN;
			}
		}

		private double MonaToBtc(double mona) {
			try {
				return mona * bv.BtcmonaVal;
			} catch {
				return double.NaN;
			}
		}

		private double BccToBtc(double bcc) {
			try {
				return bcc * bv.BtcbccVal;
			} catch {
				return double.NaN;
			}
		}

		private void FromBtc(double btc, Coins include) {
			double jpy = BtcToJpy(btc);
			if (include.HasFlag(Coins.JPY)) {
				Jpy = jpy.ToString("F8");
			}

			if (include.HasFlag(Coins.LTC)) {
				Ltc = BtcToLtc(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.ETH)) {
				Eth = BtcToEth(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.XRP)) {
				Xrp = JpyToXrp(jpy).ToString("F8");
			}

			if (include.HasFlag(Coins.MONA)) {
				Mona = JpyToMona(jpy).ToString("F8");
			}

			if (include.HasFlag(Coins.MONAT)) {
				Monat = BtcToMona(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.MONAC)) {
				Monac = BtcToMona(BccToBtc(btc)).ToString("F8");
			}

			if (include.HasFlag(Coins.BCCJ)) {
				Bccj = JpyToBcc(jpy).ToString("F8");
			}

			if (include.HasFlag(Coins.BCCT)) {
				Bcct = BtcToBcc(btc).ToString("F8");
			}
		}

		private void FromJpy(double jpy, Coins include) {
			double btc = JpyToBtc(jpy);
			if (include.HasFlag(Coins.BTC)) {
				Btc = btc.ToString("F8");
			}

			if (include.HasFlag(Coins.LTC)) {
				Ltc = BtcToLtc(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.ETH)) {
				Eth = BtcToEth(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.XRP)) {
				Xrp = JpyToXrp(jpy).ToString("F8");
			}

			if (include.HasFlag(Coins.MONA)) {
				Mona = JpyToMona(jpy).ToString("F8");
			}

			if (include.HasFlag(Coins.MONAT)) {
				Monat = BtcToMona(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.MONAC)) {
				Monac = BtcToMona(BccToBtc(JpyToBcc(jpy))).ToString("F8");
			}

			if (include.HasFlag(Coins.BCCJ)) {
				Bccj = JpyToBcc(btc).ToString("F8");
			}

			if (include.HasFlag(Coins.BCCT)) {
				Bcct = BtcToBcc(btc).ToString("F8");
			}
		}

		public void JpyTrans() {
			double jpy;

			try {
				jpy = double.Parse(Jpy);
			} catch {
				jpy = double.NaN;
			}
			
			FromJpy(jpy, Coins.ALL);
		}

		public void BtcTrans() {
			double btc;

			try {
				btc = double.Parse(Btc);
			} catch {
				btc = double.NaN;
			}
			
			FromBtc(btc, Coins.ALL);
		}

		public void LtcTrans() {
			double ltc, btc;

			try {
				ltc = double.Parse(Ltc);
			} catch {
				ltc = double.NaN;
			}

			btc = LtcToBtc(ltc);
			Btc = btc.ToString("F8");
			FromBtc(btc, Coins.ALL & ~Coins.LTC);
		}

		public void EthTrans() {
			double eth, btc;

			try {
				eth = double.Parse(Eth);
			} catch {
				eth = double.NaN;
			}

			btc = EthToBtc(eth);
			Btc = btc.ToString("F8");
			FromBtc(btc, Coins.ALL & ~Coins.ETH);
		}

		public void XrpTrans() {
			double xrp, jpy;

			try {
				xrp = double.Parse(Xrp);
			} catch {
				xrp = double.NaN;
			}

			jpy = XrpToJpy(xrp);
			Jpy = jpy.ToString("F8");
			FromJpy(jpy, Coins.ALL & ~Coins.XRP);
		}

		public void MonaTrans() {
			double mona, jpy;

			try {
				mona = double.Parse(Mona);
			} catch {
				mona = double.NaN;
			}

			jpy = MonaToJpy(mona);
			Jpy = jpy.ToString("F8");
			FromJpy(jpy, Coins.ALL & ~Coins.MONA);
		}

		public void MonatTrans() {
			double mona, btc;

			try {
				mona = double.Parse(Monat);
			} catch {
				mona = double.NaN;
			}

			btc = MonaToBtc(mona);
			Btc = btc.ToString("F8");
			FromBtc(btc, Coins.ALL & ~Coins.MONAT);
		}

		public void MonacTrans() {
			double mona, btc;

			try {
				mona = double.Parse(Monac);
			} catch {
				mona = double.NaN;
			}

			btc = MonaToBtc(mona);
			Btc = btc.ToString("F8");
			FromBtc(btc, Coins.ALL & ~Coins.MONAC);
		}

		public void BccjTrans() {
			double bcc, jpy;

			try {
				bcc = double.Parse(Bccj);
			} catch {
				bcc = double.NaN;
			}

			jpy = BccToJpy(bcc);
			Jpy = jpy.ToString("F8");
			FromJpy(jpy, Coins.ALL & ~Coins.BCCJ);
		}

		public void BcctTrans() {
			double bcc, btc;

			try {
				bcc = double.Parse(Bcct);
			} catch {
				bcc = double.NaN;
			}

			btc = BccToBtc(bcc);
			Btc = btc.ToString("F8");
			FromBtc(btc, Coins.ALL & ~Coins.BCCT);
		}
	}

	[Flags]
	public enum Coins {
		NONE = 0,
		JPY = 1, BTC = 2, LTC = 4, ETH = 8, XRP = 16,
		MONA = 32, BCCJ = 64, MONAT = 128, MONAC = 256,
		BCCT = 512,
		ALL = 1023,
	}
}
