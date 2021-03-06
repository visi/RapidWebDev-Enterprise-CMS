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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Xml;
using RapidWebDev.Common;

namespace RapidWebDev.UI.DynamicPages.Configurations
{
	/// <summary>
	/// Configuration class maps to ComboBoxItemConfiguration element.
	/// </summary>
	public class ComboBoxItemConfiguration
	{
		private string value;
		private string text;

		/// <summary>
		/// Gets combobox item display text.
		/// </summary>
		public string Text {
			get { return WebUtility.ReplaceVariables(this.text); }
			set { this.text = value; }
		}

		/// <summary>
		/// Gets combobox item value.
		/// </summary>
		public string Value
		{
			get { return this.value ?? this.Text; }
			set { this.value = value; }
		}

		/// <summary>
		/// True indicates the combobox item is checked as default. The default value is false.
		/// </summary>
		public bool Checked { get; set; }

		/// <summary>
		/// Construct ComboBoxItemConfiguration instance.
		/// </summary>
		public ComboBoxItemConfiguration()
		{
		}

		/// <summary>
		/// Construct ComboBoxItemConfiguration instance from xml element.
		/// </summary>
		/// <param name="comboBoxItemConfigurationElement"></param>
		/// <param name="xmlParser"></param>
		public ComboBoxItemConfiguration(XmlElement comboBoxItemConfigurationElement, XmlParser xmlParser)
		{
			this.Text = xmlParser.ParseString(comboBoxItemConfigurationElement, "@Text");
			this.Value = xmlParser.ParseString(comboBoxItemConfigurationElement, "@Value");
			this.Checked = xmlParser.ParseBoolean(comboBoxItemConfigurationElement, "@Checked", false);
		}
	}
}

