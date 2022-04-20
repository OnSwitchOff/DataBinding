using System;
using AppKit;
using Foundation;

namespace DataBinding
{
    internal class NavMenuTableDelegate : NSTableViewDelegate
    {
        private const string CellIdentifier = "MyNavItemCell";

        public NavMenuTableDelegate()
        {

        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            var view0 = tableView.MakeView(CellIdentifier, this);
     

            NSTableCellView viewOrigin = view0 as NSTableCellView;
            CustomTableCellView view = viewOrigin as CustomTableCellView;
            NSTrackingArea trackingArea = new NSTrackingArea(view.Frame,
                NSTrackingAreaOptions.ActiveInKeyWindow |
                NSTrackingAreaOptions.MouseEnteredAndExited,
                view, null);
            view.AddTrackingArea(trackingArea);


            return view;
        }

        public override void SelectionDidChange(NSNotification notification)
        {
            //base.SelectionDidChange(notification);

        }


    }
}

