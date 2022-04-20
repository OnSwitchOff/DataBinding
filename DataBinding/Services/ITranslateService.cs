using System;
namespace DataBinding
{
	public interface ITranslateService
	{
		public string GetTitleString(MainNavMenuItemType itemType);
		public string GetHelpMessageString(MainNavMenuItemType itemType);
	}
}

