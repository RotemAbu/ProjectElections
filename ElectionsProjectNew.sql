USE [ElectionsProjectNew]
GO
/****** Object:  Table [dbo].[Kalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kalpi](
	[kalpiCode] [varchar](10) NOT NULL,
	[managerID] [nchar](9) NULL,
	[kalpiName] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[area] [nvarchar](50) NULL,
	[votersAmount] [int] NULL,
	[maxVoters] [int] NULL,
	[invalidAccess] [bit] NULL CONSTRAINT [DF_Kalpi_invalidAccess]  DEFAULT ((0)),
	[openKalpi] [bit] NULL CONSTRAINT [DF_Kalpi_openKalpi]  DEFAULT ((0)),
	[mode] [bit] NULL CONSTRAINT [DF_Kalpi_mode]  DEFAULT ((1))
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parties]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parties](
	[partyName] [nvarchar](50) NULL,
	[memberSize] [int] NULL,
	[platform] [nvarchar](max) NULL,
	[mode] [bit] NULL CONSTRAINT [DF_Parties_mode]  DEFAULT ((1))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Party_Members]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Party_Members](
	[memberCode] [int] NOT NULL,
	[partyName] [nvarchar](50) NOT NULL,
	[fName] [nvarchar](20) NOT NULL,
	[lName] [nvarchar](20) NOT NULL,
	[dob] [date] NOT NULL,
	[listPlace] [int] NOT NULL,
	[education] [nvarchar](max) NULL,
	[experience] [nvarchar](max) NULL,
	[mode] [bit] NULL CONSTRAINT [DF_Party_Members_mode]  DEFAULT ((1))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vote]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vote](
	[vote_code] [int] NOT NULL,
	[kalpiCode] [varchar](10) NOT NULL,
	[prime_code] [int] NOT NULL,
	[partyName] [nvarchar](50) NOT NULL,
	[white_note] [bit] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Voter_T]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Voter_T](
	[id] [nvarchar](50) NOT NULL,
	[kalpiCode] [varchar](10) NULL,
	[fname] [nvarchar](50) NULL,
	[lname] [nvarchar](50) NULL,
	[username] [varchar](20) NULL,
	[password] [nvarchar](50) NULL,
	[permission] [nvarchar](50) NULL,
	[birthDay] [date] NULL CONSTRAINT [DF_Voter_T_birthDay]  DEFAULT (getdate()),
	[address] [nvarchar](50) NULL,
	[area] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[tell] [nvarchar](50) NULL,
	[accomId] [nvarchar](50) NULL,
	[isBlocked] [bit] NULL CONSTRAINT [DF_Voter_T_isBlocked]  DEFAULT ((1)),
	[isVoted] [bit] NULL CONSTRAINT [DF_Voter_T_isVoted]  DEFAULT ((0)),
	[mode] [bit] NULL CONSTRAINT [DF_Voter_T_mode]  DEFAULT ((1)),
	[lastConnection] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'CJ01', N'452876543', N'Mirkaz Macabim', N'Macabim 10', N'Jerusale', N'Center', 2, 300, 1, 0, 1)
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'CT01', N'0        ', N'Mekif Alef', N'Haruv 59', N'Tel Aviv', N'Center', 3, 500, 0, 0, 1)
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'NH01', N'413891456', N'Lev Mifraz', N'Lev Mifraz 20', N'Haifa', N'North', 3, 400, 1, 0, 1)
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'NM01', N'589362679', N'Canada Center', N'Rambam 30', N'Metula', N'North', 2, 200, 0, 0, 1)
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'SB01', N'234987621', N'Mekif Vav', N'Nahal Ashan 20', N'Beer Sheva', N'South', 4, 500, 0, 0, 1)
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'SK01', N'477635278', N'Matnas Rabin', N'Moshe Sharet 14', N'Kiryat Gat', N'South', 2, 300, 1, 0, 1)
INSERT [dbo].[Kalpi] ([kalpiCode], [managerID], [kalpiName], [address], [city], [area], [votersAmount], [maxVoters], [invalidAccess], [openKalpi], [mode]) VALUES (N'DG32', N'203129597', N'matnas', N'haim bar lev', N'Tel AvivA', N'Center', 1, 400, 1, 1, 1)
INSERT [dbo].[Parties] ([partyName], [memberSize], [platform], [mode]) VALUES (N'Likud', 10, N'Economy, Military, Education', 1)
INSERT [dbo].[Parties] ([partyName], [memberSize], [platform], [mode]) VALUES (N'Shas', 12, N'Religion, Healthcare, Wealthfare', 1)
INSERT [dbo].[Parties] ([partyName], [memberSize], [platform], [mode]) VALUES (N'Kulanu', 10, N'Treasury, Culture, Banking', 1)
INSERT [dbo].[Parties] ([partyName], [memberSize], [platform], [mode]) VALUES (N'Bait Yeudi', 15, N'Diplomacy, Infrastructure', 1)
INSERT [dbo].[Parties] ([partyName], [memberSize], [platform], [mode]) VALUES (N'rotem', 5, N'ygfh', 0)
INSERT [dbo].[Party_Members] ([memberCode], [partyName], [fName], [lName], [dob], [listPlace], [education], [experience], [mode]) VALUES (1, N'Likud', N'Binjamin', N'Nataniyahu', CAST(N'1960-03-05' AS Date), 1, N'second degree', N'20 years in politics', 1)
INSERT [dbo].[Party_Members] ([memberCode], [partyName], [fName], [lName], [dob], [listPlace], [education], [experience], [mode]) VALUES (2, N'Shas', N'Ariye', N'Deri', CAST(N'1954-07-04' AS Date), 1, N'first degree', N'9 years in politics', 1)
INSERT [dbo].[Party_Members] ([memberCode], [partyName], [fName], [lName], [dob], [listPlace], [education], [experience], [mode]) VALUES (3, N'Kulanu', N'Avi', N'Kahlon', CAST(N'1970-05-08' AS Date), 1, N'second degree', N'7 years in politics', 1)
INSERT [dbo].[Party_Members] ([memberCode], [partyName], [fName], [lName], [dob], [listPlace], [education], [experience], [mode]) VALUES (4, N'Bait Yeudi', N'Naftali', N'Benet', CAST(N'1975-09-06' AS Date), 1, N'first degree', N'5 years in politics', 1)
INSERT [dbo].[Party_Members] ([memberCode], [partyName], [fName], [lName], [dob], [listPlace], [education], [experience], [mode]) VALUES (1679, N'likud', N'saly', N'avital', CAST(N'2015-06-02' AS Date), 5, N'thy', N'ghtf', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (1, N'CT01', 1, N'Shas', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (2, N'CJ01', 2, N'Likud', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (3, N'CT01', 3, N'Bait Yeudi', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (4, N'CJ01', 0, N'0', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (5, N'SB01', 4, N'Kulanu', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (6, N'SB01', 1, N'Likud', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (7, N'SK01', 2, N'Shas', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (8, N'SK01', 3, N'Likud', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (9, N'CT01', 0, N'0', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (10, N'SK01', 0, N'0', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (11, N'SB01', 0, N'0', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (12, N'NH01', 0, N'0', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (13, N'NM01', 0, N'0', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (14, N'NM01', 4, N'Bait Yeudi', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (15, N'NH01', 2, N'Kulanu', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (16, N'SB01', -1, N'Likud', 0)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (17, N'SB01', -1, N'-1', 1)
INSERT [dbo].[Vote] ([vote_code], [kalpiCode], [prime_code], [partyName], [white_note]) VALUES (18, N'SB01', 1, N'Likud', 0)
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'1', N'CT01', N'Avi', N'Malka', N'1', N'1', N'1', CAST(N'1980-04-23' AS Date), N'Giborey Israel 5', N'Center', N'Tel AvivA', N'0527668983', N'0', 1, 0, 1, CAST(N'2015-06-03' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'2', N'CJ01', N'Eli', N'Cohen', N'2', N'2', N'2', CAST(N'1970-05-31' AS Date), N'King George 10', N'Center', N'Jerusalem', N'0523476541', N'0', 1, 0, 1, CAST(N'2015-06-03' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'762897651', N'CT01', N'Avi', N'Malka', N'avimalk', N'a6v2_j1i', N'0', CAST(N'1982-05-31' AS Date), N'Giborey Israel 4', N'Center', N'Tel AvivA', N'0527668983', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'413891456', N'NH01', N'Shmuel', N'Deri', N'shmderi', N'hjF6fdlp', N'2', CAST(N'1987-08-07' AS Date), N'Ha-Oren 50', N'North', N'Haifa', N'0548876558', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'367664225', N'NM01', N'Gila', N'Yampolsky', N'gilayam', N'gj4Fawrt', N'2', CAST(N'1970-03-04' AS Date), N'Haruv 12', N'North', N'Metula', N'0526576776', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'355768897', N'SB01', N'Aviva', N'Yakov', N'aviyako', N'fG4Jsdfg', N'2', CAST(N'1975-05-06' AS Date), N'Nahum Begin 1', N'South', N'Beer Sheva', N'0582436778', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'265687442', N'SK01', N'Michael', N'Lebedev', N'michleb', N'aG5Sgjut', N'2', CAST(N'1979-06-07' AS Date), N'Palmah 5', N'South', N'Kiryat Gat', N'0581232456', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'3', N'CT01', N'Avi', N'Malka', N'3', N'3', N'3', CAST(N'1983-05-09' AS Date), N'Giborey Israel 4', N'Center', N'Tel AvivA', N'0527668983', N'0', 1, 0, 1, CAST(N'2015-06-03' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'458765543', N'NH01', N'Kobi', N'Gueta', N'kobigue', N'dG6Aj4r8', N'3', CAST(N'1979-01-07' AS Date), N'Neviim 9', N'North', N'Haifa', N'0527865430', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'345678653', N'SB01', N'Adam', N'Peres', N'adamper', N'fD_4hk1i', N'3', CAST(N'1978-06-04' AS Date), N'Herzel 40', N'South', N'Beer Sheva', N'0536554346', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'0', N'DG32', N'Avi', N'Malka', N'0', N'0', N'0', CAST(N'1975-07-20' AS Date), N'Giborey Israel 5', N'Center', N'Tel AvivA', N'0527668983', N'0', 0, 1, 1, CAST(N'2015-06-03' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'345685775', N'CJ01', N'Irena ', N'Gordon', N'irengor', N'q4gH8pwi', N'0', CAST(N'1950-09-02' AS Date), N'Zhibotinsky 10', N'Center', N'Jerusalem', N'0524568875', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'326784765', N'SB01', N'Natalie', N'Katz', N'natakat', N'dh51flpd', N'0', CAST(N'1987-07-03' AS Date), N'Meleh 3', N'South', N'Beer Sheva', N'0525687754', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'234574675', N'SK01', N'Victoria', N'Akerman', N'victake', N'dkqwrjlpi', N'0', CAST(N'1984-05-08' AS Date), N'Aliya 39', N'South', N'Kiryat Gat', N'0542568643', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'224476780', N'NH01', N'Avraham', N'Novik', N'avrano', N'qwerty79', N'0', CAST(N'1959-05-25' AS Date), N'Tayasim 46', N'North', N'Haifa', N'0541236086', N'0', 1, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'234465787', N'NM01', N'Benjamin', N'Kadosh', N'benjkad', N'3dfyiGkd', N'0', CAST(N'1962-08-10' AS Date), N'Timna 80', N'North', N'Metula', N'0549751144', N'0', 0, 0, 1, CAST(N'2015-05-31' AS Date))
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'301800579', N'CJ01', N'tg', N'tg', N'tr', N'tr', N'3', CAST(N'2015-06-02' AS Date), N'gt', N'tr', N'gtr', N'gtr', N'gh', 0, 0, 1, NULL)
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'203129598', N'xxx', N'rtg', N'rt', N'tr', N'rty', N'0', CAST(N'2015-06-02' AS Date), N'ty', N'tr', N'Tel Aviv', N'rtry', N'try', 0, 0, 1, NULL)
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'123456789', N'CJ01', N'tg', N'tfg', N'tgr', N'tg', N'Kalpi Member', CAST(N'1991-06-03' AS Date), N'gtr', N'tgr', N'gtr', N'586', NULL, 1, 0, 1, NULL)
INSERT [dbo].[Voter_T] ([id], [kalpiCode], [fname], [lname], [username], [password], [permission], [birthDay], [address], [area], [city], [tell], [accomId], [isBlocked], [isVoted], [mode], [lastConnection]) VALUES (N'123123123', N'CJ01', N'yh', N'yth', N'yth', N'yhty', N'Guard', CAST(N'1991-06-03' AS Date), N'yth', N'hyt', N'yth', N'56353', NULL, 0, 0, 1, NULL)
/****** Object:  StoredProcedure [dbo].[addAccompanierId]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <4/04/2015>
-- Description:	<Add Accompanier Id>
-- =============================================
CREATE PROCEDURE [dbo].[addAccompanierId]
	@accomId nvarchar(50),
	@id nvarchar(50)
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id)>0
	BEGIN
		Update dbo.Voter_T
		SET accomId=@accomId
		WHERE id=@id
	END

END





GO
/****** Object:  StoredProcedure [dbo].[AddKalpiToVoter]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <25/05/2015>
-- Description:	<Add Kalpi To Voter >
-- =============================================
CREATE PROCEDURE [dbo].[AddKalpiToVoter]
	@id nvarchar(50),
	@kalpiCode nvarchar(50),
	@Result int output
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id and mode = 1)>0
	BEGIN
		if(Select COUNT(*) From Kalpi where kalpiCode=@kalpiCode)>0
		Begin
			update Kalpi set kalpi.votersAmount=Kalpi.votersAmount-1 where kalpiCode =(select kalpiCode from Voter_T where id = @id)
			update Kalpi set kalpi.votersAmount=Kalpi.votersAmount+1 where kalpiCode=@kalpiCode
			Update dbo.Voter_T SET kalpiCode=@kalpiCode where id=@id
			Set @Result = 1
		End 
		Else
		Begin
			Set @Result=2
		End
	END
	ELSE
	Begin
		Set @Result = 0
	End

END










GO
/****** Object:  StoredProcedure [dbo].[AddNewAreaManager]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Snir Dahan>
-- Create date: <11/05/2015>
-- Description:	<Add New Area Manager>
-- =============================================
CREATE PROCEDURE  [dbo].[AddNewAreaManager]
	@ID nvarchar(50),
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@userName nvarchar(50),
	@pass nvarchar(50),
	@Permission nvarchar(50),
	@dob date,
	@Address nvarchar(50),
	@Area nvarchar(50),
	@City nvarchar(50),
	@Tell nvarchar(50),
	@Accomid nvarchar(50),
	@Result int output
AS
BEGIN
	if (select count(*) from Voter_T where id=@ID)>0
		BEGIN
			SET @Result = 0
		END
	else if (select count(*) from Voter_T where area=@Area)>0
		BEGIN
			SET @Result = 0
		END
	else
		BEGIN
			INSERT INTO Voter_T(id,fname,lname,city,username,password,permission,birthDay,address,area,tell,accomId)
			VALUES (@ID,@firstName,@lastName,@City,@userName,@pass,@Permission,@dob,@Address,@Area,@Tell,@Accomid)
			SET @Result=1
		END
END






GO
/****** Object:  StoredProcedure [dbo].[addNewKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[addNewKalpi]
	@kalpiCode varchar(50),
	@city nvarchar(50),
	@address nvarchar(50),
	@kalpiName nvarchar(50),
	@area nvarchar(50),
	@maxVoters int,
	@Result int output
AS
BEGIN
	if (select count(*) from Kalpi where kalpiCode=@kalpiCode and mode=1)>0
	BEGIN
		set @Result=0;
	END
	else
	BEGIN
		insert into Kalpi(kalpiCode,kalpiName,address,city,area,maxVoters,mode)
		values(@kalpiCode,@kalpiName,@address,@city,@area,@maxVoters,1)
		set @Result=1;
	END
END






GO
/****** Object:  StoredProcedure [dbo].[AddNewKalpiManagerToArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <11/05/2015>
-- Description:	<area manager add kalpi manager to his area>
-- =============================================
CREATE PROCEDURE [dbo].[AddNewKalpiManagerToArea] 
	
@id nvarchar(50),
@kalpiCode varchar(50),
@fname nvarchar(50),
@lname nvarchar(50),
@username varchar(20),
@password nvarchar(50),
@permission nvarchar(50),
@birthDay date,
@city nvarchar(50),
@area nvarchar(50),
@address nvarchar(50),
@tell nvarchar(50),
@Result int output
	
AS
BEGIN

	IF(SELECT COUNT(*) from Voter_T WHERE id=@id)>0
		BEGIN
			set @Result =0
		END
	ELSE 
		BEGIN
			insert into Voter_T(id,kalpiCode,fname,lname,username,password,permission,birthDay,address,area,city,tell)
				 values(@id,@kalpiCode,@fname,@lname,@username,@password,@permission,@birthDay,@address,@area,@city,@tell)
			update Kalpi set managerID=@id where kalpiCode=@kalpiCode
				
			SET @Result=1
		end

END





GO
/****** Object:  StoredProcedure [dbo].[AddNewVoterToKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Snir Dahan>
-- Create date: <Create Date,,>
-- Description:	<Add new voter to kalpi>
-- =============================================
CREATE PROCEDURE [dbo].[AddNewVoterToKalpi]
	@ID nvarchar(50),
	@kalpiCode varchar(50),
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@userName nvarchar(50),
	@pass nvarchar(50),
	@Permission nvarchar(50),
	@dob date,
	@Address nvarchar(50),
	@Area nvarchar(50),
	@City nvarchar(50),
	@Tell nvarchar(50),
	@Accomid nvarchar(50),
	@Result int output
AS
BEGIN
	if (select count(*) from Voter_T where id=@ID)>0
		BEGIN
			SET @Result = 0
		END
	else if (select count(*) from Kalpi where city=@City)>0
		BEGIN
			update Kalpi set Kalpi.votersAmount+=1 where kalpiCode=@kalpiCode
			INSERT INTO Voter_T(id,kalpiCode,fname,lname,city,username,password,permission,birthDay,address,area,tell,accomId)
			VALUES (@ID,@kalpiCode,@firstName,@lastName,@City,@userName,@pass,@Permission,@dob,@Address,@Area,@Tell,@Accomid)
			SET @Result=1
		END
END



GO
/****** Object:  StoredProcedure [dbo].[addVoterToKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[addVoterToKalpi]
	@ID nvarchar(10),
	@kalpiCode varchar(10),
	@Result int output
AS
BEGIN
	if (select count (*) from Kalpi where kalpiCode=@kalpiCode and mode=1 and votersAmount<maxVoters)>0
		begin
			update Kalpi set Kalpi.votersAmount+=1 where kalpiCode=@kalpiCode
			update Voter_T set Voter_T.kalpiCode=@kalpiCode where id=@ID
			set @Result=1
		end
	else
		begin
			set @Result=0
		end
END



GO
/****** Object:  StoredProcedure [dbo].[AddWorker]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddWorker] 
	@idVoter nvarchar(9),
	@kalpiCode varchar(10),
	@name nvarchar(50),
	@lastname  varchar(50),
	@username  nvarchar(50),
	@password  nvarchar(50),
	@permission  nvarchar(50),
	@birthDay date,
	@address nvarchar(50),
	@area nvarchar(50),
	@city nvarchar(50),
	@tell nvarchar(50),
	@Result int output

AS
BEGIN
	IF(Select Count(*) From Voter_T Where id = @idVoter)=0
	Begin
		IF(Select Count(*) From Voter_T Where username = @username)=0
		Begin
			Insert Into Voter_T (id,kalpiCode,fname,lname,username,password,permission,birthDay,address,area,city,tell)
			Values (@idVoter,@kalpiCode,@name,@lastname,@username,@password,@permission,@birthDay,@address,@area,@city,@tell)
			set @Result = 1
		End
		Else
		Begin
			set @Result = 2
		End
	End
	Else
	Begin
		set @Result = 0
	End
END






GO
/****** Object:  StoredProcedure [dbo].[blockCitizen]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <19/04/2015>
-- Description:	<unblocked Citizen>
-- =============================================
CREATE PROCEDURE [dbo].[blockCitizen]
	@id nvarchar(50),
	@isBlocked bit
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id)>0
	BEGIN
		Update dbo.Voter_T
		SET isBlocked=1
		where id=@id
		
	END

END






GO
/****** Object:  StoredProcedure [dbo].[blockKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <11/05/2015>
-- Description:	<block kalpi>
-- =============================================
CREATE PROCEDURE [dbo].[blockKalpi]
	@kalpiCode nvarchar(50),
	@openKalpi bit
AS
BEGIN
	If(SELECT COUNT(*) from Kalpi where kalpiCode=@kalpiCode)>0
	BEGIN
		Update dbo.Kalpi
		SET openKalpi=0
		where kalpiCode=@kalpiCode
		
	END

END





GO
/****** Object:  StoredProcedure [dbo].[changePassword]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <4/04/2015>
-- Description:	<Chenge Password>
-- =============================================
Create PROCEDURE [dbo].[changePassword]
	@password nvarchar(50),
	@id nvarchar(50)
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id)>0
	BEGIN
		Update dbo.Voter_T
		SET password=@password
		WHERE id=@id
	END

END






GO
/****** Object:  StoredProcedure [dbo].[CheakParty]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 02/04/2015
-- Description:	search party
-- =============================================
CREATE PROCEDURE [dbo].[CheakParty]
	-- Add the parameters for the stored procedure here
	@partyName nvarchar(50),
	@Result int output
AS
BEGIN
	if(SELECT count(*) FROM Parties WHERE partyName=@partyName and mode=1)>0
	begin
		set @Result= 1
	end
	else
	begin
		set @Result= 0
	end
END






GO
/****** Object:  StoredProcedure [dbo].[CheckNameOFPartyMember]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CheckNameOFPartyMember]
	@partyName nvarchar(50),
	@Result int output
AS
BEGIN
	if (SELECT Count(*) FROM Party_Members WHERE partyName=@partyName)>0
	begin
		set @Result =1
	end
	else
	begin
		set @Result = 0
	end
END




GO
/****** Object:  StoredProcedure [dbo].[CloseAllKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Daria Sokolov>
-- Create date: <Create Date,,27/05/2015>
-- Description:	<Description,,Closes all kalpi (sets openKalpi field to 0)>
-- =============================================
CREATE PROCEDURE [dbo].[CloseAllKalpi]
AS
BEGIN
		Update dbo.Kalpi
		SET openKalpi = 0
		WHERE mode=1	
END




GO
/****** Object:  StoredProcedure [dbo].[CloseKalpiByManagerArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham	
-- Create date: 25.5.15
-- Description:	Area manager close kalpi
-- =============================================
CREATE PROCEDURE [dbo].[CloseKalpiByManagerArea]
	-- Add the parameters for the stored procedure here
	@area nvarchar(50),
	@Result int output
AS
BEGIN
	IF(SELECT COUNT(*) from Kalpi WHERE @area=area)>0
		BEGIN
			update Kalpi set Kalpi.openKalpi=0 WHERE Kalpi.area= @area 
			SET @Result=1
		END
	ELSE 
		BEGIN
			set @Result =0
	end
END








GO
/****** Object:  StoredProcedure [dbo].[DeleteParty]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Snir Dahan>
-- Create date: <1/04/2015>
-- Description:	<Delete Party>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteParty]
	@partyName nvarchar(50),
	@mode bit,
	@Result bit output
AS
BEGIN
	If(SELECT COUNT(*) from Parties where partyName=@partyName and mode= 1)>0
	BEGIN
		Update dbo.Parties
		SET mode=@mode
		WHERE partyName=@partyName
		SET @Result = 1
	END
	ELSE
	BEGIN
		SET @Result = 0
	END
END






GO
/****** Object:  StoredProcedure [dbo].[getAmountVOtersInArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <25/05/2015>
-- Description:	<Return amount of voters in area>
-- =============================================
CREATE PROCEDURE [dbo].[getAmountVOtersInArea] 

@area nvarchar(50)

AS
BEGIN
	
	select votersAmount from Kalpi where area=@area
		

END








GO
/****** Object:  StoredProcedure [dbo].[getAreaById]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin>
-- Create date: <25/05/2015>
-- Description:	<Get area by id>
-- =============================================
CREATE PROCEDURE [dbo].[getAreaById]
	@id nvarchar(9)


	
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id)>0
		BEGIN
			SELECT id, area, kalpiCode from Voter_T where id=@id
		END

END








GO
/****** Object:  StoredProcedure [dbo].[getCalpiCode]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,Alexey yakimishin>
-- Create date: <Create Date,11/05/2015,>
-- Description:	<Description, getCalpiCode,>
-- =============================================
CREATE PROCEDURE [dbo].[getCalpiCode]
	@kalpiCode nvarchar(9)

AS
BEGIN
	If(SELECT COUNT(*) from Kalpi where kalpiCode=@kalpiCode)>0
		BEGIN
			SELECT kalpiCode,area from Kalpi where kalpiCode=@kalpiCode
		END

END







GO
/****** Object:  StoredProcedure [dbo].[getCalpiCodeById]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getCalpiCodeById]
	@id nvarchar(9)


	
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id)>0
		BEGIN
			SELECT id, kalpiCode from Voter_T where id=@id
		END

END




GO
/****** Object:  StoredProcedure [dbo].[getCities]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCities]
	@area nvarchar(20)
AS
   SELECT distinct city from Kalpi where area=@area





GO
/****** Object:  StoredProcedure [dbo].[getKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getKalpi]
	@city nvarchar(20)
AS
   SELECT kalpiName from Kalpi where city=@city





GO
/****** Object:  StoredProcedure [dbo].[getKalpiByCode]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getKalpiByCode]
	@kalpiCode varchar(20)
AS
BEGIN
	Select * from Kalpi where kalpiCode=@kalpiCode
END









GO
/****** Object:  StoredProcedure [dbo].[getKalpiCodeByCity]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getKalpiCodeByCity]
	@city nvarchar(20)
AS
   SELECT kalpiCode,kalpiName from Kalpi where city=@city





GO
/****** Object:  StoredProcedure [dbo].[getNumOfWhiteNotes]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getNumOfWhiteNotes]
	@kalpiCode nvarchar(20),
	@Result int output
	
AS
	BEGIN
		set @Result =  (SELECT COUNT(white_note) from dbo.Vote where (kalpiCode=@kalpiCode AND  white_note = 1))
	End







GO
/****** Object:  StoredProcedure [dbo].[getParties]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getParties]
AS
   SELECT partyName FROM Parties




GO
/****** Object:  StoredProcedure [dbo].[getPrimeMinisters]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPrimeMinisters]
AS
	SELECT * 
	FROM Party_Members AS p
	WHERE p.listPlace=1




GO
/****** Object:  StoredProcedure [dbo].[getPrimeVotes]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getPrimeVotes]
@kalpiCode nvarchar(9)
AS
BEGIN
select primeCode, count(*) Total
from 
(
  select prime_code as primeCode 
  from Vote where kalpiCode=@kalpiCode
) d
group by primeCode
order by Total desc;
END






GO
/****** Object:  StoredProcedure [dbo].[getPrimeVotesInKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Daria Sokolov>
-- Create date: <31/05/2015>
-- Description:	<returns vote amount for prime minister in given kalpi>
-- =============================================
CREATE PROCEDURE [dbo].[getPrimeVotesInKalpi]
	@primeCode nvarchar(50),
	@kalpiCode varchar(10),
	@Result int output
AS
BEGIN
	
	IF(SELECT COUNT(*) FROM Vote WHERE prime_code=@primeCode and kalpiCode=@kalpiCode)>0
		BEGIN
			SELECT @Result=COUNT(*) FROM Vote WHERE prime_code=@primeCode and kalpiCode=@kalpiCode
		END
	ELSE
		BEGIN
			SET @Result=0
		END
END


GO
/****** Object:  StoredProcedure [dbo].[getSumOfVoters]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <25/05/2015>
-- Description:	<Return amount of voters in area>
-- =============================================
CREATE PROCEDURE [dbo].[getSumOfVoters] 

@kalpiCode varchar(10)

AS
BEGIN

	SELECT kalpiCode from Vote WHERE kalpiCode=@kalpiCode

END








GO
/****** Object:  StoredProcedure [dbo].[getTotalprecentage]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getTotalprecentage]
AS
BEGIN
	SELECT round(100.0*(select count(*) from Voter_T where isVoted=1) / (select count(*) from Voter_T),2)
END






GO
/****** Object:  StoredProcedure [dbo].[IsInVoteDB]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Snir Dahan>
-- Create date: <25/05/2015>
-- Description:	<The party name is in Vote Data Base>
-- =============================================
CREATE PROCEDURE [dbo].[IsInVoteDB]
	@partyName nvarchar(50),
	@kalpiCode varchar(10),
	@Result int output
AS
BEGIN
	
	IF(SELECT COUNT(*) FROM Vote WHERE partyName=@partyName and kalpiCode=@kalpiCode)>0
		BEGIN
			SELECT @Result=COUNT(*) FROM Vote WHERE partyName=@partyName AND kalpiCode=@kalpiCode
		END
	ELSE
		BEGIN
			SET @Result=0
		END
END



GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gorup 12
-- Create date: 30-03-2015
-- Description:	Login to System 
-- =============================================
CREATE PROCEDURE [dbo].[Login]
	@id nvarchar(20),
	@username varchar(20),
	@password varchar(20)
AS
BEGIN
	Select * from Voter_T where id=@id and username=@username and password=@password and mode = 1
END







GO
/****** Object:  StoredProcedure [dbo].[newMemberParty]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Group 12(shmuel)
-- Create date: <Create Date,,>
-- Description:	insert into member party
-- =============================================
CREATE PROCEDURE [dbo].[newMemberParty]
	@member int,
	@partyn nvarchar(50),
	@name nvarchar(20),
	@lastn nvarchar(20),
	@datet date,
	@list int,
	@ediction nvarchar(320),
	@exp nvarchar(210),
	@Result int output

AS
BEGIN
	
	IF(SELECT COUNT(*) FROM Party_Members WHERE memberCode=@member)>0
		BEGIN
			SET @Result=0
		END
	ELSE 
		BEGIN
			IF(select Count(*) from Parties where partyName=@partyn)=1
			BEgin
				IF(SELECT COUNT(*) FROM Party_Members WHERE partyName = @partyn and listPlace = @list)=0
				begin
					IF(select memberSize from Parties where partyName = @partyn)>=@list
					begin
						INSERT INTO Party_Members(memberCode,partyName,fName,lName,dob,listPlace,education,experience)
						VALUES (@member,@partyn,@name,@lastn,@datet,@list,@ediction,@exp)
						SET @Result=1
					end
				end
			end
		END


END






GO
/****** Object:  StoredProcedure [dbo].[newParty]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Snir Dahan>
-- Create date: <1/04/2015>
-- Description:	<Add new Party>
-- =============================================
CREATE PROCEDURE [dbo].[newParty]
	@partyName nvarchar(50),
	@memberSize int,
	@platform nvarchar(100),
	@Result int output
AS
BEGIN
	if (select count(*) from Parties where partyName=@partyName)>0
	BEGIN
		set @Result=0;
	END
	else
	BEGIN
		insert into Parties(partyName,memberSize,platform)
		values(@partyName,@memberSize,@platform)
		set @Result=1;
	END
END






GO
/****** Object:  StoredProcedure [dbo].[OpenKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[OpenKalpi]
AS
BEGIN
	update Kalpi Set openKalpi=1
END




GO
/****** Object:  StoredProcedure [dbo].[RemoveAcompanier]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 19/04/2015
-- Description:	Removing acommpany
-- =============================================
CREATE PROCEDURE [dbo].[RemoveAcompanier]
	@id nvarchar(50)
	
AS
BEGIN

	BEGIN
		Update dbo.Voter_T 
		SET accomId=0
		WHERE id=@id
	END
END




GO
/****** Object:  StoredProcedure [dbo].[RemoveAreaManager]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Snir Dahan>
-- Create date: <11/05/2015>
-- Description:	<Remove Exist Area Manager>
-- =============================================
CREATE PROCEDURE [dbo].[RemoveAreaManager]
	@ID nvarchar(10),
	@Result int output
AS
BEGIN
	if (select count (*) from Voter_T where id=@ID and mode=1)>0
		begin
			update Voter_T set Voter_T.mode=0 where id=@ID
			set @Result=1
		end
	else
		begin
			set @Result=0
		end
END






GO
/****** Object:  StoredProcedure [dbo].[RemoveKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveKalpi]

@kalpiCode varchar(10)
AS
	UPDATE Kalpi
	SET mode = 0
	WHERE kalpiCode=@kalpiCode





GO
/****** Object:  StoredProcedure [dbo].[RemoveKalpiManager]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Daria Sokolov>
-- Create date: <Create Date,,>
-- Description:	<Description,,Remove Kalpi Manager>
-- =============================================
CREATE PROCEDURE [dbo].[RemoveKalpiManager]

	@id nvarchar(9),
	@Result int output
AS
BEGIN
	
	If(Select Count(*) From Voter_T Where id = @id )>0
	Begin
		Update Voter_T Set Voter_T.permission = 0 Where id = @id
		Update Kalpi Set Kalpi.managerID = 0 Where managerID = @id
		Set @Result = 1
	End
	Else
	Begin
		Set @Result = 0
	End
END






GO
/****** Object:  StoredProcedure [dbo].[RemovePartyMember]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 02/04/2015
-- Description:	remove party member
-- =============================================
CREATE PROCEDURE [dbo].[RemovePartyMember]
	-- Add the parameters for the stored procedure here
	@member_code int,
	@mode bit,
	@Result int output
AS
BEGIN
		if (select count (*) from Party_Members WHERE memberCode=@member_code)>0
		begin
		update Party_Members set mode=0 WHERE memberCode=@member_code
				 set @Result=1
		end
END






GO
/****** Object:  StoredProcedure [dbo].[RemoveVoter]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RemoveVoter]

	@id nvarchar(9),
	@Result int output
AS
BEGIN
	
	If(Select Count(*) From Voter_T Where id = @id and mode = 1)>0
	Begin
		Update Voter_T Set Voter_T.mode = 0 Where id = @id
		Set @Result =1
	End
	Else
	Begin
		Set @Result =0
	End
END






GO
/****** Object:  StoredProcedure [dbo].[removeVoterFromKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[removeVoterFromKalpi]
	@ID nvarchar(10),
	@kalpiCode nvarchar(10),
	@Result int output
AS
BEGIN
	if (select count (*) from Kalpi where kalpiCode=@kalpiCode and mode=1 and votersAmount<maxVoters)>0
		begin
			if(select count(*) from Voter_T where id = @ID and kalpiCode = @kalpiCode)>0
				BEGIN
					update Kalpi set Kalpi.votersAmount-=1 where kalpiCode=@kalpiCode
					update Voter_T set Voter_T.kalpiCode=0 where id=@ID
					set @Result=1
				END
		end
	else
		begin
			set @Result=0
		end
END



GO
/****** Object:  StoredProcedure [dbo].[RemoveWorker]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RemoveWorker]

	@id nvarchar(9),
	@Result int output
AS
BEGIN
	
	If(Select Count(*) From Voter_T Where id = @id )>0
	Begin
		Update Voter_T Set Voter_T.permission = 0 Where id = @id
		Set @Result =1
	End
	Else
	Begin
		Set @Result =0
	End
END






GO
/****** Object:  StoredProcedure [dbo].[RetuenKalpiesDetails]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <25/05/2015>
-- Description:	<Return kalpies details>
-- =============================================
CREATE PROCEDURE [dbo].[RetuenKalpiesDetails] 

@kalpiCode varchar(10)

AS
BEGIN
	select * from Kalpi where kalpiCode = @kalpiCode

END








GO
/****** Object:  StoredProcedure [dbo].[ReturnKalpiCode]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <12/05/2015>
-- Description:	<Return kalpies code of kalpies without manager>
-- =============================================
CREATE PROCEDURE [dbo].[ReturnKalpiCode] 

AS
BEGIN
	select distinct kalpiCode from Kalpi where managerID=0

END






GO
/****** Object:  StoredProcedure [dbo].[ReturnKalpiesCodes]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <25/05/2015>
-- Description:	<Return kalpies codes>
-- =============================================
CREATE PROCEDURE [dbo].[ReturnKalpiesCodes] 

@area nvarchar(50)

AS
BEGIN
	select distinct kalpiCode from Kalpi where area = @area

END








GO
/****** Object:  StoredProcedure [dbo].[ReturnKalpiesInArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Daria Sokolov>
-- Create date: <31/05/2015>
-- Description:	<Return kalpies in given area>
-- =============================================
CREATE PROCEDURE [dbo].[ReturnKalpiesInArea] 

@area varchar(50)

AS
BEGIN
	select * from Kalpi where area = @area

END


GO
/****** Object:  StoredProcedure [dbo].[SearchInvalidKalpies]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 25.5.15
-- Description:	Search invalid kalpies
-- =============================================
CREATE PROCEDURE [dbo].[SearchInvalidKalpies]
@city nvarchar (50)

AS
BEGIN
	SELECT   kalpiCode from Kalpi WHERE invalidAccess=1 and Kalpi.city=@city
	
end





GO
/****** Object:  StoredProcedure [dbo].[SearchKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		Aviva Avraham
-- Create date: 12/05/15	
-- Description:	Search kalpi
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpi]
	-- Add the parameters for the stored procedure here
	@KalpiCode nvarchar(50)
AS
BEGIN
	SELECT * FROM Kalpi WHERE KalpiCode=@KalpiCode
END








GO
/****** Object:  StoredProcedure [dbo].[SearchKalpiByArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Aviva Avraham>
-- Create date: <30/05/2015>
-- Description:	<area manager search kalpi manager in his area>
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpiByArea] 

@area nvarchar(50),
@KalpiCode varchar(10)


AS
BEGIN
   SELECT * from Kalpi WHERE area=@area and KalpiCode=@kalpiCode

	
END








GO
/****** Object:  StoredProcedure [dbo].[SearchKalpiByCity]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham	
-- Create date: 25/5/15
-- Description:	Search kalpi by city
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpiByCity]
@city nvarchar(50),
@Result int output
AS
BEGIN
	IF(SELECT count(*) from Kalpi WHERE city=@city and invalidAccess=1)>0
		BEGIN
			SET @Result=1
		END
	ELSE 
		BEGIN
			set @Result =0
	end
END






GO
/****** Object:  StoredProcedure [dbo].[SearchKalpiByManager]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		Daria Sokolov
-- Create date: 22/05/15	
-- Description:	Search kalpi by kalpi manager id
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpiByManager]	
	@id nchar(9)
AS
BEGIN
	SELECT * FROM Kalpi WHERE managerID=@id and mode=1
END








GO
/****** Object:  StoredProcedure [dbo].[SearchKalpiesByArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <12/05/2015>
-- Description:	<area manager add kalpi manager to his area>
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpiesByArea] 

@area nvarchar(50),
@Result int output

AS
BEGIN
	IF(SELECT COUNT(*) from Kalpi WHERE area=@area)>0
		BEGIN
			set @Result = 1
		END
	ELSE
	BEGIN
		set @Result = 0
	END
	
END






GO
/****** Object:  StoredProcedure [dbo].[SearchKalpiManager]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Daria Sokolov>
-- Create date: <Create Date,,>
-- Description:	<Description,,searches for kalpi manager accroding to id, area and permission>
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpiManager]
	@id nvarchar(9),
	@area nvarchar(50),
	@permission nvarchar(50)
AS
BEGIN
	Select * From Voter_T where id = @id And mode = 1 And area=@area And permission=@permission
END






GO
/****** Object:  StoredProcedure [dbo].[SearchKalpiManagerByKalpiCode]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		Aviva Avraham
-- Create date: Search kalpi manager by kalpi code
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchKalpiManagerByKalpiCode]
	-- Add the parameters for the stored procedure here
	@area nvarchar(50),
	@KalpiCode nvarchar(50)
AS
BEGIN
	SELECT * FROM Voter_T WHERE KalpiCode=@KalpiCode and permission=2 and area=@area
END







GO
/****** Object:  StoredProcedure [dbo].[SearchParty]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 02/04/2015
-- Description:	search party
-- =============================================
CREATE PROCEDURE [dbo].[SearchParty]
	-- Add the parameters for the stored procedure here
	@partyName nvarchar(50)
AS
BEGIN
	SELECT * FROM Parties WHERE partyName=@partyName
END






GO
/****** Object:  StoredProcedure [dbo].[SearchPartyMember]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	< search party member by one varible>
-- =============================================
CREATE PROCEDURE [dbo].[SearchPartyMember]
	@member_code int
AS
BEGIN
	SELECT * FROM Party_Members WHERE memberCode=@member_code
END






GO
/****** Object:  StoredProcedure [dbo].[SearchPartyMemberByName]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	< search party member by one varible>
-- =============================================
CREATE PROCEDURE [dbo].[SearchPartyMemberByName]
	@partyName nvarchar(50)
AS
BEGIN
	SELECT * FROM Party_Members WHERE partyName=@partyName

END






GO
/****** Object:  StoredProcedure [dbo].[SearchVoter]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchVoter] 
	@ID nvarchar(50)
AS
BEGIN
	SELECT * FROM Voter_T WHERE id=@ID and kalpiCode=0 and mode=1
END



GO
/****** Object:  StoredProcedure [dbo].[SearchVoterToAdd]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchVoterToAdd] 
	@ID nvarchar(50)
AS
BEGIN
	SELECT * FROM Voter_T WHERE id=@ID and kalpiCode=0 and mode=1
END




GO
/****** Object:  StoredProcedure [dbo].[SearchVoterToRemove]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchVoterToRemove]
	@ID nvarchar(50)
AS
BEGIN
	SELECT * FROM Voter_T WHERE id=@ID and mode=1
END



GO
/****** Object:  StoredProcedure [dbo].[SearchVoterToUpdate]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham	
-- Create date: 3.6.15
-- Description:	<Search Voter>
-- =============================================
CREATE PROCEDURE [dbo].[SearchVoterToUpdate] 
	@ID nvarchar(50)
AS
BEGIN
	SELECT * FROM Voter_T WHERE id=@ID and mode=1
END




GO
/****** Object:  StoredProcedure [dbo].[SearchWorker]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SearchWorker]
	@id nvarchar(9)
AS
BEGIN
	Select * From Voter_T where id = @id And mode = 1
END






GO
/****** Object:  StoredProcedure [dbo].[setVoterAccompByKalMan]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[setVoterAccompByKalMan]

@kalpi_code varchar(10),
@voter_id nvarchar(50),
@accomp_id nvarchar(50)
AS
	UPDATE Voter_T
	SET accomId = @accomp_id
	WHERE id = @voter_id AND kalpiCode = @kalpi_code



GO
/****** Object:  StoredProcedure [dbo].[ShowKalpiesByArea]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Rotem Abohtzira>
-- Create date: <25/05/2015>
-- Description:	<Return kalpies details by area>
-- =============================================
CREATE PROCEDURE [dbo].[ShowKalpiesByArea] 

@area nvarchar(50)

AS
BEGIN
	select * from Kalpi where area = @area

END








GO
/****** Object:  StoredProcedure [dbo].[ShowMandat]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ShowMandat]
AS
BEGIN
select Name, count(*) Total
from 
(
  select partyName as Name
  from Vote
) d
group by Name
order by Total desc;
END


GO
/****** Object:  StoredProcedure [dbo].[unblockCitizen]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <19/04/2015>
-- Description:	<unblocked Citizen>
-- =============================================
CREATE PROCEDURE [dbo].[unblockCitizen]
	@id nvarchar(50),
	@isBlocked bit
AS
BEGIN
	If(SELECT COUNT(*) from Voter_T where id=@id)>0
	BEGIN
		Update dbo.Voter_T
		SET isBlocked=0
		WHERE id=@id
	END

END



GO
/****** Object:  StoredProcedure [dbo].[unblockKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Alexey Yakimishin	>
-- Create date: <11/05/2015>
-- Description:	<unblock kalpi>
-- =============================================
CREATE PROCEDURE [dbo].[unblockKalpi]
	@kalpiCode nvarchar(50),
	@openKalpi bit
AS
BEGIN
	If(SELECT COUNT(*) from Kalpi where kalpiCode=@kalpiCode)>0
	BEGIN
		Update dbo.Kalpi
		SET openKalpi=1
		where kalpiCode=@kalpiCode
		
	END

END





GO
/****** Object:  StoredProcedure [dbo].[updateAreaManager]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateAreaManager] 
	@idVoter nvarchar(9),
	@name nvarchar(50),
	@lastname  varchar(50),
	@username  nvarchar(50),
	@password  nvarchar(50),
	@birthDay date,
	@address nvarchar(50),
	@area nvarchar(50),
	@city nvarchar(50),
	@tell nvarchar(50),
	@Result int output

AS
BEGIN
	IF(Select Count(*) From Voter_T Where id = @idVoter And permission = 3)=0
	BEGIN
		SET @Result = 0
	END
	ELSE
	BEGIN
		UPDATE Voter_T 
			SET id = @idVoter,fname = @name,
			lname =  @lastname ,username = @username,password = @password,
			birthDay =  @birthDay,address = @address,
			area = @area,city = @city,tell = @tell
			WHERE id = @idVoter
			SET @Result = 1
	END
END



GO
/****** Object:  StoredProcedure [dbo].[UpdateInvalidKalpiChoose]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham	
-- Create date: 25/5/15
-- Description:	Update the an invalid kalpi choose of the voters
-- =============================================
CREATE PROCEDURE [dbo].[UpdateInvalidKalpiChoose]

@kalpiCode varchar(10),
@id nvarchar(50),
@Result int output
AS
BEGIN
	IF(SELECT count(*) from Voter_T WHERE id=@id)>0
		BEGIN
			update Voter_T set Voter_T.kalpiCode=@kalpiCode WHERE Voter_T.id=@id
			SET @Result=1
		END
	ELSE 
		BEGIN
			set @Result =0
	end
END





GO
/****** Object:  StoredProcedure [dbo].[UpdateKalpiDetails]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 12/05/15
-- Description:	updates kalpi details
-- =============================================
CREATE PROCEDURE [dbo].[UpdateKalpiDetails]
	-- Add the parameters for the stored procedure here
	@KalpiCode nvarchar(10),
	@area nvarchar(50),
	@address nvarchar(50),
	@city nvarchar(50),
	@kalpiName nvarchar(50),
	@Result int output

AS
BEGIN
	IF(SELECT COUNT(*) from Kalpi WHERE @KalpiCode=KalpiCode)>0
		BEGIN
			update Kalpi set Kalpi.kalpiCode=@KalpiCode,Kalpi.city=@city,Kalpi.area=@area,Kalpi.address=@address, kalpiName=@kalpiName WHERE Kalpi.kalpiCode= @KalpiCode 
			SET @Result=1
		END
	ELSE 
		BEGIN
			set @Result =0
	end
END







GO
/****** Object:  StoredProcedure [dbo].[UpdateKalpiManagerDetails]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Author:		Aviva Avraham
-- Create date: 15/12/15
-- Description:	Update kalpi manager details
-- =============================================
CREATE PROCEDURE [dbo].[UpdateKalpiManagerDetails]
	-- Add the parameters for the stored procedure here
@kalpiCode nvarchar(10),
@fname nvarchar(50),
@lname nvarchar(50),

@address nvarchar(50),
@area nvarchar(50),
@city nvarchar(50),
@tell nvarchar(50),

@Result int output
AS
BEGIN
		IF(SELECT COUNT(*) from Voter_T WHERE kalpiCode=@kalpiCode)>0
			BEGIN
				update Voter_T set Voter_T.fname=@fname,Voter_T.lname=@lname,Voter_T.address=@address,Voter_T.area=@area,Voter_T.city=@city,Voter_T.tell=@tell
				WHERE kalpiCode=@kalpiCode
				SET @Result=1	
			END
		ELSE 
			BEGIN
				set @Result =0
		end
END





GO
/****** Object:  StoredProcedure [dbo].[UpdateLastDate]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateLastDate]

	@id nvarchar(9),
	@lastdate date, 
	@Result int output
AS
BEGIN
	
	If(Select Count(*) From Voter_T Where id = @id and mode = 1)>0
	Begin
		Update Voter_T Set Voter_T.lastConnection = @lastdate Where id = @id
		Set @Result =1
	End
	Else
	Begin
		Set @Result =0
	End
END






GO
/****** Object:  StoredProcedure [dbo].[UpdateMemberParty]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Group 12 (Shmuel)
-- Create date: <Create Date,,>
-- Description:	Update to Member Party
-- =============================================
CREATE PROCEDURE [dbo].[UpdateMemberParty]
	@member_code int,
	@party_name nvarchar(20),
	@f_name nvarchar(20),
	@l_name nvarchar(20),
	@birth_date nvarchar(20) ,
	@list_place int ,
	@education nvarchar(max),
	@experience nvarchar(max),
	@Result int output
as
BEGIN
	if(select Count(*) from Party_Members where memberCode=@member_code)=1 
	Begin
		IF(select Count(*) from Parties where partyName=@party_name)=1
		begin
			IF(SELECT COUNT(*) FROM Party_Members WHERE partyName = @party_name and listPlace = @list_place)=0
			begin
				IF(select memberSize from Parties where partyName = @party_name)>=@list_place
					update Party_Members set memberCode=@member_code, partyName=@party_name, fName=@f_name, lName=@l_name, dob= @birth_date, listPlace=@list_place, education=@education, experience=@experience WHERE memberCode= @member_code
					Set @Result = 1
			end
			IF(SELECT COUNT(*) FROM Party_Members WHERE partyName = @party_name and listPlace = @list_place and memberCode=@member_code)=1
			begin
				update Party_Members set memberCode=@member_code, partyName=@party_name, fName=@f_name, lName=@l_name, dob= @birth_date, listPlace=@list_place, education=@education, experience=@experience WHERE memberCode= @member_code
				Set @Result = 1
			end
			else
				Begin
					set @Result = 0
				end
		end
	end 
	else
	Begin
		set @Result = 0
	end
END






GO
/****** Object:  StoredProcedure [dbo].[UpdatePartyDetails]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Author: Aviva Avraham
-- Create date: Date: 1.04.15
-- description:	update a party details
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePartyDetails]
	-- Add the parameters for the stored procedure here
	@partyName nvarchar(20),
	@member_size int,
	@platform nvarchar(50),
	@Result int output

AS
BEGIN
	IF(SELECT COUNT(*) from Parties WHERE partyName=@partyName and mode=1)>0
		BEGIN
			update Parties set Parties.partyName=@partyName,Parties.memberSize=@member_size,Parties.platform=@platform WHERE Parties.partyName= @partyName 
			SET @Result=1
		END
	ELSE 
		BEGIN
			set @Result =0
	end
END






GO
/****** Object:  StoredProcedure [dbo].[UpdateVoterDetails]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Aviva Avraham
-- Create date: 19/04/15
-- Description:	Update voter details
-- =============================================
CREATE PROCEDURE [dbo].[UpdateVoterDetails]
@id nvarchar(50),
@fname nvarchar(50),
@lname nvarchar(50),
@address nvarchar(50),
@area nvarchar(50),
@city nvarchar(50),
@tell nvarchar(50),
@Result int output
AS
BEGIN
	IF(SELECT COUNT(*) from Voter_T WHERE id=@id)>0
		BEGIN
			update Voter_T set Voter_T.fname=@fname,Voter_T.lname=@lname,
			Voter_T.address=@address,Voter_T.area=@area,Voter_T.city=@city,Voter_T.tell=@tell
			 WHERE Voter_T.id= @id 
			SET @Result=1
		END
	ELSE 
		BEGIN
			set @Result =0
	end
END





GO
/****** Object:  StoredProcedure [dbo].[updateVoterKalpi]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateVoterKalpi]
	@kalpiCode varchar(10),
	@id nvarchar(10),
	@prev_kalpi varchar(10),
	@res int output
	
AS
BEGIN
	if (select count (*) from Kalpi where kalpiCode=@kalpiCode and mode=1 and votersAmount<maxVoters)>0
		begin
			update Kalpi set Kalpi.votersAmount-=1 WHERE kalpiCode=@prev_kalpi
			update Kalpi set Kalpi.votersAmount+=1 where kalpiCode=@kalpiCode
			update Voter_T set Voter_T.kalpiCode=@kalpiCode where id=@id
			set @res=1
		end
	else
		begin
			set @res=0
		end
END




GO
/****** Object:  StoredProcedure [dbo].[updateWorker]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[updateWorker] 
	@idVoter nvarchar(9),
	@kalpiCode varchar(10),
	@name nvarchar(50),
	@lastname  varchar(50),
	@username  nvarchar(50),
	@password  nvarchar(50),
	@permission  nvarchar(50),
	@birthDay date,
	@address nvarchar(50),
	@area nvarchar(50),
	@city nvarchar(50),
	@tell nvarchar(50),
	@Result int output

AS
BEGIN
	IF(Select Count(*) From Voter_T Where id = @idVoter)=0
	BEGIN
		SET @Result = 0
	END
	ELSE
	BEGIN
		UPDATE Voter_T 
			SET id = @idVoter,kalpiCode = @kalpiCode,fname = @name,
			lname =  @lastname ,username = @username,password = @password,
			permission =  @permission,birthDay =  @birthDay,address = @address,
			area = @area,city = @city,tell = @tell
			WHERE id = @idVoter
			SET @Result = 1
	END
END






GO
/****** Object:  StoredProcedure [dbo].[VoteProc]    Script Date: 03/06/2015 21:39:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VoteProc]
@prime_code int = NULL,
@voter_id nvarchar(50) = NULL,
@party_name nvarchar(50) = NULL,
@kalpi_code nvarchar(10) =NULL,
@white_note bit = 0
AS
	UPDATE Voter_T
	SET isVoted = 1
	WHERE id = @voter_id
	DECLARE @EmpIDVar INT
	SElect @EmpIDVar =  count(1) from Vote
	INSERT INTO Vote (kalpiCode , partyName , prime_code , vote_code ,white_note)
	VALUES(@kalpi_code , @party_name , @prime_code ,@EmpIDVar+1 , @white_note)




GO
