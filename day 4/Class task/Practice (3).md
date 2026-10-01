### Task  1
A task related to OOP and a little more complicated:

Let's consider a system for managing a library of books.

1. Create a class `Book` with the attributes: book title, author, publication year and genre.

2. Create a class `Library` with attributes: list of books and methods:

    - `AddBook`: adds a new book to the list of library books.
    - `RemoveBook`: removes a book from the list of books by its title.
    - `SearchBookByAuthor`: returns a list of books by the given author.
    - `SearchBookByYear`: returns a list of books published after a given year.
    - `SearchBookByGenre`: returns a list of books of a specific genre.

3. Create an object of the `Library` class and check the operation of each of the methods.

4. Add a `GetBoolCount` method to the `Library` class, which will return the total number of books in the library.

Now your book library management system will have basic adding functions,
deleting and searching books, as well as the ability to get the total number of books in the library. 📚
##
Задача, связанная с ООП и немного сложнее:
Рассмотрим систему для управления библиотекой книг.
1. Создайте класс `Book` с атрибутами: название книги, автор, год издания и жанр.
2. Создайте класс `Library` с атрибутами: список книг и методами:
   - `AddBook`: добавляет новую книгу в список книг библиотеки.
   - `RemoveBook`: удаляет книгу из списка книг по ее названию. 
   - `SearchBookByAuthor`: возвращает список книг заданного автора.
   - `SearchBookByYear`: возвращает список книг, опубликованных после заданного года.
   - `SearchBookByGenre`: возвращает список книг определенного жанра.
3. Создайте объект класса `Library` и проверьте работу каждого из методов.
4. Добавьте в класс `Library` метод `GetBoolCount`, который будет возвращать общее количество книг в библиотеке.
Теперь ваша система для управления библиотекой книг будет иметь основные функции добавления, удаления и поиска книг, а также возможность получить общее количество книг в библиотеке. 📚
##
Вазифаи марбут ба OOP ва каме мураккабтар:
Системаи идоракунии китобҳои китобхонаро дида мебароем.
1. Синфи `Китоб`-ро бо атрибутҳо созед: номи китоб, муаллиф, соли нашр ва жанр.
2. Бо атрибутҳо синфи `Library` эҷод кунед: рӯйхати китобҳо ва усулҳо:
    - `AddBook`: ба рӯйхати китобҳои китобхона китоби нав илова мекунад.
    - `RemoveBook`: китобро аз рӯи унвонаш аз рӯйхати китобҳо хориҷ мекунад.
    - `SearchBookByAuthor`: рӯйхати китобҳои муаллифи додашударо бармегардонад.
    - `SearchBookByYear`: Рӯйхати китобҳоеро, ки пас аз соли дода нашр шудаанд, бармегардонад.
    - `SearchBookByGenre`: Рӯйхати китобҳои як жанри мушаххасро бармегардонад.
3. Объекти синфи `Library` созед ва кори ҳар як усулро тафтиш кунед.
4. Усули `GetBoolCount`-ро ба синфи `Library` илова кунед, ки шумораи умумии китобҳои китобхонаро бармегардонад.
Акнун системаи идоракунии китобхонаи китобҳои шумо дорои вазифаҳои асосии илова кардан, хориҷ кардан ва ҷустуҷӯи китобҳо ва инчунин қобилияти гирифтани шумораи умумии китобҳо дар китобхона хоҳад буд. 📚
---
### Task 2
The `Debt` class represents a debt with a balance and an interest rate.
- `balance` (double): The current balance of the debt.
- `interestRate` (double): The interest rate of the debt.
The `Debt` class has a constructor that takes two parameters:
- `initialBalance` (double): The initial balance of the debt.
- `initialInterestRate` (double): The initial interest rate of the debt.
The `PrintBalance()` method prints the current balance of the debt.
The `WaitOneYear()` method grows the debt amount by multiplying the balance by the interest rate.
##
Класс `Debt` представляет собой долг с остатком и процентной ставкой.
- `balance` (double): текущий баланс долга.
- `interestRate` (double): процентная ставка по долгу.
Класс `Debt` имеет конструктор, принимающий два параметра:
- `initialBalance` (double): начальный баланс долга.
- `initialInterestRate` (double): начальная процентная ставка по долгу.
Метод `PrintBalance()` печатает текущий баланс долга.
Метод `WaitOneYear()` увеличивает сумму долга путем умножения баланса на процентную ставку.
##
Синфи `Debt` қарзро бо тавозун ва меъёри фоизӣ ифода мекунад.
- `balance` (double): қарзи ҷорӣ.
- `interestRate` (double): меъёри фоизи қарз.
Синфи `Debt` конструктор дорад, ки ду параметрро мегирад:
- `initialBalance` (double): қарзи аввала.
- `initialInterestRate` (double): меъёри фоизии ибтидоии қарз.
Усули `PrintBalance()` тавозуни қарзи ҷорӣро чоп мекунад.
Усули `WaitOneYear()` маблағи қарзро тавассути зарб задани тавозун ба меъёри фоиз зиёд мекунад.
##
Example:
Пример:
Намуна:
```csharp
Debt mortgage = new Debt(100000, 0.01);
mortgage.PrintBalance(); // Output: 100000

mortgage.WaitOneYear();
mortgage.PrintBalance(); // Output: 101000

mortgage.WaitOneYear();
mortgage.PrintBalance(); // Output: 102010
```
In the example above, a new `Debt` object is created with an initial balance of 100000 and an initial interest rate of 0.01.                                       
The `PrintBalance()` method is called to print the current balance of the debt, which is 100000.        
Then, the `WaitOneYear()` method is called twice, which grows the debt amount by multiplying the balance by the interest rate.                             
After the first call, the balance is 101000, and after the second call, the balance is 102010.
##
В приведенном выше примере создается новый объект `Debt` с начальным балансом 100000 и начальной процентной ставкой 0,01.
Метод `PrintBalance()` вызывается для печати текущего баланса долга, который равен 100000.
Затем дважды вызывается метод `WaitOneYear()`, который увеличивает сумму долга путем умножения баланса на процентную ставку.
После первого звонка баланс 101000, а после второго звонка баланс 102010.
##
Мисоли дар боло овардашуда объекти нави `Debt`-ро бо тавозуни ибтидоии 100000 ва меъёри фоизии ибтидоии 0,01 эҷод мекунад.
Усули `PrintBalance()` барои чоп кардани тавозуни қарзи ҷорӣ, ки 100000 аст, даъват карда мешавад.
Пас аз он усули `WaitOneYear()` ду маротиба даъват карда мешавад, ки маблағи қарзро тавассути зарб задани тавозуни фоиз ба фоиз зиёд мекунад.
Пас аз даъвати аввал тавозун 101000 ва пас аз даъвати дуюм бақия 102010 аст.

---

### Task 3
Write a program that first reads book information from the user. 
The details to be asked for each book include the title, the author name, the number of pages and the publication year.     
Entering an empty string as the name of the book ends the reading process. 
After this the user is asked for what is to be printed.
If the user inputs `Everything` all the details are printed: the book titles, the author name, the numbers of pages, and the publication years.
However if the user enters the string `Title` only the book titles are printed.
However if the user enters the string `Author` only the books of author is book are printed.
If something else than `everything` or `TitleBook` or `AuthorName`  is given the program should not print anything.
##
Напишите программу, которая сначала считывает информацию о книге от пользователя.
Подробная информация, которую необходимо запросить для каждой книги, включает название, имя автора, количество страниц и год публикации.
Ввод пустой строки в качестве названия книги завершает процесс чтения.
После этого у пользователя спрашивают, что именно нужно распечатать.
Если пользователь вводит `Everything`, печатаются все детали: названия книг, имя автора, количество страниц и годы публикации.
Однако если пользователь вводит строку `Title`, печатаются только названия книг.
Однако если пользователь вводит строку `Author`, печатаются только книги автора книги.
Если указано что-то иное, чем `Everything`, `TitleBook` или `AuthorName`, программа не должна ничего печатать.
##
Барномае нависед, ки аввал маълумоти китобро аз корбар мехонад.
Маълумоте, ки барои ҳар як китоб дархост карда мешавад, номи китоб, номи муаллиф, шумораи саҳифаҳо ва соли нашрро дар бар мегирад.
Дохил кардани сатри холӣ барои унвони китоб раванди хонданро ба анҷом мерасонад.
Пас аз ин, аз корбар мепурсанд, ки маҳз чӣ бояд чоп карда шавад.
Агар корбар `Everything`-ро ворид кунад, ҳама тафсилот чоп карда мешавад: номи китоб, номи муаллиф, шумораи саҳифаҳо ва солҳои нашр.
Аммо, агар корбар ба сатри `Title` ворид шавад, танҳо унвонҳои китоб чоп карда мешаванд.
Аммо, агар корбар ба сатри `Author` ворид шавад, танҳо китобҳои муаллифи китоб чоп мешаванд.
Агар чизи дигаре ба ғайр аз `Everything`, `TitleBook` ё `AuthorName` муайян карда шуда бошад, барнома набояд чизеро чоп кунад.


