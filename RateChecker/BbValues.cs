namespace RateChecker {
	public class BbValues : NotifyChanged {
		private string _Jpybtc;
		public string Jpybtc {
			get { return _Jpybtc; }
			set {
				if (value != _Jpybtc) {
					_Jpybtc = value;
					OnPropertyChanged();
				}
			}
		}

		private double _JpybtcVal;
		public double JpybtcVal {
			get { return _JpybtcVal; }
			set {
				if (_JpybtcVal != value) {
					_JpybtcVal = value;
					Jpybtc = value.ToString("F2");
				}
			}
		}

		private string _Jpyxrp;
		public string Jpyxrp {
			get { return _Jpyxrp; }
			set {
				if (_Jpyxrp != value) {
					_Jpyxrp = value;
					OnPropertyChanged();
				}
			}
		}

		private double _JpyxrpVal;
		public double JpyxrpVal {
			get { return _JpyxrpVal; }
			set {
				if (_JpyxrpVal != value) {
					_JpyxrpVal = value;
					Jpyxrp = value.ToString("F3");
				}
			}
		}

		private string _Btcltc;
		public string Btcltc {
			get { return _Btcltc; }
			set {
				if (_Btcltc != value) {
					_Btcltc = value;
					OnPropertyChanged();
				}
			}
		}

		private double _BtcltcVal;
		public double BtcltcVal {
			get { return _BtcltcVal; }
			set {
				if (_BtcltcVal != value) {
					_BtcltcVal = value;
					Btcltc = value.ToString("F8");
				}
			}
		}

		private string _Btceth;
		public string Btceth {
			get { return _Btceth; }
			set {
				if (_Btceth != value) {
					_Btceth = value;
					OnPropertyChanged();
				}
			}
		}

		private double _BtcethVal;
		public double BtcethVal {
			get { return _BtcethVal; }
			set {
				if (_BtcethVal != value) {
					_BtcethVal = value;
					Btceth = value.ToString("F8");
				}
			}
		}

		private string _Jpymona;
		public string Jpymona {
			get { return _Jpymona; }
			set {
				if (_Jpymona != value) {
					_Jpymona = value;
					OnPropertyChanged();
				}
			}
		}

		private double _JpymonaVal;
		public double JpymonaVal {
			get { return _JpymonaVal; }
			set {
				if (_JpymonaVal != value) {
					_JpymonaVal = value;
					Jpymona = value.ToString("F3");
				}
			}
		}

		private string _Btcmona;
		public string Btcmona {
			get { return _Btcmona; }
			set {
				if (_Btcmona != value) {
					_Btcmona = value;
					OnPropertyChanged();
				}
			}
		}

		private double _BtcmonaVal;
		public double BtcmonaVal {
			get { return _BtcmonaVal; }
			set {
				if (_BtcmonaVal != value) {
					_BtcmonaVal = value;
					Btcmona = value.ToString("F8");
				}
			}
		}

		private string _Jpybcc;
		public string Jpybcc {
			get { return _Jpybcc; }
			set {
				if (_Jpybcc != value) {
					_Jpybcc = value;
					OnPropertyChanged();
				}
			}
		}

		private double _JpybccVal;
		public double JpybccVal {
			get { return _JpybccVal; }
			set {
				if (_JpybccVal != value) {
					_JpybccVal = value;
					Jpybcc = value.ToString("F2");
				}
			}
		}

		private string _Btcbcc;
		public string Btcbcc {
			get { return _Btcbcc; }
			set {
				if (_Btcbcc != value) {
					_Btcbcc = value;
					OnPropertyChanged();
				}
			}
		}

		private double _BtcbccVal;
		public double BtcbccVal {
			get { return _BtcbccVal; }
			set {
				if (_BtcbccVal != value) {
					_BtcbccVal = value;
					Btcbcc = value.ToString("F8");
				}
			}
		}
	}
}
