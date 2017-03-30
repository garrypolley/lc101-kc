# Starter Questions

All questions can have more answers than those listed here.

## CSharp

* Why use model classes to represent model data instead of using strings and lists?
  * Eliminate duplication - different instances can share references to objects representing the same values
  * Enable extension - additional information can be added to classes, e.g., zip code can be added to a `Location` class
  * Type checking - by using enumeration types, for example, we can leverage compile-time type checking to ensure fields are not set to invalid values
* What is the difference between a model class and a view model?
  * Model classes represent the data used by an application; they are independent of any views
  * View models usually are tied to particular views and are used to mediate communication between views and controllers
* What is an exception?
  * A runtime error (as opposed to a compile-time error)
  * Exceptions are implemented as classes derived from `Exception`
  * Can be "caught" and handled
  * Example: DivideByZeroException when code attempts to divide by 0
* What does it mean to "throw" an exception?
  * Signals to the runtime system that an error has occurred
  * Thrown exceptions can be caught and handled
* Which exceptions should you catch and handle?  Which exceptions should you allow to propagate?
  * Handle exceptions related to problems you can fix, for example, exceptions related to user input, so that the user can be asked to provide valid data
  * Do not handle exceptions representing a state from which your program cannot recover, e.g., failing to connect to a database containing data that your program requires
* What happens when you fail to catch an exception?
  * The exception will continue to propagate until it is caught
  * If the exception is not caught, the runtime will emit a message and stop the program
* What can you do to avoid some exceptions?
  * Validate data prior to using it
