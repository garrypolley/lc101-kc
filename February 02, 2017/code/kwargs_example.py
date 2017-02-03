fruits = {
    'red': ['apple', 'cherry', 'tomato'],
    'purple': ['grape', 'plumb'],
    'yellow': ['apple', 'apricot']
}

def print_kwargs(**kwargs):
    for key, value in kwargs.items():
        dict_string = "{0}: {1}".format(key, value)
        print(dict_string)

print_kwargs(
    one=1,
    two=2,
    three=3,
    four=4
)

print_kwargs(**fruits)