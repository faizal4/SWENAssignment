USE [HMSSystem]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 03/06/2015 12:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Booking](
	[bookingID] [varchar](10) NOT NULL,
	[noOfAdults] [int] NULL,
	[noOfChildren] [int] NULL,
	[checkInDate] [date] NOT NULL,
	[checkOutDate] [date] NOT NULL,
	[noOfNights] [int] NOT NULL,
	[roomID] [int] NOT NULL,
	[additionalRequest] [varchar](225) NULL,
	[employeeID] [varchar](10) NOT NULL,
	[guestID] [int] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[bookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 03/06/2015 12:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [varchar](10) NOT NULL,
	[employeeType] [varchar](20) NOT NULL,
	[employeePwd] [varchar](20) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[homeAdd] [varchar](100) NOT NULL,
	[hpNo] [int] NOT NULL,
	[email] [varchar](225) NOT NULL,
	[icNo] [varchar](20) NOT NULL,
	[position] [varchar](20) NOT NULL,
	[workingHours] [int] NOT NULL,
	[salary] [int] NOT NULL,
	[generalMaintenance] [varchar](3) NOT NULL,
	[roomMaintenance] [varchar](3) NOT NULL,
	[estateMaintenance] [varchar](3) NOT NULL,
	[security] [varchar](3) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 03/06/2015 12:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Guest](
	[guestID] [int] NOT NULL,
	[guestName] [varchar](50) NOT NULL,
	[guestPassword] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[email] [varchar](225) NOT NULL,
	[icNo] [varchar](20) NOT NULL,
	[phoneNo] [int] NOT NULL,
	[nationality] [varchar](50) NOT NULL,
	[bookingDetails] [varchar](300) NOT NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[guestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Housekeeping]    Script Date: 03/06/2015 12:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Housekeeping](
	[housekeepingID] [int] NOT NULL,
	[housekeepingDate] [date] NOT NULL,
	[housekeepingJob] [varchar](20) NOT NULL,
	[employeeID1] [varchar](10) NULL,
	[employeeID1Name] [varchar](150) NULL,
	[employeeID2] [varchar](10) NULL,
	[employeeID2Name] [varchar](150) NULL,
	[employeeID3] [varchar](10) NULL,
	[employeeID3Name] [varchar](150) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 03/06/2015 12:25:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[roomID] [int] NOT NULL,
	[roomRates] [int] NOT NULL,
	[roomAvailability] [varchar](3) NULL,
	[roomType] [varchar](50) NOT NULL,
	[maxCapacity] [int] NOT NULL,
	[roomNo] [int] NOT NULL,
	[roomKeyStatus] [varchar](3) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[roomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Booking] ([bookingID], [noOfAdults], [noOfChildren], [checkInDate], [checkOutDate], [noOfNights], [roomID], [additionalRequest], [employeeID], [guestID]) VALUES (N'1', 2, 0, CAST(0x83380B00 AS Date), CAST(0x85380B00 AS Date), 2, 1, N'NIL', N'1', 1)
INSERT [dbo].[Booking] ([bookingID], [noOfAdults], [noOfChildren], [checkInDate], [checkOutDate], [noOfNights], [roomID], [additionalRequest], [employeeID], [guestID]) VALUES (N'2', 1, 0, CAST(0x7F380B00 AS Date), CAST(0x81380B00 AS Date), 2, 2, N'NIL', N'3', 2)
INSERT [dbo].[Booking] ([bookingID], [noOfAdults], [noOfChildren], [checkInDate], [checkOutDate], [noOfNights], [roomID], [additionalRequest], [employeeID], [guestID]) VALUES (N'3', 3, 0, CAST(0xA2380B00 AS Date), CAST(0xA4380B00 AS Date), 2, 3, N'NIL', N'3', 3)
INSERT [dbo].[Booking] ([bookingID], [noOfAdults], [noOfChildren], [checkInDate], [checkOutDate], [noOfNights], [roomID], [additionalRequest], [employeeID], [guestID]) VALUES (N'4', 4, 1, CAST(0x2D3A0B00 AS Date), CAST(0x2F3A0B00 AS Date), 2, 4, N'NIL', N'1', 2)
INSERT [dbo].[Booking] ([bookingID], [noOfAdults], [noOfChildren], [checkInDate], [checkOutDate], [noOfNights], [roomID], [additionalRequest], [employeeID], [guestID]) VALUES (N'5', 5, 0, CAST(0xE6390B00 AS Date), CAST(0xE8390B00 AS Date), 2, 4, N'NIL', N'1', 2)
INSERT [dbo].[Employee] ([employeeID], [employeeType], [employeePwd], [firstName], [lastName], [homeAdd], [hpNo], [email], [icNo], [position], [workingHours], [salary], [generalMaintenance], [roomMaintenance], [estateMaintenance], [security]) VALUES (N'1', N'Standard', N'111', N'Mohamed', N'Faizal', N'345 Tampines Avenue 8 ', 98760123, N'faizal@hotmail.com', N'S9876548A', N'Manager', 9, 100, N'Yes', N'Yes', N'No', N'No')
INSERT [dbo].[Employee] ([employeeID], [employeeType], [employeePwd], [firstName], [lastName], [homeAdd], [hpNo], [email], [icNo], [position], [workingHours], [salary], [generalMaintenance], [roomMaintenance], [estateMaintenance], [security]) VALUES (N'2', N'Standard', N'222', N'Ronald ', N'Ng', N'789 Kallang Street 12', 90712345, N'ronald@hotmail.com', N'S9123450L', N'Front Desk', 9, 100, N'Yes', N'Yes', N'No', N'No')
INSERT [dbo].[Employee] ([employeeID], [employeeType], [employeePwd], [firstName], [lastName], [homeAdd], [hpNo], [email], [icNo], [position], [workingHours], [salary], [generalMaintenance], [roomMaintenance], [estateMaintenance], [security]) VALUES (N'3', N'Standard', N'333', N'Mervin', N'Neo', N'123 Serangoon Road', 91237890, N'mervin@gmail.com', N'S9126789F', N'Housekeeping', 9, 150, N'Yes', N'Yes', N'Yes', N'Yes')
INSERT [dbo].[Employee] ([employeeID], [employeeType], [employeePwd], [firstName], [lastName], [homeAdd], [hpNo], [email], [icNo], [position], [workingHours], [salary], [generalMaintenance], [roomMaintenance], [estateMaintenance], [security]) VALUES (N'4', N'Standard', N'444', N'Syazwani ', N'Saharoni', N'678 Bedok Reservoir Road', 96578246, N'syazwani@hotmail.com', N'S9456712I', N'Front Desk', 9, 120, N'No', N'No', N'No', N'Yes')
INSERT [dbo].[Guest] ([guestID], [guestName], [guestPassword], [firstName], [lastName], [email], [icNo], [phoneNo], [nationality], [bookingDetails]) VALUES (1, N'Eunice Lee', N'eunice123', N'Eunice', N'Lee', N'eunicelee@hotmail.cpm', N'S9876543Q', 97681234, N'Singaporean', N'NIL')
INSERT [dbo].[Guest] ([guestID], [guestName], [guestPassword], [firstName], [lastName], [email], [icNo], [phoneNo], [nationality], [bookingDetails]) VALUES (2, N'Felicia Tan', N'felicia123', N'Felicia', N'Tan', N'feliciatan@gmail.com', N'S9012678R', 98120945, N'Singaporean', N'NIL')
INSERT [dbo].[Guest] ([guestID], [guestName], [guestPassword], [firstName], [lastName], [email], [icNo], [phoneNo], [nationality], [bookingDetails]) VALUES (3, N'Gary Liang', N'gary345', N'Gary', N'Liang', N'garyliang@hotmail.com', N'S9456371T', 91230987, N'Singaporean', N'NIL')
INSERT [dbo].[Housekeeping] ([housekeepingID], [housekeepingDate], [housekeepingJob], [employeeID1], [employeeID1Name], [employeeID2], [employeeID2Name], [employeeID3], [employeeID3Name]) VALUES (1, CAST(0xE6390B00 AS Date), N'general', N'1', N'Faizal', N'2', N'Ronald', NULL, NULL)
INSERT [dbo].[Housekeeping] ([housekeepingID], [housekeepingDate], [housekeepingJob], [employeeID1], [employeeID1Name], [employeeID2], [employeeID2Name], [employeeID3], [employeeID3Name]) VALUES (2, CAST(0xE6390B00 AS Date), N'room', N'1', N'Faizal', N'2', N'Ronald', NULL, NULL)
INSERT [dbo].[Housekeeping] ([housekeepingID], [housekeepingDate], [housekeepingJob], [employeeID1], [employeeID1Name], [employeeID2], [employeeID2Name], [employeeID3], [employeeID3Name]) VALUES (3, CAST(0xE6390B00 AS Date), N'security', N'3', N'Mervin', NULL, NULL, NULL, NULL)
INSERT [dbo].[Housekeeping] ([housekeepingID], [housekeepingDate], [housekeepingJob], [employeeID1], [employeeID1Name], [employeeID2], [employeeID2Name], [employeeID3], [employeeID3Name]) VALUES (4, CAST(0xE6390B00 AS Date), N'estate', N'3', N'Mervin', N'4', N'Syazwani', NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomRates], [roomAvailability], [roomType], [maxCapacity], [roomNo], [roomKeyStatus]) VALUES (1, 50, N'Yes', N'Standard', 2, 101, N'Yes')
INSERT [dbo].[Room] ([roomID], [roomRates], [roomAvailability], [roomType], [maxCapacity], [roomNo], [roomKeyStatus]) VALUES (2, 100, N'Yes', N'Standard', 2, 102, N'No')
INSERT [dbo].[Room] ([roomID], [roomRates], [roomAvailability], [roomType], [maxCapacity], [roomNo], [roomKeyStatus]) VALUES (3, 200, N'Yes', N'Deluxe', 4, 201, N'Yes')
INSERT [dbo].[Room] ([roomID], [roomRates], [roomAvailability], [roomType], [maxCapacity], [roomNo], [roomKeyStatus]) VALUES (4, 300, N'Yes', N'Suite', 6, 301, N'Yes')
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Employee]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Guest] FOREIGN KEY([guestID])
REFERENCES [dbo].[Guest] ([guestID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Guest]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Room] FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([roomID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Room]
GO
