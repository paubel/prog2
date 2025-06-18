def add_score(scores):
    name = input("Ange namn: ")
    try:
        points = int(input("Ange poäng: "))
        scores.append((name, points))
    except ValueError:
        print("Du måste ange ett heltal.")

def print_high_scores(scores):
    scores.sort(key=lambda x: x[1], reverse=True)
    print("\nTopplista:")
    for name, points in scores:
        print(f"{name}: {points}")

def main():
    scores = []
    while True:
        add_score(scores)
        cont = input("Vill du lägga till fler resultat? (j/n): ")
        if cont.lower() != 'j':
            break
    print_high_scores(scores)

if __name__ == "__main__":
    main()
