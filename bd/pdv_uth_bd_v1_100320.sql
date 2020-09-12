-- MySQL Script generated by MySQL Workbench
-- Tue Mar 10 16:07:34 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema pdv_uth_bd_v1
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `pdv_uth_bd_v1` ;

-- -----------------------------------------------------
-- Schema pdv_uth_bd_v1
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pdv_uth_bd_v1` DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish2_ci ;
USE `pdv_uth_bd_v1` ;

-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`cajas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`cajas` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`cajas` (
  `id` INT(11) NOT NULL,
  `nombre` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `nombre` (`nombre` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`clientes` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`clientes` (
  `id` INT(11) NOT NULL,
  `nombre` VARCHAR(30) NOT NULL,
  `apellido_paterno` VARCHAR(30) NOT NULL,
  `apellido_materno` VARCHAR(30) NULL DEFAULT NULL,
  `fecha_de_nacimiento` DATE NOT NULL,
  `celular` VARCHAR(10) NOT NULL,
  `telefono` VARCHAR(10) NULL DEFAULT NULL,
  `correo` VARCHAR(50) NOT NULL,
  `calle` VARCHAR(30) NOT NULL,
  `numero_casa` VARCHAR(6) NOT NULL,
  `codigo_postal` VARCHAR(5) NOT NULL,
  `colonia` VARCHAR(20) NOT NULL,
  `fraccionamiento` VARCHAR(30) NULL DEFAULT NULL,
  `localidad` VARCHAR(30) NULL DEFAULT NULL,
  `municipio` VARCHAR(30) NOT NULL,
  `img_comprobante_domicilio` TEXT NOT NULL,
  `ine_comprobante` TEXT NOT NULL,
  `curp` VARCHAR(18) NOT NULL,
  `curp_comprobante` TEXT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`creditos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`creditos` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`creditos` (
  `id` INT(11) NOT NULL,
  `saldo` DOUBLE NOT NULL,
  `fecha_apertura` DATE NOT NULL,
  `cliente_id` INT(11) NOT NULL,
  `estado` ENUM('APERTURA', 'OPERANDO', 'CONGELADO', 'SALDADO') NOT NULL,
  `fecha_saldado` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_creditos_a_clientes_idx` (`cliente_id` ASC) ,
  CONSTRAINT `fk_creditos_a_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `pdv_uth_bd_v1`.`clientes` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`establecimiento`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`establecimiento` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`establecimiento` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(40) NOT NULL,
  `hora_inicio` TIME NOT NULL,
  `hora_fin` TIME NOT NULL,
  `calle` VARCHAR(30) NOT NULL,
  `numero_casa` VARCHAR(6) NOT NULL,
  `codigo_postal` VARCHAR(5) NOT NULL,
  `colonia` VARCHAR(20) NOT NULL,
  `fraccionamiento` VARCHAR(30) NULL DEFAULT NULL,
  `localidad` VARCHAR(30) NULL DEFAULT NULL,
  `municipio` VARCHAR(30) NOT NULL,
  `caja_1_id` INT(11) NOT NULL,
  `caja_2_id` INT(11)  NULL,
  PRIMARY KEY (`id`),
   INDEX `fk_caja1_idx`  (`caja_1_id` ASC) ,
  INDEX `fk_caja2_idx` (`caja_2_id` ASC) ,
  CONSTRAINT `fk_caja1`
    FOREIGN KEY (`caja_1_id` )
    REFERENCES `pdv_uth_bd_v1`.`cajas` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
   CONSTRAINT `fk_caja2`
    FOREIGN KEY (`caja_2_id` )
    REFERENCES `pdv_uth_bd_v1`.`cajas` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`usuarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`usuarios` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`usuarios` (
  `id` INT(11) NOT NULL,
  `nombre` VARCHAR(30) NOT NULL,
  `apellido_paterno` VARCHAR(30) NOT NULL,
  `apellido_materno` VARCHAR(30) NULL DEFAULT NULL,
  `fecha_de_nacimiento` DATE NOT NULL,
  `celular` VARCHAR(10) NOT NULL,
  `telefono` VARCHAR(10) NULL DEFAULT NULL,
  `correo` VARCHAR(50) NOT NULL,
  `calle` VARCHAR(30) NOT NULL,
  `numero_casa` VARCHAR(6) NOT NULL,
  `codigo_postal` VARCHAR(5) NOT NULL,
  `colonia` VARCHAR(20) NOT NULL,
  `fraccionamiento` VARCHAR(30) NULL DEFAULT NULL,
  `localidad` VARCHAR(30) NULL DEFAULT NULL,
  `municipio` VARCHAR(30) NOT NULL,
  `img_comprobante_domicilio` TEXT NOT NULL,
  `ine_comprobante` TEXT NOT NULL,
  `curp` VARCHAR(18) NOT NULL,
  `curp_comprobante` TEXT NOT NULL,
  `acta_nacimiento` TEXT NOT NULL,
  `certificado_estudios` TEXT NOT NULL,
  `numero_seguro_social` VARCHAR(11) NOT NULL,
  `tipo_usuario` ENUM('ADMINISTRADOR', 'CAJERO') NOT NULL,
  `pwd` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`movimientos_de_usuario_log`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`movimientos_de_usuario_log` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`movimientos_de_usuario_log` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `fecha_hora` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `usuario_id` INT(11) NOT NULL,
  `tipo_de_movimiento` ENUM('APERTURA-CAJA', 'CORTE-CAJA', 'RETIRO', 'ABRIR-CAJON', 'COBRAR-CREDITO', 'CREAR-USUARIO', 'ACTIVAR-CLIENTE', 'DESACTIVAR-CLIENTE', 'CREAR-PRODUCTO') NOT NULL,
  `observacion` TEXT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_log_a_usuarios_idx` (`usuario_id` ASC) ,
  CONSTRAINT `fk_log_a_usuarios`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `pdv_uth_bd_v1`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`persona_alternativas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`persona_alternativas` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`persona_alternativas` (
  `id` INT(11) NOT NULL,
  `nombre` VARCHAR(30) NOT NULL,
  `apellido_paterno` VARCHAR(30) NOT NULL,
  `apellido_materno` VARCHAR(30) NULL DEFAULT NULL,
  `fecha_de_nacimiento` DATE NOT NULL,
  `celular` VARCHAR(10) NOT NULL,
  `telefono` VARCHAR(10) NULL DEFAULT NULL,
  `correo` VARCHAR(50) NOT NULL,
  `calle` VARCHAR(30) NOT NULL,
  `numero_casa` VARCHAR(6) NOT NULL,
  `codigo_postal` VARCHAR(5) NOT NULL,
  `colonia` VARCHAR(20) NOT NULL,
  `fraccionamiento` VARCHAR(30) NULL DEFAULT NULL,
  `localidad` VARCHAR(30) NULL DEFAULT NULL,
  `municipio` VARCHAR(30) NOT NULL,
  `img_comprobante_domicilio` TEXT NOT NULL,
  `ine_comprobante` TEXT NOT NULL,
  `curp` VARCHAR(18) NOT NULL,
  `curp_comprobante` TEXT NOT NULL,
  `cliente_id` INT(11) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_personas_alternativas_a_clientes_idx` (`cliente_id` ASC) ,
  CONSTRAINT `fk_personas_alternativas_a_clientes`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `pdv_uth_bd_v1`.`clientes` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`productos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`productos` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`productos` (
  `id` INT(11) NOT NULL,
  `nombre` VARCHAR(30) NOT NULL,
  `descripcion` TEXT NULL DEFAULT NULL,
  `precio` DOUBLE NOT NULL,
  `codigo_barras` VARCHAR(13) NOT NULL,
  `imagen_producto` TEXT NULL DEFAULT NULL,
  `unidad_medida` ENUM('UNIDAD', 'LITRO', 'KILO', 'CAJA', 'PAQUETE') NOT NULL,
  `es_perecedero` BIT(1) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`ventas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`ventas` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`ventas` (
  `id` INT(11) NOT NULL,
  `folio` VARCHAR(10) NOT NULL,
  `caja_id` INT(11) NOT NULL,
  `usuario_id` INT(11) NOT NULL,
  `fecha_hora` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `total_venta` DOUBLE NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_ventas_a_cajas_idx` (`caja_id` ASC) ,
  CONSTRAINT `fk_ventas_a_cajas`
    FOREIGN KEY (`caja_id`)
    REFERENCES `pdv_uth_bd_v1`.`cajas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`ventas_con_tarjetas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`ventas_con_tarjetas` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`ventas_con_tarjetas` (
  `id` INT(11) NOT NULL,
  `venta_id` INT(11) NOT NULL,
  `vigencia_mes` VARCHAR(2) NOT NULL,
  `vigencia_anio` VARCHAR(4) NOT NULL,
  `numero_autorizacion` VARCHAR(15) NOT NULL,
  `fecha_hora` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  INDEX `fk_ventas_con_tarjetas_a_ventas_idx` (`venta_id` ASC) ,
  CONSTRAINT `fk_ventas_con_tarjetas_a_ventas`
    FOREIGN KEY (`venta_id`)
    REFERENCES `pdv_uth_bd_v1`.`ventas` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


-- -----------------------------------------------------
-- Table `pdv_uth_bd_v1`.`ventas_detalles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pdv_uth_bd_v1`.`ventas_detalles` ;

CREATE TABLE IF NOT EXISTS `pdv_uth_bd_v1`.`ventas_detalles` (
  `venta_id` INT(11) NOT NULL,
  `producto_id` INT(11) NOT NULL,
  `cantidad` INT(11) NOT NULL,
  INDEX `fk_ventas_detalles_ventas_idx` (`venta_id` ASC) ,
  INDEX `fk_ventas_detalles_productos_idx` (`producto_id` ASC) ,
  CONSTRAINT `fk_ventas_detalles_ventas`
    FOREIGN KEY (`venta_id`)
    REFERENCES `pdv_uth_bd_v1`.`ventas` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_ventas_detalles_productos`
    FOREIGN KEY (`producto_id`)
    REFERENCES `pdv_uth_bd_v1`.`productos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_spanish2_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
