CREATE DATABASE  IF NOT EXISTS `test3` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `test3`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: test3
-- ------------------------------------------------------
-- Server version	5.7.37-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `booktbl`
--

DROP TABLE IF EXISTS `booktbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booktbl` (
  `bk_ISBN` bigint(13) NOT NULL,
  `bktitle` varchar(100) NOT NULL,
  `bkedition` varchar(25) CHARACTER SET latin1 NOT NULL,
  `bkauthor` varchar(45) NOT NULL,
  `bkpublisher` varchar(45) NOT NULL,
  `bkcopies` int(11) NOT NULL,
  `bk_totalcopies` int(11) NOT NULL,
  `bk_cost` decimal(19,2) NOT NULL,
  `bk_remarks` varchar(45) CHARACTER SET latin1 NOT NULL,
  `bk_publishdate` year(4) NOT NULL,
  `bk_categoryid` int(11) NOT NULL,
  PRIMARY KEY (`bk_ISBN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booktbl`
--

LOCK TABLES `booktbl` WRITE;
/*!40000 ALTER TABLE `booktbl` DISABLE KEYS */;
INSERT INTO `booktbl` VALUES (9781871063036,'Manic Audrino','1st Edition','M.K Filters','Independent',1,1,1520.30,'Purchased',2019,1),(9784567890123,'The Book of Death','2nd Edition','J.K Killjoy','Notingham Avenue Inc.',1,1,1750.50,'Good',2019,3),(9784567890523,'Fall of Pritsckov Stanislaw: Tales of Prakov\'s Freedom','1st Edition','M.S Sustankova','Warren Cove Publishing House',1,1,1000.00,'Purchased',2020,4),(9786565815156,'Uncanny Valley','1st Edition','Im Long Chai','Independent',2,2,1230.00,'Purchased',2021,2),(9788458156156,'The History of KPop','1st Edition','M.J Akerfeld','Independent',1,1,3000.00,'Donated',2022,3),(9788515156468,'Apron Powell\'s Cooking Diary','4th Edition','Apron Powell','Independent',1,1,3000.00,'Purchased',2015,4),(9788575465476,'MySQL for Beginners','1st Edition','Josh Castalone','Independent',1,1,4500.00,'Purchased',2022,1),(9789498489484,'Immortals','1st Edition','J.J Willo','Vivian Corpus Inc.',1,1,1200.00,'Purchased',2015,2);
/*!40000 ALTER TABLE `booktbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `borrowtbl`
--

DROP TABLE IF EXISTS `borrowtbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `borrowtbl` (
  `transaction_id` bigint(50) NOT NULL AUTO_INCREMENT,
  `borrower_id` int(11) NOT NULL,
  `bk_ISBN` bigint(13) NOT NULL,
  `borrowcopies_number` int(11) NOT NULL,
  `borrow_date` date NOT NULL,
  `due_date` date NOT NULL,
  PRIMARY KEY (`transaction_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `borrowtbl`
--

LOCK TABLES `borrowtbl` WRITE;
/*!40000 ALTER TABLE `borrowtbl` DISABLE KEYS */;
INSERT INTO `borrowtbl` VALUES (1,1234567898,9789498489484,1,'2022-03-10','2022-03-12'),(2,1234567891,9786565815156,1,'2022-03-10','2022-03-12');
/*!40000 ALTER TABLE `borrowtbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorytbl`
--

DROP TABLE IF EXISTS `categorytbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorytbl` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(50) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorytbl`
--

LOCK TABLES `categorytbl` WRITE;
/*!40000 ALTER TABLE `categorytbl` DISABLE KEYS */;
INSERT INTO `categorytbl` VALUES (1,'Databases'),(2,'Fiction'),(3,'Non-Fiction'),(4,'References');
/*!40000 ALTER TABLE `categorytbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gradelevel_tbl`
--

DROP TABLE IF EXISTS `gradelevel_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gradelevel_tbl` (
  `gradelevel_id` int(11) NOT NULL,
  `gradelevel_name` varchar(45) NOT NULL,
  PRIMARY KEY (`gradelevel_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gradelevel_tbl`
--

LOCK TABLES `gradelevel_tbl` WRITE;
/*!40000 ALTER TABLE `gradelevel_tbl` DISABLE KEYS */;
INSERT INTO `gradelevel_tbl` VALUES (1,'Grade 1'),(2,'Grade 2'),(3,'Grade 3'),(4,'Grade 4'),(5,'Grade 5'),(6,'Grade 6'),(7,'Grade 7'),(8,'Grade 8'),(9,'Grade 9'),(10,'Grade 10'),(11,'Grade 11'),(12,'Grade 12');
/*!40000 ALTER TABLE `gradelevel_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `returntbl`
--

DROP TABLE IF EXISTS `returntbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `returntbl` (
  `return_id` bigint(50) NOT NULL AUTO_INCREMENT,
  `borrower_id` int(11) NOT NULL,
  `bk_ISBN` bigint(13) NOT NULL,
  `borrowcopies_number` int(11) NOT NULL,
  `borrow_date` date NOT NULL,
  `due_date` date NOT NULL,
  `return_date` date NOT NULL,
  `penalty` decimal(19,2) DEFAULT NULL,
  PRIMARY KEY (`return_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `returntbl`
--

LOCK TABLES `returntbl` WRITE;
/*!40000 ALTER TABLE `returntbl` DISABLE KEYS */;
INSERT INTO `returntbl` VALUES (1,1234567898,9789498489484,1,'2022-03-10','2022-03-12','2022-03-11',0.00),(2,1234567891,9786565815156,1,'2022-03-10','2022-03-12','2022-03-10',0.00);
/*!40000 ALTER TABLE `returntbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `section_strandtbl`
--

DROP TABLE IF EXISTS `section_strandtbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `section_strandtbl` (
  `section_strandtbl_id` int(11) NOT NULL,
  `section_strand_name` varchar(45) NOT NULL,
  PRIMARY KEY (`section_strandtbl_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `section_strandtbl`
--

LOCK TABLES `section_strandtbl` WRITE;
/*!40000 ALTER TABLE `section_strandtbl` DISABLE KEYS */;
INSERT INTO `section_strandtbl` VALUES (1,'STEM'),(2,'GAS'),(3,'ABM');
/*!40000 ALTER TABLE `section_strandtbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studenttbl`
--

DROP TABLE IF EXISTS `studenttbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studenttbl` (
  `studentid` varchar(20) NOT NULL,
  `student_name` varchar(100) NOT NULL,
  `Sex` varchar(20) CHARACTER SET latin1 NOT NULL,
  `borrower_id` int(11) NOT NULL,
  `birthdate` date NOT NULL,
  `Grade_level` int(11) NOT NULL,
  `Section_strand` varchar(50) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `contact_no` int(11) DEFAULT NULL,
  `MobileNo` bigint(11) NOT NULL,
  `AcademicYear` varchar(45) CHARACTER SET latin1 NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`studentid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studenttbl`
--

LOCK TABLES `studenttbl` WRITE;
/*!40000 ALTER TABLE `studenttbl` DISABLE KEYS */;
INSERT INTO `studenttbl` VALUES ('1234567890','Josh Castalone','Male',1234567890,'2006-12-24',12,'STEM','Wawa, Pililla, Rizal',6540889,9058010210,'2021-2022','joshcastalone@gmail.com','Active'),('1234567891','Martin Jones','Male',1234567891,'2005-01-07',11,'GAS','Morong, Rizal',6540887,9058010230,'2021-2022','martinijones@yahoo.com','Active'),('1234567892','Miriam Spencer','Female',1234567892,'2005-03-04',11,'STEM','Tanay, Rizal',8885669,9542160359,'2021-2022','Tanay, Rizal','Inactive'),('1234567895','Mirio','Male',1234567895,'2004-03-06',11,'STEM','Pililla, Rizal',6540889,9058010210,'2021-2022','Pililla, Rizal','Inactive'),('1234567898','Max Miller','Male',1234567898,'2006-12-06',12,'GAS','Wawa, Tanay, Rizal',6540556,9083212543,'2021-2022','maxmiller@gmail.com','Active');
/*!40000 ALTER TABLE `studenttbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfiles`
--

DROP TABLE IF EXISTS `tblfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblfiles` (
  `FileId` int(11) NOT NULL AUTO_INCREMENT,
  `FileName` text NOT NULL,
  PRIMARY KEY (`FileId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfiles`
--

LOCK TABLES `tblfiles` WRITE;
/*!40000 ALTER TABLE `tblfiles` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usertbl`
--

DROP TABLE IF EXISTS `usertbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usertbl` (
  `Fname` varchar(45) NOT NULL,
  `Lname` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `role` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`Fname`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usertbl`
--

LOCK TABLES `usertbl` WRITE;
/*!40000 ALTER TABLE `usertbl` DISABLE KEYS */;
INSERT INTO `usertbl` VALUES ('John','Appleseed-Smith','japple','555','Admin','Active'),('Josa','Castalone','admin','12345','Admin','active'),('Josh','Kill','jikjin','1243','Admin','Inactive'),('Leon','Kennedy','leon','123','Librarian','active');
/*!40000 ALTER TABLE `usertbl` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-11 11:05:15
