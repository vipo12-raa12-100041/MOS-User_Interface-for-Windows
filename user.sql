-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2013 at 04:10 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `vipo12`
--

-- --------------------------------------------------------

--
-- Table structure for table `usr_table`
--

CREATE TABLE IF NOT EXISTS `usr_table` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(40) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `Age` int(11) NOT NULL,
  `occupation` varchar(40) NOT NULL,
  `nationality` varchar(40) NOT NULL,
  `residence` varchar(40) NOT NULL,
  `Vid_exp` varchar(10) NOT NULL,
  `frqncy` varchar(30) DEFAULT NULL,
  `type` varchar(30) DEFAULT NULL,
  `feel` varchar(30) NOT NULL,
  `tst_exp` varchar(30) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `name` (`name`),
  KEY `Id` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
