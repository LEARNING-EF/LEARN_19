namespace Models
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static bool IsEntityValid
			(DatabaseContext databaseContext, object entity)
		{
			try
			{
				var validationResult =
					databaseContext.Entry(entity).GetValidationResult();

				return validationResult.IsValid;
			}
			catch
			{
				return false;
			}
		}

		public static bool IsEntityValid(object entity)
		{
			DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new DatabaseContext();

				return IsEntityValid(databaseContext, entity);
			}
			catch
			{
				return false;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}

		public static System.Collections.Generic.ICollection<System.Data.Entity.Validation.DbValidationError>
			CheckEntityValidation(DatabaseContext databaseContext, object entity)
		{
			System.Collections.Generic.ICollection<System.Data.Entity.Validation.DbValidationError> result;

			try
			{
				var validationResult =
					databaseContext.Entry(entity).GetValidationResult();

				if (validationResult.IsValid == false)
				{
					return validationResult.ValidationErrors;
				}
				else
				{
					result =
						new System.Collections.Generic.List<System.Data.Entity.Validation.DbValidationError>();
				}
			}
			catch (System.Exception ex)
			{
				result =
					new System.Collections.Generic.List<System.Data.Entity.Validation.DbValidationError>();

				result.Add(new System.Data.Entity.Validation.DbValidationError
					(propertyName: string.Empty, errorMessage: "Unexpected Error! " + ex.Message));
			}

			return result;
		}

		public static System.Collections.Generic.ICollection<System.Data.Entity.Validation.DbValidationError>
			CheckEntityValidation(object entity)
		{
			System.Collections.Generic.ICollection<System.Data.Entity.Validation.DbValidationError> result = null;

			DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new DatabaseContext();

				result =
					CheckEntityValidation(databaseContext, entity);
			}
			catch
			{
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}

			return result;
		}
	}
}
