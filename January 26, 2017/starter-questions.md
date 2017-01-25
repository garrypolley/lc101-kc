# Starter Questions

All questions can have more answers that what is listed here.

## Software

* What is the `Waterfall Method` of software development
  * It's a type of software development with limited feedback from the users
  * Developers are given requirements and disappear for a long while until everything is done
* What is the `Agile Method` of software development
  * A type of development to make the product better for users
  * A type of development to make it more fun for developers
* What are some differences in `Agile` vs `Waterfall`?
  * `Agile` encourages doing smaller things -- (YAGNI) you are not going to need it
  * `Waterfall` is all about doing a bunch of work upfront to try to developer a big fish at the end
* What is the `Agile Manifesto`?
  * It's a document that describes the core of the Agile methodology: http://agilemanifesto.org/

## HTTP (Web stuff)

* What is validation?
  * Safely handling data on your server
  * Making sure the data you get is what you want
* When do you need to do validation?
  * Any time content is sent from a client to the server
* If you use a `<select>` do you need to validate the data on the server?
  * Yes, it's possible for anyone to pretend to be a client and could bypass the select form
* What is the usual flow of "validation"?
  1. Send form to user
  2. User submits form
  3. Server validates form
  4. Server gives an "all good" message OR responds with form containing what is wrong
* Other than the `%` what can be used to do string substituation?
  * `.format` on string
* How do you preserve user input?
  * Keep track of it in the `POST` handler
* What is the process to prevent HTML code in submissions called?
  * Escaping HTML -- specifically this is called escaping HTML entities
* What library do you use to escape the HTML?
  * `cgi` -- `cgi.escape`
* What is redirection?
  * Sending the browser to a different page
  * Something used after a `POST` to make the experience better for a user

## General

* Is there anything specific you'd like covered tonight? -- put it into slack -> HelloKC
* Be sure to checkout the feedback form: https://goo.gl/V44IQD
