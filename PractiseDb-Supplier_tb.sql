USE [PractiseDb]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 12/7/2019 8:43:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](50) NULL,
	[ContactNo] [int] NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([Id], [SupplierName], [ContactNo], [Email], [Address]) VALUES (1, N'Ayaan', 1716454374, N'a@gmail.com', N'Dhaka')
INSERT [dbo].[Supplier] ([Id], [SupplierName], [ContactNo], [Email], [Address]) VALUES (3, N'Tofael', 1716454374, N't@gmail.com', N'DHaka')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
/****** Object:  StoredProcedure [dbo].[AddNewSupplierDetails]    Script Date: 12/7/2019 8:43:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[AddNewSupplierDetails] 
(  
   @SupplierName varchar (50),  
   @ContactNo int,  
   @Email varchar (50),
   @Address varchar (max)  
)  
as  
begin  
   Insert into Supplier values(@SupplierName,@ContactNo,@Email,@Address)  
End 
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplierByID]    Script Date: 12/7/2019 8:43:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteSupplierByID]
(
	@Id int
)
as 
Begin

DELETE FROM Supplier WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetSupplier]    Script Date: 12/7/2019 8:43:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetSupplier]
as  
begin  
   select *from Supplier  
End 
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplierDetails]    Script Date: 12/7/2019 8:43:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[UpdateSupplierDetails]  
(  @Id int,
   @SupplierName varchar (50),  
   @ContactNo int,  
   @Email varchar (50),
   @Address varchar (max)   
)  
as  
begin  
   Update Supplier
      
   set SupplierName = @SupplierName,  
   ContactNo = @ContactNo,
   Email = @Email,
   Address = @Address  

   where Id=@Id  
End 
GO
