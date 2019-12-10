-- phpMyAdmin SQL Dump
-- version 3.2.3
-- http://www.phpmyadmin.net
--
-- 호스트: localhost
-- 처리한 시간: 19-12-11 00:09 
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

INSERT INTO `adminanswar` (`ans_q_idx`, `ans_title`, `ans_content`, `ans_date`) VALUES
(1, 'dsadas', 'dasdas', '2019-11-19'),
(4, '책 기부에 대한 답변입니다.', '도서관1층에 로비에있는 안내원을 찾아가시면 관계자와 만나보실수 있습니다.\r\n항상 저희 도서관을 이용해주셔서 감사합니다.^^', '2019-12-03'),
(3, '답변 드립니다.', '답변 드립니다.', '2019-12-04'),
(5, '꺼억', '꺼억', '2019-12-09'),
(6, 'ㅇㄹ', 'ㄹㅇ', '2019-12-10');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=35 ;

--
-- 테이블의 덤프 데이터 `book`
--

INSERT INTO `book` (`b_idx`, `b_name`, `b_stock`, `b_author`, `b_summary`, `b_img`, `b_guest`, `b_date`) VALUES
(21, '개를 안다고 생각했는데', 2, '홍수지', '노석미 신작 에세이, 어쩌면 나의 40대에 대한 이야기. 보고 느끼고 쓰고 그리는 삶. 이런 일상의 반복에 있어서의 꾸준함이라는 태도. 작가는 매일같이 그 뼈대를 곧추세우고 매일같이 그 뼈대에 붙은 살을 근육으로 단련시키고자 마음을 쓰듯 몸을 쓰는 작가이다. 이 책은 그 과정의 아주 솔직하고도 담백한 어떤 일기이다.', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\k592636099_1.jpg', 19, '2019-11-27 10:38:17'),
(20, '혼밥자작감행', 2, '이한슬', '지금 당신이 아는 ‘현대미술’은 과연 진짜일까? 지난 2016년, ‘조영남 그림 대작’ 사건으로 세상이 떠들썩했다. 진중권에 따르면 이 사건은 한마디로 “현대미술에 대한 몰이해가 빚어낸 소극”이다. 많은 이들이 손가락질했던 이 사건은 2018년 항소심에서 무죄판결을 받았으며, 지금은 대법원의 판단을 기다리고 있다. 이 책은 이제는 어느덧 사람들의 기억에서 잊혔을 그 사건을 미학적·예술사적 차원에서 혹은 상식적 논리의 차원에서 재조명한다.', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\895273890x_1.jpg', 0, '2019-11-27 10:09:12'),
(22, '여행의 이유', 1, '김영하', '히가시노 게이고 필력의 진수를 엿볼 수 있는 단편집이다. 교통 법규 위반이라는 일상적인 범죄에 그만이 낼 수 있는 독특한 상상력을 녹여 내어 시대를 초월해 공감을 불러일으키는 시리즈로 탄생시켰다.\r\n', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\k842534785_1.jpg', 0, '2019-12-03 18:00:27'),
(23, '레드 퀸 : 왕의 감옥 1', 4, '빅토리아 애비야드', '태어날 때부터 능력과 신분이 결정되는 가상의 세계를 다루고 있음에도 계층의 대물림과 부조리한 현실에 대한 묘사는 일반 독자들에게 공감을 불러일으키기 충분하다. 한편 그런 세계에서 자신의 타고난 신분을 뒤엎고 세계를 뒤흔드는 여주인공의 행보는 카타르시스를 제공한다.', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\znls.jpg', 12, '2019-12-03 18:01:42'),
(24, '복수해 기억해', 3, '섀넌커크', '열여섯 살 소녀 리사가 납치되었다. 눈이 가려진 채 외딴 건물로 끌려가 감금되었지만 리사는 공포에 질리는 대신 자신의 위치를 가늠한다. 입속으로 ‘미시시피’를 602번 외었으니 도로에서 건물까지 10.2분 거리, 계단을 세 줄 올라왔으니 3층…. 소시오패스로 오해받을 정도로 냉정하고 침착한 리사는 연필깎이, 뜨개바늘, 니트 담요 등 주변의 물건을 무기 삼아 작전을 짠다. 납치범을 응징할 리사의 무자비한 작전은 성공할 수 있을까?', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\qhrtn.jpg', 19, '2019-12-03 18:02:41'),
(25, '여덟 가지 삶의 태도', 6, '나폴레온 힐', '수많은 히트 광고를 제작한 이채훈 제일기획 크리에이티브 디렉터의 첫 책이다. 그는 탁월한 아이디어는 하늘에서 내려오는 것도, 천재적인 재능도 아닌, 좋은 습관을 꾸준히 실천하는 데서 나온다고 단언한다. 타고난 재능을 이기는 힘은 매일 조금씩 쓰고, 말하고, 달리는 꾸준함에서 나온다는 것이다. 밀도 있는 작업 현장에서 건져올린 초히트 아웃풋의 비결을 만나보자!', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\8954639771_1.jpg', 0, '2019-12-03 18:04:52'),
(26, '꿈꾸는 책들의 도시', 3, '강진원', '작품 속 주인공 루시 플라이는 지진 새가 울던 날 오후, 또 다른 영국 여자 릴리 브리지스를 살해한 혐의로 일본 경찰에 체포된다. 그리고 루시의 개인적 독백, 즉 (남성) 경찰관에게 취조당하는 걸 거부하는 한 여자의 이야기가 이어지며 작품 초반부터 긴장감을 완벽하게 조성해나간다.\r\n', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\8954658121_1.jpg', 0, '2019-12-03 18:06:04'),
(27, '과거에서 온 여자', 5, '진행선', '내가 아는 한 릴리의 죽음에 관해 밝혀진 사실은 거의 없고, 있다 하더라도 오해의 소지가 다분하다. 릴리는 어느 날 밤, 소리 소문도 없이 사라졌다. 도쿄에 머문 지 몇 달밖에 되지 않았을 때였다. 그리고 며칠 후, 도쿄 만에서 젊은 여성의 몸통 하나와 절단된 사지 두 토막이 떠올랐다. 팔이었는지 다리였는지는 기억나지 않지만, 후에 몸통과 일치하는 것으로 밝혀졌다. 손이 없어서 지문도 채취할 수 없었기에 경찰은 공식적으로 신원을 밝힐 수 없었다. 하지만 시체는 릴리의 것이라고 널리 받아들여지는 듯했다.', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\8954655971_2.jpg', 12, '2019-12-03 18:07:06'),
(28, '배신의 대가', 6, '이인호', '내가 이야기를 채 끝내기도 전에 데이지는 잠들어 있었다. 사실 그는 내가 이야기를 시작한 직후 잠들었다. 나는 알고 있었지만, 내 이야기가 그에게 좋은 자장가가 되어주었기에 멈추지 않았다. 나는 그가 잠든 것이 무례하다고 생각하지 않았다. ', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\k072636585_1.jpg', 15, '2019-12-03 18:08:11'),
(29, '무죄와 유죄의 차이', 3, '김한석', '수재나 존스는 간결하지만 인상적인 문체로 내내 으스스한 모호함을 유지해감으로써 긴장감 지진계의 진도 10을 기록한다. 강렬하게 뇌리를 떠나지 않는, 매우 세심하게 창작된 이 데뷔 소설의 진동은 마지막 장이 넘어가고 한참 후까지도 계속해서 느껴진다.', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\896782095x_1.jpg', 15, '2019-12-03 18:09:09'),
(32, '마시멜로 이야기', 1, '호아킴 데 포사다, 엘런 싱어', '당신의 삶에 전환점이 되어줄마시멜로 이야기 국내에서 300만 독자의 사랑을 받은 마시멜로 이야기가 공경희 번역가의 손을 통해 재탄생하였다....', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\111.jpg', 19, '2019-12-10 21:45:36'),
(33, '노인과 바다', 2, '어니스트 헤밍웨이', '미국 현대 문학의 개척자라 불리는 어니스트 헤밍웨이의 대표작 노인과 바다 퓰리처상 수상작이자 헤밍웨이의 마지막 소설로, 작가....', '\\source\\repos\\bookPjt\\bookPjt\\Resources\\BookImg\\123.jpg', 15, '2019-12-10 21:49:57');

-- --------------------------------------------------------

--
-- 테이블 구조 `bookreservation`
--

CREATE TABLE IF NOT EXISTS `bookreservation` (
  `re_idx` int(11) NOT NULL AUTO_INCREMENT,
  `re_b_idx` int(11) NOT NULL,
  `c_idx` int(11) NOT NULL,
  `reservationDate` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`re_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=11 ;

--
-- 테이블의 덤프 데이터 `bookreservation`
--

INSERT INTO `bookreservation` (`re_idx`, `re_b_idx`, `c_idx`, `reservationDate`) VALUES
(9, 32, 3, '2019-12-19'),
(8, 20, 5, '2019-12-10');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=37 ;

--
-- 테이블의 덤프 데이터 `book_management`
--

INSERT INTO `book_management` (`bm_idx`, `bm_c_idx`, `bm_b_idx`, `bm_takeDate`, `bm_returnDate`, `bm_extend`, `bm_status`) VALUES
(1, 1, 1, '2019-11-07', '2019-11-12', 10, 1),
(3, 1, 1, '2019-11-14', '2019-11-21', 3, 1),
(4, 1, 1, '2019-11-14', '2019-11-30', 3, 1),
(5, 1, 1, '2019-11-14', '2019-11-30', 3, 1),
(6, 1, 1, '2019-11-14', '2019-11-27', 2, 1),
(7, 1, 1, '2019-11-14', '2019-11-21', 0, 1),
(8, 1, 14, '2019-11-15', '2019-11-22', 0, 1),
(9, 1, 1, '2019-11-15', '2019-11-22', 0, 1),
(10, 1, 12, '2019-11-15', '2019-11-22', 0, 1),
(11, 1, 11, '2019-11-15', '2019-11-22', 0, 1),
(12, 1, 12, '2019-11-15', '2019-11-22', 0, 1),
(13, 1, 19, '2019-11-18', '2019-12-04', 3, 1),
(14, 1, 19, '2019-11-15', '2019-11-17', 0, 1),
(15, 2, 26, '2019-12-03', '2019-12-13', 1, 1),
(16, 3, 25, '2019-12-04', '2019-12-11', 0, 1),
(17, 3, 25, '2019-12-04', '2019-12-14', 1, 1),
(18, 5, 26, '2019-12-10', '2019-12-17', 0, 1),
(19, 6, 27, '2019-12-10', '2019-12-17', 0, 1),
(20, 6, 21, '2019-12-10', '2019-12-17', 0, 1),
(21, 6, 21, '2019-12-10', '2019-12-17', 0, 1),
(22, 6, 21, '2019-12-10', '2019-12-17', 0, 1),
(23, 5, 25, '2019-12-10', '2019-11-20', 0, 1),
(24, 5, 22, '2019-12-10', '2019-11-10', 0, 1),
(25, 5, 26, '2019-12-10', '2019-11-20', 0, 1),
(26, 5, 27, '2019-12-10', '2019-11-20', 0, 1),
(27, 5, 28, '2019-12-10', '2019-11-20', 0, 1),
(28, 5, 28, '2019-12-10', '2019-11-20', 0, 1),
(29, 5, 29, '2019-12-10', '2019-11-20', 0, 1),
(30, 5, 21, '2019-12-10', '2019-12-23', 2, 0),
(31, 3, 32, '2019-12-10', '2019-12-17', 0, 1),
(32, 3, 33, '2019-12-10', '2019-12-17', 0, 0),
(33, 3, 32, '2019-12-10', '2019-12-17', 0, 1),
(34, 3, 22, '2019-12-10', '2019-12-17', 0, 0),
(35, 3, 33, '2019-12-10', '2019-12-17', 0, 0),
(36, 3, 32, '2019-12-10', '2019-12-20', 1, 1);

-- --------------------------------------------------------

--
-- 테이블 구조 `category`
--

CREATE TABLE IF NOT EXISTS `category` (
  `ct_idx` int(11) NOT NULL,
  `ct_b_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ct_b_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=35 ;

--
-- 테이블의 덤프 데이터 `category`
--

INSERT INTO `category` (`ct_idx`, `ct_b_id`) VALUES
(1, 1),
(1, 16),
(1, 19),
(1, 18),
(2, 17),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(3, 20),
(3, 21),
(5, 22),
(5, 23),
(5, 24),
(7, 25),
(1, 26),
(1, 27),
(4, 28),
(4, 29),
(5, 32),
(5, 33);

-- --------------------------------------------------------

--
-- 테이블 구조 `categoryname`
--

CREATE TABLE IF NOT EXISTS `categoryname` (
  `c_n_idx` int(11) NOT NULL AUTO_INCREMENT,
  `c_n_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`c_n_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=8 ;

--
-- 테이블의 덤프 데이터 `categoryname`
--

INSERT INTO `categoryname` (`c_n_idx`, `c_n_name`) VALUES
(1, '국문학'),
(2, '영어'),
(3, '에세이'),
(4, '사회과학'),
(5, '소설'),
(6, '고전'),
(7, '자기계발');

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
  `email` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `address` text COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`c_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=8 ;

--
-- 테이블의 덤프 데이터 `customer`
--

INSERT INTO `customer` (`c_idx`, `c_name`, `c_phone1`, `c_phone2`, `c_phone3`, `c_identy`, `c_password`, `c_birth`, `c_rank`, `email`, `address`) VALUES
(1, '삼재용', '010', '4228', '5921', 'dlwodyd202', '1234', '950717', '사서', '', ''),
(2, '윤지원', '010', '9199', '3261', 'jiwon_3261', '1234', '980416', '일반 회원', '', ''),
(3, '이재용', '010', '111', '1111', 'dlwodyd111', '11111', '950717', '일반 회원', '', ''),
(4, '관리자', '000', '0000', '0000', 'root', 'root', '000000', '관리자', '', ''),
(5, '이재용', '010', '4228', '5921', 'wodyd202', '11', '150717', '일반 회원', 'wodyd202@naver.com', '덕계동'),
(6, '이재', '010', '4222', '2222', 'wodyd2002', '1', '001220', '일반 회원', '', ''),
(7, '이재용', '010', '4228', '5921', 'dlwodyd333', 'd1489314', '950717', '관리자', 'wodyd202@naver.com', '양주시 덕계동 유림화이트 ');

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
  `no_hit` int(11) NOT NULL DEFAULT '0',
  `no_idx` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`no_idx`),
  KEY `no_idx` (`no_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=13 ;

--
-- 테이블의 덤프 데이터 `noticeboard`
--

INSERT INTO `noticeboard` (`no_title`, `no_content`, `no_date`, `no_hit`, `no_idx`) VALUES
('안녕하세요 ㅇㅈㅇ 도서관입니다.', '안녕하세요.', '2019-12-10', 0, 12);

-- --------------------------------------------------------

--
-- 테이블 구조 `publisher`
--

CREATE TABLE IF NOT EXISTS `publisher` (
  `p_idx` int(11) NOT NULL,
  `p_b_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`p_b_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=35 ;

--
-- 테이블의 덤프 데이터 `publisher`
--

INSERT INTO `publisher` (`p_idx`, `p_b_id`) VALUES
(1, 1),
(1, 16),
(1, 19),
(1, 18),
(1, 17),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(1, 20),
(3, 21),
(2, 22),
(3, 23),
(1, 24),
(1, 25),
(1, 26),
(1, 27),
(2, 28),
(3, 29),
(1, 32),
(1, 33);

-- --------------------------------------------------------

--
-- 테이블 구조 `publishername`
--

CREATE TABLE IF NOT EXISTS `publishername` (
  `p_n_idx` int(11) NOT NULL AUTO_INCREMENT,
  `p_n_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`p_n_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- 테이블의 덤프 데이터 `publishername`
--

INSERT INTO `publishername` (`p_n_idx`, `p_n_name`) VALUES
(1, '한빛출판사'),
(2, '이재용 출판사'),
(3, '강한독서출판사'),
(4, '착한책방');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=41 ;

--
-- 테이블의 덤프 데이터 `rentalchk`
--

INSERT INTO `rentalchk` (`rc_b_idx`, `rc_c_id`, `rc_date`, `rc_idx`) VALUES
(1, 'dlwodyd202', '2019-11-15', 10),
(17, 'dlwodyd202', '2019-11-15', 11),
(13, 'dlwodyd202', '2019-11-15', 12),
(11, 'dlwodyd202', '2019-11-15', 13),
(15, 'dlwodyd202', '2019-11-15', 14),
(18, 'dlwodyd202', '2019-11-19', 19);

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
  `q_c_idx` int(11) DEFAULT NULL,
  PRIMARY KEY (`q_idx`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=9 ;

--
-- 테이블의 덤프 데이터 `userquestion`
--

INSERT INTO `userquestion` (`q_idx`, `q_title`, `q_content`, `q_date`, `q_status`, `q_c_idx`) VALUES
(3, '도서가 손상되었을때', '제가 빌려간 책이 손상되었습니다. 도서관에 어느부서에 말씀드려야 할까요?', '2019-12-03', 1, 2),
(4, '오래된책 기부', '제가 소장하고있던 책을 기부하려합니다. 기부하는 방법을 알려주세요', '2019-12-03', 1, 2),
(5, '도서관 조사를 하고싶습니다.', '과제로 사서분과 인터뷰를 해야합니다. 누구를 찾아가야하나요?', '2019-12-03', 1, 2),
(6, '안녕하세요 문의드립니다.', '12월 25일날 크리스마스 관련 도서를 빌리고자하는데 희망도서 신청 가능할까요?', '2019-12-04', 1, 3),
(7, '안녕하세요 문의드립니다.', '12월 25일날 크리스마스 관련 도서를 빌리고자하는데 희망도서 신청 가능할까요?', '2019-12-04', 0, 3),
(8, '안녕하세요', '안녕하세요', '2019-12-04', 0, 3);
