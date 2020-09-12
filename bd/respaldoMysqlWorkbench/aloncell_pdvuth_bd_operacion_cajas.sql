CREATE DATABASE  IF NOT EXISTS `aloncell_pdvuth_bd` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `aloncell_pdvuth_bd`;
-- MySQL dump 10.13  Distrib 8.0.19, for macos10.15 (x86_64)
--
-- Host: 174.136.53.235    Database: aloncell_pdvuth_bd
-- ------------------------------------------------------
-- Server version	5.6.47-cll-lve

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
-- Table structure for table `operacion_cajas`
--

DROP TABLE IF EXISTS `operacion_cajas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `operacion_cajas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario_id` int(11) NOT NULL,
  `caja_id` int(11) DEFAULT NULL,
  `fondo` double DEFAULT '500',
  `observacion` text,
  `tipo_operacion` enum('APERTURA','CORTE','RETIRO','ABRIR_CAJON','REIMPRIMIR_TICKET','CONFIG') CHARACTER SET utf8 DEFAULT NULL,
  `fecha_hr` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_usuario_id_idx` (`usuario_id`),
  KEY `fk_caja_id_idx` (`caja_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operacion_cajas`
--

LOCK TABLES `operacion_cajas` WRITE;
/*!40000 ALTER TABLE `operacion_cajas` DISABLE KEYS */;
/*!40000 ALTER TABLE `operacion_cajas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-26 22:37:48
