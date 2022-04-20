using System;
namespace DataBinding
{
	public class TranslateService: ITranslateService
	{
		private static TranslateService _service;

		public static TranslateService GetService()
		{
			if (_service == null)
			{
				_service = new TranslateService();
			}
			return _service;
		}

        public string GetTitleString(MainNavMenuItemType itemType)
        {
			switch (itemType)
			{
				case MainNavMenuItemType.UNKNOWN:
					return itemType.ToString();
				case MainNavMenuItemType.SALE:
					return itemType.ToString();
				case MainNavMenuItemType.INVOICE:
					return itemType.ToString();
				case MainNavMenuItemType.PROFORM_INVOICE:
					return itemType.ToString();
				case MainNavMenuItemType.DEBIT_NOTE:
					return itemType.ToString();
				case MainNavMenuItemType.CREDIT_NOTE:
					return itemType.ToString();
				case MainNavMenuItemType.CASH_REGISTER:
					return itemType.ToString();
				case MainNavMenuItemType.EXCHANGE:
					return itemType.ToString();
				case MainNavMenuItemType.REPORT:
					return itemType.ToString();
				case MainNavMenuItemType.SETTINGS:
					return itemType.ToString();
				default:
					return itemType.ToString();
			}
		}

        public string GetHelpMessageString(MainNavMenuItemType itemType)
        {
			switch (itemType)
			{
				case MainNavMenuItemType.UNKNOWN:
					return itemType.ToString();
				case MainNavMenuItemType.SALE:
					return itemType.ToString();
				case MainNavMenuItemType.INVOICE:
					return itemType.ToString();
				case MainNavMenuItemType.PROFORM_INVOICE:
					return itemType.ToString();
				case MainNavMenuItemType.DEBIT_NOTE:
					return itemType.ToString();
				case MainNavMenuItemType.CREDIT_NOTE:
					return itemType.ToString();
				case MainNavMenuItemType.CASH_REGISTER:
					return itemType.ToString();
				case MainNavMenuItemType.EXCHANGE:
					return itemType.ToString();
				case MainNavMenuItemType.REPORT:
					return itemType.ToString();
				case MainNavMenuItemType.SETTINGS:
					return itemType.ToString();
				default:
					return itemType.ToString();
			}
		}

        public TranslateService()
		{
		}
	}
}

