-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Июл 20 2024 г., 16:44
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `db_military_enlistment_office`
--

-- --------------------------------------------------------

--
-- Структура таблицы `date_medical_data`
--

CREATE TABLE `date_medical_data` (
  `id` int(250) NOT NULL,
  `document_number` varchar(250) NOT NULL,
  `date` varchar(10) NOT NULL,
  `therapist` varchar(250) NOT NULL,
  `surgeon` varchar(250) NOT NULL,
  `neurologist` varchar(250) NOT NULL,
  `psychiatrist` varchar(250) NOT NULL,
  `ophthalmologist` varchar(250) NOT NULL,
  `dermatovenerologist` varchar(250) NOT NULL,
  `otorhinolaryngologist` varchar(250) NOT NULL,
  `dentist` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `date_medical_data`
--

INSERT INTO `date_medical_data` (`id`, `document_number`, `date`, `therapist`, `surgeon`, `neurologist`, `psychiatrist`, `ophthalmologist`, `dermatovenerologist`, `otorhinolaryngologist`, `dentist`) VALUES
(1, '5353', '25.02.2023', 'В целом неплохо', 'Кости целы', 'Нервы в порядке', 'Нет ментальных расстройств', 'Зрение -1.5', 'Всё хорошо', 'Ушные раковины в порядке, носовые пазухи тоже', 'Кариес на 7 зубе вправа, кариес на 5 зубе слева'),
(2, '5353', '07.04.2023', 'Хорошее состояние', 'Сломана правая рука', 'Нервный тик на левом глазе', 'Пограничное расстройство личности', 'Зрение 0', 'Всё хорошо', 'Носовые пазухи в порядке', 'Все зубы в хорошем состоянии'),
(3, '5353', '04.04.2024', 'Всё хорошо', 'Вывехнута правая лодыжка', 'Нервная система немного сбоит', 'Нет ментальных расстройств', 'Зрение 0', 'Всё хорошо', 'Ушная пробка в левом ухе', 'Кариес на 6 зубе слева');

-- --------------------------------------------------------

--
-- Структура таблицы `education`
--

CREATE TABLE `education` (
  `id` int(100) NOT NULL,
  `document_number` varchar(100) NOT NULL,
  `Name_of_educational_organization` varchar(200) NOT NULL,
  `Name_of_specialty` varchar(200) NOT NULL,
  `Enrollment_date` varchar(50) NOT NULL,
  `Duration_of_training` varchar(2) NOT NULL,
  `Address_educational_organization` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `education`
--

INSERT INTO `education` (`id`, `document_number`, `Name_of_educational_organization`, `Name_of_specialty`, `Enrollment_date`, `Duration_of_training`, `Address_educational_organization`) VALUES
(1, '5353', 'ГУМРФ', 'ИС', '1 сентября 2023 г.', '2', 'Санкт-Петербург, ул. Двинская, 5/7');

-- --------------------------------------------------------

--
-- Структура таблицы `literature`
--

CREATE TABLE `literature` (
  `id` int(200) NOT NULL,
  `title_literature` varchar(100) NOT NULL,
  `author` varchar(50) NOT NULL,
  `summary` varchar(200) NOT NULL,
  `keywords` varchar(250) NOT NULL,
  `link` varchar(2500) NOT NULL,
  `date_added` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `literature`
--

INSERT INTO `literature` (`id`, `title_literature`, `author`, `summary`, `keywords`, `link`, `date_added`) VALUES
(1, 'Что надо знать призывнику, отправляясь в военкомат?', 'КСМ', 'как проходит призывная кампания, что нужно знать призывникам, как правильно оформлять медицинские справки и чем грозят суды с военкоматами.', 'призыв', 'https://ksmrus.ru/text/?text=161', '14.05.2024'),
(2, 'Указ президента Российской Федерации \"Об утверждении Положения о военных комиссариатах\"', 'Государство', 'основные принципы создания военных комиссариатов, их подчиненность, задачи и порядок обеспечения деятельности', 'Закон', 'http://pravo.gov.ru/proxy/ips/?docbody=&prevDoc=102437552&backlink=1&&nd=102161418', ''),
(4, 'Что означают категории годности к военной службе', 'journal.tinkoff', 'Все виды категории годности', 'категории годности', 'https://journal.tinkoff.ru/short/k-sluzhbe-goden/', '17.04.2024'),
(5, 'Служба в армии по призыву', 'Наша жизнь', 'В какие войска призывают срочников', 'виды войск', 'https://nashazhizn64.ru/articles/sluzhba-v-armii-po-prizyvu-/', ''),
(6, 'Как вести себя в военкомате?', 'Помощь призывникам', '6 советов для призывников как себя вести в военкомате', 'призыв', 'https://pomoshch-prizyvnikam.ru/blog/kak-vesty-sebya-v-voenkomate/', '25.05.2024');

-- --------------------------------------------------------

--
-- Структура таблицы `medical_checkup`
--

CREATE TABLE `medical_checkup` (
  `id` int(100) NOT NULL,
  `document_number` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `medical_checkup`
--

INSERT INTO `medical_checkup` (`id`, `document_number`, `city`, `date`) VALUES
(1, '12345', 'Tver', '12.06.2024 12:00'),
(2, '5353', 'Тверь', '03.06.2024 12:00'),
(3, '5353', 'Тверь', '05.06.2024 15:00'),
(4, '5353', 'Тверь', '19.06.2024 12:00'),
(5, '5353', 'Тверь', '14.06.2024 12:00'),
(6, '5353', 'Тверь ', '03.07.2024 12:00'),
(7, '5353', 'Тверь ', '12.06.2024 12:00'),
(8, '5353', 'Тверь ', '19.06.2024 14:00'),
(9, '5353', 'Тверь ', '26.06.2024 14:00'),
(10, '96783543', 'Саратов', '26.07.2024 14:00');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(200) NOT NULL,
  `document_number` varchar(250) NOT NULL,
  `password` varchar(100) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `patronymic` varchar(50) NOT NULL,
  `date_of_birth` date NOT NULL,
  `address` varchar(100) NOT NULL,
  `category` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `city` varchar(100) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `user_status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `document_number`, `password`, `last_name`, `name`, `patronymic`, `date_of_birth`, `address`, `category`, `gender`, `city`, `phone_number`, `email`, `user_status`) VALUES
(1, '123', 'test', 'testt', 'testtt', 'testtttt', '2001-07-23', 'Санкт-Петербург, ул. Пушкина, д65, кв24', 'А', 'М', 'Самара', '8904021779', 'Test@gmail.com', 'admin'),
(2, '5353', '77777', 'Иванов', 'Иван', 'Иванович', '2002-11-21', 'Тверь, ул. Тверской проспект, д. 3, кв. 78', 'А', 'M', 'Пермь', '8(952)812', 'alblack@gmail.com', 'user'),
(3, '75847383', '0000', 'Пресняков', 'Виктор', 'Олегович', '1999-09-09', 'Бешкек,ул.Замайская,д.9,кв.38', 'Б', 'М', 'Бешкек', '8951754829', 'Presnyak@yandex.ru', 'user'),
(4, '96783543', '1234', 'Карпов', 'Семен', 'Ярославович', '1999-02-03', 'Саратов,ул.Книжная,д7,кв.85', 'А', 'М', 'Саратов', '89457563810', 'lolek@gmail.com', 'user'),
(5, '86748294', '0987', 'Пресняков', 'Владимир', 'Игнатович', '2004-09-18', 'Москва,ул.Ленина,д.94,кв.105', 'Б', 'М', 'Москва', '89653857383', 'Richard3@yandex.ru', 'user'),
(6, '6749535', '3030', 'Ларионова', 'Варвара', 'Витальевна', '2004-03-19', 'Санкт-Петербург, ул.Пролетарская, д.65, кв.94', 'В', 'Ж', 'Санкт-Петербург', '84568673939', 'baby2002@gmail.com', 'user'),
(7, '1293953', '4040', 'Романов', 'Петр', 'Петрович', '2001-01-01', 'Санкт-Петербург, ул.Дворцовая, д.1, кв.10', 'А', 'М', 'Санкт-Петербург', '89041918899', 'Imperat0rRusi@mail.ru', 'user'),
(8, '11111', 'admin', 'Сергеев', 'Иван', 'Дмитриевич', '1996-03-07', 'Санкт-Петербург,ул.Древесная,д.6,кв.9', '', 'М', 'Санкт-Петербург', '89048672945', 'foster@mail.ru', 'admin'),
(9, '475939', '1010', 'Екатеринин', 'Григорий', 'Петрович', '2003-12-19', 'Санкт-Петербург, ул.Дворцовая, д.4, кв.7', 'Г', 'М', 'Санкт-Петербург', '89056473859', 'DrugK0r0lya@mail.ru', 'user'),
(10, '7548758', '2020', 'Екатеринская', 'Мария', 'Петровна', '2000-09-29', 'Санкт-Петербург, ул.Рождественская, д.5, кв.57', 'Б', 'Ж', 'Санкт-Петербург', '89068473949', 'Gladiator@gmail.com', 'user'),
(11, '565656565656', '555', 'ghf', 'ghfg', 'fghfgh', '2024-07-09', '', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Структура таблицы `work`
--

CREATE TABLE `work` (
  `id` int(11) NOT NULL,
  `document_number` int(11) NOT NULL,
  `name_of_work_organization` varchar(200) NOT NULL,
  `work_organization_address` varchar(200) NOT NULL,
  `job_title` varchar(100) NOT NULL,
  `work's status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `work`
--

INSERT INTO `work` (`id`, `document_number`, `name_of_work_organization`, `work_organization_address`, `job_title`, `work's status`) VALUES
(1, 5353, 'ООО\"Метрополь\"', 'Санкт-Петербург, ул. Новая, 7', 'Программист', 'нынешнее место работы'),
(2, 123456789, 'ОАО\"Сколково\"', 'Москва, ул.Старая, 9', 'Бухгалтер', 'нынешнее место работы');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `date_medical_data`
--
ALTER TABLE `date_medical_data`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `education`
--
ALTER TABLE `education`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `literature`
--
ALTER TABLE `literature`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `medical_checkup`
--
ALTER TABLE `medical_checkup`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `work`
--
ALTER TABLE `work`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `date_medical_data`
--
ALTER TABLE `date_medical_data`
  MODIFY `id` int(250) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `education`
--
ALTER TABLE `education`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `literature`
--
ALTER TABLE `literature`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `medical_checkup`
--
ALTER TABLE `medical_checkup`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `work`
--
ALTER TABLE `work`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
