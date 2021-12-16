ALTER PROC UserAdd
@Username VARCHAR(50),
@Password VARCHAR(50),
AS
	INSERT INTO 'Login'(Username, Password)
	VALUES (@Username, @Password)