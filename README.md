Solution of the ZennoLab task

Задание:
Сделать backend-часть к сервису на ASP.NET Core 2+.

Описание задачи:
Имеется сервис, где клиент может зарегистрироваться, залогиниться и задать несколько ключевых слов и товар для мониторинга позиции по ключевым словам товара на amazon.com.
Имеются самостоятельные парсеры страниц amazon.com. Парсеры периодически спрашивают сервер, есть ли задание на парсинг, могут его получить и прислать результат парсинга, на каком месте товар по ключевому слову, сколько рекламных объявлений перед твоим ключевым словом.
Имеется клиентская часть в браузере (FrontEnd SPA), которая позволяет пользователям регистрироваться, логиниться, добавлять задания на мониторинг ключевых слов, показывать результаты в виде таблиц.
Что требуется сделать:

Клиентская часть и парсеры работают через API, прототипы методов этого API нужно написать. Разработать DAL (без реального работы с базой данных). Разработать структуру API запросов. Код следуют писать так, чтобы его можно было легко покрыть автоматическими тестами. Какую базу данных вы бы рекомендовали использовать для данной задачи, если нужно отслеживать 10 000 000 ключевых слов ежедневно?

Solution:
Выполнено ввиде Swagger спеки без реалезации методов с минимумом коментариев по предпологаемым путям решения.
