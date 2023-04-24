
def add_cont():
    file = open('file.txt', 'a', encoding ='UTF-8')
    data1 = input ('введите ФИО: ')
    data2 = input ('номер телефона: ')
    data3 = input ('место работы: ')

    data = '\n'+data1 + ';'+ data2 + ';' + data3 + ';'
    file.write(data)
    file.close()

def print_phone_book():
    file = open('file.txt', 'r', encoding ='UTF-8')
    data = file.readlines()
    file.close()
    for contact in data:
        print(contact)
#print_phone_book()

def find_cont():
    file = open('file.txt', 'r', encoding ='UTF-8')
    data = file.readlines()
    file.close()
    search_cont = input('Введите информацию для поиска: ')
    for cont in data:
        if search_cont.lower() in cont.lower():
            print(cont)

#find_cont()
def save_phone_book(phone_book):
    file = open('file.txt', 'w', encoding ='UTF-8')
    data = ""
    for k, contact in enumerate(phone_book):
        if k>0:
            data +='\n'
        data += str(contact['id']) + ';' + contact['name'].strip() + ';' + contact['phone'].strip() + ';' + contact['comment'].strip() + ';'
    file.write(data)
    file.close()

def get_phone_book():
    phone_book = []
    file = open('file.txt', 'r', encoding ='UTF-8')
    data = file.readlines()
    file.close()
    i = 0
    for contact in data:
        new_contact = contact.strip().split(';')
        new_contact = {'id': i,
                    'name':new_contact[1],
                    'phone':new_contact[2],
                    'comment': new_contact[3]}
        phone_book.append(new_contact)
        i +=1
    return phone_book

def change_cont():

    phone_book = get_phone_book()    
    print_phone_book()

    id = int(input('введите id '))
    print(phone_book[id])
    select = int (input('Введите поле для изменения: 1 - имя, 2 - телефон, 3 - место работы:'))
    if select == 1:
        name = input('Введите новое имя: ')
        phone_book[id]['name'] = name
    if select == 2:
        phone = input('Введите новый телефон: ')
        phone_book[id]['phone'] = phone
    if select == 3:
        comment = input('Введите новое место работы: ')
        phone_book[id]['comment'] = comment
    save_phone_book(phone_book)

#change_cont()

def del_cont():
    phone_book = get_phone_book()    
    print_phone_book()
    id = int(input('введите id для удаления: '))

    del phone_book[id]

    i = 0
    for contact in phone_book:
        contact['id'] = i
        i += 1

    save_phone_book(phone_book)

change_cont()