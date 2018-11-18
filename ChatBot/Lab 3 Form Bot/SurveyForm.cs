using System;
using Microsoft.Bot.Builder.FormFlow;

namespace Lab_3_Form_Bot
{
  public enum DepartmentOptions
  {
    Accounting,
    AdministrativeSupport,
    IT
  }

  [Serializable]
  public class SurveyForm
  {
    [Prompt("Please enter your {&}.")]
    public string Name;

    [Prompt("Please enter your {&}.")]
    public string PhoneNumber;

    [Prompt("Please enter your {&}.")]
    public string Address;

    [Prompt("What {&} did it happen?")]
    public string Date;

    [Prompt("{&} did it happen?")]
    public string How;

    [Prompt("Any {&}?")]
    public string Witnesses;

    [Prompt("Do you have {&} (Pictures, Police report)?")]
    public string Evidence;
    
    public static IForm<SurveyForm> BuildForm()
    {
      return new FormBuilder<SurveyForm>().Build();
    }
  }
}