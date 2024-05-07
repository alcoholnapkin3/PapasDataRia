/*
insert into Printer (model, wow) */
/*
SELECT 3001, BulkColumn */
/*FRoM Openrowset( Bulk 'E:\gCRlGuHWsYE.jpg', Single_Blob) as img*/

UPDATE Printer SET wow = (SELECT BulkColumn FROM Openrowset( Bulk 'E:\gCRlGuHWsYE.jpg', Single_Blob) as img) where model = 3001
UPDATE Printer SET wow = (SELECT BulkColumn FROM Openrowset( Bulk 'E:\1399862787_0.jpg', Single_Blob) as img) where model = 3002
UPDATE Printer SET wow = (SELECT BulkColumn FROM Openrowset( Bulk 'E:\luk.jpg', Single_Blob) as img) where model = 3003

INSERT INTO Printer VALUES
	(2001, 'B', 'Ooooo', 390, (SELECT BulkColumn FROM Openrowset( Bulk 'E:\Printer.png', Single_Blob) as img))