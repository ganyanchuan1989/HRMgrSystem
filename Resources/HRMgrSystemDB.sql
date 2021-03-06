-- MySQL dump 10.13  Distrib 5.7.30, for Win64 (x86_64)
--
-- Host: localhost    Database: hrmgrsystemdb
-- ------------------------------------------------------
-- Server version	5.7.30-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `hr_contract`
--

DROP TABLE IF EXISTS `hr_contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_contract` (
  `ID` varchar(20) NOT NULL COMMENT '鍚堝悓缂栧彿',
  `EMP_ID` varchar(20) DEFAULT NULL COMMENT '鍛樺伐id',
  `START_TIME` varchar(10) DEFAULT NULL COMMENT '寮€濮嬫椂闂?,
  `END_TIME` varchar(10) DEFAULT NULL COMMENT '缁撴潫鏃堕棿',
  `SALARY` decimal(20,0) DEFAULT NULL COMMENT '鍚堝悓宸ヨ祫',
  `PROBATION` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `Index_1` (`ID`,`EMP_ID`),
  KEY `FK_REF_CONTRACT_EMP` (`EMP_ID`),
  CONSTRAINT `FK_REF_CONTRACT_EMP` FOREIGN KEY (`EMP_ID`) REFERENCES `hr_employee` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='鍚堝悓';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_contract`
--

LOCK TABLES `hr_contract` WRITE;
/*!40000 ALTER TABLE `hr_contract` DISABLE KEYS */;
INSERT INTO `hr_contract` VALUES ('20200604101010000001','20200604101010000001','2020-05-01','2021-05-01',5000,3),('20200604101010000002','20200604101010000002','2020-05-01','2021-05-01',5000,3),('20200604101010000003','20200604101010000003','2020-01-01','2021-01-01',5000,3);
/*!40000 ALTER TABLE `hr_contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hr_dept`
--

DROP TABLE IF EXISTS `hr_dept`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_dept` (
  `ID` varchar(20) NOT NULL COMMENT '閮ㄩ棬ID',
  `NAME` varchar(20) DEFAULT NULL COMMENT '閮ㄩ棬鍚嶇О',
  PRIMARY KEY (`ID`),
  KEY `Index_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='閮ㄩ棬';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_dept`
--

LOCK TABLES `hr_dept` WRITE;
/*!40000 ALTER TABLE `hr_dept` DISABLE KEYS */;
INSERT INTO `hr_dept` VALUES ('20200604101010000001','淇℃伅鎶€鏈儴'),('20200604101010000002','閿€鍞儴'),('20200604101010000003','浜哄姏璧勬簮閮?);
/*!40000 ALTER TABLE `hr_dept` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hr_employee`
--

DROP TABLE IF EXISTS `hr_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_employee` (
  `ID` varchar(20) NOT NULL COMMENT '鍛樺伐缂栧彿',
  `NAME` varchar(20) DEFAULT NULL COMMENT '鍛樺伐濮撳悕',
  `SEX` int(11) DEFAULT NULL COMMENT '鎬у埆锛?:鐢凤紱1锛氬コ锛?,
  `ID_CARD` varchar(18) DEFAULT NULL COMMENT '韬唤璇?,
  `EDUCATION` int(11) DEFAULT NULL COMMENT '瀛﹀巻锛?锛氶珮涓強楂樹腑浠ヤ笅:2锛氬ぇ涓擄紝3锛氭湰绉戯紝4锛氱澹紝5锛氬崥澹紝6锛涘崥澹悗锛?,
  `SCHOOL` varchar(20) DEFAULT NULL COMMENT '瀛︽牎',
  `GRADUATION_TIME` varchar(10) DEFAULT NULL COMMENT '姣曚笟鏃堕棿',
  `PROFESSION` varchar(20) DEFAULT NULL COMMENT '涓撲笟',
  `TELEPHONE` varchar(11) DEFAULT NULL COMMENT '绉诲姩鐢佃瘽',
  `POLITICAL_STATUS` int(11) DEFAULT NULL COMMENT '鏀挎不闈㈣矊锛?锛氱兢浼楋紝2锛氬洟鍛橈紝3锛氬厷鍛橈級',
  `ADDRESS` varchar(100) DEFAULT NULL COMMENT '浣忓潃',
  `BANK_CARD` varchar(30) DEFAULT NULL COMMENT '閾惰鍗?,
  `EMAIL` varchar(50) DEFAULT NULL COMMENT '閭',
  `DEPT_ID` varchar(20) DEFAULT NULL COMMENT '閮ㄩ棬ID',
  `JOB_ID` varchar(20) DEFAULT NULL COMMENT '鑱屼綅',
  `STATUS` int(11) DEFAULT NULL COMMENT '鐘舵€侊紙1锛氬湪鑱岋紱2锛氱鑱岋級',
  PRIMARY KEY (`ID`),
  KEY `Index_1` (`ID`,`ID_CARD`),
  KEY `FK_REF_EMP_DEPT` (`DEPT_ID`),
  KEY `FK_REF_EMP_JOB` (`JOB_ID`),
  CONSTRAINT `FK_REF_EMP_DEPT` FOREIGN KEY (`DEPT_ID`) REFERENCES `hr_dept` (`ID`),
  CONSTRAINT `FK_REF_EMP_JOB` FOREIGN KEY (`JOB_ID`) REFERENCES `hr_job` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='鍛樺伐琛?;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_employee`
--

LOCK TABLES `hr_employee` WRITE;
/*!40000 ALTER TABLE `hr_employee` DISABLE KEYS */;
INSERT INTO `hr_employee` VALUES ('20200604101010000001','绠＄悊鍛?,1,'1',1,'1','2020-01-01','1','1',1,'1','1','1','20200604101010000003','20200604101010000001',1),('20200604101010000002','寮犱笁',1,'1',1,'1','2020-01-01','1','1',1,'1','1','1','20200604101010000001','20200604101010000002',1),('20200604101010000003','鏉庡洓',1,'1',1,'1','2020-01-01','1','1',1,'1','1','1','20200604101010000001','20200604101010000003',1),('20200607215501903072','鐜嬩簲',0,'111111111111111111',3,'111','2020-06-10','111','111',2,'','','','20200604101010000001','20200604101010000002',1);
/*!40000 ALTER TABLE `hr_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hr_job`
--

DROP TABLE IF EXISTS `hr_job`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_job` (
  `ID` varchar(20) NOT NULL COMMENT '鑱屼綅ID',
  `NAME` varchar(20) DEFAULT NULL COMMENT '鑱屼綅鍚嶇О',
  PRIMARY KEY (`ID`),
  KEY `Index_1` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='鑱屼綅绠＄悊';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_job`
--

LOCK TABLES `hr_job` WRITE;
/*!40000 ALTER TABLE `hr_job` DISABLE KEYS */;
INSERT INTO `hr_job` VALUES ('20200604101010000001','浜轰簨缁忕悊'),('20200604101010000002','椤圭洰缁忕悊'),('20200604101010000003','寮€鍙戝伐绋嬪笀'),('20200604101010000004','娴嬭瘯宸ョ▼甯?),('20200604101010000005','鏅€氬憳宸?);
/*!40000 ALTER TABLE `hr_job` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hr_leave`
--

DROP TABLE IF EXISTS `hr_leave`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_leave` (
  `ID` varchar(20) NOT NULL,
  `EMP_ID` varchar(20) DEFAULT NULL COMMENT '鍛樺伐ID',
  `TYPE` int(11) DEFAULT NULL COMMENT '璇峰亣绫诲瀷锛?锛氬勾鍋囷紝2锛氱梾鍋囷紝3锛氬鍋囷紝4锛氫骇鍋囷紝5锛氫簨鍋囷級',
  `LEAVE_DAY` int(11) DEFAULT NULL COMMENT '璇峰亣澶╂暟',
  `LEAVE_DATE` varchar(10) DEFAULT NULL COMMENT '寮€濮嬫棩鏈?,
  `CAUSE` varchar(500) DEFAULT NULL COMMENT '浜嬬敱',
  `STATUS` int(11) DEFAULT NULL COMMENT '瀹℃壒鐘舵€侊紙1锛氫繚瀛橈紝2锛氭彁浜ょ敵璇凤紝3锛氬鎵归€氳繃锛?锛氶┏鍥烇級',
  PRIMARY KEY (`ID`),
  KEY `Index_1` (`ID`,`EMP_ID`),
  KEY `FK_REF_LEAVE_EMP` (`EMP_ID`),
  CONSTRAINT `FK_REF_LEAVE_EMP` FOREIGN KEY (`EMP_ID`) REFERENCES `hr_employee` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='璇峰亣';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_leave`
--

LOCK TABLES `hr_leave` WRITE;
/*!40000 ALTER TABLE `hr_leave` DISABLE KEYS */;
INSERT INTO `hr_leave` VALUES ('20200607223706999312','20200604101010000003',2,1,'2020-05-07','1',2),('20200607223738070372','20200604101010000002',5,1,'2020-05-17','1',1);
/*!40000 ALTER TABLE `hr_leave` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hr_payroll`
--

DROP TABLE IF EXISTS `hr_payroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_payroll` (
  `ID` varchar(20) NOT NULL COMMENT 'ID',
  `EMP_ID` varchar(20) DEFAULT NULL COMMENT '鍛樺伐ID',
  `PAYROLL_DATE` varchar(10) DEFAULT NULL COMMENT '宸ヨ祫鍗曟棩鏈?,
  `PROBATION_STATUS` int(11) DEFAULT NULL COMMENT '鏄惁鍦ㄨ瘯鐢ㄦ湡锛?:鏄紝0锛氬惁锛?,
  `SICK_LEAVE_DAY` int(11) DEFAULT NULL COMMENT '鐥呭亣澶╂暟',
  `LEAVE_DAY` int(11) DEFAULT NULL COMMENT '浜嬪亣澶╂暟\n            ',
  `REAL_SALARY` decimal(18,2) DEFAULT NULL COMMENT '瀹為檯宸ヨ祫',
  PRIMARY KEY (`ID`),
  KEY `FK_REF_PAYROLL_EMP` (`EMP_ID`),
  CONSTRAINT `FK_REF_PAYROLL_EMP` FOREIGN KEY (`EMP_ID`) REFERENCES `hr_employee` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='宸ヨ祫鍗?;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_payroll`
--

LOCK TABLES `hr_payroll` WRITE;
/*!40000 ALTER TABLE `hr_payroll` DISABLE KEYS */;
INSERT INTO `hr_payroll` VALUES ('20200607224741186121','20200604101010000001','2020-05-07',0,0,0,5000.00),('20200607224741186122','20200604101010000002','2020-05-07',0,0,0,5000.00),('20200607224741186123','20200604101010000003','2020-05-07',1,1,0,3973.33);
/*!40000 ALTER TABLE `hr_payroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hr_user`
--

DROP TABLE IF EXISTS `hr_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hr_user` (
  `ID` varchar(20) NOT NULL COMMENT '鐢ㄦ埛ID',
  `EMP_ID` varchar(20) DEFAULT NULL COMMENT '鍛樺伐ID',
  `PASSWORD` varchar(20) DEFAULT NULL COMMENT '瀵嗙爜',
  `USERNAME` varchar(20) DEFAULT NULL COMMENT '鐢ㄦ埛鍚?,
  `USER_TYPE` int(11) DEFAULT NULL COMMENT '鐢ㄦ埛绫诲瀷锛?锛氭櫘閫氱敤鎴凤紱2锛氱鐞嗗憳鐢ㄦ埛锛?,
  PRIMARY KEY (`ID`),
  KEY `Index_1` (`ID`,`EMP_ID`,`PASSWORD`,`USERNAME`),
  KEY `FK_REF_USER_EMP` (`EMP_ID`),
  CONSTRAINT `FK_REF_USER_EMP` FOREIGN KEY (`EMP_ID`) REFERENCES `hr_employee` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='鐢ㄦ埛琛?';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hr_user`
--

LOCK TABLES `hr_user` WRITE;
/*!40000 ALTER TABLE `hr_user` DISABLE KEYS */;
INSERT INTO `hr_user` VALUES ('20200604101010000001','20200604101010000001','admin','admin',3),('20200604101010000002','20200604101010000002','123456','zhangsan',2),('20200604101010000003','20200604101010000003','123456','lisi',1),('20200607212638434145','20200604101010000002','123','wangwu',1);
/*!40000 ALTER TABLE `hr_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-07 22:55:12
