namespace Dtx
{
	public static class SemiLogHandler
	{
		static SemiLogHandler()
		{
		}

		public static void Log(System.Exception ex)
		{
			string strTab = "\t";
			string strTabs = strTab;
			System.Exception exception = ex;

			string errorMessage =
				System.Environment.NewLine + System.Environment.NewLine + "***** BEGIN *****";

			while (exception != null)
			{
				errorMessage +=
					System.Environment.NewLine + exception.Message;

				System.Data.Entity.Validation.DbEntityValidationException
					dbEntityValidationException = exception as System.Data.Entity.Validation.DbEntityValidationException;

				if (dbEntityValidationException != null)
				{
					errorMessage += System.Environment.NewLine;

					foreach (var entityValidationError in dbEntityValidationException.EntityValidationErrors)
					{
						errorMessage +=
							System.Environment.NewLine + strTabs +
							string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
							entityValidationError.Entry.Entity.GetType().Name, entityValidationError.Entry.State);

						foreach (var validationError in entityValidationError.ValidationErrors)
						{
							errorMessage +=
								System.Environment.NewLine + strTabs + strTab +
								string.Format("- Property: \"{0}\", Error: \"{1}\"",
								validationError.PropertyName, validationError.ErrorMessage);
						}
					}
				}

				strTabs += strTab;
				exception = exception.InnerException;
			}

			errorMessage += System.Environment.NewLine + "***** END *****";

			string strPathName = "Application.log";

			System.IO.StreamWriter oStream = null;

			try
			{
				oStream =
					new System.IO.StreamWriter
						(strPathName, true, System.Text.Encoding.UTF8);

				oStream.WriteLine(errorMessage);
			}
			catch
			{
			}
			finally
			{
				if (oStream != null)
				{
					//oStream.Close();
					oStream.Dispose();
					oStream = null;
				}
			}
		}
	}
}
