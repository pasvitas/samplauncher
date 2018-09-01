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
* В файле MainForm.cs, в коде найти class ServerInfo, изменить там поля
servername - Имя сервера
ip - IP-Адресс
port - Порт сервера
site - Сайт сервера
group - группа вконтакте
* Изменить все что ваша душа пожелает
* Вверху изменить сборку в Debug на Release
* Дождатся завершения сборки
* Зайти в папку samplauncher/bin/Release
* Создать папку SAMP, поместить туда установщик SAMP под именем install.exe (можно взять из samplauncher/bin/Debug)
* Создать папку ModPack, поместить туда модпак(при необходимости)
* Распорстранять всю содержимое папки Realase (сделать установщик, например)

За поддержкой или заказами обращайтесь https://vk.com/pasvitas

Patreon-страничка для пожертвований: https://www.patreon.com/pasvitas
