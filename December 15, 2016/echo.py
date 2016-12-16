import sys
import argparse


def get_command_line_args():
    """
    Sets up the parser for getting command line arguments
    """
    parser = argparse.ArgumentParser()
    parser.add_argument("echo", help="echo the string you use here")

    args = parser.parse_args()

    return args

def main(value):
    # By default the `0` is returned to indicate the program ran successfully
    return_code = 0

    if value is None:
        # A return code of 2 means there was an error in the program
        return_code = 2
    else:
        sys.stdout.write('{}\n'.format(value))

    return return_code


if __name__ == "__main__":
    # If called as main get the values
    args = get_command_line_args()

    sys.exit(main(args.echo))
