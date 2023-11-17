-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: proyecto
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.28-MariaDB

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
-- Table structure for table `almacenan`
--

DROP TABLE IF EXISTS `almacenan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacenan` (
  `Id_Pedidos` int(11) NOT NULL,
  `Id_Almacen` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Pedidos`),
  KEY `Id_Almacen` (`Id_Almacen`),
  CONSTRAINT `almacenan_ibfk_1` FOREIGN KEY (`Id_Almacen`) REFERENCES `almacenes` (`Id_Almacen`),
  CONSTRAINT `almacenan_ibfk_2` FOREIGN KEY (`Id_Pedidos`) REFERENCES `pedidos` (`Id_Pedidos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenan`
--

LOCK TABLES `almacenan` WRITE;
/*!40000 ALTER TABLE `almacenan` DISABLE KEYS */;
INSERT INTO `almacenan` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,11),(12,12),(13,13),(14,14),(15,15);
/*!40000 ALTER TABLE `almacenan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacenes`
--

DROP TABLE IF EXISTS `almacenes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacenes` (
  `Id_Almacen` int(11) NOT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Direccion` varchar(255) DEFAULT NULL,
  `Departamento` int(11) DEFAULT NULL,
  `Ciudad` int(11) DEFAULT NULL,
  `Calle` varchar(255) DEFAULT NULL,
  `Numero_De_Puerta` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Almacen`),
  KEY `Departamento` (`Departamento`),
  KEY `Ciudad` (`Ciudad`),
  CONSTRAINT `almacenes_ibfk_1` FOREIGN KEY (`Departamento`) REFERENCES `departamento` (`Id_Departamento`),
  CONSTRAINT `almacenes_ibfk_2` FOREIGN KEY (`Ciudad`) REFERENCES `ciudad` (`Id_Ciudad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenes`
--

LOCK TABLES `almacenes` WRITE;
/*!40000 ALTER TABLE `almacenes` DISABLE KEYS */;
INSERT INTO `almacenes` VALUES (1,'Almacén 1','Dirección 1',1,1,'Calle 1',123),(2,'Almacén 2','Dirección 2',2,2,'Calle 2',456),(3,'Almacén 3','Dirección 3',3,3,'Calle 3',789),(4,'Almacén 4','Dirección 4',1,1,'Calle 4',101),(5,'Almacén 5','Dirección 5',2,2,'Calle 5',111),(6,'Almacén 6','Dirección 6',3,3,'Calle 6',222),(7,'Almacén 7','Dirección 7',1,1,'Calle 7',333),(8,'Almacén 8','Dirección 8',2,2,'Calle 8',444),(9,'Almacén 9','Dirección 9',3,3,'Calle 9',555),(10,'Almacén 10','Dirección 10',1,1,'Calle 10',666),(11,'Almacén 11','Dirección 11',2,2,'Calle 11',777),(12,'Almacén 12','Dirección 12',3,3,'Calle 12',888),(13,'Almacén 13','Dirección 13',1,1,'Calle 13',999),(14,'Almacén 14','Dirección 14',2,2,'Calle 14',1010),(15,'Almacén 15','Dirección 15',3,3,'Calle 15',1111);
/*!40000 ALTER TABLE `almacenes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ciudad` (
  `Id_Ciudad` int(11) NOT NULL,
  `Id_Departamento` int(11) DEFAULT NULL,
  `Nombre_Ciudad` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id_Ciudad`),
  KEY `Id_Departamento` (`Id_Departamento`),
  CONSTRAINT `ciudad_ibfk_1` FOREIGN KEY (`Id_Departamento`) REFERENCES `departamento` (`Id_Departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,1,'Artigas'),(2,1,'Bella Unión'),(3,1,'Tomás Gomensoro'),(4,2,'Canelones'),(5,2,'Las Piedras'),(6,2,'Pando'),(7,3,'Melo'),(8,3,'Aceguá'),(9,3,'Fraile Muerto'),(10,4,'Colonia del Sacramento'),(11,4,'Nueva Helvecia'),(12,4,'Carmelo'),(13,5,'Durazno'),(14,5,'Sarandí del Yí'),(15,5,'Blanquillo'),(16,6,'Trinidad'),(17,6,'Ismael Cortinas'),(18,6,'Capilla del Sauce'),(19,7,'Florida'),(20,7,'Cardal'),(21,7,'25 de Agosto'),(22,8,'Minas'),(23,8,'Solís de Mataojo'),(24,8,'José Pedro Varela'),(25,9,'Maldonado'),(26,9,'Punta del Este'),(27,9,'San Carlos'),(28,10,'Montevideo'),(29,11,'Paysandú'),(30,11,'Quebracho'),(31,11,'Guichón'),(32,12,'Fray Bentos'),(33,12,'Young'),(34,12,'Nuevo Berlín'),(35,13,'Rivera'),(36,13,'Bella Unión'),(37,13,'Vichadero'),(38,14,'Rocha'),(39,14,'Castillos'),(40,14,'Chuy'),(41,15,'Salto'),(42,15,'Daymán'),(43,15,'Arapey'),(44,16,'San José de Mayo'),(45,16,'Libertad'),(46,16,'Rodríguez'),(47,17,'Mercedes'),(48,17,'Dolores'),(49,17,'Cardona'),(50,18,'Tacuarembó'),(51,18,'Paso de los Toros'),(52,18,'San Gregorio de Polanco'),(53,19,'Treinta y Tres'),(54,19,'Vergara'),(55,19,'Rincón de la Buena Vista');
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conduce`
--

DROP TABLE IF EXISTS `conduce`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conduce` (
  `Cedula` int(11) NOT NULL,
  `Matricula` varchar(7) NOT NULL,
  PRIMARY KEY (`Cedula`,`Matricula`),
  KEY `Matricula` (`Matricula`),
  CONSTRAINT `conduce_ibfk_1` FOREIGN KEY (`Cedula`) REFERENCES `usuario` (`Cedula`),
  CONSTRAINT `conduce_ibfk_2` FOREIGN KEY (`Matricula`) REFERENCES `transporte` (`Matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conduce`
--

LOCK TABLES `conduce` WRITE;
/*!40000 ALTER TABLE `conduce` DISABLE KEYS */;
INSERT INTO `conduce` VALUES (1,'ABC123'),(2,'XYZ789'),(3,'LMN456'),(4,'PQR789'),(5,'JKL321'),(6,'EFG987'),(7,'MNO654'),(8,'HIJ012'),(9,'UVW345'),(10,'RST678'),(11,'IJK123'),(12,'XYZ012'),(13,'ABC789'),(14,'PQR321'),(15,'LMN789');
/*!40000 ALTER TABLE `conduce` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `Id_Departamento` int(11) NOT NULL,
  `Nombre_Departamento` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id_Departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Artigas'),(2,'Canelones'),(3,'Cerro Largo'),(4,'Colonia'),(5,'Durazno'),(6,'Flores'),(7,'Florida'),(8,'Lavalleja'),(9,'Maldonado'),(10,'Montevideo'),(11,'Paysandú'),(12,'Río Negro'),(13,'Rivera'),(14,'Rocha'),(15,'Salto'),(16,'San José'),(17,'Soriano'),(18,'Tacuarembó'),(19,'Treinta y Tres');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lotes`
--

DROP TABLE IF EXISTS `lotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lotes` (
  `Id_Lote` int(11) NOT NULL,
  `Estado_Boolean` tinyint(1) DEFAULT NULL,
  `Peso` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Lote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lotes`
--

LOCK TABLES `lotes` WRITE;
/*!40000 ALTER TABLE `lotes` DISABLE KEYS */;
INSERT INTO `lotes` VALUES (1,1,100),(2,0,200),(3,1,150),(4,0,180),(5,1,120),(6,1,250),(7,0,90),(8,1,300),(9,0,170),(10,1,140),(11,1,210),(12,0,160),(13,1,280),(14,0,110),(15,1,190);
/*!40000 ALTER TABLE `lotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `Id_Pedidos` int(11) NOT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora_Ingreso` time DEFAULT NULL,
  `Direccion_Entrega` varchar(255) DEFAULT NULL,
  `Departamento` int(11) DEFAULT NULL,
  `Ciudad` int(11) DEFAULT NULL,
  `Calle` varchar(255) DEFAULT NULL,
  `Numero_Puerta` int(11) DEFAULT NULL,
  `Info_Cliente` varchar(255) DEFAULT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Cedula` int(11) DEFAULT NULL,
  `Peso` int(11) DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id_Pedidos`),
  KEY `Cedula` (`Cedula`),
  KEY `Departamento` (`Departamento`),
  KEY `Ciudad` (`Ciudad`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`Cedula`) REFERENCES `usuario` (`Cedula`),
  CONSTRAINT `pedidos_ibfk_2` FOREIGN KEY (`Departamento`) REFERENCES `departamento` (`Id_Departamento`),
  CONSTRAINT `pedidos_ibfk_3` FOREIGN KEY (`Ciudad`) REFERENCES `ciudad` (`Id_Ciudad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,'2023-11-13','14:30:00','Calle 1',10,1,'Calle A',123,'1','Pedido 1',1,30,NULL),(2,'2023-11-14','15:00:00','Calle 2',10,2,'Calle B',456,'2','Pedido 2',2,80,NULL),(3,'2023-11-15','16:30:00','Calle 3',10,3,'Calle C',789,'3','Pedido 3',3,90,NULL),(4,'2023-11-16','17:00:00','Calle 4',10,4,'Calle D',101,'4','Pedido 4',4,102,NULL),(5,'2023-11-17','18:30:00','Calle 5',5,7,'Calle E',111,'2','Pedido 5',5,506,NULL),(6,'2023-11-18','19:00:00','Calle 6',7,18,'Calle F',222,'3','Pedido 6',6,15,NULL),(7,'2023-11-19','20:30:00','Calle 7',5,7,'Calle G',333,'4','Pedido 7',7,69,NULL),(8,'2023-11-20','21:00:00','Calle 8',10,2,'Calle H',444,'2','Pedido 8',8,24,NULL),(9,'2023-11-21','22:30:00','Calle 9',10,1,'Calle I',555,'3','Pedido 9',9,1000,NULL),(10,'2023-11-22','23:00:00','Calle 10',11,28,'Calle J',666,'1','Pedido 10',10,860,NULL),(11,'2023-11-23','14:30:00','Calle 11',6,15,'Calle K',777,'4','Pedido 11',11,526,NULL),(12,'2023-11-24','15:00:00','Calle 12',9,21,'Calle L',888,'3','Pedido 12',12,86,NULL),(13,'2023-11-25','16:30:00','Calle 13',16,37,'Calle M',999,'4','Pedido 13',13,92,NULL),(14,'2023-11-26','17:00:00','Calle 14',13,15,'Calle N',1010,'2','Pedido 14',14,26,NULL),(15,'2023-11-27','18:30:00','Calle 15',19,46,'Calle O',1111,'4','Pedido 15',15,87,NULL);
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posee`
--

DROP TABLE IF EXISTS `posee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posee` (
  `Cedula` int(11) NOT NULL,
  `Id_Rol` int(11) DEFAULT NULL,
  PRIMARY KEY (`Cedula`),
  KEY `Id_Rol` (`Id_Rol`),
  CONSTRAINT `posee_ibfk_1` FOREIGN KEY (`Cedula`) REFERENCES `usuario` (`Cedula`),
  CONSTRAINT `posee_ibfk_2` FOREIGN KEY (`Id_Rol`) REFERENCES `rol` (`Id_Rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posee`
--

LOCK TABLES `posee` WRITE;
/*!40000 ALTER TABLE `posee` DISABLE KEYS */;
INSERT INTO `posee` VALUES (1,1),(10,1),(2,2),(5,2),(8,2),(14,2),(3,3),(6,3),(9,3),(12,3),(4,4),(7,4),(11,4),(13,4),(15,4);
/*!40000 ALTER TABLE `posee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `realiza`
--

DROP TABLE IF EXISTS `realiza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `realiza` (
  `Id_Trayecto` int(11) DEFAULT NULL,
  `Id_Ruta` int(11) DEFAULT NULL,
  `Id_Lote` int(11) DEFAULT NULL,
  KEY `Id_Trayecto` (`Id_Trayecto`),
  KEY `Id_Ruta` (`Id_Ruta`),
  KEY `Id_Lote` (`Id_Lote`),
  CONSTRAINT `realiza_ibfk_1` FOREIGN KEY (`Id_Trayecto`) REFERENCES `rel_trayecto_ruta` (`Id_Trayecto`),
  CONSTRAINT `realiza_ibfk_2` FOREIGN KEY (`Id_Ruta`) REFERENCES `ruta` (`Id_Ruta`),
  CONSTRAINT `realiza_ibfk_3` FOREIGN KEY (`Id_Lote`) REFERENCES `transporta` (`Id_Lote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `realiza`
--

LOCK TABLES `realiza` WRITE;
/*!40000 ALTER TABLE `realiza` DISABLE KEYS */;
/*!40000 ALTER TABLE `realiza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rel_almacenes_transporta`
--

DROP TABLE IF EXISTS `rel_almacenes_transporta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rel_almacenes_transporta` (
  `Id_Lote` int(11) NOT NULL,
  `Id_Almacen` int(11) DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  PRIMARY KEY (`Id_Lote`),
  KEY `Id_Almacen` (`Id_Almacen`),
  CONSTRAINT `rel_almacenes_transporta_ibfk_1` FOREIGN KEY (`Id_Almacen`) REFERENCES `almacenes` (`Id_Almacen`),
  CONSTRAINT `rel_almacenes_transporta_ibfk_2` FOREIGN KEY (`Id_Lote`) REFERENCES `transporta` (`Id_Lote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rel_almacenes_transporta`
--

LOCK TABLES `rel_almacenes_transporta` WRITE;
/*!40000 ALTER TABLE `rel_almacenes_transporta` DISABLE KEYS */;
INSERT INTO `rel_almacenes_transporta` VALUES (1,1,'14:30:00','2023-11-13'),(2,2,'15:00:00','2023-11-14'),(3,3,'16:30:00','2023-11-15'),(4,4,'17:00:00','2023-11-16'),(5,5,'18:30:00','2023-11-17'),(6,6,'19:00:00','2023-11-18'),(7,7,'20:30:00','2023-11-19'),(8,8,'21:00:00','2023-11-20'),(9,9,'22:30:00','2023-11-21'),(10,10,'23:00:00','2023-11-22'),(11,11,'14:30:00','2023-11-23'),(12,12,'15:00:00','2023-11-24'),(13,13,'16:30:00','2023-11-25'),(14,14,'17:00:00','2023-11-26'),(15,15,'18:30:00','2023-11-27');
/*!40000 ALTER TABLE `rel_almacenes_transporta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rel_lote_pedidos`
--

DROP TABLE IF EXISTS `rel_lote_pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rel_lote_pedidos` (
  `Id_Pedidos` int(11) NOT NULL,
  `Id_Lote` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Pedidos`),
  KEY `Id_Lote` (`Id_Lote`),
  CONSTRAINT `rel_lote_pedidos_ibfk_1` FOREIGN KEY (`Id_Lote`) REFERENCES `lotes` (`Id_Lote`),
  CONSTRAINT `rel_lote_pedidos_ibfk_2` FOREIGN KEY (`Id_Pedidos`) REFERENCES `pedidos` (`Id_Pedidos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rel_lote_pedidos`
--

LOCK TABLES `rel_lote_pedidos` WRITE;
/*!40000 ALTER TABLE `rel_lote_pedidos` DISABLE KEYS */;
INSERT INTO `rel_lote_pedidos` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,11),(12,12),(13,13),(14,14),(15,15);
/*!40000 ALTER TABLE `rel_lote_pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rel_pedidos_camionetas`
--

DROP TABLE IF EXISTS `rel_pedidos_camionetas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rel_pedidos_camionetas` (
  `Id_Pedidos` int(11) NOT NULL,
  `Matricula` varchar(7) NOT NULL,
  `Hora` time DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id_Pedidos`,`Matricula`),
  KEY `Matricula` (`Matricula`),
  CONSTRAINT `rel_pedidos_camionetas_ibfk_1` FOREIGN KEY (`Id_Pedidos`) REFERENCES `pedidos` (`Id_Pedidos`),
  CONSTRAINT `rel_pedidos_camionetas_ibfk_2` FOREIGN KEY (`Matricula`) REFERENCES `transporte` (`Matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rel_pedidos_camionetas`
--

LOCK TABLES `rel_pedidos_camionetas` WRITE;
/*!40000 ALTER TABLE `rel_pedidos_camionetas` DISABLE KEYS */;
INSERT INTO `rel_pedidos_camionetas` VALUES (1,'ABC123','14:30:00','2023-11-13',1),(2,'XYZ789','15:00:00','2023-11-14',1),(3,'LMN456','16:30:00','2023-11-15',0),(4,'PQR789','17:00:00','2023-11-16',1),(5,'JKL321','18:30:00','2023-11-17',1),(6,'EFG987','19:00:00','2023-11-18',0),(7,'MNO654','20:30:00','2023-11-19',1),(8,'HIJ012','21:00:00','2023-11-20',1),(9,'UVW345','22:30:00','2023-11-21',0),(10,'RST678','23:00:00','2023-11-22',1),(11,'IJK123','14:30:00','2023-11-23',0),(12,'XYZ012','15:00:00','2023-11-24',1),(13,'ABC789','16:30:00','2023-11-25',1),(14,'PQR321','17:00:00','2023-11-26',0),(15,'LMN789','18:30:00','2023-11-27',1);
/*!40000 ALTER TABLE `rel_pedidos_camionetas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rel_trayecto_ruta`
--

DROP TABLE IF EXISTS `rel_trayecto_ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rel_trayecto_ruta` (
  `Id_Trayecto` int(11) NOT NULL,
  `Id_Ruta` int(11) NOT NULL,
  PRIMARY KEY (`Id_Trayecto`,`Id_Ruta`),
  KEY `Id_Ruta` (`Id_Ruta`),
  CONSTRAINT `rel_trayecto_ruta_ibfk_1` FOREIGN KEY (`Id_Trayecto`) REFERENCES `trayecto` (`Id_Trayecto`),
  CONSTRAINT `rel_trayecto_ruta_ibfk_2` FOREIGN KEY (`Id_Ruta`) REFERENCES `ruta` (`Id_Ruta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rel_trayecto_ruta`
--

LOCK TABLES `rel_trayecto_ruta` WRITE;
/*!40000 ALTER TABLE `rel_trayecto_ruta` DISABLE KEYS */;
INSERT INTO `rel_trayecto_ruta` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,11),(12,12),(13,13),(14,14),(15,15);
/*!40000 ALTER TABLE `rel_trayecto_ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `Id_Rol` int(11) NOT NULL,
  `Nombre_Rol` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id_Rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Administrativo'),(2,'Chofer'),(3,'Almacenero'),(4,'Cliente');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `Id_Ruta` int(11) NOT NULL,
  `Nombre_Ruta` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id_Ruta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (1,'Ruta 1'),(2,'Ruta 2'),(3,'Ruta 3'),(4,'Ruta 4'),(5,'Ruta 5'),(6,'Ruta 6'),(7,'Ruta 7'),(8,'Ruta 8'),(9,'Ruta 9'),(10,'Ruta 10'),(11,'Ruta 11'),(12,'Ruta 12'),(13,'Ruta 13'),(14,'Ruta 14'),(15,'Ruta 15');
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajan`
--

DROP TABLE IF EXISTS `trabajan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trabajan` (
  `Cedula` int(11) NOT NULL,
  `Id_Almacenes` int(11) DEFAULT NULL,
  PRIMARY KEY (`Cedula`),
  KEY `Id_Almacenes` (`Id_Almacenes`),
  CONSTRAINT `trabajan_ibfk_1` FOREIGN KEY (`Id_Almacenes`) REFERENCES `almacenes` (`Id_Almacen`),
  CONSTRAINT `trabajan_ibfk_2` FOREIGN KEY (`Cedula`) REFERENCES `usuario` (`Cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajan`
--

LOCK TABLES `trabajan` WRITE;
/*!40000 ALTER TABLE `trabajan` DISABLE KEYS */;
INSERT INTO `trabajan` VALUES (3,1),(12,2),(6,4),(9,8);
/*!40000 ALTER TABLE `trabajan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporta`
--

DROP TABLE IF EXISTS `transporta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporta` (
  `Id_Lote` int(11) NOT NULL,
  `Matricula` varchar(7) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  PRIMARY KEY (`Id_Lote`),
  KEY `Matricula` (`Matricula`),
  CONSTRAINT `transporta_ibfk_1` FOREIGN KEY (`Matricula`) REFERENCES `transporte` (`Matricula`),
  CONSTRAINT `transporta_ibfk_2` FOREIGN KEY (`Id_Lote`) REFERENCES `lotes` (`Id_Lote`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporta`
--

LOCK TABLES `transporta` WRITE;
/*!40000 ALTER TABLE `transporta` DISABLE KEYS */;
INSERT INTO `transporta` VALUES (1,'ABC123','2023-11-13','14:30:00'),(2,'XYZ789','2023-11-14','15:00:00'),(3,'LMN456','2023-11-15','16:30:00'),(4,'PQR789','2023-11-16','17:00:00'),(5,'JKL321','2023-11-17','18:30:00'),(6,'EFG987','2023-11-18','19:00:00'),(7,'MNO654','2023-11-19','20:30:00'),(8,'HIJ012','2023-11-20','21:00:00'),(9,'UVW345','2023-11-21','22:30:00'),(10,'RST678','2023-11-22','23:00:00'),(11,'IJK123','2023-11-23','14:30:00'),(12,'XYZ012','2023-11-24','15:00:00'),(13,'ABC789','2023-11-25','16:30:00'),(14,'PQR321','2023-11-26','17:00:00'),(15,'LMN789','2023-11-27','18:30:00');
/*!40000 ALTER TABLE `transporta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporte`
--

DROP TABLE IF EXISTS `transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transporte` (
  `Matricula` varchar(7) NOT NULL,
  `Estado` tinyint(1) DEFAULT NULL,
  `Capacidad_De_Carga` int(11) DEFAULT NULL,
  `Modelo` varchar(255) DEFAULT NULL,
  `Marca` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporte`
--

LOCK TABLES `transporte` WRITE;
/*!40000 ALTER TABLE `transporte` DISABLE KEYS */;
INSERT INTO `transporte` VALUES ('ABC123',1,500,'Modelo 1','Marca 1'),('ABC789',1,550,'Modelo 13','Marca 13'),('EFG987',1,480,'Modelo 6','Marca 6'),('HIJ012',1,600,'Modelo 8','Marca 8'),('IJK123',1,520,'Modelo 11','Marca 11'),('JKL321',0,450,'Modelo 5','Marca 5'),('LMN456',0,700,'Modelo 3','Marca 3'),('LMN789',0,600,'Modelo 15','Marca 15'),('MNO654',0,520,'Modelo 7','Marca 7'),('PQR321',1,500,'Modelo 14','Marca 14'),('PQR789',1,550,'Modelo 4','Marca 4'),('RST678',0,700,'Modelo 10','Marca 10'),('UVW345',1,580,'Modelo 9','Marca 9'),('XYZ012',0,480,'Modelo 12','Marca 12'),('XYZ789',1,600,'Modelo 2','Marca 2');
/*!40000 ALTER TABLE `transporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trayecto`
--

DROP TABLE IF EXISTS `trayecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trayecto` (
  `Id_Trayecto` int(11) NOT NULL,
  `Duracion` time DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Ciudad_Inicial` int(11) DEFAULT NULL,
  `Ciudad_Final` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Trayecto`),
  KEY `Ciudad_Inicial` (`Ciudad_Inicial`),
  KEY `Ciudad_Final` (`Ciudad_Final`),
  CONSTRAINT `trayecto_ibfk_1` FOREIGN KEY (`Ciudad_Inicial`) REFERENCES `ciudad` (`Id_Ciudad`),
  CONSTRAINT `trayecto_ibfk_2` FOREIGN KEY (`Ciudad_Final`) REFERENCES `ciudad` (`Id_Ciudad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trayecto`
--

LOCK TABLES `trayecto` WRITE;
/*!40000 ALTER TABLE `trayecto` DISABLE KEYS */;
INSERT INTO `trayecto` VALUES (1,'02:30:00',NULL,1,3),(2,'03:00:00',NULL,3,5),(3,'02:45:00',NULL,5,7),(4,'02:15:00',NULL,7,9),(5,'03:30:00',NULL,9,11),(6,'02:45:00',NULL,11,13),(7,'03:15:00',NULL,13,15),(8,'02:30:00',NULL,15,17),(9,'03:00:00',NULL,17,19),(10,'02:45:00',NULL,19,21),(11,'02:15:00',NULL,21,23),(12,'03:30:00',NULL,23,25),(13,'02:45:00',NULL,25,27),(14,'03:15:00',NULL,27,29),(15,'02:30:00',NULL,29,31);
/*!40000 ALTER TABLE `trayecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `Cedula` int(11) NOT NULL,
  `Usuario` varchar(255) DEFAULT NULL,
  `Nombre_Completo` varchar(255) DEFAULT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Apellido` varchar(255) DEFAULT NULL,
  `Cotrasena` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Juan1','Juan Pérez','Juan','Pérez','clave123'),(2,'Maria2','María Rodríguez','María','Rodríguez','contraseña456'),(3,'Luis3','Luis González','Luis','González','pass789'),(4,'Ana4','Ana Sánchez','Ana','Sánchez','secreta987'),(5,'Carlos5','Carlos Martínez','Carlos','Martínez','password1234'),(6,'Laura6','Laura Fernández','Laura','Fernández','miclave567'),(7,'Pablo7','Pablo López','Pablo','López','123abc'),(8,'Sofia8','Sofía Silva','Sofía','Silva','contraseña123'),(9,'Diego9','Diego Pérez','Diego','Pérez','clave456'),(10,'Valentina10','Valentina Rodríguez','Valentina','Rodríguez','pass7890'),(11,'Fernando11','Fernando González','Fernando','González','contraseña321'),(12,'Lorena12','Lorena Sánchez','Lorena','Sánchez','secreta654'),(13,'Javier13','Javier Martínez','Javier','Martínez','password987'),(14,'Silvana14','Silvina Fernández','Silvina','Fernández','miclave321'),(15,'Robert15','Roberto López','Roberto','López','1234abc');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-15 21:45:51
