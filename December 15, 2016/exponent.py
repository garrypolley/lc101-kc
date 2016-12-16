import sys
import argparse

def get_command_line_args():
    """
    Sets up the parser for getting command line arguments
    """
    parser = argparse.ArgumentParser(description="calculate X to the power of Y")

    # Create a group of arguments that is exclusive
    group = parser.add_mutually_exclusive_group()

    group.add_argument("-v", "--verbose", action="store_true", help="show a lot of logging data")
    group.add_argument("-q", "--quiet", action="store_true", help="show no logging data")

    # Add the main required arguments
    parser.add_argument("x", type=int, help="the base")
    parser.add_argument("y", type=int, help="the exponent")

    return parser.parse_args()

def main(x, y, quiet=False, verbose=False):
    return_code = 0

    if x is None or y is None:
        return_code = 2
    else:
        answer = x ** y

        if quiet:
            sys.stdout.write("{}\n".format(answer))
        elif verbose:
            sys.stdout.write("{} to the power {} equals {}\n".format(x, y, answer))
        else:
            sys.stdout.write("{}^{} == {}\n".format(x, y, answer))

    return return_code


if __name__ == "__main__":
    # If called as main get the values
    args = get_command_line_args()

    sys.exit(main(args.x, args.y, args.quiet, args.verbose))
