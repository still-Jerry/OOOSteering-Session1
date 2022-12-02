-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: trade2
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `ProductName` text NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductCategory` text NOT NULL,
  `ProductPhoto` text NOT NULL,
  `ProductManufacturer` text NOT NULL,
  `ProductCost` decimal(19,2) NOT NULL,
  `ProductDiscountAmount` tinyint DEFAULT NULL,
  `ProductQuantityInStock` int NOT NULL,
  `ProductStatus` text,
  `uniti` varchar(45) NOT NULL,
  `ProductDiscountAmountMax` tinyint DEFAULT NULL,
  `ProductGiver` text NOT NULL,
  PRIMARY KEY (`ProductArticleNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (' M562Y7','Мультиметр','Мультиметр JTC 1227A автомобильный','Аксессуары','','JTC',14200.00,3,12,NULL,'шт.',5,'Максидом'),('A782R4','Аккумулятор','Аккумулятор автомобильный BIG FIGHTER 55р','Автозапчасти','A782R4.jpg','BIG FIGHTER',4500.00,2,24,NULL,'шт.',30,'Максидом'),('B702T6','Домкрат','Домкрат ALCA 436000','Автосервис','','ALCA',2700.00,2,3,NULL,'шт.',10,'220-volt'),('D374E4','Съемник подшипников','Съемник AIRLINE AT-GP2-05','Съемники подшипников','D374E4.jpeg','AIRLINE',1400.00,3,2,NULL,'шт.',20,'220-volt'),('D799T6','Съемник подшипников','Съемник для подшипников JTC 9000','Съемники подшипников','','JTC',1800.00,2,6,NULL,'шт.',25,'220-volt'),('E679R3','Автошампунь','Автошампунь GRASS 800026 Active Foam Truck','Автосервис','','GRASS',4000.00,4,14,NULL,'шт.',15,'220-volt'),('E932T8','Полироль','Полироль GRASS 125101 Black Brilliance','Автосервис','','GRASS',2100.00,3,23,NULL,'шт.',25,'220-volt'),('F026R4','Антифриз','Антифриз сине-зеленый MOBIL ANTIFREEZE EXTRA','Автосервис','','MOBIL',530.00,2,13,NULL,'шт.',15,'220-volt'),('F938T5','Антифриз','Антифриз красный TCL LLC01212','Автосервис','','TCL',1200.00,4,34,NULL,'шт.',15,'220-volt'),('H572T6','Парктроник','Парктроник AIRLINE APS-8L-02','Автозапчасти','','AIRLINE',2900.00,5,12,NULL,'шт.',15,'220-volt'),('K702L6','Ключ','Ключ JONNESWAY W233032 (30 / 32 мм)','Ручные инструменты','','JONNESWAY',1600.00,3,9,NULL,'шт.',15,'220-volt'),('K830R4','Колпак для колеса','Колпак для колеса AIRLINE Супер Астра R16 серебристый 2шт','Автозапчасти','K830R4.jpg','AIRLINE',915.00,3,14,NULL,'уп.',20,'Максидом'),('K849L6','Набор ключей','Набор ключей накидных STV 00-00010990 6шт.','Ручные инструменты','K849L6.jpeg','STV',780.00,2,23,NULL,'уп.',15,'220-volt'),('L802Y5','Лопата','Лопата саперная AIRLINE AB-S-03','Аксессуары','','AIRLINE',870.00,4,23,NULL,'шт.',5,'220-volt'),('O393R4','Отвертка','Отвертка JONNESWAY D04P2100','Ручные инструменты','O393R4.jpeg','JONNESWAY',460.00,3,14,NULL,'шт.',15,'220-volt'),('P023T2','Провода прикуривания','Провода прикуривания в сумке SMART CABLE 700 4,5м','Автозапчасти','','SMART',3400.00,2,6,NULL,'шт.',20,'Максидом'),('P307T5','Провода прикуривания','Провода прикуривания в сумке EXPERT 400А 2,5м','Автозапчасти','','EXPERT',700.00,4,2,NULL,'шт.',10,'Максидом'),('P439R4','Пассатижи','Пассатижи HAMMER Flex 601-050 160 мм (6 дюймов)','Аксессуары','','HAMMER',310.00,3,34,NULL,'шт.',5,'Максидом'),('S021R4','Адаптер для щеток','Адаптер для щеток стеклоочистителя ALCA Top Lock A/C блистер 2 шт','Автозапчасти','','ALCA',200.00,2,13,NULL,'уп.',3,'Максидом'),('S037R9','Щетка','Щётка AIRLINE AB-H-03','Аксессуары','S037R9.jpeg','AIRLINE',740.00,2,26,NULL,'шт.',25,'220-volt'),('S625T5','Щетка','щетка стеклоочистителя ALCA Start 16\"/40см каркасная\"','Автозапчасти','','ALCA',249.00,3,12,NULL,'шт.',20,'Максидом'),('S826R4','Щетка','Щетка стеклоочистителя ALCA Super flat 19\"/48см бескаркасная\"','Автозапчасти','','ALCA',530.00,4,28,NULL,'шт.',2,'Максидом'),('S983R4','Щетка','Щетка с/о BOSCH ECO 65C 650мм каркасная','Автозапчасти','S983R4.jpg','BOSCH',500.00,4,8,NULL,'шт.',15,'Максидом'),('T589T6','Термометр','Термометр ALCA 577000','Аксессуары','','ALCA',1400.00,2,3,NULL,'шт.',10,'220-volt'),('V892T6','Свеча зажигания','Свеча зажигания CHAMPION IGP F7RTC','Автозапчасти','','CHAMPION',130.00,3,21,NULL,'шт.',5,'Максидом'),('Z326T9','Зарядное устройство','Устройство зарядное EXPERT ЗУ-300 6/12В 3,8А','Зарядные устройства','','EXPERT',2400.00,3,14,NULL,'шт.',15,'Максидом'),('Z374R3','Зарядное устройство','Зарядное устройство AIRLINE ACH-15A-08','Зарядные устройства','Z374R3.jpeg','AIRLINE',4600.00,2,14,NULL,'шт.',25,'220-volt'),('Z469T7','Устройство пуско-зарядное','Устройство пуско-зарядное AIRLINE 12В 8000мАч 350А','Зарядные устройства','Z469T7.jpg','AIRLINE',4000.00,2,4,NULL,'шт.',25,'Максидом'),('Z472R4','Зарядное устройство','Зарядное устройство KOLNER KBCН 4','Зарядные устройства','Z472R4.jpeg','KOLNER',1250.00,4,6,NULL,'шт.',30,'220-volt'),('Z782T5','Зажим','Зажим AIRLINE SA-400-P','Зарядные устройства','','AIRLINE',290.00,5,6,NULL,'уп.',25,'220-volt');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-03  1:50:00
