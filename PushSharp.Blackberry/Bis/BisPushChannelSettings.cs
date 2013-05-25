﻿using PushSharp.Core;

namespace PushSharp.Blackberry
{
    public class BisPushChannelSettings : IPushChannelSettings
	{
		public string ApplicationId { get; set; }
		public string Password { get; set; }
        public string Boundary { get { return "ASDFaslkdfjasfaSfdasfhpoiurwqrwm"; } }

        private const string SEND_URL = "https://pushapi.eval.blackberry.com/mss/PD_pushRequest";

        public BisPushChannelSettings()
        {
            SendUrl = SEND_URL;
        }

        public BisPushChannelSettings(string applicationId, string password)
		{
			ApplicationId = applicationId;
            Password = password;
			SendUrl = SEND_URL;
		}

		public string SendUrl { get; private set; }

		public void OverrideSendUrl(string url)
		{
			SendUrl = url;
		}
	}
}
