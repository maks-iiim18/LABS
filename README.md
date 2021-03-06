# Introduction to Testing

## Функциональное тестирование сайта [Binary](https://webtrader.binary.me/v2.2.8/main.html#)

Тест-кейс №1

| Название                                                     | Описание                                                     |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| Номер                                                        | 1                                                            |
| Заголовок                                                    | Выбор основной пары для торговли(EUR/USD)                    |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| Нажать на кнопку "Торговля" в верхнем меню                   | Открывется выподающее меню со следующими полями: Forex, Фондовые индексы, Индексы Синтетик, Сырьевые товары. |
| Навести курсор мыши на пункт выпадающего меню "Forex"        | Открывается еще одно выпадающее меню со следующими полями: Smart FX,  Минорные пары, Основные пары. |
| Навести курсор мыши на пункт выпадающего меню "Основные пары" | Открывается список основных пар.                             |
| Выбрать из списка основных пар пару EUR/USD                  | На рабочей облати появится окно для настройки сделки         |

Тест-кейс №2

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 2                                                            |
| Заголовок                                                    | Вывод графика для пары EUR/USD                               |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| Нажать на кнопку "График" в верххнем меню                    | Открывается выподяющее меню со следующими полями: Forex, Фондовые индексы, Индексы Синтетик, Сырьевые товары. |
| Навести курсор мыши на пункт выпадающего меню "Forex"        | Открывается еще одно выпадающее меню со следующими полями: Smart FX, Минорные пары, Основные пары. |
| Навести курсор мыши на пункт выпадающего меню "Основные пары" | Открывается список графиков для основных пар.                |
| Выбрать из списка графиков для основных пар пару EUR/USD     | На рабочей области появится окно с графиком для пары EUR/USD |

Тест-кейс №3

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 3                                                            |
| Заголовок                                                    | Ставка в разделе "вверх/вниз" на повышение в размере 10 USD  |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, находиться в рабочей области, в рабочую область выведено окно для работы со ставкой, на счету должно быть минимум 5 USD |
| **Шаг**                                                      | **Ожиданиемый результат**                                    |
| В верхнем левом углу окна для настройки сделки нажать на кнопку выадающего типы сделок | Раскроется список со значениями: Вверх/вниз, Касание/Нет касания, Внутри/Вне, Значение Повышения/Падения |
| В появившемся списке выбрать пункт Вврех/Вниз                | Данный пункт будет выбран как тип сделки                     |
| Из списка расположенного в верхней части окна выбрать пункт "Повышение" | Данный пункт будет выбран как подтип сделки                  |
| В разделе продолжительность установить время равное 5 минутам | Будет установлено время действия сделки                      |
| В разделе ставка установить размер ставки равный 10 USD      | Размер сделки быдет составлять 10 USD                        |
| Нажать кнопку "Купить"                                       | Сделка переносится в портфель сделок и со счета списывается 10 USD |

Тест-кейс №4

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 4                                                            |
| Заголовок                                                    | Просмотр портфеля текущих сделок                             |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, наличие активных сделок |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхнем левом углу сайта, необходимо нажать на кнопку с именем аккаунта | Раскрывается меню, в котороом представлена основная информация по данному аккаунту |
| Среди пунктов меню необходимо выбрать пункт "Портфель"       | На рабочей области появится окно с текущими сделками, есть возможность посмотреть обзор данной сделки |

Тест-кейс №5

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 5                                                            |
| Заголовок                                                    | Ставка на сумму 0 USD                                        |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхнем левом углу окна для настройки сделки нажать на кнопку выадающего список типов сделки | Раскроется список со значениями: Вверх/вниз, Касание/Нет касания, Внутри/Вне, Значение Повышения/Падения |
| В появившемся списке выбрать пункт Вврех/Вниз                | Данный пункт будет выбран как тип сделки                     |
| Из списка расположенного в верхней части окна выбрать пункт "Повышение" | Данный пункт будет выбран как подтип сделки                  |
| В разделе ставка установить размер ставки равный 0 USD       | Появляется высплывающее окно, уведомляющее о том что минимальный размер ставки состовляет 0,5 USD, кнопка "купить" становится некликабельной. |

Тест-кейс №6

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 6                                                            |
| Заголовок                                                    | Ставка в разделе "внутри/вне" с установкой невозможного барьера |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхнем левом углу окна для настройки сделки нажать на кнопку выадающего типы сделок | Раскроется список со значениями: Вверх/вниз, Касание/Нет касания, Внутри/Вне, Значение Повышения/Падения |
| В появившемся списке выбрать пункт "внутри/вне"              | Данный пункт будет выбран как тип сделки                     |
| Из списка расположенного в верхней части окна выбрать пункт "ends between" | Данный пункт будет выбран как подтип сделки                  |
| В разделе продолжительность установить время равное 1 дню    | Будет установлено время действия сделки                      |
| В разделе "Верхний барьер" установить в значение 1.1         | Данное значение будет установлено для верхнего барьера       |
| В разделе "Нижний барьер" установить в значение 1.2          | Данное значение будет установлено для нижнего барьера и появиться всплывающее окно уведомляющее о том, что верхний барьер должен быть выше нижнего барьера, кнопка "купить" становится некликабельной. |

Тест-кейс №7

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 7                                                            |
| Заголовок                                                    | Ставка в разделе "внутри/вне" с установкой правильного барьера |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой, на счету должно быть минимум 10 USD |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхнем левом углу окна для настройки сделки нажать на кнопку выадающего типы сделок | Раскроется список со значениями: Вверх/вниз, Касание/Нет касания, Внутри/Вне, Значение Повышения/Падения |
| В появившемся списке выбрать пункт "внутри/вне"              | Данный пункт будет выбран как тип сделки                     |
| Из списка расположенного в верхней части окна выбрать пункт "ends between" | Данный пункт будет выбран как подтип сделки                  |
| В разделе продолжительность установить время равное 1 дню    | Будет установлено время действия сделки                      |
| В разделе "Верхний барьер" установить в значение 1.15        | Данное значение будет установлено для верхнего барьера       |
| В разделе "Нижний барьер" установить в значение 1.13         | Данное значение будет установлено для нижнего барьера        |
| В разделе "Ставка" установить значение в размере 10 USD      | Размер сделки быдет составлять 10 USD                        |
| Нажать кнопку "Купить"                                       | Сделка переносится в портфель сделок и со счета списывается 10 USD |

Тест-кейс №8

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 8                                                            |
| Заголовок                                                    | Ставка на сырьевые товары в размере 10 USD                   |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыта рабочая область |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| Нажать на кнопку "Торговля" в верхнем меню                   | Открывется выподающее меню со следующими полями: Forex, Фондовые индексы, Индексы Синтетик, Сырьевые товары. |
| Навести курсор мыши на пункт выпадающего меню "Сырьевые товары" | Открывается еще одно выпадающее меню со следующими полями: Металлы, Энергоносители. |
| Навести курсор мыши на пункт выпадающего меню "Металлы"      | Открывается список металлов.                                 |
| Выбрать из списка металлов пару Золото/USD                   | На рабочей облати появится окно для настройки сделки         |
| В разделе "Ставка" установить значение равное 10 USD         | Размер сделки быдет составлять 10 USD                        |
| Нажать кнопку "Купить"                                       | Сделка переносится в портфель сделок и со счета списывается 10 USD |

Тест-кейс №9

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 9                                                            |
| Заголовок                                                    | Ставка превышающая баланс аккаунта                           |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой, на балансе аккаунта находится 14612 USD |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхнем левом углу окна для настройки сделки нажать на кнопку выадающего типы сделок | Раскроется список со значениями: Вверх/вниз, Касание/Нет касания, Внутри/Вне, Значение Повышения/Падения |
| В появившемся списке выбрать пункт Вврех/Вниз                | Данный пункт будет выбран как тип сделки                     |
| Из списка расположенного в верхней части окна выбрать пункт "Повышение" | Данный пункт будет выбран как подтип сделки                  |
| В разделе продолжительность установить время равное 5 минутам | Будет установлено время действия сделки                      |
| В разделе "Ставка" установить значение равное 15000 USD      | Появляется всплывающее окно, уведомляющее что вашего баланса недостаточно для совершения данной сделки, кнопка "купить" становится некликабельной. |

Тест-кейс №10

| Название                                                     | Описание                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Номер                                                        | 10                                                           |
| Заголовок                                                    | Савка, продолжительность которой составляет 0 минут          |
| Предусловие                                                  | Открыта страница [Binary: Webtrader](https://webtrader.binary.me/v2.2.8/main.html#), реализован вход в аккаунт, открыто окно для работы со сделкой |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхнем левом углу окна для настройки сделки нажать на кнопку выадающего типы сделок | Раскроется список со значениями: Вверх/вниз, Касание/Нет касания, Внутри/Вне, Значение Повышения/Падения |
| В появившемся списке выбрать пункт Вврех/Вниз                | Данный пункт будет выбран как тип сделки                     |
| Из списка расположенного в верхней части окна выбрать пункт "Повышение" | Данный пункт будет выбран как подтип сделки                  |
| В разделе продолжительность установить время равное 0 минутам | Появиться всплывающее окно, уведомляющее о том, что контракты на данный период не предлагаются |


