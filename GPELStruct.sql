﻿-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: localhost    Database: dicionario
-- ------------------------------------------------------
-- Server version	5.7.22-log

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
-- Table structure for table `conjugacao`
--

DROP TABLE IF EXISTS `conjugacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conjugacao` (
  `idconjugacao` int(11) NOT NULL AUTO_INCREMENT,
  `ExPreterito` text COLLATE utf8_unicode_ci,
  `ExPresente` text COLLATE utf8_unicode_ci,
  `ExFuturo` text COLLATE utf8_unicode_ci,
  `ConstrPreterito` text COLLATE utf8_unicode_ci,
  `ConstrPresente` text COLLATE utf8_unicode_ci,
  `ConstrFuturo` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`idconjugacao`),
  UNIQUE KEY `idconjugacao_UNIQUE` (`idconjugacao`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `equivalencias`
--

DROP TABLE IF EXISTS `equivalencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equivalencias` (
  `Origem` int(11) NOT NULL,
  `equivalente` int(11) NOT NULL COMMENT '	',
  `heterogenerico` tinyint(1) NOT NULL DEFAULT '0',
  `heterotonico` tinyint(1) NOT NULL DEFAULT '0',
  `heterossemantico` tinyint(1) NOT NULL DEFAULT '0',
  `Exemplo` tinytext,
  `Exemplo_Traduzido` tinytext,
  `Referencia` int(11) DEFAULT NULL,
  `MarcaUso` int(11) DEFAULT NULL,
  `nApresentacao` int(4) NOT NULL DEFAULT '1',
  `NCultural` text,
  `NGramatical` text,
  PRIMARY KEY (`Origem`,`equivalente`,`nApresentacao`),
  KEY `fk_Equivalencias_2_idx` (`equivalente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Equivalente também vale como *Tradução*';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `marca_uso`
--

DROP TABLE IF EXISTS `marca_uso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca_uso` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `sigla` varchar(4) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `palavra`
--

DROP TABLE IF EXISTS `palavra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `palavra` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Lema` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `ClasseGram` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `Idioma` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `notas_gramatica` tinytext COLLATE utf8_unicode_ci,
  `notas_cultura` text COLLATE utf8_unicode_ci,
  `Id_conjuga` int(11) DEFAULT NULL,
  `Genero` enum('M','F','N','S') COLLATE utf8_unicode_ci NOT NULL DEFAULT 'M',
  `Definicao` text COLLATE utf8_unicode_ci,
  `Sinonimo1` int(11) DEFAULT '0',
  `Sinonimo2` int(11) DEFAULT '0',
  PRIMARY KEY (`Lema`,`Idioma`,`ClasseGram`,`Genero`),
  UNIQUE KEY `IDX_EntradaUnica` (`Lema`,`Idioma`,`ClasseGram`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `referencias`
--

DROP TABLE IF EXISTS `referencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `referencias` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Cod` char(6) COLLATE utf8_unicode_ci NOT NULL,
  `Descricao` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `Ano` int(4) DEFAULT NULL,
  `Autor` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Cod`),
  UNIQUE KEY `Id_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usr`
--

DROP TABLE IF EXISTS `usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr` (
  `usr` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `nivel_permissao` enum('ADM','EDT','USR') COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `nome` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `contato` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `rede_social` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cpf` char(11) COLLATE utf8_unicode_ci NOT NULL,
  `telefone` char(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`usr`),
  UNIQUE KEY `usr_UNIQUE` (`usr`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-29 15:37:35
