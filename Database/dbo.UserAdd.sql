CREATE PROC UserAdd
@Username varchar(50),
@Password varchar(50)
AS
	INSERT INTO LOGIN(Username,Password)
	VALUES (@Username,@Password)