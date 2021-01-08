-- select * from City
-- select * from address
select * from Account


 exec AddAddress @Street='Faubourg Leon Hurez', 
 					@Number ='14', @CityId = 1936


exec AddAccount @Login = 'dave',
				@LastName = 'Lissens', 
				@FirstName = 'David', 
				@Password = 'abc123', 
				@RoleID = 1, 
				@AddressId = 1;

	
select * from Account
DECLARE @salt varchar(32), @passWithSalt binary(32)
SET @passWithSalt = HASHBYTES('SHA2_256', CONCAT('abc123', 'E7029B722DA04F1BBE1F11FDEB513DE2'))
PRINT @passWithSalt
print HASHBYTES('SHA2_256', CONCAT('abc123', 'E7029B722DA04F1BBE1F11FDEB513DE2'))

-- 0xD3918BCB08EBFB4E4A24C5D6EBDC1A4234C0A5E785480B5B347915026552F860
-- 0xD3918BCB08EBFB4E4A24C5D6EBDC1A4234C0A5E785480B5B347915026552F860

exec CheckAccountPassword