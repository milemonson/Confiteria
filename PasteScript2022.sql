USE [Pasteleria ]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[idArticulo] [int] IDENTITY(1,1) NOT NULL,
	[idRubro] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[Estado] [int] NOT NULL,
	[NombreArticulo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[idArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleTicket]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleTicket](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdTicket] [int] NOT NULL,
	[Articulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_DetalleTicket_1] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Local]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local](
	[idLocal] [int] IDENTITY(1,1) NOT NULL,
	[Entidad] [nvarchar](50) NOT NULL,
	[CUIT] [nvarchar](50) NOT NULL,
	[IIBB] [nvarchar](50) NOT NULL,
	[IVA] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Local] PRIMARY KEY CLUSTERED 
(
	[idLocal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mozo]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mozo](
	[idMozo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[idUser] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[Comision] [float] NOT NULL,
 CONSTRAINT [PK_Mozo_1] PRIMARY KEY CLUSTERED 
(
	[idMozo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rubros]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rubros](
	[idRubro] [int] IDENTITY(1,1) NOT NULL,
	[NombreRubro] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Rubros] PRIMARY KEY CLUSTERED 
(
	[idRubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[idTicket] [int] IDENTITY(1,1) NOT NULL,
	[idLocal] [int] NOT NULL,
	[idMozo] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[idTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 02/03/2022 11:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[NameUser] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articulos] ON 

INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (1, 3, 13, 350, 1, N'Marquise de Chocolate')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (2, 1, 3, 450, 1, N'Selva Negra')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (3, 3, 50, 250, 2, N'Tostado')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (4, 3, 48, 250, 1, N'Carlitos')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (5, 2, 50, 200, 1, N'Licuado')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (6, 2, 15, 100, 1, N'Gaseosa Fanta')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (7, 2, 15, 100, 2, N'Agua Saborizada')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (8, 3, 20, 300, 1, N'Tostado XXL')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (9, 3, 50, 300, 1, N'Carlitos XXL')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (1008, 2, 20, 100, 1, N'Gaseosa Coca Cola')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (1009, 2, 10, 100, 2, N'Agua con Gas')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (1010, 3, 20, 250, 1, N'Tostado')
INSERT [dbo].[Articulos] ([idArticulo], [idRubro], [Cantidad], [Precio], [Estado], [NombreArticulo]) VALUES (1011, 2, 50, 100, 1, N'Agua Saborizada')
SET IDENTITY_INSERT [dbo].[Articulos] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleTicket] ON 

INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1, 1, 2, 1)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2, 2, 3, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (3, 2, 5, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (4, 3, 4, 3)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (5, 3, 4, 3)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (6, 5, 6, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (7, 5, 3, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (8, 6, 7, 1)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (9, 7, 3, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (10, 7, 6, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (11, 8, 3, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (12, 9, 3, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (13, 9, 5, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (14, 10, 8, 3)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1014, 11, 2, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1015, 1011, 5, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1016, 1011, 4, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1017, 1012, 8, 3)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1018, 1012, 8, 3)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (1019, 1013, 1010, 3)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2014, 1014, 9, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2015, 1014, 1008, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2016, 1015, 1, 1)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2017, 1016, 1, 150)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2018, 1017, 4, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2019, 1017, 4, 2)
INSERT [dbo].[DetalleTicket] ([IdDetalle], [IdTicket], [Articulo], [Cantidad]) VALUES (2020, 1018, 1, 2)
SET IDENTITY_INSERT [dbo].[DetalleTicket] OFF
GO
SET IDENTITY_INSERT [dbo].[Local] ON 

INSERT [dbo].[Local] ([idLocal], [Entidad], [CUIT], [IIBB], [IVA]) VALUES (1, N'Manolita SRL', N'30-67854245-7', N'45213641', N'21')
SET IDENTITY_INSERT [dbo].[Local] OFF
GO
SET IDENTITY_INSERT [dbo].[Mozo] ON 

INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (1, N'Milena', N'Monzon', N'3516451824', N'milemonson@gmail.com', 1, 1, 20)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (2, N'Facu', N'Moyano', N'3518452136', N'facumoyano@gmail.com', 2, 1, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (3, N'Javi', N'DellaCosta', N'3516452158', N'javidellacosta@gmail.com', 3, 1, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (4, N'Lucho', N'Andino', N'3516545211', N'luchoand@gmail.com', 4, 1, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (7, N'Nataniel', N'Gigena', N'3518659521', N'natagigena@gmail.com', 10, 2, 15)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (8, N'Joaco', N'Auce', N'351642858', N'joaauce@gmail.com', 11, 2, 10)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (10, N'Rodri ', N'Rosales', N'3452134', N'rodrirosales@gmail.com', 12, 1, 20)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (11, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (13, N'', N'', N'', N'', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (14, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (15, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (16, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (17, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (18, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 0, 2, 21)
INSERT [dbo].[Mozo] ([idMozo], [Nombre], [Apellido], [Telefono], [Email], [idUser], [Estado], [Comision]) VALUES (19, N'Agustin', N'Favot', N'3516894512', N'agusfavot@gmai.com', 8, 1, 21)
SET IDENTITY_INSERT [dbo].[Mozo] OFF
GO
SET IDENTITY_INSERT [dbo].[Rubros] ON 

INSERT [dbo].[Rubros] ([idRubro], [NombreRubro], [Descripcion], [Estado]) VALUES (1, N'Postre', N'', 1)
INSERT [dbo].[Rubros] ([idRubro], [NombreRubro], [Descripcion], [Estado]) VALUES (2, N'Bebida', N'', 1)
INSERT [dbo].[Rubros] ([idRubro], [NombreRubro], [Descripcion], [Estado]) VALUES (3, N'Comida', N'', 1)
SET IDENTITY_INSERT [dbo].[Rubros] OFF
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 

INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1, 1, 4, CAST(N'2021-11-25' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (2, 1, 3, CAST(N'2021-11-25' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (3, 1, 3, CAST(N'2021-11-25' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (4, 1, 3, CAST(N'2021-11-25' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (5, 1, 4, CAST(N'2021-11-25' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (6, 1, 4, CAST(N'2021-11-25' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (7, 1, 8, CAST(N'2021-11-26' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (8, 1, 4, CAST(N'2021-11-26' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (9, 1, 3, CAST(N'2021-11-26' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (10, 1, 2, CAST(N'2021-11-29' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1010, 1, 1, CAST(N'2021-12-06' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1011, 1, 1, CAST(N'2021-12-06' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1012, 1, 10, CAST(N'2021-12-06' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1013, 1, 10, CAST(N'2021-12-06' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1014, 1, 10, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1015, 1, 2, CAST(N'2021-12-09' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1016, 1, 1, CAST(N'2021-12-10' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1017, 1, 1, CAST(N'2021-12-10' AS Date))
INSERT [dbo].[Ticket] ([idTicket], [idLocal], [idMozo], [Fecha]) VALUES (1018, 1, 1, CAST(N'2021-12-10' AS Date))
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (1, N'MileM', N'456', 1)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (2, N'FacuM', N'1234', 1)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (3, N'JaviDella', N'12345', 1)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (8, N'AgusM', N'Montoto', 2)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (9, N'AgusM', N'123456', 1)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (10, N'Nataniel', N'456', 2)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (11, N'Joa', N'123', 2)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (12, N'Rodri', N'789', 1)
INSERT [dbo].[Usuarios] ([idUser], [NameUser], [Contraseña], [Estado]) VALUES (13, N'RodriR', N'78910', 2)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Articulos] ADD  DEFAULT ('0') FOR [NombreArticulo]
GO
ALTER TABLE [dbo].[Ticket] ADD  DEFAULT ('0') FOR [Fecha]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Rubros] FOREIGN KEY([idRubro])
REFERENCES [dbo].[Rubros] ([idRubro])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Rubros]
GO
ALTER TABLE [dbo].[DetalleTicket]  WITH CHECK ADD  CONSTRAINT [FK_DetalleTicket_Articulos] FOREIGN KEY([Articulo])
REFERENCES [dbo].[Articulos] ([idArticulo])
GO
ALTER TABLE [dbo].[DetalleTicket] CHECK CONSTRAINT [FK_DetalleTicket_Articulos]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Local] FOREIGN KEY([idLocal])
REFERENCES [dbo].[Local] ([idLocal])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Local]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Mozo] FOREIGN KEY([idMozo])
REFERENCES [dbo].[Mozo] ([idMozo])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Mozo]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Ticket] FOREIGN KEY([idTicket])
REFERENCES [dbo].[Ticket] ([idTicket])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Ticket]
GO
/****** Object:  StoredProcedure [dbo].[sp_cambioArticulo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_cambioArticulo]
@numdeArticulo int, 
@nameArticulo nvarchar (50),
@cantidad int,
@idRubro int,
@precio float,
@estado int
AS
BEGIN


    UPDATE Articulos
	SET NombreArticulo=@nameArticulo, Cantidad=@cantidad,idRubro=@idRubro, Precio=@precio,Estado=@estado
	WHERE idArticulo=@numdeArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cambioLocal]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_cambioLocal]
@idLocal int,
@entidad nvarchar (50),
@cuit nvarchar(50),
@iibb nvarchar (50),
@iva nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

      UPDATE Local
	SET  Entidad=@entidad, CUIT=@cuit,IIBB=@iibb,IVA=@iva
	WHERE idLocal=@idLocal
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cambioMozo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_cambioMozo]
@mozo int,
@nombre varchar (50),
@apellido varchar (50), 
@telefono nvarchar(50), 
@email nvarchar(50), 
@comision float 
AS

BEGIN
	
	UPDATE Mozo
	SET Nombre=@nombre,Apellido=@apellido,Telefono=@telefono,Email=@email,comision=@comision
	WHERE idMozo=@mozo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cambiosRubro]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_cambiosRubro]
@idRubro int,
@nameArticulo int,
@descripcion nvarchar (50),
@estado int

AS
BEGIN
	 UPDATE Rubros
	SET [NombreRubro] =@nameArticulo,Descripcion=@descripcion, Estado=@estado
	WHERE idRubro=@idRubro
    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_cambiosUser]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_cambiosUser]
@idUser int,
@nameUser nvarchar (50),
@password nvarchar (50)
AS
BEGIN
	 UPDATE Usuarios
	SET NameUser =@nameUser,Contraseña=@password
	WHERE idUser=@idUser
END
GO
/****** Object:  StoredProcedure [dbo].[sp_descArticulo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_descArticulo]

@idTicket int,
@cantidad int

AS
BEGIN
	UPDATE Articulos
	SET  Cantidad= (a.Cantidad - @cantidad)
	FROM Articulos a JOIN DetalleTicket dt on dt.Articulo = a.idArticulo where dt.IdTicket = @idTicket
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarArticulo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminarArticulo]
@numdeArticulo int, 
@idRubro int,
@cantidad int,
@precio float,
@estado int,
@nameArticulo nvarchar (50)

AS
BEGIN


    UPDATE Articulos
	SET idRubro=@idRubro,Cantidad=@cantidad,Precio=@precio,Estado=@estado,NombreArticulo=@nameArticulo
	WHERE idArticulo=@numdeArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarMozo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminarMozo]
@mozo int,
@nombre varchar (50),
@apellido varchar (50), 
@telefono nvarchar(50), 
@email nvarchar(50), 
@state int,
@comision float 
AS

BEGIN
	
	UPDATE Mozo
	SET Nombre=@nombre,Apellido=@apellido,Telefono=@telefono,Email=@email, Estado=@state,comision=@comision
	WHERE idMozo=@mozo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarRubro]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminarRubro]
@idRubro int,
@nameArticulo int,
@descripcion nvarchar (50),
@estado int

AS
BEGIN
	 UPDATE Rubros
	SET [NombreRubro] =@nameArticulo,Descripcion=@descripcion,Estado=@estado
	WHERE idRubro=@idRubro
    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarUser]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminarUser]
@idUser int, 
@nameUser nvarchar (50),
@password nvarchar (50),
@state int
AS
BEGIN
	 UPDATE Usuarios
	SET NameUser =@nameUser,Contraseña=@password,Estado=@state
	WHERE idUser=@idUser
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertArticulos]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertArticulos] 
@nameArticulo nvarchar (50),
@cantidad int,
@idRubro int,
@precio float,
@state int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Articulos(NombreArticulo,Cantidad,idRubro,Precio,Estado)
	VALUES (@nameArticulo,@cantidad,@idRubro,@precio,1)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertDatosMozo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertDatosMozo]

@nombre varchar (50),
@apellido varchar (50), 
@telefono nvarchar(50), 
@email nvarchar(50), 
@idUser int,
@state varchar(50),
@comision float 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Mozo (Nombre,Apellido,Telefono,Email,idUser,estado,comision)
	VALUES (@nombre,@apellido,@telefono,@email,@idUser,@state,@comision)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertDatosRubrodeArticulo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertDatosRubrodeArticulo]
@idRubro int,
@nameArticulo int,
@descripcion nvarchar (50),
@estado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Rubros(idRubro,NombreRubro,Descripcion,Estado)
	VALUES (@idRubro,@nameArticulo,@descripcion,@estado)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertDetalleTicket]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertDetalleTicket]
@idTicket int,
@articulo int,
@cantidad int
AS
BEGIN
	INSERT INTO DetalleTicket (IdTicket,Articulo,Cantidad)
	VALUES (@idTicket,@articulo ,@cantidad)

END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertLocal]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertLocal]
@idLocal int,
@entidad nvarchar (50),
@cuit nvarchar(50),
@iibb nvarchar (50),
@iva nvarchar(50)
AS
BEGIN
	
	INSERT INTO Local(idLocal,Entidad,CUIT,IIBB,IVA)
	VALUES (@idLocal,@entidad,@cuit,@iibb,@iva)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertTicket]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insertTicket]
@idLocal int,
@idMozo int,
@fecha date
AS
BEGIN
INSERT INTO Ticket(idLocal,idMozo,Fecha)
	VALUES (@idLocal,@idMozo,@fecha )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertuser]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertuser]
 
@nameUser nvarchar (50),
@password nvarchar (50),
@state int
AS
BEGIN

 Insert into Usuarios(NameUser,Contraseña,Estado)
	values (@nameUser,@password,@state)

END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectArticulo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_selectArticulo]

AS
BEGIN


    -- Insert statements for procedure here
	SELECT a.*, r.NombreRubro from Articulos a join Rubros r on a.idRubro = r.idRubro 
	WHERE a.Estado = 1 
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectDescription]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_selectDescription]
@idArticulo int
AS
BEGIN

	SELECT Precio from Articulos WHERE idArticulo = @idArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectLocal]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_selectLocal]
AS
BEGIN
	

    SELECT * FROM Local
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectMozo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_selectMozo]
AS
BEGIN
	
    -- Insert statements for procedure here
	SELECT mo.*, u.NameUser from Mozo mo join Usuarios u on mo.idUser = u.idUser  WHERE mo.Estado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectNameUser]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_selectNameUser]
@nameUser nvarchar (50)
AS
BEGIN
 select idUser from Usuarios where NameUser = @nameUser
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectRubro]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_selectRubro]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from Rubros WHERE Estado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectUser]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_selectUser]
AS
BEGIN
	
	Select * from Usuarios WHERE Estado = 1;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_traerTicket]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_traerTicket]
AS
BEGIN
SELECT MAX(IdTicket) from Ticket
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VentasporDia]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_VentasporDia]
@fecha date
AS
BEGIN

SELECT a.idArticulo as 'idArticulo',a.NombreArticulo 'nameArticulo' ,sum(dt.cantidad) 'Cantidad',sum(dt.cantidad * a.precio) 'Precio'
FROM Articulos a join DetalleTicket dt on dt.Articulo = a.idArticulo join Ticket t on t.idTicket = dt.IdTicket
WHERE t.Fecha = @fecha
GROUP BY a.idArticulo,a.NombreArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ventasporRango]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ventasporRango]
@fecha1 date,
@fecha2 date
AS
BEGIN
	SELECT a.idArticulo as 'idArticulo',a.NombreArticulo 'nameArticulo' ,sum(dt.cantidad) 'Cantidad',sum(dt.cantidad * a.precio) 'Precio'
FROM Articulos a join DetalleTicket dt on dt.Articulo = a.idArticulo join Ticket t on t.idTicket = dt.IdTicket
WHERE t.Fecha between @fecha1 and @fecha2
GROUP BY a.idArticulo,a.NombreArticulo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ventasxmozo]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ventasxmozo]
@fecha date
AS
BEGIN

SELECT	mo.nombre + ' ' + mo.apellido as 'Mozo', sum(dt.cantidad) 'Cantidad' , sum(dt.cantidad * a.precio) 'Total' , mo.comision 'Comision' , ((sum(dt.cantidad * a.precio) * mo.comision) / 100) as 'Pago' 
FROM Articulos a join DetalleTicket dt on a.idArticulo = dt.Articulo join  Ticket t on t.idTicket = dt.IdTicket join Mozo mo on mo.idMozo = t.idMozo
WHERE t.Fecha = @fecha
GROUP BY mo.nombre + ' ' + mo.apellido, mo.Comision	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_verificarUsuario]    Script Date: 02/03/2022 11:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[sp_verificarUsuario]
@nameUser varchar (50),
@password varchar (50)
AS

	SELECT 
		COUNT(*)
	FROM 
		Mozo mo  join Usuarios us  on mo.idUser= us.idUser 
	WHERE 
		NameUser=@nameUser AND Contraseña=@password
	
GO
