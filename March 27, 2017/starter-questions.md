# Starter Questions

All questions can have more answers that what is listed here.

## CSharp

* What is a ViewModel?
  * "A ViewModel is a model class to be specifically used in a View." (from the prep)
* Why use a ViewModel?
  * Allows compile-time checking of properties
  * Makes form validation easier
* What do you need to do to use ViewModels?
  * Define a new class for your view model, typically in a subfolder called ViewModels; the properties of the model will be used to generate the user interface and pass data between the Controller and the View
  * Pass in the variable representing your ViewModel to the call to View() from the Controller
  * Declare with the `@model` syntax the type of your model at the top of the View template 
  * You can also use an `@using` statement  at the top of the View template to make the model class available without having to use the full-qualified name of the class
* What is a tag helper?
  * Attributes that help .NET generate tags such as anchor, form, input, and label tags
  * Tag helpers can be used with a ViewModel to generate user interface components from model properties
* What are some examples of tag helpers?
  * `asp-for` - used to generate labels and inputs
  * `asp-controller` - used to generate anchor and form tags
  * `asp-action` - used to generate anchor and form tags
  * `asp-validation-summary` - used to generate a summary of validation errors; use with `div`
  * `asp-validation-for` - used to generate validation error messages for individual properties; use with `span`
* What are some advantages of using Enumeration types?
  * Enumeration types define the valid values for a variable
  * Code completion tools can display the valid values
* When would you use an Enumeration type?
  * When a variable or property logically can only take a few different values.
  * Examples: day of the week, type of cheese
  * Counter examples: temperature (too many values), a person's age (too many values)
