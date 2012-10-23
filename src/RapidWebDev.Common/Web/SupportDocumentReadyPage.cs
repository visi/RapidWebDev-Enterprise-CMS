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
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web;

namespace RapidWebDev.Common.Web
{
	/// <summary>
	/// The base page type supports to flush javascripts added to document ready automatically.
	/// </summary>
	public class SupportDocumentReadyPage : Page
	{
		/// <summary>
		/// Flush javascripts which are added to document ready automatically.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPreRenderComplete(EventArgs e)
		{
			base.OnPreRenderComplete(e);

			ClientScripts.OnDocumentReady.Flush();
		}
	}
}
