namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		// **********
		//public int HouseCount { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(int), minimum: "25", maximum: "35")]
		//public int HouseCount { get; set; }
		// **********

		// **********
		//// Note: Deprecate
		////[System.ComponentModel.DisplayName
		////	(displayName: "House Count")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "House Count")]

		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(int), minimum: "25", maximum: "35")]
		//public int HouseCount { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "تعداد منازل")]

		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(int), minimum: "25", maximum: "35",
		//	ErrorMessage = "مقدار فیلد تعداد منازل، باید بین ۲۵ تا ۳۵ باشد!")]
		//public int HouseCount { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "تعداد منازل")]

		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(int), minimum: "25", maximum: "35",
		//	ErrorMessage = "مقدار فیلد {0}، باید بین {1} تا {2} باشد!")]
		//public int HouseCount { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "سن")]

		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(int), minimum: "25", maximum: "35",
			ErrorMessage = "مقدار فیلد {0}، بايد بين {1} تا {2} سال باشد!")]
		public int Age { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "نام و نام خانوادگی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "تکميل فيلد {0} الزامی است!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3,
			ErrorMessage = "طول مقدار فیلد {0}، بايد بين {2} تا {1} کاراکتر باشد")]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "نشانی پست الکترونيکی")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
			ErrorMessage = "مقدار فيلد {0} معتبر نمی‌باشد!")]
		public string EmailAddress { get; set; }
		// **********
	}
}
