namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Person person = new Models.Person();

				person.Age = 20;
				person.FullName = "آب";
				person.EmailAddress = "DariushT";

				// Solution (1)
				//databaseContext.People.Add(person);

				//databaseContext.SaveChanges();
				// /Solution (1)

				// Solution (2)
				if (Models.Utility.IsEntityValid(databaseContext, person))
				{
					databaseContext.People.Add(person);

					databaseContext.SaveChanges();
				}
				else
				{
					System.Windows.Forms.MessageBox.Show("Error On Model Validation!");
				}
				// /Solution (2)

				// Solution (3)
				//var databaseValidationErrors =
				//	Models.Utility.CheckEntityValidation(databaseContext: databaseContext, entity: person);

				//if (databaseValidationErrors.Count == 0)
				//{
				//	databaseContext.People.Add(person);

				//	databaseContext.SaveChanges();

				//	System.Windows.Forms.MessageBox.Show("Your information was added successfully.");
				//}
				//else
				//{
				//	string strErrorMessages = string.Empty;

				//	foreach (var varDatabaseValidationError in databaseValidationErrors)
				//	{
				//		//strErrorMessages +=
				//		//	varDatabaseValidationError.ErrorMessage + "\n\r";

				//		strErrorMessages +=
				//			varDatabaseValidationError.ErrorMessage + System.Environment.NewLine;
				//	}

				//	System.Windows.Forms.MessageBox.Show
				//		(text: strErrorMessages,
				//		caption: "خطا",
				//		buttons: System.Windows.Forms.MessageBoxButtons.OK,
				//		icon: System.Windows.Forms.MessageBoxIcon.Error,
				//		defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
				//		options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				//		System.Windows.Forms.MessageBoxOptions.RtlReading);
				//}
				// Solution (3)
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Unexpected Error! - " + ex.Message);

				Dtx.SemiLogHandler.Log(ex);

				System.Windows.Forms.MessageBox.Show("Unexpected Error!");
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void CreateButton_Click(object sender, System.EventArgs e)
		{
			Models.Person person = new Models.Person();

			if (string.IsNullOrWhiteSpace(ageTextBox.Text) == false)
			{
				person.Age =
					System.Convert.ToInt32(ageTextBox.Text);
			}

			if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) == false)
			{
				person.FullName =
					fullNameTextBox.Text;
			}

			if (string.IsNullOrWhiteSpace(emailAddressTextBox.Text) == false)
			{
				person.EmailAddress =
					emailAddressTextBox.Text;
			}

			var errors =
				Models.Utility.CheckEntityValidation(person);

			if (errors.Count > 0)
			{
				Infrastructure.Utility.DisplayErrors(form: this, errors: errors);
			}
		}
	}
}
