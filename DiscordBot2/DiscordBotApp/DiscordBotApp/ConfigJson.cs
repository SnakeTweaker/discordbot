using System;
using Newtonsoft.Json;
using System.Text;

namespace DiscordBotApp
{

	public struct ConfigJson
	{
			//Struct defines Token and Prefix for main Bot.cs
			[JsonProperty("token")]
			public string Token { get; private set; }
			[JsonProperty("prefix")]
			public string Prefix { get; private set; }

	}
}
