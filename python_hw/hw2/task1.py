'''
Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой,
а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
чтобы все монетки были повернуты вверх одной и той же стороной.
Выведите минимальное количество монет, которые нужно перевернуть
'''
from random import randint

reshki = 0
orly = 0

n = int(input("введите количество монет: "))

for i in range (0, n, 1):
    storona_monety = randint(0,1)
    print (storona_monety, end = " ")
    if storona_monety == 0:
        reshki +=1
    if storona_monety == 1:
        orly +=1
    storona_monety = -1
print()

if reshki < orly:
    print (reshki)
else: print (orly)
