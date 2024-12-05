namespace FastEndpointsDotNet.Application.Common.Utilities;

//public static class FluentValidationHelper
//{
//    public static List<string> GetErrorMessage(List<ValidationFailure> errors)
//    {
//        List<string> errorsMessages = new List<string>();
//        foreach (var failure in errors)
//        {
//            errorsMessages.Add(failure.ErrorMessage);
//        }
//        return errorsMessages;
//    }

//    public static object GetErrorMessagePropertyWise(List<ValidationFailure> errors, List<string> items)
//    {
//        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

//        foreach (ValidationFailure item in errors.DistinctBy(x => x.PropertyName))
//        {
//            data[item.PropertyName] = errors.Where(x => x.PropertyName == item.PropertyName).Select(x => x.ErrorMessage).ToList();
//        }
//        return data;
//    }

//    public static object GetErrorMessagePropertyWise(string propertyName, string errorMessage)
//    {
//        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();


//        data[propertyName] = new List<string>() { errorMessage };

//        return data;
//    }
//}