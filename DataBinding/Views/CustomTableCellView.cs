using System;
using AppKit;
using CoreGraphics;
using Foundation;

namespace DataBinding
{
	[Register("CustomTableCellView")]
	public partial class CustomTableCellView : NSTableCellView
	{
		public CustomTableCellView(IntPtr handle) : base(handle)
		{
		}

        public override void MouseEntered(NSEvent theEvent)
        {
            //this.WantsLayer = true;
            //this.Layer.BackgroundColor = new CGColor(CGConstantColor.White);
            //this.Layer.BackgroundColor = new CGColor(125,0,0,140);
            MainViewController mainViewController = NSApplication.SharedApplication.KeyWindow.ContentViewController as MainViewController;
            if (mainViewController == null)
            {
                return;
            }
            mainViewController.HelpString = this.HelpField.StringValue;
        }

        public override void MouseExited(NSEvent theEvent)
        {
            MainViewController mainViewController = NSApplication.SharedApplication.KeyWindow.ContentViewController as MainViewController;
            if (mainViewController == null)
            {
                return;
            }
            mainViewController.HelpString = String.Empty;
            //this.WantsLayer = false;
            //this.Layer.BackgroundColor = new CGColor(CGConstantColor.White);
            //this.Layer.BackgroundColor = new CGColor(0, 125, 0, 0);
        }
    }
}

