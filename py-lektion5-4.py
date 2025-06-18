import tkinter as tk

def visa_meddelande():
    namn = namn_entry.get()
    resultat_label.config(text=f"Hej, {namn}!")

# Skapa fönster
rot = tk.Tk()
rot.title("Mitt första GUI")

# Skapa etikett och textfält
tk.Label(rot, text="Vad heter du?").pack()
namn_entry = tk.Entry(rot)
namn_entry.pack()

# Skapa knapp
tk.Button(rot, text="Säg hej", command=visa_meddelande).pack()

# Skapa resultatetikett
resultat_label = tk.Label(rot, text="")
resultat_label.pack()

# Starta programmet
rot.mainloop()
