# SAMP Launcher by pasvitas v2.0
[![Build Status](https://travis-ci.org/pasvitas/samplauncher.svg?branch=master)](https://travis-ci.org/pasvitas/samplauncher)

Лаунчер для SAMP-серверов by pasvitas
Версия 2.0

Требования:
* NetFramework 4.6.1

Возможности:
* Запуск SAMP
* Ссылки на сайт и группу ВКонтакте
* Установка SAMP
* Установка модпака.

Установка модпака:
* Положите в папку ModPack все файлы модпака (текстуры, модели)
* При установке модпака программа скопирует все файлы оттуда в models.img

Как построить проект:
* Установить Visual Studio 2017 Community, при установке выбрать "Создание приложений для Windows", поддержку C#, NetFramework 4.6.1
* Скачать проект с репозитория (или воспользоваться командой git clone https://github.com/pasvitas/samplauncher)
* Открыть проект (файл samplauncher.sln)
* В файле MainForm.cs, в коде найти class ServerInfo, изменить там свойства
servername - Имя сервера
ip - IP-Адресс
port - Порт сервера
group - группа вконтакте
site - Сайт сервера
allowinstallsamp (false/true) - показывать или нет кнопку установки SAMP
allowinstallmodpack (false/true) - показывать или нет кнопку установки модпака
* Изменить все что ваша душа пожелает
* Вверху изменить сборку с Debug на Release
* Запустить сборку, дождатся завершения
* Зайти в папку samplauncher/bin/Release
* Создать папку SAMP, поместить туда установщик SAMP под именем install.exe (можно взять из samplauncher/bin/Debug) (опционально)
* Создать папку ModPack, поместить туда модпак (опционально)
* Распорстранять всю содержимое папки Realase (сделать установщик, например)

Возможные проблемы:
* Может некорректно работать прогессбар установки файла. Очень странный метод у библиотеки для работы с архивом. Если работать не будет - пишите, переделаю на свой. 

За поддержкой или заказами обращайтесь https://vk.com/pasvitas

Patreon-страничка для пожертвований: https://www.patreon.com/pasvitas
