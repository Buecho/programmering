import random

number = random.randint(1,100)
guess = 0

while guess != number:
    guess = int (input("Gissa nummer"))
    if(guess < number):
        print("Gissa högre")
    elif(guess > number):
        print("Gissa lägre")
    else:
        print("Du gissade rätt!")