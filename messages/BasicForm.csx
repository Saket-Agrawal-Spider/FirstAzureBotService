using System;
using Microsoft.Bot.Builder.FormFlow;

public enum NumbersToChoose { One=1, Two, Three,Four,Five,Six,Seven,Eight,Nine };
public enum DoneWaiting { Done = 1, Wait };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! Choose a number from below list {&}? {||}")]
    public NumbersToChoose Name { get; set; }

    [Prompt("Multiply your number by 2.{||}")]
    public DoneWaiting Question1 { get; set; }

    [Prompt("Add 5 to your result.{||}")]
    public DoneWaiting Question2 { get; set; }

    [Prompt("Multiply the result by 50.{||}")]
    public DoneWaiting Question3 { get; set; }

    [Prompt("If you've already had your birthday this year, Add 1767.If not, Add 1766. {||}")]
    public DoneWaiting Question4 { get; set; }

    [Prompt("Got a four-figure number? Now, Subtract the year of your birth from the result. {||}")]
    public DoneWaiting Question5 { get; set; }


    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Confirm("You must have got 3 digit number, first digit is your choosen number and other two are your age.").Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
