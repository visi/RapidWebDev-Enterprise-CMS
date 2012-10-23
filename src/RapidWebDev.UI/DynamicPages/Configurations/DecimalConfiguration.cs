﻿/****************************************************************************************************
	Copyright (C) 2010 RapidWebDev Organization (http://rapidwebdev.org)
	Author: Eunge, Legal Name: Jian Liu, Email: eunge.liu@RapidWebDev.org

	The GNU Library General Public License (LGPL) used in RapidWebDev is 
	intended to guarantee your freedom to share and change free software - to 
	make sure the software is free for all its users.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU Library General Public License (LGPL) for more details.

	You should have received a copy of the GNU Library General Public License (LGPL)
	along with this program.  
	If not, see http://www.rapidwebdev.org/Content/ByUniqueKey/OpenSourceLicense
 ****************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web.UI.WebControls;
using RapidWebDev.Common;

namespace RapidWebDev.UI.DynamicPages.Configurations
{
	/// <summary>
	/// Configuration class maps to DecimalConfiguration element.
	/// </summary>
	public sealed class DecimalConfiguration : BaseControlConfiguration
	{
		/// <summary>
		/// False to prevent entering a negative sign (defaults to true)
		/// </summary>
		public bool AllowNegative { get; set; }

		/// <summary>
		/// The maximum precision to display after the decimal separator (defaults to 2)
		/// </summary>
		public int DecimalPrecision { get; set; }

		/// <summary>
		/// Gets control type for the configuration.
		/// </summary>
		public override ControlConfigurationTypes ControlType { get { return ControlConfigurationTypes.Decimal; } }

		/// <summary>
		/// Empty Constructor
		/// </summary>
		public DecimalConfiguration()
		{
			this.AllowNegative = true;
			this.DecimalPrecision = 2;
		}

		/// <summary>
		/// Construct DecimalConfiguration instance from xml element.
		/// </summary>
		/// <param name="baseControlConfigurationElement"></param>
		/// <param name="xmlParser"></param>
		public DecimalConfiguration(XmlElement baseControlConfigurationElement, XmlParser xmlParser) : base(baseControlConfigurationElement, xmlParser)
		{
			XmlElement numbericElement = baseControlConfigurationElement;
			this.AllowNegative = xmlParser.ParseBoolean(numbericElement, "@AllowNegative", true);
			this.DecimalPrecision = xmlParser.ParseInt(numbericElement, "@DecimalPrecision", 2);
		}
	}
}

