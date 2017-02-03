num = input('Give me a number: ')

# sanitized_num = num and int(num)

if num:
    sanitized_num = int(num)
else:
    sanitized_num = num

print('sanitized num, ', sanitized_num)
