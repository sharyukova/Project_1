CREATE TABLE students
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(30) UNIQUE NULL,
	passw VARCHAR(50) NULL
)

SELECT * FROM students
INSERT students (username, passw) VALUES ('student','student123')

SELECT * FROM admins
INSERT admins (username, password) VALUES ('admin', 'admin123')