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
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  `apellido_paterno` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  `apellido_materno` varchar(30) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `fecha_de_nacimiento` date NOT NULL,
  `celular` varchar(10) COLLATE utf8_spanish2_ci NOT NULL,
  `telefono` varchar(10) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `correo` varchar(50) COLLATE utf8_spanish2_ci NOT NULL,
  `calle` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  `numero_casa` varchar(6) COLLATE utf8_spanish2_ci NOT NULL,
  `codigo_postal` varchar(5) COLLATE utf8_spanish2_ci NOT NULL,
  `colonia` varchar(20) COLLATE utf8_spanish2_ci NOT NULL,
  `fraccionamiento` varchar(30) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `localidad` varchar(30) COLLATE utf8_spanish2_ci DEFAULT NULL,
  `municipio` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  `img_comprobante_domicilio` text COLLATE utf8_spanish2_ci NOT NULL,
  `ine_comprobante` text COLLATE utf8_spanish2_ci NOT NULL,
  `curp` varchar(18) COLLATE utf8_spanish2_ci NOT NULL,
  `curp_comprobante` text COLLATE utf8_spanish2_ci NOT NULL,
  `acta_nacimiento` text COLLATE utf8_spanish2_ci NOT NULL,
  `certificado_estudios` text COLLATE utf8_spanish2_ci NOT NULL,
  `numero_seguro_social` varchar(11) COLLATE utf8_spanish2_ci NOT NULL,
  `tipo_usuario` enum('ADMINISTRADOR','CAJERO') COLLATE utf8_spanish2_ci NOT NULL,
  `pwd` varchar(30) COLLATE utf8_spanish2_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish2_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'SUPER','ADMIN','ISTRADOR','1990-01-01','6621379254','66220000','admin@gmail.com','privada admin','22','83290','Admin','Admin','Hermosillo','Hermosillo','admin.jpg','admin.jpg','LORA790310HSRPML03','curp_admin.jpg','acta_admin.jpg','admin.jpg','00220022','ADMINISTRADOR','123123123'),(2,'CAJERO','CAJA','RO','1990-01-02','6622000000','662210000','cajero@gmail.com','caja','1','83000','Cajeros','Caja','Hermosillo','Hermosillo','cajeros.jpg','cajero.jpg','CAJE20202020202020','caja.jpg','acta_caja.jpg','caje.jpg','00220202','CAJERO','123123123');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-26 22:38:07
