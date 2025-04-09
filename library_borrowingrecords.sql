-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: library
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `borrowingrecords`
--

DROP TABLE IF EXISTS `borrowingrecords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `borrowingrecords` (
  `BorrowingID` int NOT NULL AUTO_INCREMENT,
  `MemberID` int DEFAULT NULL,
  `BookID` int DEFAULT NULL,
  `BorrowedDate` date DEFAULT NULL,
  `DueDate` date DEFAULT NULL,
  `ReturnDate` date DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`BorrowingID`),
  KEY `MemberID` (`MemberID`),
  KEY `BookID` (`BookID`),
  CONSTRAINT `borrowingrecords_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`),
  CONSTRAINT `borrowingrecords_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `borrowingrecords`
--

LOCK TABLES `borrowingrecords` WRITE;
/*!40000 ALTER TABLE `borrowingrecords` DISABLE KEYS */;
INSERT INTO `borrowingrecords` VALUES (1,1,2,'2025-03-12','2025-05-12','2025-03-12',NULL),(2,1,3,'2025-03-12','2025-05-12','2025-03-12',NULL),(3,1,5,'2025-03-11','2025-05-11','2025-03-12',NULL),(6,1,5,'2025-03-13','2025-05-13','2025-03-15',NULL),(7,1,2,'2025-03-13','2025-05-13',NULL,NULL),(8,8,2,'2025-03-13','2025-05-13','2025-04-10',NULL),(9,9,1,'2025-03-10','2025-05-10','2025-03-15',NULL),(10,9,4,'2025-02-27','2025-04-27','2025-03-15',NULL),(11,9,2,'2025-02-01','2025-04-01','2025-03-15',NULL),(12,1,5,'2025-03-04','2025-05-04',NULL,NULL),(13,1,1,'2025-03-04','2025-05-04','2025-04-05',NULL),(14,1,3,'2025-03-02','2025-05-02','2025-05-03',NULL),(15,1,5,'2025-03-01','2025-05-01',NULL,NULL),(16,9,3,'2025-02-26','2025-04-26',NULL,NULL),(17,1,5,'2025-04-05','2025-06-05',NULL,NULL);
/*!40000 ALTER TABLE `borrowingrecords` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-06 17:51:45
