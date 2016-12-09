from sys import argv

def no_arguments():
    if argv[-1] == __file__:
        return True
    return False

if __name__ == "__main__":
    print(argv)
    print('last arg: {}'.format(argv[-1]))
    print('last arge type: {}'.format(type(argv[-1])))

    if no_arguments():
        print('No arguments passed in')
