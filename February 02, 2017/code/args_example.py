sentences = [
    'First one that isn\'t title',
    'another one that isn\'t title',
    'The quick brown fox jumped over the lazy dog',
    'The lazy dog layed down for the quick brown fox who jumped'
]

def to_camel(*args):
    master_string = ''
    for arg in args:
        master_string += str(arg).title()

    print(type(master_string))

    return master_string

print(to_camel(
    'the',
    'quick',
    'brown',
    'fox',
    1,
    'jumped'
))

print(to_camel(*sentences))
