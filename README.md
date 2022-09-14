## Программа написана в рамках вводного курса в профессию Разработчик и является итоговой работой курса.

**Задача:**

>Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

>Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
>1. Создать репозиторий на GitHub
>2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
>3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
>4. Написать программу, решающую поставленную задачу
>5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Программа работает следующим образом:**
1. **Получаем от пользователя количество элементов массива** *(и в этом же действии получаем модуль числа, которое ввел пользователь, тем самым даже при вводе отрицательных значений будем получать число, которое можно использовать, как размер ммассива.)*
2. **Заполняем массив данными от пользователя** *(для этого в цикле просим вводить данные пользователя и на каждой итерации добавляем данные на соответсвующие позиции в массиве.)*
3. **Выводим массив с пользовательскими данными на экран** *(по факту такой задачи не стояло, но это поможет нам проверить правильность работы программы, да и так нагляднее)*
4. **Получаем длину нового массива** *(для этого счиатем количество элементов, длина которых меньше или равна 3 сиволам. Эту длину можно получить и на этапе ввода данных от пользователя, то есть на 2 этапе, изменив метод. Мы можем заставить метод при вводе данных с клавиатуры сразу проверять длинну элемента, который вводит пользователь и считать количество таких элементов, а на выходе получить массив, в котором содержится массив данных полученных от пользователя, и количество элементов, длинной до 3-х символов включительно.)*
5. **Создаем маассив с размером, который получили на предыдущем этапе и заполняем его, проверяя данные в имеющемся массиве** *(Этот этап у меня реализован в одном методе с предыдщим этапом. Мне показалось, что так будет нагляднее)*
6. **Выводим массив на экран** *(Все аналогично пункту 3)*