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
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		AppKit.NSBox ExpanderBox { get; set; }

		[Outlet]
		AppKit.NSView ExpView { get; set; }

		[Outlet]
		AppKit.NSScrollView HelpScrollView { get; set; }

		[Outlet]
		AppKit.NSTextView HelpTextView { get; set; }

		[Outlet]
		AppKit.NSScrollView MainNavScrollView { get; set; }

		[Outlet]
		AppKit.NSTableView MainNavTable { get; set; }

		[Outlet]
		AppKit.NSScrollView NavScrollView { get; set; }

		[Outlet]
		AppKit.NSBox SalesHeaderBox { get; set; }

		[Outlet]
		AppKit.NSButton SqBtn { get; set; }

		[Action ("ExpandBtnClick:")]
		partial void ExpandBtnClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ExpanderBox != null) {
				ExpanderBox.Dispose ();
				ExpanderBox = null;
			}

			if (ExpView != null) {
				ExpView.Dispose ();
				ExpView = null;
			}

			if (HelpScrollView != null) {
				HelpScrollView.Dispose ();
				HelpScrollView = null;
			}

			if (HelpTextView != null) {
				HelpTextView.Dispose ();
				HelpTextView = null;
			}

			if (MainNavScrollView != null) {
				MainNavScrollView.Dispose ();
				MainNavScrollView = null;
			}

			if (MainNavTable != null) {
				MainNavTable.Dispose ();
				MainNavTable = null;
			}

			if (NavScrollView != null) {
				NavScrollView.Dispose ();
				NavScrollView = null;
			}

			if (SalesHeaderBox != null) {
				SalesHeaderBox.Dispose ();
				SalesHeaderBox = null;
			}

			if (SqBtn != null) {
				SqBtn.Dispose ();
				SqBtn = null;
			}
		}
	}
}
