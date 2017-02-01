# Starter Questions

All questions can have more answers that what is listed here.

## Python

* What is `*arg`?
  * It is a convention to allow an unlimited number of positional parameters e.g. `call(value)`
  * It allows you to put in as many unnamed arguments as you want to a function
* What is `**kwarg`?
  * It is a convention to allow an unlimited number of keyword parameters e.g. `call(key=value)`
  * It allows as many named arguments to a function as you desire
* When might you use a `*arg`?
  * A function that sums all passed arguments
  * To make backwards compatibility easier
  * If you made a `print` function
* When might you use a `**kwarg`?
  * A function that prints out keys and values
  * Keep backwards compatibility more easily when newer versions are made
* What would you do to replace parts of strings?
  * use `.format` and a string with one or more `{}` parts
  * use `%` followed by a character for replacing later with percent replacement

## HTTP

* What is the default `method` of a form?
  * It does a `get` issuing a `GET` HTTP request
* How do you access a URL parameter in `webapp2`?
  * Within a request processing method do a `self.request.get('MY_PARAM')`

## Web Framework

* What is a template?
  * An HTML file that accepts variables
  * A way to make really big strings
* What is the type of _every_ variable gotten from a request?
  * `str`
* What is `autoescape`?
  * A feature of many template engines that will make the dynamically added content safe
  * It makes user input be encoded so that raw HTML doesn't go into the pages

## General

* What did you learn from Monday night and Jeff from Blooom?
* What could the course have done differently to make this user-sign-up easier to hit the ground running?
* Make sure as you're working you get the next smallest piece done and check it. Don't do everything at once.
