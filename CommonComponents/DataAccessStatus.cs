﻿namespace CommonComponents
{
  public class DataAccessStatus
   {
      public string Status { get; set; }
      public bool OperationSucceeded { get; set; }
      public string ExceptionMessage { get; set; }
      public string CustomMessage { get; set; }
      public string HelpLink { get; set; }
      public int ErrorCode { get; set; }
      public string StackTrace { get; set; }


      public void setValues(string status, bool operationSucceeded, string exceptionMessage, string customMessage, string helpLink, int errorCode, string stackTrace)
    {
      Status = status ?? string.Copy("");
      OperationSucceeded = operationSucceeded;
      ExceptionMessage = exceptionMessage ?? string.Copy("");
      CustomMessage = customMessage ?? string.Copy("");
      HelpLink = helpLink ?? string.Copy("");
      ErrorCode = errorCode;
      StackTrace = stackTrace ?? string.Copy("");
    }
    public string getFormattedValues()
    {
      return $"Status--> {Status}\nOperatinSucceeded--> {OperationSucceeded}\nExceptinoMessage--> {ExceptionMessage}\nCustomMessage-->{CustomMessage}\nHelpLink--> {HelpLink}\nStackTrace--> {StackTrace}";
    }

  }
}
