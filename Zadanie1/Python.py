a = float(input("Podaj pierwszą liczbę: "))
b = float(input("Podaj drugą liczbę: "))
op = input("Podaj operację (+, -, *, /): ")

if op == "+":
    print("Wynik:", a + b)
elif op == "-":
    print("Wynik:", a - b)
elif op == "*":
    print("Wynik:", a * b)
elif op == "/":
    if b == 0:
        print("Błąd: dzielenie przez zero!")
    else:
        print("Wynik:", a / b)
else:
    print("Nieznana operacja!")
