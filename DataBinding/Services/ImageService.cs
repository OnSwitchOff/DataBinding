using System;
using AppKit;

namespace DataBinding
{
	public class ImageService: IImageService
	{
		private static ImageService _service;

		public static ImageService GetService()
        {
			if(_service == null)
            {
				_service = new ImageService();
            }
			return _service;
        }

        public NSImage GetNSImage(MainNavMenuItemType itemType)
        {
			switch (itemType)
			{
				case MainNavMenuItemType.UNKNOWN:
					return NSImage.ImageNamed("question.png");
				case MainNavMenuItemType.SALE:
					return NSImage.ImageNamed("prodajba.png");
				case MainNavMenuItemType.INVOICE:
					return NSImage.ImageNamed("fakturirane.png");
				case MainNavMenuItemType.PROFORM_INVOICE:
					return NSImage.ImageNamed("fakturirane.png");
				case MainNavMenuItemType.DEBIT_NOTE:
					return NSImage.ImageNamed("fakturirane.png");
				case MainNavMenuItemType.CREDIT_NOTE:
					return NSImage.ImageNamed("fakturirane.png");
				case MainNavMenuItemType.CASH_REGISTER:
					return NSImage.ImageNamed("kasovAparat.png");
				case MainNavMenuItemType.EXCHANGE:
					return NSImage.ImageNamed("obmen.png");
				case MainNavMenuItemType.REPORT:
					return NSImage.ImageNamed("spravki.png");
				case MainNavMenuItemType.SETTINGS:
					return NSImage.ImageNamed("nastroiki.png");
				default:
					return NSImage.ImageNamed("question.png");
			}
		}

        private ImageService()
		{

		}
	}
}

