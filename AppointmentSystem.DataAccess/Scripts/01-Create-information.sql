USE [AppointmentSystem]
GO

DECLARE @APPOINTMENTID VARCHAR(36)='BEDE4B95-7194-4016-AC08-9D8C18D53DE2',
	    @PatientId VARCHAR(36)='6FD6368B-740C-423E-9F4B-737FFC2D5376',
		@PatientId2 VARCHAR(36)='6FD6368B-740C-423E-9F4B-737FFC2D5377',
		@DoctorId VARCHAR(36)='1C218B2D-8D00-4F75-BECA-224F6634DBDD'

	INSERT INTO [dbo].[Appointment]([AppointmentId],[Date]) VALUES (@APPOINTMENTID,GETDATE())

	INSERT INTO [dbo].[Doctor]([DoctorId],[Name])VALUES (@DoctorId,'Pepe Perez')

	INSERT INTO [dbo].[Patient]([PatientId] ,[Document] ,[Name]) VALUES (@PatientId,'1035431','Ana Perez')

	INSERT INTO [dbo].[Patient]([PatientId] ,[Document] ,[Name]) VALUES (@PatientId2,'500424','Manuel Velez')

	INSERT INTO [dbo].[AppointmentDetail]([AppointmentDetailId],[AppointmentId],[PatientId],[DoctorId],[ConsultingRoom],[Diagnostic])
    VALUES(NEWID(),@APPOINTMENTID,@PatientId,@DoctorId,101,'Tiene tos y mucha flema, dolor de cabeza y fiebre, positivo para COVID19')

	INSERT INTO [dbo].[AppointmentDetail]([AppointmentDetailId],[AppointmentId],[PatientId],[DoctorId],[ConsultingRoom],[Diagnostic])
    VALUES(NEWID(),@APPOINTMENTID,@PatientId,@DoctorId,101,'Tiene tos y mucha flema')

    INSERT INTO [dbo].[AppointmentDetail]([AppointmentDetailId],[AppointmentId],[PatientId],[DoctorId],[ConsultingRoom],[Diagnostic])
    VALUES (NEWID(),@APPOINTMENTID,@PatientId2,@DoctorId,101,'Presenta inchazon en la pierna derecha')



GO


