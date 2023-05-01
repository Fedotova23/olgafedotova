import pandas as pd
import random

def dummies(data):
    data_unique = []
    data_dummies = []
    for index, row in data.iterrows():
        if row['whoAmI'] not in data_unique:
            data_unique.append(row['whoAmI'])

    for index, row in data.iterrows():
        print(index, "\t", data_unique.index(row['whoAmI']))

lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})
dummies(data)

#print(data.head)
#print(pd.get_dummies(data, columns=['whoAmI'], drop_first=True))