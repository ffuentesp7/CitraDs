-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.14-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando estructura para tabla citrads.et_diario
CREATE TABLE IF NOT EXISTS `et_diario` (
  `id_estacion` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `ETo` double DEFAULT NULL,
  `x` double DEFAULT NULL,
  `h` double DEFAULT NULL,
  `observacion` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla citrads.et_instantaneo
CREATE TABLE IF NOT EXISTS `et_instantaneo` (
  `fecha` date NOT NULL,
  `Hor` int(11) DEFAULT NULL,
  `estacion` int(11) NOT NULL,
  `lai` double DEFAULT NULL,
  `rst_sw` double DEFAULT NULL,
  `fc` double DEFAULT NULL,
  `ta` double DEFAULT NULL,
  `rso` double DEFAULT NULL,
  `rsn` double DEFAULT NULL,
  `rnl` double DEFAULT NULL,
  `rnpm` double DEFAULT NULL,
  `gdiario` double DEFAULT NULL,
  `rso_wm2` double DEFAULT NULL,
  `rsa_wm2` double DEFAULT NULL,
  `rn_wm2` double DEFAULT NULL,
  `etia` double DEFAULT NULL,
  `x` double DEFAULT NULL,
  `h` double DEFAULT NULL,
  `observacion` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla citrads.medicion
CREATE TABLE IF NOT EXISTS `medicion` (
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `medicion` double NOT NULL,
  `instrumento_id` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  PRIMARY KEY (`fecha`,`hora`,`instrumento_id`),
  KEY `fk_medicion_instrumento` (`instrumento_id`),
  KEY `fecha` (`fecha`),
  KEY `hora` (`hora`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- La exportación de datos fue deseleccionada.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
