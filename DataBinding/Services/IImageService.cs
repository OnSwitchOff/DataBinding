using System;
using AppKit;

namespace DataBinding
{
	public interface IImageService
	{
		public NSImage GetNSImage(MainNavMenuItemType itemType);
	}
}

