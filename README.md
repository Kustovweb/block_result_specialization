### Программа запрашивает у пользователя ввод строк из консоли и находит строки с длиной меньше, либо равно 3 символа.
### Программа написана на C#

>Программа будет стпрашивать размер массива пока не будет введено пользователем целое число

Основной функционал программы заключен в 4 методах:

```void FillArr(string[] arr)``` - заполняет массив значениями вводимыми пользователем, ничего не возвращает, принимает на вход один параметр одномерный массив строк.

```string[] GetArrStr(string[] arr, SizeArr)``` - находит все строки с длиной меньше, либо равным 3 символа, возвращает массив, принимает на вход 2 параметра: arr - одномерный массив строк,  SizeArr - размер массива.

```string[] GetNormArr(string[] arr)``` - находит все пустые значения в массиве исключает их, получает новую длину для массива, создает новый массив и записывает в новый массив все значения не равные null, возвращает одномерный массив строк.

```void PrintArray(string[] arr)``` - печатает массив в консоль в удобочитаемом виде, ничего не возвращает, принимает на вход одномерный массив строк.

> P.S. Коллекции не использовались, только массивы.