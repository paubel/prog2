def get_number(prompt):
    return float(input(prompt))
def calculate_average(n1, n2, n3):
    return (n1 + n2 + n3) / 3
def main():
    number1 = get_number("Enter first number: ")
    number2 = get_number("Enter second number: ")
    number3 = get_number("Enter third number: ")
    average = calculate_average(number1, number2, number3)
    print(f"The average is {average:.2f}")
main()
