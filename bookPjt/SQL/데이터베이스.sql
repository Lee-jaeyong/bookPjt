/*
SQLyog Community v13.1.5  (64 bit)
MySQL - 5.1.41-community : Database - library
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `book` */

DROP TABLE IF EXISTS `book`;

CREATE TABLE `book` (
  `b_idx` int(11) NOT NULL AUTO_INCREMENT,
  `b_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `b_stock` int(11) NOT NULL,
  `b_author` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `b_summary` text COLLATE utf8_unicode_ci NOT NULL,
  `b_img` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `b_guest` int(11) NOT NULL,
  `b_date` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`b_idx`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `book` */

insert  into `book`(`b_idx`,`b_name`,`b_stock`,`b_author`,`b_summary`,`b_img`,`b_guest`,`b_date`) values 
(1,'ㅋㅋ',3,'ㅋ','ㄴㅇㄹ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\2.jpg',0,'2019-11-13 19:52:51'),
(17,'윤지원',3,'윤지원','ㅇㅁㄴㄴㅇㄴㅁ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\91307468_1_1540008883_w640.jpg',0,'2019-11-14 12:54:19'),
(10,'ㅇㄴ',22,'ㅇ','ㄷㅈㄷ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\11.jpg',12,'2019-11-13 19:30:24'),
(11,'윤지원',3,'윤','ㄷㅈㄷ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\6.jpg',0,'2019-11-13 19:35:02'),
(12,'이이',2,'ㅇ','ㅇㄴㅇ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\3.jpg',0,'2019-11-13 19:35:36'),
(13,'ㅁㅁㅁ',2,'ㄴ','ㄷ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\11.jpg',0,'2019-11-13 19:36:27'),
(14,'ㄴㄴ',3,'ㄴ','ㅇ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\3.jpg',0,'2019-11-13 19:37:48'),
(15,'이재용',233,'이','ㅇㅇ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\2.jpg',0,'2019-11-13 19:39:32'),
(18,'마시멜로 이야기',3,'이재용','ㅇㄴㅇ','\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\10.jpg',0,'2019-11-15 17:19:19');

/*Table structure for table `book_management` */

DROP TABLE IF EXISTS `book_management`;

CREATE TABLE `book_management` (
  `bm_idx` int(11) NOT NULL AUTO_INCREMENT,
  `bm_c_idx` int(11) NOT NULL,
  `bm_b_idx` int(11) NOT NULL,
  `bm_takeDate` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `bm_returnDate` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `bm_extend` int(11) NOT NULL DEFAULT '0',
  `bm_status` int(11) DEFAULT '0',
  PRIMARY KEY (`bm_idx`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `book_management` */

insert  into `book_management`(`bm_idx`,`bm_c_idx`,`bm_b_idx`,`bm_takeDate`,`bm_returnDate`,`bm_extend`,`bm_status`) values 
(1,1,1,'2019-11-07','2019-11-12',10,0),
(3,1,1,'2019-11-14','2019-11-21',3,1),
(4,1,1,'2019-11-14','2019-11-30',3,1),
(5,1,1,'2019-11-14','2019-11-30',3,1),
(6,1,1,'2019-11-14','2019-11-27',2,1),
(7,1,1,'2019-11-14','2019-11-21',0,1),
(8,1,14,'2019-11-15','2019-11-22',0,0),
(9,1,1,'2019-11-15','2019-11-22',0,0),
(10,1,12,'2019-11-15','2019-11-22',0,0),
(11,1,11,'2019-11-15','2019-11-22',0,0);

/*Table structure for table `category` */

DROP TABLE IF EXISTS `category`;

CREATE TABLE `category` (
  `ct_idx` int(11) NOT NULL,
  `ct_b_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ct_b_id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `category` */

insert  into `category`(`ct_idx`,`ct_b_id`) values 
(1,1),
(1,16),
(1,18),
(2,17),
(1,10),
(1,11),
(1,12),
(1,13),
(1,14),
(1,15);

/*Table structure for table `categoryname` */

DROP TABLE IF EXISTS `categoryname`;

CREATE TABLE `categoryname` (
  `c_n_idx` int(11) NOT NULL AUTO_INCREMENT,
  `c_n_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`c_n_idx`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `categoryname` */

insert  into `categoryname`(`c_n_idx`,`c_n_name`) values 
(1,'국문학'),
(2,'영어');

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
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
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `customer` */

insert  into `customer`(`c_idx`,`c_name`,`c_phone1`,`c_phone2`,`c_phone3`,`c_identy`,`c_password`,`c_birth`,`c_rank`) values 
(1,'삼재용','010','4228','5921','dlwodyd202','1234','9507172','A'),
(2,'윤지원','010','9199','3261','jiwon_3261','1234','980416','A'),
(3,'이재용','010','111','1111','dlwodyd111','11111','111111','A'),
(4,'관리자','000','0000','0000','root','root','000000','C');

/*Table structure for table `delinquent` */

DROP TABLE IF EXISTS `delinquent`;

CREATE TABLE `delinquent` (
  `d_bm_idx` int(11) NOT NULL,
  `d_penalty` int(11) NOT NULL,
  `d_c_idx` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `delinquent` */

/*Table structure for table `publisher` */

DROP TABLE IF EXISTS `publisher`;

CREATE TABLE `publisher` (
  `p_idx` int(11) NOT NULL,
  `p_b_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`p_b_id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `publisher` */

insert  into `publisher`(`p_idx`,`p_b_id`) values 
(1,1),
(1,16),
(1,18),
(1,17),
(1,10),
(1,11),
(1,12),
(1,13),
(1,14),
(1,15);

/*Table structure for table `publishername` */

DROP TABLE IF EXISTS `publishername`;

CREATE TABLE `publishername` (
  `p_n_idx` int(11) NOT NULL AUTO_INCREMENT,
  `p_n_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`p_n_idx`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `publishername` */

insert  into `publishername`(`p_n_idx`,`p_n_name`) values 
(1,'이재용 출판사'),
(2,'윤지원 출판사');

/*Table structure for table `rentalchk` */

DROP TABLE IF EXISTS `rentalchk`;

CREATE TABLE `rentalchk` (
  `rc_b_idx` int(11) DEFAULT NULL,
  `rc_c_id` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rc_date` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rc_idx` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`rc_idx`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

/*Data for the table `rentalchk` */

insert  into `rentalchk`(`rc_b_idx`,`rc_c_id`,`rc_date`,`rc_idx`) values 
(1,'dlwodyd202','2019-11-15',10),
(17,'dlwodyd202','2019-11-15',11),
(13,'dlwodyd202','2019-11-15',12),
(11,'dlwodyd202','2019-11-15',13);

/* Function  structure for function  `rentalBookCountChk` */

/*!50003 DROP FUNCTION IF EXISTS `rentalBookCountChk` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `rentalBookCountChk`(
	b_idx int
    ) RETURNS int(11)
BEGIN
	DECLARE result INT;
	
	    SELECT COUNT(bm_b_idx) INTO result
	    FROM book_management
	    WHERE bm_b_idx = b_idx AND bm_status = 0;
	    RETURN result;
    END */$$
DELIMITER ;

/* Function  structure for function  `searchBook` */

/*!50003 DROP FUNCTION IF EXISTS `searchBook` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `searchBook`(
	b_idx int
    ) RETURNS int(11)
BEGIN

    DECLARE result INT;
    select count(bm_b_idx) into result
    from book_management
    where bm_b_idx = b_idx and bm_status = 0;
    return result;

    END */$$
DELIMITER ;

/* Function  structure for function  `SearchOverDue` */

/*!50003 DROP FUNCTION IF EXISTS `SearchOverDue` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `SearchOverDue`(
	c_idx int
    ) RETURNS int(11)
BEGIN
	DECLARE result INT;
	    SELECT COUNT(d_c_idx) INTO result
	    FROM delinquent
	    where d_c_idx = c_idx;
	    RETURN result;

    END */$$
DELIMITER ;

/* Function  structure for function  `totalCustomerManageCount` */

/*!50003 DROP FUNCTION IF EXISTS `totalCustomerManageCount` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `totalCustomerManageCount`(
	custId int
    ) RETURNS int(11)
BEGIN
    DECLARE result INT;
    SELECT COUNT(bm_c_idx) INTO result
    FROM book_management
    where bm_c_idx = custId; 
    RETURN result;   
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
