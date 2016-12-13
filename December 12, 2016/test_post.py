# This file will only work properly under a Python 2.7 environment

class Post(object):
    def __init__(self, title, author, body):
        self.title = title
        self.author = author
        self.body = body
        self.likes = 0

    def like(self):
        self.likes += 1

    def __str__(self):
        return self.title + " by " + self.author

class VideoPost(Post):
    def __init__(self, title, author, url):
        super(VideoPost, self).__init__(title, author, None)
        self.video_url = url
        self.plays = 0

    def play(self):
        self.plays += 1

    def __str__(self):
        return self.title + " played " + str(self.plays) + " times"

if __name__ == '__main__':
    post = VideoPost('Awesome title', 'me', 'http://google.com')
    print(post)
