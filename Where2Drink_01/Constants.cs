using System;
using System.Collections.Generic;
using System.Text;

namespace Where2Drink_01
{
   public static class Constants
    {
		public static string AppName = "Where2Drink";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string iOSClientId = "<insert IOS client ID here>";
		public static string AndroidClientId = "733817685387-vn2317l64s847slm8ghum1f8kjjmi9jo.apps.googleusercontent.com";

		// These values do not need changing
		public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
		public static string iOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
		public static string AndroidRedirectUrl = "733817685387-vn2317l64s847slm8ghum1f8kjjmi9jo.apps.googleusercontent.com:/oauth2redirect";
	}
}
