using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using PubnubApi;
using Newtonsoft.Json;

namespace RateChecker {
	public class BitBankTicker {
		public BbValues bv;
		private Pubnub pn;

		private string[] channels = new string[] { "btc_jpy", "xrp_jpy", "ltc_btc", "eth_btc",
		"mona_jpy", "mona_btc", "bcc_jpy", "bcc_btc" };

		public BitBankTicker() {
			var pnConf = new PNConfiguration();
			pnConf.SubscribeKey = "sub-c-e12e9174-dd60-11e6-806b-02ee2ddab7fe";
			pnConf.Secure = false;
			pn = new Pubnub(pnConf);

			bv = new BbValues();
		}

		~BitBankTicker() {
			pn.Unsubscribe<string>().Channels(channels.Select(x => "ticker_" + x).ToArray()).Execute();
			pn.Destroy();
		}

		public void Execute() {
			WebClient wc = new WebClient();
			foreach (var c in channels) {
				var dnstr = wc.DownloadString("https://public.bitbank.cc/" + c + "/ticker");
				Console.WriteLine(dnstr);
				SetData("ticker_" + c, dnstr);
			}

			pn.AddListener(new SubscribeCallbackExt(
				(obj, msg) => {
					if (msg != null) {
						if (msg.Channel != null) {
							string chan = msg.Channel.ToString();
							SetData(chan, msg.Message.ToString());
						}
					}
				},
				(obj, hoge) => { },
				(obj, bar) => { }));
			pn.Subscribe<string>().Channels(channels.Select(x => "ticker_" + x).ToArray()).Execute();
		}

		private void SetData(string channel, string data) {
			var json = JsonConvert.DeserializeObject<Json>(data);
			Console.WriteLine(json.data.last);
			switch (channel) {
				case "ticker_btc_jpy":
					bv.JpybtcVal = double.Parse(json.data.last);
					break;
				case "ticker_xrp_jpy":
					bv.JpyxrpVal = double.Parse(json.data.last);
					break;
				case "ticker_ltc_btc":
					bv.BtcltcVal = double.Parse(json.data.last);
					break;
				case "ticker_eth_btc":
					bv.BtcethVal = double.Parse(json.data.last);
					break;
				case "ticker_mona_jpy":
					bv.JpymonaVal = double.Parse(json.data.last);
					break;
				case "ticker_mona_btc":
					bv.BtcmonaVal = double.Parse(json.data.last);
					break;
				case "ticker_bcc_jpy":
					bv.JpybccVal = double.Parse(json.data.last);
					break;
				case "ticker_bcc_btc":
					bv.BtcbccVal = double.Parse(json.data.last);
					break;
			}
		}
	}

	public class Json {
		public Data data;
	}

	public class Data {
		public string last;
	}
}
