﻿-- select * from City
-- select * from address
-- select * from Account
-- select * from Category;

/*
DECLARE @salt varchar(32), @passWithSalt binary(32)
SET @passWithSalt = HASHBYTES('SHA2_256', CONCAT('abc123', 'E7029B722DA04F1BBE1F11FDEB513DE2'))
PRINT @passWithSalt
print HASHBYTES('SHA2_256', CONCAT('abc123', 'E7029B722DA04F1BBE1F11FDEB513DE2'))
B5EE37F1DC3A46AC83F48BDA17207099

-- 0xD3918BCB08EBFB4E4A24C5D6EBDC1A4234C0A5E785480B5B347915026552F860
-- 0xD3918BCB08EBFB4E4A24C5D6EBDC1A4234C0A5E785480B5B347915026552F860
*/

-- ***** INSERT

 exec AddAddress @Street='Faubourg Leon Hurez', 
 					@Number ='14', @CityId = 1936

-- **********************************************************

exec AddAccount @Login = 'dave',
				@LastName = 'Lissens', 
				@FirstName = 'David', 
				@Password = 'abc123', 
				@RoleID = 1, 
				@AddressId = 1;

exec CheckAccountPassword @login='dave', @password='abc123'

-- **********************************************************

exec AddCategory @Name='Cat 1',
				 @CreateBy = 1;

-- **********************************************************

exec [AddContactInfo] @ContactType='email', @ContactInformation='02/270 93 04'

-- **********************************************************

DECLARE @tmp varbinary(max);
SET @tmp = CONVERT(varbinary, '6011511810332120109108110115613410411611611258474711911911946119514611111410347504848484711511810334321191051001161046134505550343210410110510310411661345750346260112971161043210210510810861343569655251515334321006134774949534655533252554649569948324950465555455746575732505046495645505046505332505046495611545505046505345574652494550504650534550504649566755494650533251524651503256494650523250533257514653325053115505046505332574651503250504650533250504649561221094557465552324899484555465756455346555745495146525245495046534945495146525283564846575732515746503256484657573252554649569948325546573253465557324951465252324950465349324951465252115495046534945534653533249504653494549514652521223447626011297116104321021051081086134357066666748533432100613477495451465553325255464956994832495046555545574657573250504649564550504650533250504649561154550504650534557465249455050465053455050464956994845495046565332574657574550504649563250504650534550504649561155050465053325746515032505046505332505046495612210945574655523248994845554657564553465557454951465252454950465349454951465252115454950465349325346525445495046534932495146525299483255465732534655573249514652523249504653493249514652521154950465349455346535332495046534945495146525212234476260112971161043210210510810861343552505653705234321006134775048574655533250544651521185157465650994832495446515645574654543250514648554550494648563250514648554549484655533248454955465050455546495745495746545445495146485510856465256455146535199494653493251465449325346504932554656553249494649553255465655325546514932483249494656524552465349324949465652454951118455146495710445465152994550464956325046545745544651563253464852454949465456325346485245494946485732484550494650534557465454455049465053455050464857324845495046535032494846495445505046505432504946505345505046505432534650573248325746525732504651533249494654563252465754104465152118455146544910457465053122109455646535432504846575099484555465649455346504945495146535045494946565245495146535045544655503248454950465153325346554945495046515332495146535032483255465551325346545132495146515432495046515332495146515432544654513248324949465652455346545132494946565245495146515412234476260112971161043210210510810861343551526556535134321006134775050533251118545310445574653865110457465312234476260112971161043210210510810861343569655251515334321006134775054504648503253524652561085546535432534648529945504652523251465449455646515032574656514549564652563257465651454950465432484550504648494557465552455050464849455050464956324845495146495732574652574550504649563250484657504550504649563249494653493248324955464952325746495432495646575632495246494910849464849325046535045505746545332495046505699504650553252465253325346563254465550324948465553325446555032524657543248325646524550465252324948465750455446495212210945505146505545554657561084957465650455646505199454946485745504655554552465155455246554556465051455246554552465753324845494946565232524651554549494653573249504657511223447626011297116104321021051081086134355250565370523432100613477515346505732524946524986515072545599465149324946545246525532514653564652553253465456324832554648544549465751324953465557455646495332505046484945544648533254465145495146555632574654544550524648503257465454674954465150325457465153465154325351465657465154325152465749465154324953465751324954465150465255325153465146525599494846533248324955465756325246495032505146543257465257108455446545232544654529945524648514551465556455746525745544655504549544657554554465550454951465654324845505246553249494649554550524655325053464851324832495146565432494846565232505346485132505246553250534648513256465757324832495246494945514654493249554651574554465657325046545445504654543252465249455446525432534649454949465453108455050465257464849122344762604711511810362');
PRINT @TMP

exec [AddFiles] @Name = 'logo google',
				@FileName = 'google_logo.svg',
				@FileExension = 'svg',
				@FileByte = @tmp,
				@FileSize = '1829',
				@CreateBy = 1;

-- **********************************************************

exec [AddProduct] @Manufacturer = 'Buderus',
				  @Name = 'Chaudière à condensation',
				  @CreateBy = 1;

-- **********************************************************

exec [AddProject] @Name='Maison Hafid',
				  @AddressId=1,
				  @CreateBy=1

-- **********************************************************

exec [AddSupplier] @Name='Facq',
				   @AddressId = 1,
				   @CreateBy = 1;

-- **********************************************************
-- ***** GET
-- **********************************************************

exec [GetFile] @id = 1

exec [GetAccount] @id = 1

exec [GetAccountByLogin] @login = 'dave'

exec [GetCategory] @id = 1

exec [GetCategoryByName] @name = 'Cat 1'

exec [GetCategoryAll]

exec [GetCity] @id = '1'

exec [GetCityByName] @name = 'li'

exec [GetCityByCountry] @CountryId = 21

exec [GetCityByPostalCode] @postalCode = '7110'

exec [GetCountry] @id = 21

exec [GetCountryByCode] @Iso = 'BE'

exec [GetCountryByName] @name = 'BEL'

exec [GetContactInfo]  @id = 1

exec [GetProduct] @id = 1

exec [GetProductAll]

exec [GetProductByName] @name = 'chaudière'

exec [GetProductByManufacturer] @manufacturer = 'buderus'

exec [GetProject] @id = 1

exec [GetProjectByName] @name = 'Hafid'

-- insert into [Account_Project] ([AccountId], [ProjectId] ) values (1 , 1)

exec [GetProjectByAccountId] @accountId = 1

exec [GetRole] @id = 1