﻿using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
	/// <summary>
	/// Note : A widget that is not embedded in a parent widget is called a window (from Qt documentation)
	/// </summary>
	public class LabelDemo : BaseDemoWidget
	{
		public static readonly string Description = "Show simple label";
		public LabelDemo()
		{
			WindowTitle = "Label demo";

			//Resize(250, 150);
			//Show();
		}

		public override void InitUI()
		{

			var vboxLayout = GetLayout();
			this.Layout = vboxLayout;

		}

		/// <summary>
		/// Gets VBoxLayout with label
		/// </summary>
		/// <returns>The layout.</returns>
		QLayout GetLayout()
		{
			var vbox = new QVBoxLayout();
			vbox.AddWidget(InitLabel("Hello world"));
			return vbox;
		}

		/// <summary>
		/// Inits the label.
		/// </summary>
		/// <returns>The label.</returns>
		/// <param name="text">Label text</param>
		/// <param name="font">Font for text (default is Arial 12)</param>
		public static QLabel InitLabel(string text = "Hi", QFont font = null)
		{
			return new QLabel(text)
			{
				Font = font ?? new QFont("Arial", 12)
			};
		}


	}
}
