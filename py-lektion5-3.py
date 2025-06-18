import requests

def hamta_skämt():
    url = "https://official-joke-api.appspot.com/random_joke"
    try:
        response = requests.get(url)
        response.raise_for_status()  # Kontrollera HTTP-fel
        data = response.json()
        print("\nSkämt:")
        print(data["setup"])
        print(data["punchline"])
    except requests.exceptions.RequestException as e:
        print("Kunde inte hämta skämt. Felmeddelande:", e)

if __name__ == "__main__":
    hamta_skämt()
