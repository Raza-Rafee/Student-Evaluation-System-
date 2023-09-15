-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 05, 2021 at 09:32 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tuts_dbcurriculumn`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblauto`
--

CREATE TABLE `tblauto` (
  `id` int(11) NOT NULL,
  `autostart` varchar(30) NOT NULL,
  `autoend` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblauto`
--

INSERT INTO `tblauto` (`id`, `autostart`, `autoend`) VALUES
(1, '100', 35),
(2, '0', 8);

-- --------------------------------------------------------

--
-- Table structure for table `tblcourse`
--

CREATE TABLE `tblcourse` (
  `CourseId` int(11) NOT NULL,
  `Course` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcourse`
--

INSERT INTO `tblcourse` (`CourseId`, `Course`) VALUES
(1, 'BSIT'),
(5, 'BEED'),
(6, 'BSBA'),
(7, 'BSCRIM'),
(8, 'BSED'),
(9, 'BSFI');

-- --------------------------------------------------------

--
-- Table structure for table `tblcurriculum`
--

CREATE TABLE `tblcurriculum` (
  `CurriculumId` int(11) NOT NULL,
  `SubjectId` int(11) NOT NULL,
  `CourseId` int(11) NOT NULL,
  `Semester` varchar(35) NOT NULL,
  `YearLevel` varchar(32) NOT NULL,
  `AcademicYear` varchar(30) NOT NULL,
  `PreRequisite` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcurriculum`
--

INSERT INTO `tblcurriculum` (`CurriculumId`, `SubjectId`, `CourseId`, `Semester`, `YearLevel`, `AcademicYear`, `PreRequisite`) VALUES
(1, 1, 1, 'First', 'First', '2016-2017', 'None'),
(2, 2, 1, 'First', 'First', '2016-2017', 'None'),
(3, 1, 1, 'First', 'Second', '2016-2017', 'ENG 11'),
(4, 1, 1, 'Second', 'First', '2016-2017', 'None'),
(5, 2, 2, 'First', 'First', '2016-2017', 'None'),
(6, 2, 2, 'First', 'Second', '2016-2017', 'MATH 11');

-- --------------------------------------------------------

--
-- Table structure for table `tblgrades`
--

CREATE TABLE `tblgrades` (
  `GradesId` int(11) NOT NULL,
  `CourseId` int(11) NOT NULL,
  `IdNo` varchar(90) NOT NULL,
  `SubjectId` int(11) NOT NULL,
  `Grades` double NOT NULL,
  `YearLevel` varchar(32) NOT NULL,
  `Sem` varchar(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblgrades`
--

INSERT INTO `tblgrades` (`GradesId`, `CourseId`, `IdNo`, `SubjectId`, `Grades`, `YearLevel`, `Sem`) VALUES
(1, 1, '123123', 3, 1, 'First', 'First'),
(2, 1, '123123', 4, 2, 'First', 'First'),
(3, 1, '123123', 5, 2, 'First', 'First'),
(4, 1, '123123', 6, 2, 'First', 'First'),
(5, 1, '123123', 7, 2.3, 'First', 'First'),
(6, 1, '123123', 8, 2.1, 'First', 'First'),
(7, 1, '123123', 9, 1.3, 'First', 'First'),
(8, 1, '123123', 10, 0, 'First', 'Second'),
(9, 1, '123123', 11, 0, 'First', 'Second'),
(10, 1, '123123', 12, 0, 'First', 'Second'),
(11, 1, '123123', 13, 0, 'First', 'Second'),
(12, 1, '123123', 14, 0, 'First', 'Second'),
(13, 1, '123123', 15, 0, 'First', 'Second'),
(14, 1, '123123', 16, 0, 'First', 'Second'),
(15, 1, '123123', 17, 0, 'First', 'Second'),
(16, 1, '123123', 18, 0, 'First', 'Second'),
(17, 1, '123123', 19, 0, 'Second', 'First'),
(18, 1, '123123', 20, 0, 'Second', 'First'),
(19, 1, '123123', 21, 0, 'Second', 'First'),
(20, 1, '123123', 22, 0, 'Second', 'First'),
(21, 1, '123123', 23, 0, 'Second', 'First'),
(22, 1, '123123', 24, 0, 'Second', 'First'),
(23, 1, '123123', 25, 0, 'Second', 'First'),
(24, 1, '123123', 26, 0, 'Second', 'First'),
(25, 1, '123123', 27, 0, 'Second', 'First'),
(26, 1, '123123', 28, 0, 'Second', 'Second'),
(27, 1, '123123', 29, 0, 'Second', 'Second'),
(28, 1, '123123', 30, 0, 'Second', 'Second'),
(29, 1, '123123', 31, 0, 'Second', 'Second'),
(30, 1, '123123', 32, 0, 'Second', 'Second'),
(31, 1, '123123', 33, 0, 'Second', 'Second'),
(32, 1, '123123', 34, 0, 'Second', 'Second'),
(33, 1, '123123', 35, 0, 'Second', 'Second'),
(34, 1, '123123', 36, 0, 'Third', 'First'),
(35, 1, '123123', 37, 0, 'Third', 'First'),
(36, 1, '123123', 38, 0, 'Third', 'First'),
(37, 1, '123123', 39, 0, 'Third', 'First'),
(38, 1, '123123', 40, 0, 'Third', 'First'),
(39, 1, '123123', 41, 0, 'Third', 'First'),
(40, 1, '123123', 42, 0, 'Third', 'First'),
(41, 1, '123123', 43, 0, 'Third', 'First'),
(42, 1, '123123', 44, 0, 'Third', 'Second'),
(43, 1, '123123', 45, 0, 'Third', 'Second'),
(44, 1, '123123', 46, 0, 'Third', 'Second'),
(45, 1, '123123', 47, 0, 'Third', 'Second'),
(46, 1, '123123', 48, 0, 'Third', 'Second'),
(47, 1, '123123', 49, 0, 'Third', 'Second'),
(48, 1, '123123', 50, 0, 'Third', 'Second'),
(49, 1, '123123', 51, 0, 'Third', 'Second'),
(50, 1, '123123', 52, 0, 'Fourth', 'First'),
(51, 1, '123123', 53, 0, 'Fourth', 'First'),
(52, 1, '123123', 54, 0, 'Fourth', 'First'),
(53, 1, '123123', 55, 0, 'Fourth', 'First'),
(54, 1, '123123', 56, 0, 'Fourth', 'First'),
(55, 1, '123123', 57, 0, 'Fourth', 'First'),
(56, 1, '123123', 58, 0, 'Fourth', 'Second'),
(57, 1, '123123', 59, 1.1, 'First', 'First'),
(58, 1, '123123', 60, 1.2, 'First', 'First'),
(59, 1, '1234322', 3, 3.2, 'First', 'First'),
(60, 1, '1234322', 4, 2, 'First', 'First'),
(61, 1, '1234322', 5, 3.6, 'First', 'First'),
(62, 1, '1234322', 6, 1, 'First', 'First'),
(63, 1, '1234322', 7, 2.1, 'First', 'First'),
(64, 1, '1234322', 8, 2, 'First', 'First'),
(65, 1, '1234322', 9, 3, 'First', 'First'),
(66, 1, '1234322', 10, 0, 'First', 'Second'),
(67, 1, '1234322', 11, 0, 'First', 'Second'),
(68, 1, '1234322', 12, 0, 'First', 'Second'),
(69, 1, '1234322', 13, 0, 'First', 'Second'),
(70, 1, '1234322', 14, 0, 'First', 'Second'),
(71, 1, '1234322', 15, 0, 'First', 'Second'),
(72, 1, '1234322', 16, 0, 'First', 'Second'),
(73, 1, '1234322', 17, 0, 'First', 'Second'),
(74, 1, '1234322', 18, 0, 'First', 'Second'),
(75, 1, '1234322', 19, 0, 'Second', 'First'),
(76, 1, '1234322', 20, 0, 'Second', 'First'),
(77, 1, '1234322', 21, 0, 'Second', 'First'),
(78, 1, '1234322', 22, 0, 'Second', 'First'),
(79, 1, '1234322', 23, 0, 'Second', 'First'),
(80, 1, '1234322', 24, 0, 'Second', 'First'),
(81, 1, '1234322', 25, 0, 'Second', 'First'),
(82, 1, '1234322', 26, 0, 'Second', 'First'),
(83, 1, '1234322', 27, 0, 'Second', 'First'),
(84, 1, '1234322', 28, 0, 'Second', 'Second'),
(85, 1, '1234322', 29, 0, 'Second', 'Second'),
(86, 1, '1234322', 30, 0, 'Second', 'Second'),
(87, 1, '1234322', 31, 0, 'Second', 'Second'),
(88, 1, '1234322', 32, 0, 'Second', 'Second'),
(89, 1, '1234322', 33, 0, 'Second', 'Second'),
(90, 1, '1234322', 34, 0, 'Second', 'Second'),
(91, 1, '1234322', 35, 0, 'Second', 'Second'),
(92, 1, '1234322', 36, 0, 'Third', 'First'),
(93, 1, '1234322', 37, 0, 'Third', 'First'),
(94, 1, '1234322', 38, 0, 'Third', 'First'),
(95, 1, '1234322', 39, 0, 'Third', 'First'),
(96, 1, '1234322', 40, 0, 'Third', 'First'),
(97, 1, '1234322', 41, 0, 'Third', 'First'),
(98, 1, '1234322', 42, 0, 'Third', 'First'),
(99, 1, '1234322', 43, 0, 'Third', 'First'),
(100, 1, '1234322', 44, 0, 'Third', 'Second'),
(101, 1, '1234322', 45, 0, 'Third', 'Second'),
(102, 1, '1234322', 46, 0, 'Third', 'Second'),
(103, 1, '1234322', 47, 0, 'Third', 'Second'),
(104, 1, '1234322', 48, 0, 'Third', 'Second'),
(105, 1, '1234322', 49, 0, 'Third', 'Second'),
(106, 1, '1234322', 50, 0, 'Third', 'Second'),
(107, 1, '1234322', 51, 0, 'Third', 'Second'),
(108, 1, '1234322', 52, 0, 'Fourth', 'First'),
(109, 1, '1234322', 53, 0, 'Fourth', 'First'),
(110, 1, '1234322', 54, 0, 'Fourth', 'First'),
(111, 1, '1234322', 55, 0, 'Fourth', 'First'),
(112, 1, '1234322', 56, 0, 'Fourth', 'First'),
(113, 1, '1234322', 57, 0, 'Fourth', 'First'),
(114, 1, '1234322', 58, 0, 'Fourth', 'Second'),
(115, 1, '1234322', 59, 1.1, 'First', 'First'),
(116, 1, '1234322', 60, 1.3, 'First', 'First'),
(117, 1, '312312312', 3, 0, 'First', 'First'),
(118, 1, '312312312', 4, 0, 'First', 'First'),
(119, 1, '312312312', 5, 0, 'First', 'First'),
(120, 1, '312312312', 6, 0, 'First', 'First'),
(121, 1, '312312312', 7, 0, 'First', 'First'),
(122, 1, '312312312', 8, 0, 'First', 'First'),
(123, 1, '312312312', 9, 0, 'First', 'First'),
(124, 1, '312312312', 10, 0, 'First', 'Second'),
(125, 1, '312312312', 11, 0, 'First', 'Second'),
(126, 1, '312312312', 12, 0, 'First', 'Second'),
(127, 1, '312312312', 13, 0, 'First', 'Second'),
(128, 1, '312312312', 14, 0, 'First', 'Second'),
(129, 1, '312312312', 15, 0, 'First', 'Second'),
(130, 1, '312312312', 16, 0, 'First', 'Second'),
(131, 1, '312312312', 17, 0, 'First', 'Second'),
(132, 1, '312312312', 18, 0, 'First', 'Second'),
(133, 1, '312312312', 19, 0, 'Second', 'First'),
(134, 1, '312312312', 20, 0, 'Second', 'First'),
(135, 1, '312312312', 21, 0, 'Second', 'First'),
(136, 1, '312312312', 22, 0, 'Second', 'First'),
(137, 1, '312312312', 23, 0, 'Second', 'First'),
(138, 1, '312312312', 24, 0, 'Second', 'First'),
(139, 1, '312312312', 25, 0, 'Second', 'First'),
(140, 1, '312312312', 26, 0, 'Second', 'First'),
(141, 1, '312312312', 27, 0, 'Second', 'First'),
(142, 1, '312312312', 28, 0, 'Second', 'Second'),
(143, 1, '312312312', 29, 0, 'Second', 'Second'),
(144, 1, '312312312', 30, 0, 'Second', 'Second'),
(145, 1, '312312312', 31, 0, 'Second', 'Second'),
(146, 1, '312312312', 32, 0, 'Second', 'Second'),
(147, 1, '312312312', 33, 0, 'Second', 'Second'),
(148, 1, '312312312', 34, 0, 'Second', 'Second'),
(149, 1, '312312312', 35, 0, 'Second', 'Second'),
(150, 1, '312312312', 36, 0, 'Third', 'First'),
(151, 1, '312312312', 37, 0, 'Third', 'First'),
(152, 1, '312312312', 38, 0, 'Third', 'First'),
(153, 1, '312312312', 39, 0, 'Third', 'First'),
(154, 1, '312312312', 40, 0, 'Third', 'First'),
(155, 1, '312312312', 41, 0, 'Third', 'First'),
(156, 1, '312312312', 42, 0, 'Third', 'First'),
(157, 1, '312312312', 43, 0, 'Third', 'First'),
(158, 1, '312312312', 44, 0, 'Third', 'Second'),
(159, 1, '312312312', 45, 0, 'Third', 'Second'),
(160, 1, '312312312', 46, 0, 'Third', 'Second'),
(161, 1, '312312312', 47, 0, 'Third', 'Second'),
(162, 1, '312312312', 48, 0, 'Third', 'Second'),
(163, 1, '312312312', 49, 0, 'Third', 'Second'),
(164, 1, '312312312', 50, 0, 'Third', 'Second'),
(165, 1, '312312312', 51, 0, 'Third', 'Second'),
(166, 1, '312312312', 52, 0, 'Fourth', 'First'),
(167, 1, '312312312', 53, 0, 'Fourth', 'First'),
(168, 1, '312312312', 54, 0, 'Fourth', 'First'),
(169, 1, '312312312', 55, 0, 'Fourth', 'First'),
(170, 1, '312312312', 56, 0, 'Fourth', 'First'),
(171, 1, '312312312', 57, 0, 'Fourth', 'First'),
(172, 1, '312312312', 58, 0, 'Fourth', 'Second'),
(173, 1, '312312312', 59, 0, 'First', 'First'),
(174, 1, '312312312', 60, 0, 'First', 'First'),
(175, 1, '121031', 3, 0, 'First', 'First'),
(176, 1, '121031', 4, 0, 'First', 'First'),
(177, 1, '121031', 5, 0, 'First', 'First'),
(178, 1, '121031', 6, 0, 'First', 'First'),
(179, 1, '121031', 7, 0, 'First', 'First'),
(180, 1, '121031', 8, 0, 'First', 'First'),
(181, 1, '121031', 9, 0, 'First', 'First'),
(182, 1, '121031', 10, 0, 'First', 'Second'),
(183, 1, '121031', 11, 0, 'First', 'Second'),
(184, 1, '121031', 12, 0, 'First', 'Second'),
(185, 1, '121031', 13, 0, 'First', 'Second'),
(186, 1, '121031', 14, 0, 'First', 'Second'),
(187, 1, '121031', 15, 0, 'First', 'Second'),
(188, 1, '121031', 16, 0, 'First', 'Second'),
(189, 1, '121031', 17, 0, 'First', 'Second'),
(190, 1, '121031', 18, 0, 'First', 'Second'),
(191, 1, '121031', 19, 0, 'Second', 'First'),
(192, 1, '121031', 20, 0, 'Second', 'First'),
(193, 1, '121031', 21, 0, 'Second', 'First'),
(194, 1, '121031', 22, 0, 'Second', 'First'),
(195, 1, '121031', 23, 0, 'Second', 'First'),
(196, 1, '121031', 24, 0, 'Second', 'First'),
(197, 1, '121031', 25, 0, 'Second', 'First'),
(198, 1, '121031', 26, 0, 'Second', 'First'),
(199, 1, '121031', 27, 0, 'Second', 'First'),
(200, 1, '121031', 28, 0, 'Second', 'Second'),
(201, 1, '121031', 29, 0, 'Second', 'Second'),
(202, 1, '121031', 30, 0, 'Second', 'Second'),
(203, 1, '121031', 31, 0, 'Second', 'Second'),
(204, 1, '121031', 32, 0, 'Second', 'Second'),
(205, 1, '121031', 33, 0, 'Second', 'Second'),
(206, 1, '121031', 34, 0, 'Second', 'Second'),
(207, 1, '121031', 35, 0, 'Second', 'Second'),
(208, 1, '121031', 36, 0, 'Third', 'First'),
(209, 1, '121031', 37, 0, 'Third', 'First'),
(210, 1, '121031', 38, 0, 'Third', 'First'),
(211, 1, '121031', 39, 0, 'Third', 'First'),
(212, 1, '121031', 40, 0, 'Third', 'First'),
(213, 1, '121031', 41, 0, 'Third', 'First'),
(214, 1, '121031', 42, 0, 'Third', 'First'),
(215, 1, '121031', 43, 0, 'Third', 'First'),
(216, 1, '121031', 44, 0, 'Third', 'Second'),
(217, 1, '121031', 45, 0, 'Third', 'Second'),
(218, 1, '121031', 46, 0, 'Third', 'Second'),
(219, 1, '121031', 47, 0, 'Third', 'Second'),
(220, 1, '121031', 48, 0, 'Third', 'Second'),
(221, 1, '121031', 49, 0, 'Third', 'Second'),
(222, 1, '121031', 50, 0, 'Third', 'Second'),
(223, 1, '121031', 51, 0, 'Third', 'Second'),
(224, 1, '121031', 52, 0, 'Fourth', 'First'),
(225, 1, '121031', 53, 0, 'Fourth', 'First'),
(226, 1, '121031', 54, 0, 'Fourth', 'First'),
(227, 1, '121031', 55, 0, 'Fourth', 'First'),
(228, 1, '121031', 56, 0, 'Fourth', 'First'),
(229, 1, '121031', 57, 0, 'Fourth', 'First'),
(230, 1, '121031', 58, 0, 'Fourth', 'Second'),
(231, 1, '121031', 59, 0, 'First', 'First'),
(232, 1, '121031', 60, 0, 'First', 'First'),
(233, 1, '312312290', 3, 0, 'First', 'First'),
(234, 1, '312312290', 4, 0, 'First', 'First'),
(235, 1, '312312290', 5, 0, 'First', 'First'),
(236, 1, '312312290', 6, 0, 'First', 'First'),
(237, 1, '312312290', 7, 0, 'First', 'First'),
(238, 1, '312312290', 8, 0, 'First', 'First'),
(239, 1, '312312290', 9, 0, 'First', 'First'),
(240, 1, '312312290', 10, 0, 'First', 'Second'),
(241, 1, '312312290', 11, 0, 'First', 'Second'),
(242, 1, '312312290', 12, 0, 'First', 'Second'),
(243, 1, '312312290', 13, 0, 'First', 'Second'),
(244, 1, '312312290', 14, 0, 'First', 'Second'),
(245, 1, '312312290', 15, 0, 'First', 'Second'),
(246, 1, '312312290', 16, 0, 'First', 'Second'),
(247, 1, '312312290', 17, 0, 'First', 'Second'),
(248, 1, '312312290', 18, 0, 'First', 'Second'),
(249, 1, '312312290', 19, 0, 'Second', 'First'),
(250, 1, '312312290', 20, 0, 'Second', 'First'),
(251, 1, '312312290', 21, 0, 'Second', 'First'),
(252, 1, '312312290', 22, 0, 'Second', 'First'),
(253, 1, '312312290', 23, 0, 'Second', 'First'),
(254, 1, '312312290', 24, 0, 'Second', 'First'),
(255, 1, '312312290', 25, 0, 'Second', 'First'),
(256, 1, '312312290', 26, 0, 'Second', 'First'),
(257, 1, '312312290', 27, 0, 'Second', 'First'),
(258, 1, '312312290', 28, 0, 'Second', 'Second'),
(259, 1, '312312290', 29, 0, 'Second', 'Second'),
(260, 1, '312312290', 30, 0, 'Second', 'Second'),
(261, 1, '312312290', 31, 0, 'Second', 'Second'),
(262, 1, '312312290', 32, 0, 'Second', 'Second'),
(263, 1, '312312290', 33, 0, 'Second', 'Second'),
(264, 1, '312312290', 34, 0, 'Second', 'Second'),
(265, 1, '312312290', 35, 0, 'Second', 'Second'),
(266, 1, '312312290', 36, 0, 'Third', 'First'),
(267, 1, '312312290', 37, 0, 'Third', 'First'),
(268, 1, '312312290', 38, 0, 'Third', 'First'),
(269, 1, '312312290', 39, 0, 'Third', 'First'),
(270, 1, '312312290', 40, 0, 'Third', 'First'),
(271, 1, '312312290', 41, 0, 'Third', 'First'),
(272, 1, '312312290', 42, 0, 'Third', 'First'),
(273, 1, '312312290', 43, 0, 'Third', 'First'),
(274, 1, '312312290', 44, 0, 'Third', 'Second'),
(275, 1, '312312290', 45, 0, 'Third', 'Second'),
(276, 1, '312312290', 46, 0, 'Third', 'Second'),
(277, 1, '312312290', 47, 0, 'Third', 'Second'),
(278, 1, '312312290', 48, 0, 'Third', 'Second'),
(279, 1, '312312290', 49, 0, 'Third', 'Second'),
(280, 1, '312312290', 50, 0, 'Third', 'Second'),
(281, 1, '312312290', 51, 0, 'Third', 'Second'),
(282, 1, '312312290', 52, 0, 'Fourth', 'First'),
(283, 1, '312312290', 53, 0, 'Fourth', 'First'),
(284, 1, '312312290', 54, 0, 'Fourth', 'First'),
(285, 1, '312312290', 55, 0, 'Fourth', 'First'),
(286, 1, '312312290', 56, 0, 'Fourth', 'First'),
(287, 1, '312312290', 57, 0, 'Fourth', 'First'),
(288, 1, '312312290', 58, 0, 'Fourth', 'Second'),
(289, 1, '312312290', 59, 0, 'First', 'First'),
(290, 1, '312312290', 60, 0, 'First', 'First'),
(291, 1, '312312312-32', 3, 0, 'First', 'First'),
(292, 1, '312312312-32', 4, 0, 'First', 'First'),
(293, 1, '312312312-32', 5, 0, 'First', 'First'),
(294, 1, '312312312-32', 6, 0, 'First', 'First'),
(295, 1, '312312312-32', 7, 0, 'First', 'First'),
(296, 1, '312312312-32', 8, 0, 'First', 'First'),
(297, 1, '312312312-32', 9, 0, 'First', 'First'),
(298, 1, '312312312-32', 10, 0, 'First', 'Second'),
(299, 1, '312312312-32', 11, 0, 'First', 'Second'),
(300, 1, '312312312-32', 12, 0, 'First', 'Second'),
(301, 1, '312312312-32', 13, 0, 'First', 'Second'),
(302, 1, '312312312-32', 14, 0, 'First', 'Second'),
(303, 1, '312312312-32', 15, 0, 'First', 'Second'),
(304, 1, '312312312-32', 16, 0, 'First', 'Second'),
(305, 1, '312312312-32', 17, 0, 'First', 'Second'),
(306, 1, '312312312-32', 18, 0, 'First', 'Second'),
(307, 1, '312312312-32', 19, 0, 'Second', 'First'),
(308, 1, '312312312-32', 20, 0, 'Second', 'First'),
(309, 1, '312312312-32', 21, 0, 'Second', 'First'),
(310, 1, '312312312-32', 22, 0, 'Second', 'First'),
(311, 1, '312312312-32', 23, 0, 'Second', 'First'),
(312, 1, '312312312-32', 24, 0, 'Second', 'First'),
(313, 1, '312312312-32', 25, 0, 'Second', 'First'),
(314, 1, '312312312-32', 26, 0, 'Second', 'First'),
(315, 1, '312312312-32', 27, 0, 'Second', 'First'),
(316, 1, '312312312-32', 28, 0, 'Second', 'Second'),
(317, 1, '312312312-32', 29, 0, 'Second', 'Second'),
(318, 1, '312312312-32', 30, 0, 'Second', 'Second'),
(319, 1, '312312312-32', 31, 0, 'Second', 'Second'),
(320, 1, '312312312-32', 32, 0, 'Second', 'Second'),
(321, 1, '312312312-32', 33, 0, 'Second', 'Second'),
(322, 1, '312312312-32', 34, 0, 'Second', 'Second'),
(323, 1, '312312312-32', 35, 0, 'Second', 'Second'),
(324, 1, '312312312-32', 36, 0, 'Third', 'First'),
(325, 1, '312312312-32', 37, 0, 'Third', 'First'),
(326, 1, '312312312-32', 38, 0, 'Third', 'First'),
(327, 1, '312312312-32', 39, 0, 'Third', 'First'),
(328, 1, '312312312-32', 40, 0, 'Third', 'First'),
(329, 1, '312312312-32', 41, 0, 'Third', 'First'),
(330, 1, '312312312-32', 42, 0, 'Third', 'First'),
(331, 1, '312312312-32', 43, 0, 'Third', 'First'),
(332, 1, '312312312-32', 44, 0, 'Third', 'Second'),
(333, 1, '312312312-32', 45, 0, 'Third', 'Second'),
(334, 1, '312312312-32', 46, 0, 'Third', 'Second'),
(335, 1, '312312312-32', 47, 0, 'Third', 'Second'),
(336, 1, '312312312-32', 48, 0, 'Third', 'Second'),
(337, 1, '312312312-32', 49, 0, 'Third', 'Second'),
(338, 1, '312312312-32', 50, 0, 'Third', 'Second'),
(339, 1, '312312312-32', 51, 0, 'Third', 'Second'),
(340, 1, '312312312-32', 52, 0, 'Fourth', 'First'),
(341, 1, '312312312-32', 53, 0, 'Fourth', 'First'),
(342, 1, '312312312-32', 54, 0, 'Fourth', 'First'),
(343, 1, '312312312-32', 55, 0, 'Fourth', 'First'),
(344, 1, '312312312-32', 56, 0, 'Fourth', 'First'),
(345, 1, '312312312-32', 57, 0, 'Fourth', 'First'),
(346, 1, '312312312-32', 58, 0, 'Fourth', 'Second'),
(347, 1, '312312312-32', 59, 0, 'First', 'First'),
(348, 1, '312312312-32', 60, 0, 'First', 'First'),
(349, 1, '312312312-32', 3, 0, 'First', 'First'),
(350, 1, '312312312-32', 4, 0, 'First', 'First'),
(351, 1, '312312312-32', 5, 0, 'First', 'First'),
(352, 1, '312312312-32', 6, 0, 'First', 'First'),
(353, 1, '312312312-32', 7, 0, 'First', 'First'),
(354, 1, '312312312-32', 8, 0, 'First', 'First'),
(355, 1, '312312312-32', 9, 0, 'First', 'First'),
(356, 1, '312312312-32', 10, 0, 'First', 'Second'),
(357, 1, '312312312-32', 11, 0, 'First', 'Second'),
(358, 1, '312312312-32', 12, 0, 'First', 'Second'),
(359, 1, '312312312-32', 13, 0, 'First', 'Second'),
(360, 1, '312312312-32', 14, 0, 'First', 'Second'),
(361, 1, '312312312-32', 15, 0, 'First', 'Second'),
(362, 1, '312312312-32', 16, 0, 'First', 'Second'),
(363, 1, '312312312-32', 17, 0, 'First', 'Second'),
(364, 1, '312312312-32', 18, 0, 'First', 'Second'),
(365, 1, '312312312-32', 19, 0, 'Second', 'First'),
(366, 1, '312312312-32', 20, 0, 'Second', 'First'),
(367, 1, '312312312-32', 21, 0, 'Second', 'First'),
(368, 1, '312312312-32', 22, 0, 'Second', 'First'),
(369, 1, '312312312-32', 23, 0, 'Second', 'First'),
(370, 1, '312312312-32', 24, 0, 'Second', 'First'),
(371, 1, '312312312-32', 25, 0, 'Second', 'First'),
(372, 1, '312312312-32', 26, 0, 'Second', 'First'),
(373, 1, '312312312-32', 27, 0, 'Second', 'First'),
(374, 1, '312312312-32', 28, 0, 'Second', 'Second'),
(375, 1, '312312312-32', 29, 0, 'Second', 'Second'),
(376, 1, '312312312-32', 30, 0, 'Second', 'Second'),
(377, 1, '312312312-32', 31, 0, 'Second', 'Second'),
(378, 1, '312312312-32', 32, 0, 'Second', 'Second'),
(379, 1, '312312312-32', 33, 0, 'Second', 'Second'),
(380, 1, '312312312-32', 34, 0, 'Second', 'Second'),
(381, 1, '312312312-32', 35, 0, 'Second', 'Second'),
(382, 1, '312312312-32', 36, 0, 'Third', 'First'),
(383, 1, '312312312-32', 37, 0, 'Third', 'First'),
(384, 1, '312312312-32', 38, 0, 'Third', 'First'),
(385, 1, '312312312-32', 39, 0, 'Third', 'First'),
(386, 1, '312312312-32', 40, 0, 'Third', 'First'),
(387, 1, '312312312-32', 41, 0, 'Third', 'First'),
(388, 1, '312312312-32', 42, 0, 'Third', 'First'),
(389, 1, '312312312-32', 43, 0, 'Third', 'First'),
(390, 1, '312312312-32', 44, 0, 'Third', 'Second'),
(391, 1, '312312312-32', 45, 0, 'Third', 'Second'),
(392, 1, '312312312-32', 46, 0, 'Third', 'Second'),
(393, 1, '312312312-32', 47, 0, 'Third', 'Second'),
(394, 1, '312312312-32', 48, 0, 'Third', 'Second'),
(395, 1, '312312312-32', 49, 0, 'Third', 'Second'),
(396, 1, '312312312-32', 50, 0, 'Third', 'Second'),
(397, 1, '312312312-32', 51, 0, 'Third', 'Second'),
(398, 1, '312312312-32', 52, 0, 'Fourth', 'First'),
(399, 1, '312312312-32', 53, 0, 'Fourth', 'First'),
(400, 1, '312312312-32', 54, 0, 'Fourth', 'First'),
(401, 1, '312312312-32', 55, 0, 'Fourth', 'First'),
(402, 1, '312312312-32', 56, 0, 'Fourth', 'First'),
(403, 1, '312312312-32', 57, 0, 'Fourth', 'First'),
(404, 1, '312312312-32', 58, 0, 'Fourth', 'Second'),
(405, 1, '312312312-32', 59, 0, 'First', 'First'),
(406, 1, '312312312-32', 60, 0, 'First', 'First'),
(407, 1, '12122', 3, 0, 'First', 'First'),
(408, 1, '12122', 4, 0, 'First', 'First'),
(409, 1, '12122', 5, 0, 'First', 'First'),
(410, 1, '12122', 6, 0, 'First', 'First'),
(411, 1, '12122', 7, 0, 'First', 'First'),
(412, 1, '12122', 8, 0, 'First', 'First'),
(413, 1, '12122', 9, 0, 'First', 'First'),
(414, 1, '12122', 10, 0, 'First', 'Second'),
(415, 1, '12122', 11, 0, 'First', 'Second'),
(416, 1, '12122', 12, 0, 'First', 'Second'),
(417, 1, '12122', 13, 0, 'First', 'Second'),
(418, 1, '12122', 14, 0, 'First', 'Second'),
(419, 1, '12122', 15, 0, 'First', 'Second'),
(420, 1, '12122', 16, 0, 'First', 'Second'),
(421, 1, '12122', 17, 0, 'First', 'Second'),
(422, 1, '12122', 18, 0, 'First', 'Second'),
(423, 1, '12122', 19, 0, 'Second', 'First'),
(424, 1, '12122', 20, 0, 'Second', 'First'),
(425, 1, '12122', 21, 0, 'Second', 'First'),
(426, 1, '12122', 22, 0, 'Second', 'First'),
(427, 1, '12122', 23, 0, 'Second', 'First'),
(428, 1, '12122', 24, 0, 'Second', 'First'),
(429, 1, '12122', 25, 0, 'Second', 'First'),
(430, 1, '12122', 26, 0, 'Second', 'First'),
(431, 1, '12122', 27, 0, 'Second', 'First'),
(432, 1, '12122', 28, 0, 'Second', 'Second'),
(433, 1, '12122', 29, 0, 'Second', 'Second'),
(434, 1, '12122', 30, 0, 'Second', 'Second'),
(435, 1, '12122', 31, 0, 'Second', 'Second'),
(436, 1, '12122', 32, 0, 'Second', 'Second'),
(437, 1, '12122', 33, 0, 'Second', 'Second'),
(438, 1, '12122', 34, 0, 'Second', 'Second'),
(439, 1, '12122', 35, 0, 'Second', 'Second'),
(440, 1, '12122', 36, 0, 'Third', 'First'),
(441, 1, '12122', 37, 0, 'Third', 'First'),
(442, 1, '12122', 38, 0, 'Third', 'First'),
(443, 1, '12122', 39, 0, 'Third', 'First'),
(444, 1, '12122', 40, 0, 'Third', 'First'),
(445, 1, '12122', 41, 0, 'Third', 'First'),
(446, 1, '12122', 42, 0, 'Third', 'First'),
(447, 1, '12122', 43, 0, 'Third', 'First'),
(448, 1, '12122', 44, 0, 'Third', 'Second'),
(449, 1, '12122', 45, 0, 'Third', 'Second'),
(450, 1, '12122', 46, 0, 'Third', 'Second'),
(451, 1, '12122', 47, 0, 'Third', 'Second'),
(452, 1, '12122', 48, 0, 'Third', 'Second'),
(453, 1, '12122', 49, 0, 'Third', 'Second'),
(454, 1, '12122', 50, 0, 'Third', 'Second'),
(455, 1, '12122', 51, 0, 'Third', 'Second'),
(456, 1, '12122', 52, 0, 'Fourth', 'First'),
(457, 1, '12122', 53, 0, 'Fourth', 'First'),
(458, 1, '12122', 54, 0, 'Fourth', 'First'),
(459, 1, '12122', 55, 0, 'Fourth', 'First'),
(460, 1, '12122', 56, 0, 'Fourth', 'First'),
(461, 1, '12122', 57, 0, 'Fourth', 'First'),
(462, 1, '12122', 58, 0, 'Fourth', 'Second'),
(463, 1, '12122', 59, 0, 'First', 'First'),
(464, 1, '12122', 60, 0, 'First', 'First'),
(465, 1, '12112', 3, 0, 'First', 'First'),
(466, 1, '12112', 4, 0, 'First', 'First'),
(467, 1, '12112', 5, 0, 'First', 'First'),
(468, 1, '12112', 6, 0, 'First', 'First'),
(469, 1, '12112', 7, 0, 'First', 'First'),
(470, 1, '12112', 8, 0, 'First', 'First'),
(471, 1, '12112', 9, 0, 'First', 'First'),
(472, 1, '12112', 10, 0, 'First', 'Second'),
(473, 1, '12112', 11, 0, 'First', 'Second'),
(474, 1, '12112', 12, 0, 'First', 'Second'),
(475, 1, '12112', 13, 0, 'First', 'Second'),
(476, 1, '12112', 14, 0, 'First', 'Second'),
(477, 1, '12112', 15, 0, 'First', 'Second'),
(478, 1, '12112', 16, 0, 'First', 'Second'),
(479, 1, '12112', 17, 0, 'First', 'Second'),
(480, 1, '12112', 18, 0, 'First', 'Second'),
(481, 1, '12112', 19, 0, 'Second', 'First'),
(482, 1, '12112', 20, 0, 'Second', 'First'),
(483, 1, '12112', 21, 0, 'Second', 'First'),
(484, 1, '12112', 22, 0, 'Second', 'First'),
(485, 1, '12112', 23, 0, 'Second', 'First'),
(486, 1, '12112', 24, 0, 'Second', 'First'),
(487, 1, '12112', 25, 0, 'Second', 'First'),
(488, 1, '12112', 26, 0, 'Second', 'First'),
(489, 1, '12112', 27, 0, 'Second', 'First'),
(490, 1, '12112', 28, 0, 'Second', 'Second'),
(491, 1, '12112', 29, 0, 'Second', 'Second'),
(492, 1, '12112', 30, 0, 'Second', 'Second'),
(493, 1, '12112', 31, 0, 'Second', 'Second'),
(494, 1, '12112', 32, 0, 'Second', 'Second'),
(495, 1, '12112', 33, 0, 'Second', 'Second'),
(496, 1, '12112', 34, 0, 'Second', 'Second'),
(497, 1, '12112', 35, 0, 'Second', 'Second'),
(498, 1, '12112', 36, 0, 'Third', 'First'),
(499, 1, '12112', 37, 0, 'Third', 'First'),
(500, 1, '12112', 38, 0, 'Third', 'First'),
(501, 1, '12112', 39, 0, 'Third', 'First'),
(502, 1, '12112', 40, 0, 'Third', 'First'),
(503, 1, '12112', 41, 0, 'Third', 'First'),
(504, 1, '12112', 42, 0, 'Third', 'First'),
(505, 1, '12112', 43, 0, 'Third', 'First'),
(506, 1, '12112', 44, 0, 'Third', 'Second'),
(507, 1, '12112', 45, 0, 'Third', 'Second'),
(508, 1, '12112', 46, 0, 'Third', 'Second'),
(509, 1, '12112', 47, 0, 'Third', 'Second'),
(510, 1, '12112', 48, 0, 'Third', 'Second'),
(511, 1, '12112', 49, 0, 'Third', 'Second'),
(512, 1, '12112', 50, 0, 'Third', 'Second'),
(513, 1, '12112', 51, 0, 'Third', 'Second'),
(514, 1, '12112', 52, 0, 'Fourth', 'First'),
(515, 1, '12112', 53, 0, 'Fourth', 'First'),
(516, 1, '12112', 54, 0, 'Fourth', 'First'),
(517, 1, '12112', 55, 0, 'Fourth', 'First'),
(518, 1, '12112', 56, 0, 'Fourth', 'First'),
(519, 1, '12112', 57, 0, 'Fourth', 'First'),
(520, 1, '12112', 58, 0, 'Fourth', 'Second'),
(521, 1, '12112', 59, 0, 'First', 'First'),
(522, 1, '12112', 60, 0, 'First', 'First');

-- --------------------------------------------------------

--
-- Table structure for table `tblprerequisite`
--

CREATE TABLE `tblprerequisite` (
  `PreRequisiteId` int(11) NOT NULL,
  `SubjectId` int(11) NOT NULL,
  `Pre1` varchar(90) NOT NULL,
  `Pre2` varchar(90) NOT NULL,
  `Pre3` varchar(90) NOT NULL,
  `Pre4` varchar(90) NOT NULL,
  `Pre5` varchar(90) NOT NULL,
  `Pre6` varchar(90) NOT NULL,
  `Pre7` varchar(90) NOT NULL,
  `Pre8` varchar(90) NOT NULL,
  `Pre9` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblprerequisite`
--

INSERT INTO `tblprerequisite` (`PreRequisiteId`, `SubjectId`, `Pre1`, `Pre2`, `Pre3`, `Pre4`, `Pre5`, `Pre6`, `Pre7`, `Pre8`, `Pre9`) VALUES
(1, 3, '', '', '', '', '', '', '', '', ''),
(2, 4, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(3, 5, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(4, 6, '', '', '', '', '', '', '', '', ''),
(5, 7, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(6, 8, '', '', '', '', '', '', '', '', ''),
(7, 9, '', '', '', '', '', '', '', '', ''),
(8, 10, 'ENG 11', '', '', '', '', '', '', '', ''),
(9, 11, '', '', '', '', '', '', '', '', ''),
(10, 12, '', '', '', '', '', '', '', '', ''),
(11, 13, '', '', '', '', '', '', '', '', ''),
(12, 14, 'SOC SCI 11', '', '', '', '', '', '', '', ''),
(13, 15, '', '', '', '', '', '', '', '', ''),
(14, 16, '', '', '', '', '', '', '', '', ''),
(15, 17, '', '', '', '', '', '', '', '', ''),
(16, 18, '', '', '', '', '', '', '', '', ''),
(17, 19, '', '', '', '', '', '', '', '', ''),
(18, 20, '', '', '', '', '', '', '', '', ''),
(19, 21, '', '', '', '', '', '', '', '', ''),
(20, 22, '', '', '', '', '', '', '', '', ''),
(21, 23, '', '', '', '', '', '', '', '', ''),
(22, 24, '', '', '', '', '', '', '', '', ''),
(23, 25, '', '', '', '', '', '', '', '', ''),
(24, 26, '', '', '', '', '', '', '', '', ''),
(25, 27, '', '', '', '', '', '', '', '', ''),
(26, 28, '', '', '', '', '', '', '', '', ''),
(27, 29, '', '', '', '', '', '', '', '', ''),
(28, 30, 'SOC SCI 12', '', '', '', '', '', '', '', ''),
(29, 31, '', '', '', '', '', '', '', '', ''),
(30, 32, '', '', '', '', '', '', '', '', ''),
(31, 33, '', '', '', '', '', '', '', '', ''),
(32, 34, '', '', '', '', '', '', '', '', ''),
(33, 35, '', '', '', '', '', '', '', '', ''),
(34, 36, '', '', '', '', '', '', '', '', ''),
(35, 37, '', '', '', '', '', '', '', '', ''),
(36, 38, '', '', '', '', '', '', '', '', ''),
(37, 39, '', '', '', '', '', '', '', '', ''),
(38, 40, '', '', '', '', '', '', '', '', ''),
(39, 41, '', '', '', '', '', '', '', '', ''),
(40, 42, '', '', '', '', '', '', '', '', ''),
(41, 43, 'SOC SCI 13', '', '', '', '', '', '', '', ''),
(42, 44, '', '', '', '', '', '', '', '', ''),
(43, 45, '', '', '', '', '', '', '', '', ''),
(44, 46, '', '', '', '', '', '', '', '', ''),
(45, 47, '', '', '', '', '', '', '', '', ''),
(46, 48, '', '', '', '', '', '', '', '', ''),
(47, 49, '', '', '', '', '', '', '', '', ''),
(48, 50, '', '', '', '', '', '', '', '', ''),
(49, 51, '', '', '', '', '', '', '', '', ''),
(50, 52, '', '', '', '', '', '', '', '', ''),
(51, 53, '', '', '', '', '', '', '', '', ''),
(52, 54, '', '', '', '', '', '', '', '', ''),
(53, 55, '', '', '', '', '', '', '', '', ''),
(54, 56, '', '', '', '', '', '', '', '', ''),
(55, 57, '', '', '', '', '', '', '', '', ''),
(56, 58, '', '', '', '', '', '', '', '', ''),
(57, 59, '', '', '', '', '', '', '', '', ''),
(58, 60, '', '', '', '', '', '', '', '', ''),
(59, 10025, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(60, 10027, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(62, 10028, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(63, 10029, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(64, 10031, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(65, 10032, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(66, 10033, 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None', 'None'),
(67, 62, 'FIL 11', 'HIST 12', 'IT 113', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE `tblstudent` (
  `ID` int(11) NOT NULL,
  `IdNo` varchar(90) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `MI` varchar(255) NOT NULL,
  `HomeAddress` varchar(255) NOT NULL,
  `Sex` varchar(35) NOT NULL,
  `CourseId` int(11) NOT NULL,
  `YearLevel` varchar(32) NOT NULL,
  `StudentPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudent`
--

INSERT INTO `tblstudent` (`ID`, `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`, `CourseId`, `YearLevel`, `StudentPhoto`) VALUES
(3, '312312312', 'Angel Jude', 'Suarez', 'R', 'Bacolod', 'Male', 1, 'Fourth', 'file-clip-art-file-folder.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tblsubject`
--

CREATE TABLE `tblsubject` (
  `SubjectId` int(11) NOT NULL,
  `Subject` varchar(128) NOT NULL,
  `DescriptiveTitle` varchar(255) NOT NULL,
  `LecUnit` int(11) NOT NULL,
  `LabUnit` int(11) NOT NULL,
  `CourseId` int(11) NOT NULL,
  `YearLevel` varchar(30) NOT NULL,
  `Semester` varchar(30) NOT NULL,
  `PreRequisite` varchar(255) NOT NULL,
  `Level` int(11) NOT NULL,
  `PreTaken` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsubject`
--

INSERT INTO `tblsubject` (`SubjectId`, `Subject`, `DescriptiveTitle`, `LecUnit`, `LabUnit`, `CourseId`, `YearLevel`, `Semester`, `PreRequisite`, `Level`, `PreTaken`) VALUES
(3, 'ENG 11', 'STUDY AND THINKING SKILLS', 3, 0, 1, 'First', 'First', 'None', 1, 0),
(4, 'MATH 11', 'COLLEGE ALGEBRA', 3, 0, 1, 'First', 'First', 'None', 1, 0),
(5, 'SOC SCI 11', 'GENERAL PSYCHOLOGY WITH DRUG ABUSE PREVENTION', 3, 0, 1, 'First', 'First', 'None', 1, 0),
(6, 'NAT SCI 11', 'BIOLOGICAL SCIENCE', 3, 0, 1, 'First', 'First', 'None', 1, 0),
(7, 'IT 101', 'IT FUNDAMENTALS', 2, 1, 1, 'First', 'First', 'None', 1, 0),
(8, 'IT 102', 'PROGRAMMING LANGUAGE (LOGIC FORMULATION)', 2, 1, 1, 'First', 'First', 'None', 1, 0),
(9, 'NSTP 11', 'NATIONAL SERVICE TRAINING PROGRAM 11', 3, 0, 1, 'First', 'First', 'None', 1, 0),
(10, 'ENG 12', 'WRITING IN THE DISCIPLINE', 3, 0, 1, 'First', 'Second', 'ENG 11', 1, 0),
(11, 'FIL 12', 'PAGBASA AT PAGSULAT TUNGO SA PANANALIKSIK', 3, 0, 1, 'First', 'Second', 'FIL 11', 1, 0),
(12, 'MATH 13', 'PLANE AND SPHERICAL TRIGONOMETRY', 4, 0, 1, 'First', 'Second', 'MATH 11', 1, 0),
(13, 'NAT SCI 12', 'GENERAL PHYSICS ', 3, 0, 1, 'First', 'Second', 'NAT SCI 11', 1, 0),
(14, 'SOC SCI 12', 'SOCIETY, CULTURE AND FAMILY PLANNING', 3, 0, 1, 'First', 'Second', 'SOC SCI 11', 1, 0),
(15, 'HUM 11', 'INTRO TO HUMANITIES', 3, 0, 1, 'First', 'Second', 'None', 1, 0),
(16, 'IT 103', 'PROGRAMMING 2 (STRUCTURED COMP PROG)', 2, 1, 1, 'First', 'Second', 'IT 102', 1, 0),
(17, 'PE 12', 'INDIVIDUAL AND DUAL SPORTS', 2, 0, 1, 'First', 'Second', 'PE 11', 1, 0),
(18, 'NSTP 12', 'NATIONAL SERVICE TRAINING PROGRAM 2', 3, 0, 1, 'First', 'Second', 'NSTP 11', 1, 0),
(19, 'BUS COM 11', 'BUSINESS COMMUNICATION', 3, 0, 1, 'Second', 'First', 'ENG 12', 2, 0),
(20, 'FIL 13', 'MASINING NA PAKIKIPAGTALASTASAN', 3, 0, 1, 'Second', 'First', 'FIL 12', 2, 0),
(21, 'HIST 11', 'LIFE AND WORKS OF RIZAL', 3, 0, 1, 'Second', 'First', 'None', 2, 0),
(22, 'IT 104', 'COMPUTER ORGANIZATION', 2, 1, 1, 'Second', 'First', 'IT 103', 2, 0),
(23, 'IT 105', 'OBJECT ORIENTED PROGRAMMING', 2, 1, 1, 'Second', 'First', 'IT 103', 2, 0),
(24, 'IT 106', 'DISCRETE MATHEMATICS', 3, 0, 1, 'Second', 'First', 'MATH 13', 2, 0),
(25, 'IT 107', 'ACCOUNTING PRINCIPLES AND FINANCIAL SYSTEM', 3, 0, 1, 'Second', 'First', 'MATH 13', 2, 0),
(26, 'IT 108', 'PC SERVICING', 2, 1, 1, 'Second', 'First', 'IT 101', 2, 0),
(27, 'PE 13', 'RHYTHMIC ACTIVITIES', 2, 0, 1, 'Second', 'First', 'PE 11', 2, 0),
(28, 'ENG 13', 'SPEECH AND ORAL COMMUNICATION', 3, 0, 1, 'Second', 'Second', 'ENG 13', 2, 0),
(29, 'STAT 12', 'PROBABILITY AND STATISTICS', 4, 0, 1, 'Second', 'Second', 'MATH 13', 2, 0),
(30, 'SOC SCI 13', 'BASIC ECON. W/ TAXATION AND AGRARIAN  REFORM', 3, 0, 1, 'Second', 'Second', 'SOC SCI 12', 2, 0),
(31, 'HIST 12', 'Philippine History Its roots and Development', 3, 0, 1, 'Second', 'Second', 'None', 2, 0),
(32, 'IT 109', 'DATABASE MANAGEMENT SYSTEM', 2, 1, 1, 'Second', 'Second', 'IT 103,IT 106', 2, 0),
(33, 'IT 110', 'OPERATING SYSTEM APPLICATIONS', 2, 1, 1, 'Second', 'Second', 'IT 108', 2, 0),
(34, 'IT 111', 'NETWORK MANAGEMENT', 2, 1, 1, 'Second', 'Second', 'IT 108', 2, 0),
(35, 'PE 14', 'TEAM SPORTS', 2, 0, 1, 'Second', 'Second', 'PE 11', 2, 0),
(36, 'PHILO 11', 'LOGIC AND PHILOSOPHY OF MAN', 3, 0, 1, 'Third', 'First', 'HUM 11', 3, 0),
(37, 'LIT 11', 'PHILIPPINE LITERATURE', 3, 0, 1, 'Third', 'First', 'None', 3, 0),
(38, 'IT 112', 'WEB DEVELOPMENT', 2, 1, 1, 'Third', 'First', 'IT 105, IT 109', 3, 0),
(39, 'IT 113', 'DATABASE MANAGEMENT SYSTEM 2', 2, 1, 1, 'Third', 'First', 'IT 109', 3, 0),
(40, 'IT 114', 'SYSTEM ANALYSIS AND DESIGN', 3, 0, 1, 'Third', 'First', 'IT 105, IT 109', 3, 0),
(41, 'IT 115', 'IT ELECTIVE 1(FUTURE AND CURRENT TRENDS IN IT)', 3, 0, 1, 'Third', 'First', 'All IT Subjects in First Year', 3, 0),
(42, 'IT 116', 'SEMINARS/FIELTRIPS', 1, 0, 1, 'Third', 'First', '3rd Year Standing', 3, 0),
(43, 'SOC SCI 14', 'POLITICS, GOVERNANCE W/ THE NEW CONSTITUTION', 3, 0, 1, 'Third', 'First', 'SOC SCI 13', 3, 0),
(44, 'LIT 12', 'WOLRD LITERATURE', 3, 0, 1, 'Third', 'Second', 'None', 3, 0),
(45, 'IT 117', 'SOFTWARE ENGINEERING', 2, 1, 1, 'Third', 'Second', 'IT 114, IT 115', 3, 0),
(46, 'IT 118', 'MULTIMEDIA SYSTEM', 2, 1, 1, 'Third', 'Second', 'IT 112, IT 115', 3, 0),
(47, 'IT 119', 'PROFESSIONAL ETHICS', 3, 0, 1, 'Third', 'Second', 'IT 101', 3, 0),
(48, 'IT 120', 'IT ELECTIVE 2(NETWORK ADMIN AND PERFORMANCE)', 2, 1, 1, 'Third', 'Second', 'IT 111', 3, 0),
(49, 'IT 126', 'CONTENT MANAGEMENT SYSTEM', 3, 0, 1, 'Third', 'Second', 'IT 112, IT 113, IT 114', 3, 0),
(50, 'IT 122', 'CAPSTONE PROJECT 1', 2, 1, 1, 'Third', 'Second', 'IT 112, IT 113, IT 114', 3, 0),
(51, 'NAT SCI 16', 'ELECTRICITY AND MAGNETISM ', 3, 0, 1, 'Third', 'Second', 'NAT SCI 12', 3, 0),
(52, 'IT 123', 'CAPSTONE PROJECT 2', 2, 1, 1, 'Fourth', 'First', '4rthYr Standing', 4, 0),
(53, 'IT 124', 'IT ELECTIVE 3(WIRELESS TECH)', 2, 1, 1, 'Fourth', 'First', '4rthYr Standing', 4, 0),
(54, 'IT 125', 'IT ELECTIVE 4(JAVA PROGRAMMING)', 2, 1, 1, 'Fourth', 'First', '4rthYr Standing', 4, 0),
(55, 'IT 121', 'MOBILE COMPUTING', 3, 0, 1, 'Fourth', 'First', '4rthYr Standing', 4, 0),
(56, 'IT 132', 'AUTOCAD', 3, 0, 1, 'Fourth', 'First', '4rthYr Standing', 4, 0),
(57, 'IT 128', 'IT ELECTIVE 5(ARTIFICIAL INTELLIGENCE)', 2, 1, 1, 'Fourth', 'First', '4rtYr Standing', 4, 0),
(58, 'IT 129', 'OJT/INTERNSHIP PROGRAM(600 HOURS)', 0, 9, 1, 'Fourth', 'Second', '4rthYr Standing', 4, 0),
(59, 'FIL 11', 'KOMUNIKASYON SA AKADEMIKONG FILIPINO', 3, 0, 1, 'First', 'First', 'None', 1, 0),
(60, 'PE 11', 'PHYSICAL FITNESS & SELF TESTING ACTIVITIES', 2, 0, 1, 'First', 'First', 'None', 1, 0),
(62, 'hsyah', 'asdasd', 2, 2, 5, 'First', 'First', 'NONE', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbluseraccount`
--

CREATE TABLE `tbluseraccount` (
  `UserId` int(11) NOT NULL,
  `Fullname` varchar(255) NOT NULL,
  `User_name` varchar(255) NOT NULL,
  `Pass` varchar(255) NOT NULL,
  `UserType` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluseraccount`
--

INSERT INTO `tbluseraccount` (`UserId`, `Fullname`, `User_name`, `Pass`, `UserType`) VALUES
(1, 'Adones', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(2, 'Faculty', 'faculty', '5cee1c23e1604e9ae4f2c0e93bbb4c6eb72b5f2c', 'Faculty');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblauto`
--
ALTER TABLE `tblauto`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblcourse`
--
ALTER TABLE `tblcourse`
  ADD PRIMARY KEY (`CourseId`);

--
-- Indexes for table `tblcurriculum`
--
ALTER TABLE `tblcurriculum`
  ADD PRIMARY KEY (`CurriculumId`);

--
-- Indexes for table `tblgrades`
--
ALTER TABLE `tblgrades`
  ADD PRIMARY KEY (`GradesId`);

--
-- Indexes for table `tblprerequisite`
--
ALTER TABLE `tblprerequisite`
  ADD PRIMARY KEY (`PreRequisiteId`);

--
-- Indexes for table `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `IdNo` (`IdNo`);

--
-- Indexes for table `tblsubject`
--
ALTER TABLE `tblsubject`
  ADD PRIMARY KEY (`SubjectId`);

--
-- Indexes for table `tbluseraccount`
--
ALTER TABLE `tbluseraccount`
  ADD PRIMARY KEY (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblauto`
--
ALTER TABLE `tblauto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tblcourse`
--
ALTER TABLE `tblcourse`
  MODIFY `CourseId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `tblcurriculum`
--
ALTER TABLE `tblcurriculum`
  MODIFY `CurriculumId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `tblgrades`
--
ALTER TABLE `tblgrades`
  MODIFY `GradesId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=523;
--
-- AUTO_INCREMENT for table `tblprerequisite`
--
ALTER TABLE `tblprerequisite`
  MODIFY `PreRequisiteId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;
--
-- AUTO_INCREMENT for table `tblstudent`
--
ALTER TABLE `tblstudent`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tblsubject`
--
ALTER TABLE `tblsubject`
  MODIFY `SubjectId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;
--
-- AUTO_INCREMENT for table `tbluseraccount`
--
ALTER TABLE `tbluseraccount`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
