using System;
using Microsoft.Bot.Builder.FormFlow;

public enum NumbersToChoose { One, Two, Three,Four,Five,Six,Seven,Eight,Nine };
public enum DoneWeighting { Done = 1, Weighting };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! Choose a number from below list {&}? {||}")]
    public NumbersToChoose Name { get; set; }

    [Prompt("Question1?")]
    public DoneWeighting Question1 { get; set; }

    [Prompt("Question2?")]
    public DoneWeighting Question2 { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
