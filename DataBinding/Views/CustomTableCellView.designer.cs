// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DataBinding
{
	partial class CustomTableCellView
	{
		[Outlet]
		AppKit.NSTextField HelpField { get; set; }

		[Outlet]
		AppKit.NSImageView Icon { get; set; }

		[Outlet]
		AppKit.NSTextField TitleStr { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Icon != null) {
				Icon.Dispose ();
				Icon = null;
			}

			if (TitleStr != null) {
				TitleStr.Dispose ();
				TitleStr = null;
			}

			if (HelpField != null) {
				HelpField.Dispose ();
				HelpField = null;
			}
		}
	}
}
