using System.Linq;

namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static System.Windows.Forms.Control
			FindControlByName(System.Windows.Forms.Form form, string name)
		{
			if (form == null)
			{
				return null;
			}

			if (name == null)
			{
				return null;
			}

			name =
				name.Replace(" ", string.Empty);

			if (name == string.Empty)
			{
				return null;
			}

			var foundedControl =
				form.Controls.OfType<System.Windows.Forms.Control>()
				.Where(current => string.Compare(current.Name, name, true) == 0)
				.FirstOrDefault();

			return foundedControl;
		}

		public static void DisplayErrors
			(System.Windows.Forms.Form form,
			System.Collections.Generic.ICollection<System.Data.Entity.Validation.DbValidationError> errors)
		{
			if (form == null)
			{
				return;
			}

			if ((errors == null) || (errors.Count == 0))
			{
				return;
			}

			foreach (var error in errors)
			{
				string name =
					$"{ error.PropertyName }ErrorMessageLabel";

				var foundedControl =
					FindControlByName(form: form, name: name);

				if (foundedControl != null)
				{
					foundedControl.Visible = true;
					foundedControl.Text = error.ErrorMessage;
				}
			}
		}
	}
}
