using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace MercuryTour.Base
{
	public class CSettings
	{

	public static string UserName
		{
			get
			{
				return ConfigurationManager.AppSettings["Username"];
			}
		}

		public static string Password
		{
			get
			{
				return ConfigurationManager.AppSettings["Password"];
			}
		}


	}
}
