USE [master]
GO
/****** Object:  Database [Aerolineas]    Script Date: 1/10/2018 20:31:29 ******/
CREATE DATABASE [Aerolineas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Aerolineas', FILENAME = N'C:\Users\gasto\Desktop\BD\Aerolineas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Aerolineas_log', FILENAME = N'C:\Users\gasto\Desktop\BD\Aerolineas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Aerolineas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Aerolineas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Aerolineas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Aerolineas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Aerolineas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Aerolineas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Aerolineas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Aerolineas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Aerolineas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Aerolineas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Aerolineas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Aerolineas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Aerolineas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Aerolineas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Aerolineas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Aerolineas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Aerolineas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Aerolineas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Aerolineas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Aerolineas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Aerolineas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Aerolineas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Aerolineas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Aerolineas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Aerolineas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Aerolineas] SET  MULTI_USER 
GO
ALTER DATABASE [Aerolineas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Aerolineas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Aerolineas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Aerolineas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Aerolineas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Aerolineas] SET QUERY_STORE = OFF
GO
USE [Aerolineas]
GO

/****** Object:  Table [dbo].[Aeropuertos]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aeropuertos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cabotaje/internacional] [int] NULL,
	[cantidadPuertasEmbarque] [int] NOT NULL,
	[salaVip] [int] NULL,
	[salaFumadores] [int] NULL,
	[calle] [varchar](50) NOT NULL,
	[nroCalle] [int] NOT NULL,
	[id_Localidad] [int] NOT NULL,
 CONSTRAINT [PK_Aeropuertos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aviones]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aviones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idTipoAvion] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinos]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_localidad] [int] NOT NULL,
 CONSTRAINT [PK_Destinos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEmbarques]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEmbarques](
	[nroVuelo] [int] NOT NULL,
	[nroDocumento] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[nroEquipaje] [int] NOT NULL,
	[arbordo/bodega] [int] NULL,
 CONSTRAINT [PK_DetalleEmbarques] PRIMARY KEY CLUSTERED 
(
	[nroVuelo] ASC,
	[nroDocumento] ASC,
	[tipoDocumento] ASC,
	[nroEquipaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Embarque]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Embarque](
	[nroVuelo] [int] IDENTITY(1,1) NOT NULL,
	[nroDocumento] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[PuertaEmbarque] [int] NOT NULL,
 CONSTRAINT [PK_Embarque] PRIMARY KEY CLUSTERED 
(
	[nroVuelo] ASC,
	[nroDocumento] ASC,
	[tipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipajes]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipajes](
	[nroEquipaje] [int] IDENTITY(1,1) NOT NULL,
	[peso] [int] NOT NULL,
	[especial/noespecial] [int] NOT NULL,
 CONSTRAINT [PK_Equipajes] PRIMARY KEY CLUSTERED 
(
	[nroEquipaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_provincia] [int] NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pasajero]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasajero](
	[nroDocumento] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[nacionalidad] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[sexo] [varchar](50) NOT NULL,
	[calle] [varchar](50) NOT NULL,
	[motivo] [varchar](50) NOT NULL,
	[nroCalle] [int] NOT NULL,
	[id_localidad] [int] NOT NULL,
 CONSTRAINT [PK_Pasajero] PRIMARY KEY CLUSTERED 
(
	[nroDocumento] ASC,
	[tipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[legajo] [int] IDENTITY(1000,1) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[celular] [int] NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[fechaIngreso] [date] NOT NULL,
	[id_Aeropuerto] [int] NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalxVuelo]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalxVuelo](
	[legajo] [int] NOT NULL,
	[id_vuelo] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,
 CONSTRAINT [PK_PersonalxVuelo] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC,
	[id_vuelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_pais] [int] NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicioxAereopuerto]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicioxAereopuerto](
	[id_aereopuerto] [int] NOT NULL,
	[tipo_servicio] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_ServicioxAereopuerto] PRIMARY KEY CLUSTERED 
(
	[id_aereopuerto] ASC,
	[tipo_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoAvion]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAvion](
	[id_tipoAvion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[capacidadPasajerosClaseAlta] [int] NULL,
	[capacidadPasajerosClaseTurista] [int] NULL,
	[capacidadKGEquipaje] [int] NOT NULL,
	[numeroSalidaEmergencia] [int] NOT NULL,
	[longitud] [int] NOT NULL,
	[alcanceVuelo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoAvion] PRIMARY KEY CLUSTERED 
(
	[id_tipoAvion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoServicio]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoServicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoServicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vuelos]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vuelos](
	[id_vuelo] [int] IDENTITY(1,1) NOT NULL,
	[fechaSalida] [date] NOT NULL,
	[horasalida] [time](7) NOT NULL,
	[fechaLlegada] [date] NOT NULL,
	[horaLlegada] [time](7) NOT NULL,
	[id_avion] [int] NOT NULL,
	[idAereopuertoOrigen] [int] NOT NULL,
	[idAereopuertoDestino] [int] NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Vuelos] PRIMARY KEY CLUSTERED 
(
	[id_vuelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilio](
	[calle] [varchar](50) NOT NULL,
	[nroCalle] [int] NOT NULL,
	[dpto] [varchar](50) NOT NULL,
	[pais] [int] NOT NULL,
	[localidad] [int] NOT NULL,
 CONSTRAINT [PK_Domicilio] PRIMARY KEY CLUSTERED 
(
	[calle] ASC,
	[nroCalle] ASC,
	[localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pasaje]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pasaje](
	[idVuelo] [int] NOT NULL,
	[nroDocumento] [int] NOT NULL,
	[tipoDocumento] [int] NOT NULL,
	[tipoPasaje] [int] NOT NULL,
	[atencion] [varchar](50) NULL,
	[nroAsiento] [int] NOT NULL,
	[claseTurista] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pasaje] PRIMARY KEY CLUSTERED 
(
	[idVuelo] ASC,
	[nroDocumento] ASC,
	[tipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[id_puesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Puesto] PRIMARY KEY CLUSTERED 
(
	[id_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 1/10/2018 20:31:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aeropuertos]  WITH CHECK ADD  CONSTRAINT [FK_Aeropuertos_Domicilio] FOREIGN KEY([calle], [nroCalle], [id_Localidad])
REFERENCES [dbo].[Domicilio] ([calle], [nroCalle], [localidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Aeropuertos] CHECK CONSTRAINT [FK_Aeropuertos_Domicilio]
GO
ALTER TABLE [dbo].[Aviones]  WITH CHECK ADD  CONSTRAINT [FK_Aviones_TipoAvion] FOREIGN KEY([idTipoAvion])
REFERENCES [dbo].[TipoAvion] ([id_tipoAvion])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Aviones] CHECK CONSTRAINT [FK_Aviones_TipoAvion]
GO
ALTER TABLE [dbo].[Destinos]  WITH CHECK ADD  CONSTRAINT [FK_Destinos_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Destinos] CHECK CONSTRAINT [FK_Destinos_Localidad]
GO
ALTER TABLE [dbo].[DetalleEmbarques]  WITH CHECK ADD  CONSTRAINT [FK_DetalleEmbarques_Equipajes] FOREIGN KEY([nroEquipaje])
REFERENCES [dbo].[Equipajes] ([nroEquipaje])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleEmbarques] CHECK CONSTRAINT [FK_DetalleEmbarques_Equipajes]
GO
ALTER TABLE [dbo].[DetalleEmbarques]  WITH CHECK ADD  CONSTRAINT [FK_DetalleEmbarques_Pasaje] FOREIGN KEY([nroVuelo], [nroDocumento], [tipoDocumento])
REFERENCES [dbo].[Pasaje] ([idVuelo], [nroDocumento], [tipoDocumento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleEmbarques] CHECK CONSTRAINT [FK_DetalleEmbarques_Pasaje]
GO
ALTER TABLE [dbo].[Embarque]  WITH CHECK ADD  CONSTRAINT [FK_Embarque_Pasajero] FOREIGN KEY([nroDocumento], [tipoDocumento])
REFERENCES [dbo].[Pasajero] ([nroDocumento], [tipoDocumento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Embarque] CHECK CONSTRAINT [FK_Embarque_Pasajero]
GO
ALTER TABLE [dbo].[Embarque]  WITH CHECK ADD  CONSTRAINT [FK_Embarque_Vuelos] FOREIGN KEY([nroVuelo])
REFERENCES [dbo].[Vuelos] ([id_vuelo])
GO
ALTER TABLE [dbo].[Embarque] CHECK CONSTRAINT [FK_Embarque_Vuelos]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_Pasajero_Domicilio] FOREIGN KEY([calle], [nroCalle], [id_localidad])
REFERENCES [dbo].[Domicilio] ([calle], [nroCalle], [localidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_Pasajero_Domicilio]
GO
ALTER TABLE [dbo].[Pasajero]  WITH CHECK ADD  CONSTRAINT [FK_Pasajero_TipoDocumento] FOREIGN KEY([tipoDocumento])
REFERENCES [dbo].[TipoDocumento] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pasajero] CHECK CONSTRAINT [FK_Pasajero_TipoDocumento]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Aeropuertos] FOREIGN KEY([id_Aeropuerto])
REFERENCES [dbo].[Aeropuertos] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Aeropuertos]
GO
ALTER TABLE [dbo].[PersonalxVuelo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalxVuelo_Personal] FOREIGN KEY([legajo])
REFERENCES [dbo].[Personal] ([legajo])
GO
ALTER TABLE [dbo].[PersonalxVuelo] CHECK CONSTRAINT [FK_PersonalxVuelo_Personal]
GO
ALTER TABLE [dbo].[PersonalxVuelo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalxVuelo_Puesto] FOREIGN KEY([id_puesto])
REFERENCES [dbo].[Puesto] ([id_puesto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonalxVuelo] CHECK CONSTRAINT [FK_PersonalxVuelo_Puesto]
GO
ALTER TABLE [dbo].[PersonalxVuelo]  WITH CHECK ADD  CONSTRAINT [FK_PersonalxVuelo_Vuelos] FOREIGN KEY([id_vuelo])
REFERENCES [dbo].[Vuelos] ([id_vuelo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonalxVuelo] CHECK CONSTRAINT [FK_PersonalxVuelo_Vuelos]
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Pais] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Pais]
GO
ALTER TABLE [dbo].[ServicioxAereopuerto]  WITH CHECK ADD  CONSTRAINT [FK_ServicioxAereopuerto_Aeropuertos] FOREIGN KEY([id_aereopuerto])
REFERENCES [dbo].[Aeropuertos] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServicioxAereopuerto] CHECK CONSTRAINT [FK_ServicioxAereopuerto_Aeropuertos]
GO
ALTER TABLE [dbo].[ServicioxAereopuerto]  WITH CHECK ADD  CONSTRAINT [FK_ServicioxAereopuerto_TipoServicio] FOREIGN KEY([tipo_servicio])
REFERENCES [dbo].[TipoServicio] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServicioxAereopuerto] CHECK CONSTRAINT [FK_ServicioxAereopuerto_TipoServicio]
GO
ALTER TABLE [dbo].[Vuelos]  WITH CHECK ADD  CONSTRAINT [FK_Vuelos_Aeropuertos] FOREIGN KEY([idAereopuertoDestino])
REFERENCES [dbo].[Aeropuertos] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vuelos] CHECK CONSTRAINT [FK_Vuelos_Aeropuertos]
GO
ALTER TABLE [dbo].[Vuelos]  WITH CHECK ADD  CONSTRAINT [FK_Vuelos_Aeropuertos1] FOREIGN KEY([idAereopuertoOrigen])
REFERENCES [dbo].[Aeropuertos] ([id])
GO
ALTER TABLE [dbo].[Vuelos] CHECK CONSTRAINT [FK_Vuelos_Aeropuertos1]
GO
ALTER TABLE [dbo].[Vuelos]  WITH CHECK ADD  CONSTRAINT [FK_Vuelos_Aviones] FOREIGN KEY([id_avion])
REFERENCES [dbo].[Aviones] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vuelos] CHECK CONSTRAINT [FK_Vuelos_Aviones]
GO
ALTER TABLE [dbo].[Domicilio]  WITH CHECK ADD  CONSTRAINT [FK_Domicilio_Pais] FOREIGN KEY([pais])
REFERENCES [dbo].[Pais] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Domicilio] CHECK CONSTRAINT [FK_Domicilio_Pais]
GO
ALTER TABLE [dbo].[Pasaje]  WITH CHECK ADD  CONSTRAINT [FK_Pasaje_Pasajero] FOREIGN KEY([nroDocumento], [tipoDocumento])
REFERENCES [dbo].[Pasajero] ([nroDocumento], [tipoDocumento])
GO
ALTER TABLE [dbo].[Pasaje] CHECK CONSTRAINT [FK_Pasaje_Pasajero]
GO
ALTER TABLE [dbo].[Pasaje]  WITH CHECK ADD  CONSTRAINT [FK_Pasaje_Vuelos] FOREIGN KEY([idVuelo])
REFERENCES [dbo].[Vuelos] ([id_vuelo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pasaje] CHECK CONSTRAINT [FK_Pasaje_Vuelos]
GO
USE [master]
GO
ALTER DATABASE [Aerolineas] SET  READ_WRITE 
GO
