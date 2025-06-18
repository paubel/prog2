def is_adult(age):
    if age >= 18:
        return True
    else:
        return False

def grade_feedback(grade):
    if grade >= 90:
        return "Excellent"
    elif grade >= 75:
        return "Good"
    elif grade >= 60:
        return "Pass"
    else:
        return "Fail"

def calculate_discount(price, age):
    if age < 18:
        return price * 0.9  # 10 % rabatt för ungdom
    elif age > 65:
        return price * 0.85  # 15 % rabatt för pensionärer
    else:
        return price  # fullpris

# Huvudprogram
print("Välkommen!")

# Fråga efter ålder en gång
user_age = int(input("Hur gammal är du? "))

# Kontrollera myndighet
if is_adult(user_age):
    print("Du är myndig.")
else:
    print("Du är inte myndig.")

# Fråga efter betyg och ge återkoppling
grade = int(input("Vad fick du för poäng (0–100)? "))
feedback = grade_feedback(grade)
print(f"Din återkoppling: {feedback}")

# Rabatt – nu frågar vi efter priset
price = float(input("Vad kostar varan? "))
final_price = calculate_discount(price, user_age)
print(f"Du ska betala: {final_price:.2f} SEK")
