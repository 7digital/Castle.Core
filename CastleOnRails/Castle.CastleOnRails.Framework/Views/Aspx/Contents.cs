// Copyright 2004 DigitalCraftsmen - http://www.digitalcraftsmen.com.br/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.CastleOnRails.Framework.Views.Aspx
{
	using System;
	using System.Web;
	using System.Web.UI;

	/// <summary>
	/// Summary description for Contents.
	/// </summary>
	public class Contents : Control
	{
		public Contents()
		{
		}

		protected override void Render(HtmlTextWriter writer)
		{
			byte[] contentsArray = (byte[]) HttpContext.Current.Items["rails.contents"];

			if (contentsArray != null)
			{
				String contents = writer.Encoding.GetString(contentsArray);

				writer.InnerWriter.Write( contents.TrimEnd('\0') );
			}
			else
			{
				writer.Write("The child page wasn't processed by the rails engine. " + 
					"Was this page invoked directly?");
			}
		}
	}
}
