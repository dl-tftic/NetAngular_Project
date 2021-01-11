 --  Address
 DECLARE @idAddressAccount int;
 EXEC @idAddressAccount = AddAddress @Street='Faubourg Leon Hurez', @Number ='14', @CityId = 1936;
 SELECT @idAddressAccount;

 DECLARE @idAddressProject int;
 EXEC @idAddressProject = AddAddress @Street='Rue du moulin', @Number ='4', @CityId = 1874;
 SELECT @idAddressProject;

 DECLARE @idAddressSupplier int;
 EXEC @idAddressSupplier = AddAddress @Street='Rue des Viaducs', @Number ='289', @CityId = 1873;
 SELECT @idAddressSupplier;

 -- Account
 DECLARE @idAccount int;
 EXEC @idAccount = AddAccount  
						@Login = 'dave',
						@LastName = 'Lissens', 
						@FirstName = 'David', 
						@Password = 'abc123', 
						@RoleID = 1, 
						@AddressId = @idAddressAccount;
 SELECT @idAccount;

 -- Category
 DECLARE @idCategoryProject int;
 EXEC @idCategoryProject =  AddCategory @Name='Cat 1', @CreateBy = @idAccount;
 SELECT @idCategoryProject;

 DECLARE @idCategoryProduct int;
 EXEC @idCategoryProduct =  AddCategory @Name='Cat product 1', @CreateBy = @idAccount;
 SELECT @idCategoryProduct;

 -- ContactInfo
 DECLARE @accountContactInfoId int;
 exec @accountContactInfoId = [AddContactInfo] @ContactType='phone', @ContactInformation='02/270 93 04'
 DECLARE @supplierContactInfoId int;
 exec @supplierContactInfoId = [AddContactInfo] @ContactType='email', @ContactInformation='contact@supplier.com'

 -- Product
 DECLARE @productId int;
 exec @productId = [AddProduct] @Manufacturer = 'Buderus',
								@Name = 'Chaudière à condensation',
								@CreateBy = @idAccount;

 -- Project 
 DECLARE @projectId int;
 exec @projectId = [AddProject] @Name='Maison Hafid',
								@AddressId = @idAddressProject,
								@CreateBy = @idAccount

 -- Supplier
 DECLARE @supplierId int;
 exec @supplierId = [AddSupplier] @Name='Facq Sanicenter Mons',
 								@AddressId = @idAddressSupplier,
 								@CreateBy = @idAccount;

 -- ******* Link

 -- AccountContactInfo
 DECLARE @accContactInfoId int;
 exec @accContactInfoId =  [AddAccountContactInfo] @AccountId = @idAccount,
													  @ContactInfoId = @accountContactInfoId;

 -- SupplierContactInfo
 DECLARE @suppContactInfoId int;
 exec @suppContactInfoId =  [AddSupplierContactInfo] @SupplierId = @supplierId,
 													   @ContactInfoId = @supplierContactInfoId;
 -- ProjectCategory
 DECLARE @projectCategoryId int;
 exec @projectCategoryId = [AddProjectCategory] @ProjectId = @projectId,
												@CategoryId = @idCategoryProject;

 -- ProductCategory
 DECLARE @productCategoryId int;
 exec @productCategoryId = [AddProductCategory] @ProductId = @productId,
												@CategoryId = @idCategoryProduct;