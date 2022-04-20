using System;
using Foundation;
using AppKit;
using System.IO;

namespace DataBinding
{
	[Register("PersonModel")]
	public class PersonModel: NSObject
	{
		private string _name = "";
		private string _occupation = "";
		private bool _isManager = false;
		private NSMutableArray _people = new NSMutableArray();

		[Export("Name")]
		public string Name
        {
			get => _name;
			set
            {
				WillChangeValue("Name");
				_name = value;
				DidChangeValue("Name");
            }
        }

		[Export("Occupation")]
		public string Occupation
		{
			get => _occupation;
			set
			{
				WillChangeValue("Occupation");
				_occupation = value;
				DidChangeValue("Occupation");
			}
		}

		[Export("isManager")]
		public bool isManager
		{
			get { return _isManager; }
			set
			{
				WillChangeValue("isManager");
				WillChangeValue("Icon");
				_isManager = value;
				DidChangeValue("isManager");
				DidChangeValue("Icon");
			}
		}

		[Export("isEmployee")]
		public bool isEmployee
		{
			get { return (NumberOfEmployees == 0); }
		}

		[Export("Icon")]
		public NSImage Icon
		{
			get
			{
				if (isManager)
				{
					var path = NSBundle.GetPathsForResources("",NSBundle.MainBundle.BundlePath) ;
					return NSImage.ImageNamed("prodajba.png");
				}
				else
				{
					return NSImage.ImageNamed("prodajba.png");
				}
			}
		}

		[Export("personModelArray")]
		public NSArray People
		{
			get { return _people; }
		}

		[Export("NumberOfEmployees")]
		public nint NumberOfEmployees
		{
			get { return (nint)_people.Count; }
		}


		public PersonModel()
		{
		}

		public PersonModel(string name, string occupation)
		{
			// Initialize
			this.Name = name;
			this.Occupation = occupation;
		}

		public PersonModel(string name, string occupation, bool manager)
		{
			// Initialize
			this.Name = name;
			this.Occupation = occupation;
			this.isManager = manager;
		}

		[Export("addObject:")]
		public void AddPerson(PersonModel person)
		{
			WillChangeValue("personModelArray");
			isManager = true;
			_people.Add(person);
			DidChangeValue("personModelArray");
		}

		[Export("insertObject:inPersonModelArrayAtIndex:")]
		public void InsertPerson(PersonModel person, nint index)
		{
			WillChangeValue("personModelArray");
			_people.Insert(person, index);
			DidChangeValue("personModelArray");
		}

		[Export("removeObjectFromPersonModelArrayAtIndex:")]
		public void RemovePerson(nint index)
		{
			WillChangeValue("personModelArray");
			_people.RemoveObject(index);
			DidChangeValue("personModelArray");
		}

		[Export("setPersonModelArray:")]
		public void SetPeople(NSMutableArray array)
		{
			WillChangeValue("personModelArray");
			_people = array;
			DidChangeValue("personModelArray");
		}
	}
}

