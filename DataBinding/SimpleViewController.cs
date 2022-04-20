﻿// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace DataBinding
{
	public partial class SimpleViewController : NSViewController
	{
		private PersonModel _person = new PersonModel();

		[Export("Person")]
		public PersonModel Person
		{
			get { return _person; }
			set
			{
				WillChangeValue("Person");
				_person = value;
				DidChangeValue("Person");
			}
		}

		public SimpleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.AwakeFromNib();

			// Set a default person
			var Craig = new PersonModel("Craig Dunn", "Documentation Manager");
			Craig.AddPerson(new PersonModel("Amy Burns", "Technical Writer"));
			Craig.AddPerson(new PersonModel("Joel Martinez", "Web & Infrastructure"));
			Craig.AddPerson(new PersonModel("Kevin Mullins", "Technical Writer"));
			Craig.AddPerson(new PersonModel("Mark McLemore", "Technical Writer"));
			Craig.AddPerson(new PersonModel("Tom Opgenorth", "Technical Writer"));
			Person = Craig;

		}
	}
}