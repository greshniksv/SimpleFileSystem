## SimpleFileSystem

Описание
---------

Реализовать файловую класс способный работать с файлом или блоком памяти как с файловой системой.
Работа с файлом или блоком памяти будет реализована на основе работы со Stream.

Конструктор: `SimpleFileSystem(Stream, Size)`

Методы
------

* CreateFile — создание файлов/директорий
* OpenDirectory — открытие директории
* CreateDirectory — создание директории
* Cleanup — удаление файла/пустой директории ?
* CloseFile — закрытие файлового дескриптора
* ReadFile — чтение куска файла указанной длины с указанным смещением
* WriteFile — запись данных в файл с указанным смещением
* FlushFileBuffers — очистка буферов (кэша) файла
* GetFileInformation — получение информации о размере, атрибутах, времени создания/последнего доступа/модификации файла/директории
* FindFiles — получение списка файлов/директорий в указанной директории
* SetFileAttributes — установка атрибутов файла/директории
* SetFileTime — установка времени создания/последнего доступа/модификации файла/директории
* DeleteFile — пометка файла на удаление (удаление проводится в Cleanup)
* DeleteDirectory — пометка директории на удаление (удаление проводится в Cleanup)
* MoveFile — перемещение/переименование файла/директории
* SetEndOfFile — установка размера файла (используется при создании пустого файла определенной длины)
* LockFile — блокировка файла в single-доступе
* UnlockFile — снятие блокировки
* GetDiskFreeSpace — получение информации о кол-ве доступного/общего/свободного места в ФС
* Unmount — размонтирование/отключение ФС

Структура ФС
------------
* Метка того что это SimpleFileSystem (3 байта) - SFS.
* Размер файловой системы (5 байт) - Максимальный размер ФС 256^5 = 1 099 511 627 776 байта. ~ 1ТБ.
* Комментарий (1024 байта) - Комментарий к ФС.
* Блок выделенный для хранения папок (0,5% от размера ФС).
* Блок транзакций (10Мб).
* Остальное пространство для хранения файлов и их содержимого.
