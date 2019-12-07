
-----Basic MVC CRUD BY ADO>NET--


Create procedure AddNewSupplierDetails 
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

--
Create Procedure GetSupplier
as  
begin  
   select *from Supplier  
End 
--

Create procedure UpdateSupplierDetails  
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

--
Create Procedure DeleteSupplierByID
(
	@Id int
)
as 
Begin

DELETE FROM Supplier WHERE Id=@Id
END
