n = int(input("Podaj liczbę ocen: "))
suma = 0

for i in range(n):
    ocena = int(input(f"Podaj ocenę {i + 1} (1-6): "))
    suma += ocena

srednia = suma / n
print(f"Średnia ocen: {srednia:.2f}")

if srednia >= 3.0:
    print("Uczeń zaliczył przedmiot.")
else:
    print("Uczeń nie zaliczył przedmiotu.")
