--1
alter PROCEDURE checkLogin(
	@username nvarchar(20),
	@password nvarchar(20),
	@role nvarchar(20) OUTPUT,
	@status int OUTPUT
	)
AS
if exists (select * from userAccount where username=@username and password = @password)
begin
	set @status = 1
	select @role = role FROM userAccount WHERE username = @username
end
else
	set @status = 0 

--2

alter PROCEDURE register(
	@username nvarchar(20),
	@password nvarchar(20),
	@role nvarchar(20),
	@regstatus int output
	)
as  
if exists (select * from userAccount where username=@username)
begin
	set @regstatus = 1
end
else
begin
	set @regstatus = 0 
	INSERT INTO userAccount(username,password,role) VALUES (@username,@password,@role);
end

--3
alter procedure totalEarnings(
	@moneyOutput int output 
)
as 
if ((select count(totalMoney) from course) != 0)
begin
select @moneyOutput = SUM(totalMoney) from course where totalMoney is not null;
end
else
begin
select @moneyOutput = 0
end

--4
alter procedure countCustomers(
	@countCustomers int output
)
as
IF NOT EXISTS (SELECT 1 FROM patient)
set @countCustomers = 0 
else
select @countCustomers = Count(*) from patient;

--5
alter procedure addNewPatient(
	@name varchar(50)=null,
	@dob date = null,
	@phone1 varchar(11) = null,
	@nationalID varchar(50),
	@job varchar(20)= null,
	@address varchar(100)= null,
	@gender varchar(10)= null,
	@email varchar(100)= null,
	@note varchar(200)= null
)
as
INSERT INTO patient(patientName, DOB, phoneNumber, NationalID, job, patientAddress, gender, email, note)
VALUES (@name, @dob, @phone1, @nationalID, @job, @address, @gender, @email, @note);

--6
alter procedure addNewCourse(
	@nationalID varchar(14),
	@username varchar(20),
	@sessionDate date,
	@sessionTime time,
	@doctorID int,
	@title varchar(20),
	@bool int output
)
as
declare @idPatient int
declare @idUser int
declare @idcourse int
declare @docID int


select @idPatient = patientID FROM patient WHERE NationalID = @nationalID
select @idUser = userID FROM userAccount WHERE username = @username
select @docID = doctorID from doctor where user_doctor_ID = @doctorID
if exists (select * from reservation where sessionTime = @sessionTime and sessionDate= @sessionDate)
begin
set @bool = 1
end
else
begin
set @bool = 0
INSERT INTO course(course_patient_ID, course_doctor_ID,title, completedSessions, finished, totalMoney) VALUES (@idPatient , @docID, @title, 0, 0, 0);
SELECT @idcourse = IDENT_CURRENT('course')
insert into reservation(reservation_patient_ID, reservation_secretary_ID, sessionDate, sessionTime,reservation_course_ID, confirmed) values (@idPatient , @idUser, @sessionDate, @sessionTime, @idcourse, 0);
end

--7
alter procedure updateCourseReservation(
	@nationalID varchar(14),
	@username varchar(20),
	@sessionDate date,
	@sessionTime time,
	@idcourse int,
	@bool int output

)
as
declare @idPatient int
declare @idUser int

select @idPatient = patientID FROM patient WHERE NationalID = @nationalID
select @idUser = userID FROM userAccount WHERE username = @username
if exists (select * from reservation where sessionTime = @sessionTime and sessionDate= @sessionDate)
begin
set @bool = 1
end
else
begin
set @bool = 0
insert into reservation(reservation_patient_ID, reservation_secretary_ID, sessionDate, sessionTime,reservation_course_ID, confirmed)
values (@idPatient , @idUser, @sessionDate, @sessionTime , @idcourse, 0);
end

--8
alter procedure checkOldUser(
	@nationalID varchar(14),
	@status int OUTPUT
)
as
if exists (select * from patient where NationalID=@nationalID)
	set @status = 1
else
	set @status = 0


--9
create procedure allPatients(
	@patients varchar(1000) output
)
as
select * from patient;

--10
alter procedure returnValuePatient(
	@patientID int
	
	)
as 
select * from patient where patientID = @patientID

--11
alter procedure patientInfo(
	@patientID int ,
	@patientName varchar(20) output ,
	@age int output,
	@gender varchar(20) output,
	@nationality varchar(20) output,
	@firstLanguage varchar(20) output,
	@patientAddress varchar(100) output,
	@phoneNumber varchar(11) output,
	@job varchar(20) output,
	@email varchar(100) output,
	@note varchar(200) output,
	@nationalID varchar(14) output
)
as
 
select @patientName = patientName from patient where patientID = @patientID
select @age = age from patient where patientID = @patientID
select @gender = gender from patient where patientID = @patientID
select @nationality = nationality from patient where patientID = @patientID
select @firstLanguage = firstLanguage from patient where patientID = @patientID
select @patientAddress = patientAddress from patient where patientID = @patientID
select @phoneNumber = phoneNumber from patient where patientID = @patientID
select @job = job from patient where patientID = @patientID
select @email = email from patient where patientID = @patientID
select @note = note from patient where patientID = @patientID
select @nationalID = NationalID from patient where patientID = @patientID

--12
alter procedure updateProfile(
	@patientID int ,
	@patientName varchar(20) ,
	@age int,
	@gender varchar(20) ,
	@nationality varchar(20) ,
	@firstLanguage varchar(20) ,
	@patientAddress varchar(100) ,
	@phoneNumber varchar(11),
	@job varchar(20),
	@email varchar(100),
	@note varchar(200),
	@nationalID varchar(14)
)
as
UPDATE patient SET patientName = @patientName, age=@age, gender=@gender, nationality=@nationality,
firstLanguage=@firstLanguage, patientAddress=@patientAddress,
job= @job, email = @email, note=@note, NationalID= @nationalID
WHERE patientID = @patientID;

--13
create procedure calendar(
	@day date,
	@time time output
)
as
select @time = sessionTime from reservation where sessionDate=@day;
execute calendar '2021-05-20', @time output
select courseID, title from course where course_patient_ID = (select patientID from patient where NationalID = '11111111111113');
select sessionTime, reservation_course_ID, reservation_patient_ID from reservation where sessionDate ='2021-06-17';

--14

alter procedure addSession(
	@time time,
	@date date,
	@nationalID varchar(14),
	@title varchar(20)
)
as
declare @courseid int
select @courseid = courseID  from course c, patient p where title = @title and patientID = course_patient_ID and NationalID = @nationalID

insert into course_sessionsDates (sessionDate, sessionTime, sessionMoney,courseID) 
values (@date, @time, 250, @courseid);

update course set completedSessions = completedSessions+1 where courseID = @courseid;
update reservation set confirmed = 1 where sessionTime = @time and sessionDate = @date;
update course set totalMoney = totalMoney+250 where courseID = @courseid;
if ((select completedSessions from course where courseID = @courseid) = (select sessionsNo from course where courseID = @courseid) )
begin
update course set finished = 1 where courseID=@courseid
update course set endDate = getdate() where courseID=@courseid
end

if ((select completedSessions from course where courseID = @courseid) = 1 )
begin
update course set startDate = getdate() where courseID=@courseid
end

--15
alter procedure courseInfo(
	@courseID int,
	@sessionsNo int output ,
	@doctorname varchar(20) output,
	@startDate date output,
	@endDate date output,
	@totalMoney int output,
	@frequency varchar(50) output,
	@totalDuration varchar(50) output,
	@diagnosis varchar(200) output,
	@notes varchar(400) output,
	@title varchar(50) output,
	@completedSessions int output,
	@finished int output
)
as
select @sessionsNo= sessionsNo from course where courseID = @courseID;
select @doctorname = name from userAccount where userID = (select user_doctor_ID from doctor where doctorID =(select course_doctor_ID from course where courseID = @courseID));

select @startDate = startDate from course where courseID = @courseID;
select @endDate = endDate from course where courseID = @courseID;
select @totalMoney = totalMoney from course where courseID = @courseID;
select @frequency = frequency from course where courseID = @courseID;
select @totalDuration = totalDuration from course where courseID = @courseID;
select @diagnosis = Diagnosis from course where courseID = @courseID;
select @notes = Notes from course where courseID = @courseID;
select @title = title from course where courseID = @courseID;
select @completedSessions = completedSessions from course where courseID = @courseID;
select @finished = finished from course where courseID = @courseID;

--16
create procedure updateCourse(
	@courseID int ,
	@sessionsNo int ,
	@frequency varchar(20),
	@totalDuration varchar(20),
	@notes varchar(200)

)
as
UPDATE course SET sessionsNo = @sessionsNo , frequency = @frequency , totalDuration = @totalDuration, notes = @notes
WHERE courseID = @courseID;

--17
create procedure deleteAllEquipmentsOfPatient(
	@courseID int
)
as
delete from course_equipments where courseID =@courseID


--18
create procedure deleteAllDiagnosisOfPatient(
	@courseID int
)
as
delete from course_diagnosis where courseID =@courseID

--19
alter procedure updateEquipmentsOfPatient(
	@courseID int, 
	@equipmentID int
)
as
insert into course_equipments (courseID, equipmentID) values (@courseID, @equipmentID);

--20
alter procedure updateDiagnosisOfPatient(
	@courseID int, 
	@diagnosisID int
)
as
insert into course_diagnosis(courseID, diagnosisID) values (@courseID, @diagnosisID);