-- phpMyAdmin SQL Dump
-- version 3.2.3
-- http://www.phpmyadmin.net
--
-- 호스트: localhost
-- 처리한 시간: 19-11-19 16:26 
-- 서버 버전: 5.1.41
-- PHP 버전: 5.2.12

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- 데이터베이스: `library`
--

-- --------------------------------------------------------

--
-- 테이블 구조 `adminanswar`
--

CREATE TABLE IF NOT EXISTS `adminanswar` (
  `ans_q_idx` int(11) NOT NULL,
  `ans_title` text COLLATE utf8_unicode_ci NOT NULL,
  `ans_content` text COLLATE utf8_unicode_ci NOT NULL,
  `ans_date` varchar(200) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- 테이블의 덤프 데이터 `adminanswar`
--


-- --------------------------------------------------------

--
-- 테이블 구조 `book`
--

CREATE TABLE IF NOT EXISTS `book` (
  `b_idx` int(11) NOT NULL AUTO_INCREMENT,
  `b_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `b_stock` int(11) NOT NULL,
  `b_author` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `b_summary` text COLLATE utf8_unicode_ci NOT NULL,
  `b_img` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `b_guest` int(11) NOT NULL,
  `b_date` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`b_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=19 ;

--
-- 테이블의 덤프 데이터 `book`
--

INSERT INTO `book` (`b_idx`, `b_name`, `b_stock`, `b_author`, `b_summary`, `b_img`, `b_guest`, `b_date`) VALUES
(1, 'ㅋㅋ', 3, 'ㅋ', 'ㄴㅇㄹ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\2.jpg', 0, '2019-11-13 19:52:51'),
(17, '윤지원', 3, '윤지원', 'ㅇㅁㄴㄴㅇㄴㅁ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\91307468_1_1540008883_w640.jpg', 0, '2019-11-14 12:54:19'),
(10, 'ㅇㄴ', 22, 'ㅇ', 'ㄷㅈㄷ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\11.jpg', 12, '2019-11-13 19:30:24'),
(11, '윤지원', 3, '윤', 'ㄷㅈㄷ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\6.jpg', 0, '2019-11-13 19:35:02'),
(12, '이이', 2, 'ㅇ', 'ㅇㄴㅇ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\3.jpg', 0, '2019-11-13 19:35:36'),
(13, 'ㅁㅁㅁ', 2, 'ㄴ', 'ㄷ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\11.jpg', 0, '2019-11-13 19:36:27'),
(14, 'ㄴㄴ', 3, 'ㄴ', 'ㅇ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\3.jpg', 0, '2019-11-13 19:37:48'),
(15, '이재용', 233, '이', 'ㅇㅇ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\2.jpg', 0, '2019-11-13 19:39:32'),
(18, '마시멜로 이야기', 3, '이재용', 'ㅇㄴㅇ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\10.jpg', 0, '2019-11-15 17:19:19');

-- --------------------------------------------------------

--
-- 테이블 구조 `book_management`
--

CREATE TABLE IF NOT EXISTS `book_management` (
  `bm_idx` int(11) NOT NULL AUTO_INCREMENT,
  `bm_c_idx` int(11) NOT NULL,
  `bm_b_idx` int(11) NOT NULL,
  `bm_takeDate` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `bm_returnDate` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `bm_extend` int(11) NOT NULL DEFAULT '0',
  `bm_status` int(11) DEFAULT '0',
  PRIMARY KEY (`bm_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=12 ;

--
-- 테이블의 덤프 데이터 `book_management`
--

INSERT INTO `book_management` (`bm_idx`, `bm_c_idx`, `bm_b_idx`, `bm_takeDate`, `bm_returnDate`, `bm_extend`, `bm_status`) VALUES
(1, 1, 1, '2019-11-07', '2019-11-12', 10, 0),
(3, 1, 1, '2019-11-14', '2019-11-21', 3, 1),
(4, 1, 1, '2019-11-14', '2019-11-30', 3, 1),
(5, 1, 1, '2019-11-14', '2019-11-30', 3, 1),
(6, 1, 1, '2019-11-14', '2019-11-27', 2, 1),
(7, 1, 1, '2019-11-14', '2019-11-21', 0, 1),
(8, 1, 14, '2019-11-15', '2019-11-22', 0, 0),
(9, 1, 1, '2019-11-15', '2019-11-22', 0, 0),
(10, 1, 12, '2019-11-15', '2019-11-22', 0, 0),
(11, 1, 11, '2019-11-15', '2019-11-22', 0, 0);

-- --------------------------------------------------------

--
-- 테이블 구조 `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `ct_idx` int(11) NOT NULL,
  `ct_b_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ct_b_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=19 ;

--
-- 테이블의 덤프 데이터 `category`
--

INSERT INTO `category` (`ct_idx`, `ct_b_id`) VALUES
(1, 1),
(1, 16),
(1, 18),
(2, 17),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15);

-- --------------------------------------------------------

--
-- 테이블 구조 `categoryname`
--

CREATE TABLE IF NOT EXISTS `categoryname` (
  `c_n_idx` int(11) NOT NULL AUTO_INCREMENT,
  `c_n_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`c_n_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- 테이블의 덤프 데이터 `categoryname`
--

INSERT INTO `categoryname` (`c_n_idx`, `c_n_name`) VALUES
(1, '국문학'),
(2, '영어');

-- --------------------------------------------------------

--
-- 테이블 구조 `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `c_idx` int(11) NOT NULL AUTO_INCREMENT,
  `c_name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `c_phone1` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `c_phone2` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `c_phone3` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `c_identy` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `c_password` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `c_birth` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `c_rank` varchar(10) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL DEFAULT 'A',
  PRIMARY KEY (`c_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- 테이블의 덤프 데이터 `customer`
--

INSERT INTO `customer` (`c_idx`, `c_name`, `c_phone1`, `c_phone2`, `c_phone3`, `c_identy`, `c_password`, `c_birth`, `c_rank`) VALUES
(1, '삼재용', '010', '4228', '5921', 'dlwodyd202', '1234', '9507172', 'A'),
(2, '윤지원', '010', '9199', '3261', 'jiwon_3261', '1234', '980416', 'A'),
(3, '이재용', '010', '111', '1111', 'dlwodyd111', '11111', '111111', 'A'),
(4, '관리자', '000', '0000', '0000', 'root', 'root', '000000', 'C');

-- --------------------------------------------------------

--
-- 테이블 구조 `delinquent`
--

CREATE TABLE IF NOT EXISTS `delinquent` (
  `d_bm_idx` int(11) NOT NULL,
  `d_penalty` int(11) NOT NULL,
  `d_c_idx` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- 테이블의 덤프 데이터 `delinquent`
--


-- --------------------------------------------------------

--
-- 테이블 구조 `noticeboard`
--

CREATE TABLE IF NOT EXISTS `noticeboard` (
  `no_title` text COLLATE utf8_unicode_ci NOT NULL,
  `no_content` text COLLATE utf8_unicode_ci NOT NULL,
  `no_date` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `no_hit` int(11) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- 테이블의 덤프 데이터 `noticeboard`
--


-- --------------------------------------------------------

--
-- 테이블 구조 `publisher`
--

CREATE TABLE IF NOT EXISTS `publisher` (
  `p_idx` int(11) NOT NULL,
  `p_b_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`p_b_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=19 ;

--
-- 테이블의 덤프 데이터 `publisher`
--

INSERT INTO `publisher` (`p_idx`, `p_b_id`) VALUES
(1, 1),
(1, 16),
(1, 18),
(1, 17),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15);

-- --------------------------------------------------------

--
-- 테이블 구조 `publishername`
--

CREATE TABLE IF NOT EXISTS `publishername` (
  `p_n_idx` int(11) NOT NULL AUTO_INCREMENT,
  `p_n_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`p_n_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- 테이블의 덤프 데이터 `publishername`
--

INSERT INTO `publishername` (`p_n_idx`, `p_n_name`) VALUES
(1, '이재용 출판사'),
(2, '윤지원 출판사');

-- --------------------------------------------------------

--
-- 테이블 구조 `rentalchk`
--

CREATE TABLE IF NOT EXISTS `rentalchk` (
  `rc_b_idx` int(11) DEFAULT NULL,
  `rc_c_id` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rc_date` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rc_idx` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`rc_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=14 ;

--
-- 테이블의 덤프 데이터 `rentalchk`
--

INSERT INTO `rentalchk` (`rc_b_idx`, `rc_c_id`, `rc_date`, `rc_idx`) VALUES
(1, 'dlwodyd202', '2019-11-15', 10),
(17, 'dlwodyd202', '2019-11-15', 11),
(13, 'dlwodyd202', '2019-11-15', 12),
(11, 'dlwodyd202', '2019-11-15', 13);

-- --------------------------------------------------------

--
-- 테이블 구조 `userquestion`
--

CREATE TABLE IF NOT EXISTS `userquestion` (
  `q_idx` int(11) NOT NULL AUTO_INCREMENT,
  `q_title` text COLLATE utf8_unicode_ci NOT NULL,
  `q_content` text COLLATE utf8_unicode_ci NOT NULL,
  `q_date` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `q_status` int(11) NOT NULL,
  PRIMARY KEY (`q_idx`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

--
-- 테이블의 덤프 데이터 `userquestion`
--

