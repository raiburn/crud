SET FOREIGN_KEY_CHECKS = 0; #Base de datos: pdv_uth_bd_v1
DROP TABLE IF EXISTS `usuarios`;
DROP TABLE IF EXISTS `clientes`;
DROP TABLE IF EXISTS `persona_alternativas`;
DROP TABLE IF EXISTS `creditos`;
DROP TABLE IF EXISTS `cajas`;
DROP TABLE IF EXISTS `ventas_con_tarjetas`;
DROP TABLE IF EXISTS `establecimiento`;
DROP TABLE IF EXISTS `productos`;
DROP TABLE IF EXISTS `ventas`;
DROP TABLE IF EXISTS `ventas_detalles`;
DROP TABLE IF EXISTS `movimientos_de_usuario_log`;

SET FOREIGN_KEY_CHECKS = 1;

CREATE TABLE `usuarios` (
    `id` int NOT NULL,
	`nombre` VARCHAR(30) NOT NULL,
    `apellido_paterno` varchar(30) NOT NULL,
    `apellido_materno` varchar(30) NULL,
    `fecha_de_nacimiento` DATE NOT NULL,
    `celular` varchar(10) NOT NULL,
    `telefono` varchar(10)  NULL,
    `correo` varchar(50) NOT NULL,
    `calle` varchar(30) NOT NULL,
    `numero_casa` varchar(6) NOT NULL,
    `codigo_postal` varchar(5) NOT NULL,
    `colonia` varchar(20) NOT NULL,
    `fraccionamiento` varchar(30)  NULL,
    `localidad` varchar(30)  NULL,
    `municipio` varchar(30) NOT NULL,
    `img_comprobante_domicilio` TEXT NOT NULL,
    `ine_comprobante` text NOT NULL,
    `curp` varchar(18) NOT NULL,
    `curp_comprobante` text NOT NULL,
    `acta_nacimiento` text NOT NULL,
    `certificado_estudios` text NOT NULL,
    `numero_seguro_social` varchar(11) NOT NULL,
    `tipo_usuario` ENUM('ADMINISTRADOR', 'CAJERO') NOT NULL,
    `pwd` varchar(30) NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `clientes` (
    `id` int  NOT NULL,
    `nombre` VARCHAR(30) NOT NULL,
    `apellido_paterno` varchar(30) NOT NULL,
    `apellido_materno` varchar(30)  NULL,
    `fecha_de_nacimiento` DATE NOT NULL,
    `celular` varchar(10) NOT NULL,
    `telefono` varchar(10)  NULL,
    `correo` varchar(50) NOT NULL,
    `calle` varchar(30) NOT NULL,
    `numero_casa` varchar(6) NOT NULL,
    `codigo_postal` varchar(5) NOT NULL,
    `colonia` varchar(20) NOT NULL,
    `fraccionamiento` varchar(30)  NULL,
    `localidad` varchar(30)  NULL,
    `municipio` varchar(30) NOT NULL,
    `img_comprobante_domicilio` TEXT NOT NULL,
    `ine_comprobante` text NOT NULL,
    `curp` varchar(18) NOT NULL,
    `curp_comprobante` text NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `persona_alternativas` (
    `id` int NOT NULL,
    `nombre` VARCHAR(30) NOT NULL,
    `apellido_paterno` varchar(30) NOT NULL,
    `apellido_materno` varchar(30)  NULL,
    `fecha_de_nacimiento` DATE NOT NULL,
    `celular` varchar(10) NOT NULL,
    `telefono` varchar(10)  NULL,
    `correo` varchar(50) NOT NULL,
    `calle` varchar(30) NOT NULL,
    `numero_casa` varchar(6) NOT NULL,
    `codigo_postal` varchar(5) NOT NULL,
    `colonia` varchar(20) NOT NULL,
    `fraccionamiento` varchar(30)  NULL,
    `localidad` varchar(30)  NULL,
    `municipio` varchar(30) NOT NULL,
    `img_comprobante_domicilio` TEXT NOT NULL,
    `ine_comprobante` text NOT NULL,
    `curp` varchar(18) NOT NULL,
    `curp_comprobante` text NOT NULL,
    `cliente_id` int NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `creditos` (
    `id` int NOT NULL,
    `saldo` double NOT NULL,
    `fecha_apertura` date NOT NULL,
    `cliente_id` int NOT NULL,
    `estado` ENUM('APERTURA', 'OPERANDO', 'CONGELADO', 'SALDADO') NOT NULL,
    `fecha_saldado` date  NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `cajas` (
    `id` int NOT NULL,
    `nombre` VARCHAR(15) NOT NULL,
    PRIMARY KEY (`id`),
    UNIQUE (`nombre`)
);

CREATE TABLE `ventas_con_tarjetas` (
    `id` int NOT NULL,
    `venta_id` int NOT NULL,
    `vigencia_mes` varchar(2) NOT NULL,
    `vigencia_anio` varchar(4) NOT NULL,
    `numero_autorizacion` varchar(15) NOT NULL,
    `fecha_hora` timestamp NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `establecimiento` (
    `id` int primary key auto_increment NOT NULL,
    `nombre` varchar(40) NOT NULL,
    `hora_inicio` time NOT NULL,
    `hora_fin` time NOT NULL,
    `calle` varchar(30) NOT NULL,
    `numero_casa` varchar(6) NOT NULL,
    `codigo_postal` varchar(5) NOT NULL,
    `colonia` varchar(20) NOT NULL,
    `fraccionamiento` varchar(30)  NULL,
    `localidad` varchar(30)  NULL,
    `municipio` varchar(30) NOT NULL,
    `caja_1_id` int NOT NULL,
    `caja_2_id` int NOT NULL
);


CREATE TABLE `productos` (
    `id` int NOT NULL,
    `nombre` VARCHAR(30) NOT NULL,
    `descripcion` TEXT  NULL,
    `precio` DOUBLE NOT NULL,
    `codigo_barras` VARCHAR(13) NOT NULL,
    `imagen_producto` TEXT  NULL,
    `unidad_medida` ENUM('UNIDAD', 'LITRO', 'KILO', 'CAJA', 'PAQUETE') NOT NULL,
    `es_perecedero` BIT NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `ventas` (
    `id` int NOT NULL,
    `folio` varchar(10) NOT NULL,
    `caja_id` int NOT NULL,
    `usuario_id` int NOT NULL,
    `fecha_hora` TIMESTAMP NOT NULL,
    `total_venta` DOUBLE NOT NULL,
    PRIMARY KEY (`id`)
);

CREATE TABLE `ventas_detalles` (
    `venta_id` int NOT NULL,
    `producto_id` int NOT NULL,
    `cantidad` int NOT NULL
);

CREATE TABLE `movimientos_de_usuario_log`(
	`id` int PRIMARY KEY auto_increment NOT NULL,
    `fecha_hora` TIMESTAMP NOT NULL,
	`usuario_id` INT NOT NULL,
	`venta_id` ENUM('APERTURA-CAJA', 
					'CORTE-CAJA', 'RETIRO', 'ABRIR-CAJON', 
					'COBRAR-CREDITO', 'CREAR-USUARIO','ACTIVAR-CLIENTE', 
					'DESACTIVAR-CLIENTE', 'CREAR-PRODUCTO') NOT NULL,
	`observacion` TEXT NOT NULL
);