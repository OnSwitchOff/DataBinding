using System;
using AppKit;
using Foundation;

namespace DataBinding
{
	[Register("MainNavMenuItemModel")]
	public class MainNavMenuItemModel : NSObject
	{
		private bool _isExpanded = false;
		private MainNavMenuItemType _mainNavMenuType = MainNavMenuItemType.UNKNOWN;

		[Export("Icon")]
		public NSImage Icon
		{
			get
			{
				var path = NSBundle.GetPathsForResources("", NSBundle.MainBundle.BundlePath);
				var x = ImageService.GetService().GetNSImage(_mainNavMenuType);
				return x;
			} 
		}

		[Export("Title")]
		public string Title
		{
			get => TranslateService.GetService().GetTitleString(_mainNavMenuType);
		}

		[Export("HelpMessage")]
		public string HelpMessage
        {
			get => TranslateService.GetService().GetHelpMessageString(_mainNavMenuType);
		}

		[Export("IsExpanded")]
		public bool IsExpanded
		{
			get => _isExpanded;
			set
			{
				WillChangeValue("IsExpanded");
				_isExpanded = value;
				DidChangeValue("IsExpanded");
			}
		}

		[Export("MainNavMenuItemType")]
		public MainNavMenuItemType MainNavMenuItemType
		{
			get => _mainNavMenuType;
			set
			{
				WillChangeValue("MainNavMenuItemType");
				_mainNavMenuType = value;
				DidChangeValue("MainNavMenuItemType");
				DidChangeValue("Icon");
				DidChangeValue("Title");
				DidChangeValue("HelpMessage");
			}
		}

		public MainNavMenuItemModel()
		{
		}

        public MainNavMenuItemModel(MainNavMenuItemType mainNavMenuItemType)
        {
            MainNavMenuItemType = mainNavMenuItemType;
        }

    }
}

