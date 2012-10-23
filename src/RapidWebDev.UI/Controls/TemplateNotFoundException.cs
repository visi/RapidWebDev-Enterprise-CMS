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

namespace RapidWebDev.UI.Controls
{
	/// <summary>
	/// Template file not found exception.
	/// </summary>
	[global::System.Serializable]
	public class TemplateNotFoundException : Exception
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public TemplateNotFoundException() { }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message"></param>
		public TemplateNotFoundException(string message) : base(message) { }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="message"></param>
		/// <param name="inner"></param>
		public TemplateNotFoundException(string message, Exception inner) : base(message, inner) { }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TemplateNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}

