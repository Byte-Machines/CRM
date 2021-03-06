USE [DB_CRM]
GO
/****** Object:  Table [dbo].[tlb_FollowUp]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_FollowUp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Followup_ID] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Mobile_No] [nvarchar](max) NOT NULL,
	[Date_Of_Birth] [nvarchar](max) NOT NULL,
	[Email_ID] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Occupation] [nvarchar](max) NOT NULL,
	[Product_Details] [nvarchar](max) NOT NULL,
	[Followup_Type] [nvarchar](max) NOT NULL,
	[F_Date] [nvarchar](max) NULL,
	[F_Message] [nvarchar](max) NULL,
	[Folloup_Update] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [nvarchar](max) NOT NULL,
 CONSTRAINT [pk_Follow_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Employee]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [nvarchar](max) NOT NULL,
	[EmployeeName] [nvarchar](max) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[EmpAddress] [nvarchar](max) NOT NULL,
	[MobileNo] [nvarchar](max) NOT NULL,
	[PhoneNo] [nvarchar](max) NOT NULL,
	[Designation] [nvarchar](max) NOT NULL,
	[DateOfJoining] [datetime] NOT NULL,
	[NoOfYears] [nvarchar](max) NOT NULL,
	[Years] [nvarchar](max) NOT NULL,
	[NoOfMonths] [nvarchar](max) NOT NULL,
	[Months] [nvarchar](max) NOT NULL,
	[Salary] [money] NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [pk_EmployeeID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Domain]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Domain](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Domain_Name] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
	[PAN_Card] [nvarchar](max) NULL,
	[Adhar_Card] [nvarchar](max) NULL,
	[Passport] [nvarchar](max) NULL,
	[Address_Proof] [nvarchar](max) NULL,
	[Seven_Twevel] [nvarchar](max) NULL,
	[Form_16] [nvarchar](max) NULL,
	[Dealer_Lisence] [nvarchar](max) NULL,
	[Other_ID_Proof] [nvarchar](max) NULL,
	[No_Documents] [nvarchar](max) NULL,
	[Cmp_ID_Proof] [nvarchar](max) NULL,
 CONSTRAINT [pk_DID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Main_Login]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Main_Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login_ID] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Change_Password] [varchar](max) NOT NULL,
	[Sataus] [varchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [P_login_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Admin_Login]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin_Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login_ID] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Change_Password] [varchar](max) NOT NULL,
	[Sataus] [varchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [P_A_login_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ADD_Default_Thank_you]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADD_Default_Thank_you](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Text_Message] [varchar](max) NOT NULL,
	[Sataus] [varchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [P_thank_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ADD_Default_Followup]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADD_Default_Followup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Text_Message] [varchar](max) NOT NULL,
	[Sataus] [varchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [P_follow_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ADD_Default_Bithday]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADD_Default_Bithday](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Text_Message] [varchar](max) NOT NULL,
	[Sataus] [varchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [P_birth_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Add_Dealer]    Script Date: 07/31/2014 14:40:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Add_Dealer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Dealer_ID] [varchar](max) NOT NULL,
	[Dealer_Name] [varchar](max) NOT NULL,
	[Phone_No] [varchar](max) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Dealer_for_Product] [varchar](max) NOT NULL,
	[Sataus] [varchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [P_dealer_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_Add_Product]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Add_Product]

	@Flag int=null,
	@Domain_Name nvarchar(MAX),
	@PAN_Card nvarchar(MAX),
	@Adhar_Card nvarchar(MAX) ,
	@Passport nvarchar(MAX),
	@Address_Proof nvarchar(MAX),
	@Seven_Twevel nvarchar(MAX),
	@Form_16 nvarchar(MAX),
	@Dealer_Lisence nvarchar(MAX),
	@Other_ID_Proof nvarchar(MAX),
	@No_Documents nvarchar(MAX),
	@Cmp_ID_Proof nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if(@Flag =1)
	begin
	Insert into tb_Domain(Domain_Name,PAN_Card ,Adhar_Card ,Passport ,Address_Proof ,Seven_Twevel ,Form_16 ,Dealer_Lisence,Other_ID_Proof,No_Documents ,Cmp_ID_Proof ,S_Status ,C_Date ) values (@Domain_Name ,@PAN_Card ,@Adhar_Card ,@Passport ,@Address_Proof ,@Seven_Twevel ,@Form_16 ,@Dealer_Lisence ,@Other_ID_Proof ,@No_Documents ,@Cmp_ID_Proof ,@S_Status ,@C_Date )
	end
	
END
GO
/****** Object:  Table [dbo].[tlb_Products]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Domain_ID] [int] NOT NULL,
	[Product_Name] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [pk_Domain_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_Followup2]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Followup2]
	-- Add the parameters for the stored procedure here
	@Flag int=null,
	@Followup_ID nvarchar(MAX) ,
@Name nvarchar(MAX) ,
@Mobile_No nvarchar(MAX),
@Date_Of_Birth nvarchar(MAX),
@Email_ID nvarchar(MAX),
@Address nvarchar(MAX) ,
@Occupation nvarchar(MAX) ,
@Product_Details nvarchar(MAX) ,
@Followup_Type nvarchar(MAX),
@Folloup_Update nvarchar(MAX) ,
@S_Status nvarchar(MAX) ,
@C_Date nvarchar(MAX) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 
  if(@Flag=1)
  begin
  insert into tlb_FollowUp(Followup_ID,Name,Mobile_No,Date_Of_Birth,Email_ID,Address,Occupation,Product_Details ,Followup_Type,Folloup_Update ,S_Status,C_Date)values(@Followup_ID,@Name ,@Mobile_No,@Date_Of_Birth ,@Email_ID  ,@Address,@Occupation ,@Product_Details ,@Followup_Type, @Folloup_Update ,@S_Status,@C_Date  )
  end
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Followup]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Followup]
	-- Add the parameters for the stored procedure here
	@Flag int=null,
	@Followup_ID nvarchar(MAX) ,
@Name nvarchar(MAX) ,
@Mobile_No nvarchar(MAX),
@Date_Of_Birth nvarchar(MAX),
@Email_ID nvarchar(MAX),
@Address nvarchar(MAX) ,
@Occupation nvarchar(MAX) ,
@Product_Details nvarchar(MAX) ,
@Followup_Type nvarchar(MAX),
@F_Date nvarchar(MAX),
@F_Message nvarchar(MAX) ,
@Folloup_Update nvarchar(MAX) ,
@S_Status nvarchar(MAX) ,
@C_Date nvarchar(MAX) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  if(@Flag=1)
  begin
  insert into tlb_FollowUp(Followup_ID,Name,Mobile_No,Date_Of_Birth,Email_ID,Address,Occupation,Product_Details ,Followup_Type,F_Date,F_Message,Folloup_Update ,S_Status,C_Date)values(@Followup_ID,@Name ,@Mobile_No,@Date_Of_Birth ,@Email_ID  ,@Address,@Occupation ,@Product_Details ,@Followup_Type ,@F_Date,@F_Message , @Folloup_Update ,@S_Status,@C_Date  )
  end
  if(@Flag=2)
  begin
  insert into tlb_FollowUp(Followup_ID,Name,Mobile_No,Date_Of_Birth,Email_ID,Address,Occupation,Product_Details ,Followup_Type,Folloup_Update ,S_Status,C_Date)values(@Followup_ID,@Name ,@Mobile_No,@Date_Of_Birth ,@Email_ID  ,@Address,@Occupation ,@Product_Details ,@Followup_Type, @Folloup_Update ,@S_Status,@C_Date  )
  end
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Employee]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Employee]
	@Flag int=null,
	@EmployeeID nvarchar (MAX),
	@EmployeeName nvarchar(MAX),
	@DateOfBirth datetime,
	@EmpAddress nvarchar(MAX),
	@MobileNo nvarchar(MAX),
	@PhoneNo nvarchar(MAX),
	@Designation nvarchar(MAX),
	@DateOfJoining nvarchar(MAX),
	@NoOfYears nvarchar(MAX),
	@Years nvarchar(MAX),
	@NoOfMonths nvarchar(MAX),
	@Months nvarchar(MAX),
	@Salary nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if(@Flag = 1)
		begin
		 Insert Into tbl_Employee(EmployeeID, EmployeeName, DateOfBirth, EmpAddress, MobileNo, PhoneNo, Designation, DateOfJoining, NoOfYears, Years, NoOfMonths, Months, Salary, S_Status, C_Date) Values (@EmployeeID, @EmployeeName, @DateOfBirth, @EmpAddress, @MobileNo, @PhoneNo, @Designation, @DateOfJoining, @NoOfYears, @Years, @NoOfMonths, @Months, @Salary, @S_Status, @C_Date)
		end
END
GO
/****** Object:  Table [dbo].[tlb_Brand]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_Brand](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Brand_Name] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [pk_Product_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADDProducts]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ADDProducts]
	-- Add the parameters for the stored procedure here
	@Flag int=null,
	
	@Domain_ID int=null,
	@Product_Name nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
if(@Flag =1)
	begin
	insert into tlb_Products (Domain_ID,Product_Name,S_Status,C_Date) values (@Domain_ID ,@Product_Name ,@S_Status ,@C_Date )
	end
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ADDBrand]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ADDBrand]
	-- Add the parameters for the stored procedure here
	@Flag int=null,
	@Product_ID nvarchar(MAX),
	@Brand_Name nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
if(@Flag =1)
begin
insert into  tlb_Brand(Product_ID,Brand_Name,S_Status,C_Date) values(@Product_ID ,@Brand_Name ,@S_Status ,@C_Date )
end
   
END
GO
/****** Object:  Table [dbo].[tlb_P_Category]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_P_Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Brand_ID] [int] NOT NULL,
	[Product_Category] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [pk_Brand_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tlb_Model]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_Model](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[P_Category] [int] NOT NULL,
	[Model_No] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [pk_P_Category_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADDP_Category]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ADDP_Category]
	-- Add the parameters for the stored procedure here
	@Flag int=null,
	@Brand_ID nvarchar(MAX),
	@Product_Category nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date DateTime 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  if(@Flag=1)
  begin 
  insert into tlb_P_Category (Brand_ID,Product_Category,S_Status,C_Date) values (@Brand_ID ,@Product_Category ,@S_Status ,@C_Date )
  end
END
GO
/****** Object:  Table [dbo].[tlb_Color]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tlb_Color](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Model_No_ID] [int] NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NOT NULL,
	[C_Date] [datetime] NOT NULL,
 CONSTRAINT [pk_ModelNo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADDModel]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ADDModel]
	@Flag int=null,
	@P_Category nvarchar(MAX),
	@Model_No nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date DateTime 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  if(@Flag=1)
  begin 
  insert into tlb_Model (P_Category,Model_No,S_Status,C_Date) values (@P_Category ,@Model_No ,@S_Status ,@C_Date )
  end
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ADDColor]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ADDColor]
	@Flag int=null,
	@Model_No_ID nvarchar(MAX),
	@Color nvarchar(MAX),
	@S_Status nvarchar(MAX),
	@C_Date DateTime 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   if(@Flag=1)
  begin 
  insert into tlb_Color (Model_No_ID,Color,S_Status,C_Date) values (@Model_No_ID  ,@Color ,@S_Status ,@C_Date )
  end
END
GO
/****** Object:  Table [dbo].[Pre_Products]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Domain_ID] [int] NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Brand_ID] [int] NOT NULL,
	[P_Category] [int] NOT NULL,
	[Model_No_ID] [int] NOT NULL,
	[Color_ID] [int] NOT NULL,
	[Narration] [nvarchar](max) NOT NULL,
	[Price] [money] NOT NULL,
	[S_Status] [nvarchar](max) NULL,
	[C_Date] [datetime] NULL,
 CONSTRAINT [pk_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pre_Procurement]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pre_Procurement](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Domain_ID] [int] NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Brand_ID] [int] NOT NULL,
	[P_Category] [int] NOT NULL,
	[Model_No_ID] [int] NOT NULL,
	[Color_ID] [int] NOT NULL,
	[Procurment_Price] [money] NOT NULL,
	[Reg_Document] [nvarchar](max) NOT NULL,
	[Have_Insurance] [nvarchar](max) NOT NULL,
	[re_ferb_cost] [nvarchar](max) NULL,
	[Follow_up] [nvarchar](max) NOT NULL,
	[Narration] [nvarchar](max) NOT NULL,
	[S_Status] [nvarchar](max) NULL,
	[C_Date] [datetime] NULL,
 CONSTRAINT [pk_Pro_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_Save]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Save]
	@Flag int=null,
	@Domain_ID int=null,
 @Product_ID int=null,
 @Brand_ID int=null,
 @P_Category int=null,
 @Model_No_ID int=null,
 @Color_ID int=null,
 @Narration nvarchar(MAX),
 @Price money ,
 @S_Status nvarchar(MAX),
	@C_Date DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
if(@Flag =1)
   begin
   insert into Pre_Products(Domain_ID,Product_ID,Brand_ID,P_Category,Model_No_ID,Color_ID,Narration,Price,S_Status,C_Date) values(@Domain_ID ,@Product_ID ,@Brand_ID ,@P_Category ,@Model_No_ID ,@Color_ID ,@Narration ,@Price,@S_Status,@C_Date  )
   end
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Pre_Procurement_Save]    Script Date: 07/31/2014 14:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Pre_Procurement_Save]
	@Flag int=null,
	@Domain_ID int=null,
 @Product_ID int=null,
 @Brand_ID int=null,
 @P_Category int=null,
 @Model_No_ID int=null,
 @Color_ID int=null,
 
 @Procurment_Price money ,
 @Reg_Document  nvarchar(MAX),
 @Have_Insurance  nvarchar(MAX),
 @re_ferb_cost nvarchar(MAX),
 @Follow_up nvarchar(MAX),
 @Narration nvarchar(MAX),
 
 @S_Status nvarchar(MAX),
	@C_Date DateTime
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
if(@Flag =1)
   begin
   insert into Pre_Procurement(Domain_ID,Product_ID,Brand_ID,P_Category,Model_No_ID,Color_ID,Procurment_Price,Reg_Document,Have_Insurance,re_ferb_cost,Follow_up,Narration,S_Status,C_Date) values(@Domain_ID ,@Product_ID ,@Brand_ID ,@P_Category ,@Model_No_ID ,@Color_ID ,@Procurment_Price,@Reg_Document ,@Have_Insurance ,@re_ferb_cost ,@Follow_up ,@Narration  ,@S_Status,@C_Date  )
   end
END
GO
/****** Object:  ForeignKey [fk_PID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[tlb_Products]  WITH CHECK ADD  CONSTRAINT [fk_PID] FOREIGN KEY([Domain_ID])
REFERENCES [dbo].[tb_Domain] ([ID])
GO
ALTER TABLE [dbo].[tlb_Products] CHECK CONSTRAINT [fk_PID]
GO
/****** Object:  ForeignKey [fk_BID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[tlb_Brand]  WITH CHECK ADD  CONSTRAINT [fk_BID] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[tlb_Products] ([ID])
GO
ALTER TABLE [dbo].[tlb_Brand] CHECK CONSTRAINT [fk_BID]
GO
/****** Object:  ForeignKey [fk_PCID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[tlb_P_Category]  WITH CHECK ADD  CONSTRAINT [fk_PCID] FOREIGN KEY([Brand_ID])
REFERENCES [dbo].[tlb_Brand] ([ID])
GO
ALTER TABLE [dbo].[tlb_P_Category] CHECK CONSTRAINT [fk_PCID]
GO
/****** Object:  ForeignKey [fk_MID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[tlb_Model]  WITH CHECK ADD  CONSTRAINT [fk_MID] FOREIGN KEY([P_Category])
REFERENCES [dbo].[tlb_P_Category] ([ID])
GO
ALTER TABLE [dbo].[tlb_Model] CHECK CONSTRAINT [fk_MID]
GO
/****** Object:  ForeignKey [fk_CID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[tlb_Color]  WITH CHECK ADD  CONSTRAINT [fk_CID] FOREIGN KEY([Model_No_ID])
REFERENCES [dbo].[tlb_Model] ([ID])
GO
ALTER TABLE [dbo].[tlb_Color] CHECK CONSTRAINT [fk_CID]
GO
/****** Object:  ForeignKey [fk_BrandID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Products]  WITH CHECK ADD  CONSTRAINT [fk_BrandID] FOREIGN KEY([Brand_ID])
REFERENCES [dbo].[tlb_Brand] ([ID])
GO
ALTER TABLE [dbo].[Pre_Products] CHECK CONSTRAINT [fk_BrandID]
GO
/****** Object:  ForeignKey [fk_ColorID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Products]  WITH CHECK ADD  CONSTRAINT [fk_ColorID] FOREIGN KEY([Color_ID])
REFERENCES [dbo].[tlb_Color] ([ID])
GO
ALTER TABLE [dbo].[Pre_Products] CHECK CONSTRAINT [fk_ColorID]
GO
/****** Object:  ForeignKey [fk_DomainID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Products]  WITH CHECK ADD  CONSTRAINT [fk_DomainID] FOREIGN KEY([Domain_ID])
REFERENCES [dbo].[tb_Domain] ([ID])
GO
ALTER TABLE [dbo].[Pre_Products] CHECK CONSTRAINT [fk_DomainID]
GO
/****** Object:  ForeignKey [fk_modelID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Products]  WITH CHECK ADD  CONSTRAINT [fk_modelID] FOREIGN KEY([Model_No_ID])
REFERENCES [dbo].[tlb_Model] ([ID])
GO
ALTER TABLE [dbo].[Pre_Products] CHECK CONSTRAINT [fk_modelID]
GO
/****** Object:  ForeignKey [fk_PCategoryID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Products]  WITH CHECK ADD  CONSTRAINT [fk_PCategoryID] FOREIGN KEY([P_Category])
REFERENCES [dbo].[tlb_P_Category] ([ID])
GO
ALTER TABLE [dbo].[Pre_Products] CHECK CONSTRAINT [fk_PCategoryID]
GO
/****** Object:  ForeignKey [fk_ProductID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Products]  WITH CHECK ADD  CONSTRAINT [fk_ProductID] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[tlb_Products] ([ID])
GO
ALTER TABLE [dbo].[Pre_Products] CHECK CONSTRAINT [fk_ProductID]
GO
/****** Object:  ForeignKey [fk_ProBrandID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Procurement]  WITH CHECK ADD  CONSTRAINT [fk_ProBrandID] FOREIGN KEY([Brand_ID])
REFERENCES [dbo].[tlb_Brand] ([ID])
GO
ALTER TABLE [dbo].[Pre_Procurement] CHECK CONSTRAINT [fk_ProBrandID]
GO
/****** Object:  ForeignKey [fk_ProColorID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Procurement]  WITH CHECK ADD  CONSTRAINT [fk_ProColorID] FOREIGN KEY([Color_ID])
REFERENCES [dbo].[tlb_Color] ([ID])
GO
ALTER TABLE [dbo].[Pre_Procurement] CHECK CONSTRAINT [fk_ProColorID]
GO
/****** Object:  ForeignKey [fk_ProDomainID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Procurement]  WITH CHECK ADD  CONSTRAINT [fk_ProDomainID] FOREIGN KEY([Domain_ID])
REFERENCES [dbo].[tb_Domain] ([ID])
GO
ALTER TABLE [dbo].[Pre_Procurement] CHECK CONSTRAINT [fk_ProDomainID]
GO
/****** Object:  ForeignKey [fk_PromodelID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Procurement]  WITH CHECK ADD  CONSTRAINT [fk_PromodelID] FOREIGN KEY([Model_No_ID])
REFERENCES [dbo].[tlb_Model] ([ID])
GO
ALTER TABLE [dbo].[Pre_Procurement] CHECK CONSTRAINT [fk_PromodelID]
GO
/****** Object:  ForeignKey [fk_ProPCategoryID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Procurement]  WITH CHECK ADD  CONSTRAINT [fk_ProPCategoryID] FOREIGN KEY([P_Category])
REFERENCES [dbo].[tlb_P_Category] ([ID])
GO
ALTER TABLE [dbo].[Pre_Procurement] CHECK CONSTRAINT [fk_ProPCategoryID]
GO
/****** Object:  ForeignKey [fk_ProProductID]    Script Date: 07/31/2014 14:40:17 ******/
ALTER TABLE [dbo].[Pre_Procurement]  WITH CHECK ADD  CONSTRAINT [fk_ProProductID] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[tlb_Products] ([ID])
GO
ALTER TABLE [dbo].[Pre_Procurement] CHECK CONSTRAINT [fk_ProProductID]
GO
