def counting(characters):
    char_dict = {}
    for char in characters:
        if char in char_dict:
            char_dict[char] += 1
        else:
            char_dict[char] = 1

    sorted_chars = sorted(char_dict)
    for key in sorted_chars:
        print(key, char_dict[key])

string = input("Please enter a sentence: ")
counting(string)