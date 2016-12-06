"""
A program to take grade input and calculate a student's gpa
"""

grades = []

# gather grade information
still_getting_grades = True
while still_getting_grades:
    grade = input("Your grade (0.0-4.0): ")
    credits = input("# credits: ")

    # store grades
    grades.append({'grade': float(grade), 'credits': int(credits)})

    continue_entry = input("Enter another grade? [y/n]: ")
    if continue_entry == 'n':
        still_getting_grades = False

# compute GPA
total_quality_score = 0
total_credits = 0

# calculate quality scores and total
for gradeinfo in grades:
    total_quality_score += (gradeinfo['grade'] * gradeinfo['credits'])
    total_credits += gradeinfo['credits']

gpa = total_quality_score / total_credits
print("Your GPA is:", gpa)
