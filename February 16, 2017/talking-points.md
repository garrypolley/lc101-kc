# Talking points

## Beofre Class

* Plugin back TV
* Start Youtube live

## Start of Class

* We will use the first part of tonight for a Q&A -- ask questions in your group
* Starter will be a bit different -- in that you will lead them
* You'll have time tonight to work on homework and ask any questions

## Lecture

* Cover stuff form TF groups
    * Writing idiomatic python -- good source here: http://docs.python-guide.org/en/latest/writing/style/
    * Cover some `t.render` stuff -- how does that work, mention the kwargs and how it works
    * mention the bonus material from slack that doesn't need special covering
    * functions added to handler class
    * cryptographic parts we have
    * Cover this code:
```python
class MainPage(Handler):
    def get(self):
        self.response.headers['Content-Type'] = 'text/plain'
```
* Overview of what we will do:
    1. Add owners to movies
    2. Ensure when we create movies we add owners
    2. Only show movie ratings for our movies we have watched
* Add owner and `datetime` field to Movie class
* Add logic that puts an owner on the Movie when created
* Only show our movies for ratings
* Create skeleton of recently watched movie

## End of Class

* Cover studio answer
  * Docs for ORM of webapp2 https://cloud.google.com/appengine/docs/python/datastore/queryclass
* Keep up on assignments
* We only have class on Monday of next week -- no other classes next week
* Monday is entirely a review day
