using System;
using Newtonsoft.Json;
using System.Text;

namespace DiscordBotApp
{

	public class ConfigJson
	{
		//Struct defines Token and Prefix for main Bot.cs

		public struct ConfigJson
		{
			[JsonProperty("token")]
			public string Token { get; private set; }
			[JsonProperty("prefix")]
			public string Prefix { get; private set }

		}
	}
}
