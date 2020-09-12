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
-- Table structure for table `movimientos_de_usuario_log`
--

DROP TABLE IF EXISTS `movimientos_de_usuario_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimientos_de_usuario_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_hora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `usuario_id` int(11) NOT NULL,
  `tipo_de_movimiento` enum('APERTURA-CAJA','CORTE-CAJA','RETIRO','ABRIR-CAJON','COBRAR-CREDITO','CREAR-USUARIO','ACTIVAR-CLIENTE','DESACTIVAR-CLIENTE','CREAR-PRODUCTO') COLLATE utf8_spanish2_ci NOT NULL,
  `observacion` text COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_log_a_usuarios_idx` (`usuario_id`),
  CONSTRAINT `fk_log_a_usuarios` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos_de_usuario_log`
--

LOCK TABLES `movimientos_de_usuario_log` WRITE;
/*!40000 ALTER TABLE `movimientos_de_usuario_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimientos_de_usuario_log` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-26 22:37:44
