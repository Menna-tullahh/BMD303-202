
create table patient(
	patientID int IDENTITY(1,1),
	primary key (patientID),
	--patient_reservation_ID int, --many
	--patient_course_ID int, --many 
	patientName varchar(20),
	nationalID varchar(14),
	DOB date,
	gender varchar(20),
	nationality varchar(20),
	firstLanguage varchar(20),
	patientAddress varchar(100),
	phoneNumber varchar(11),
	job varchar(20),
	email varchar(100),
	note varchar(200),
	age int,
	photo image,
);


create table userAccount(
	userID int IDENTITY(1,1),
	primary key(userID),
	username varchar(20) not null,
	password varchar(20) not null,
	role varchar(20) not null,
	creationDate datetime,
	name varchar(20),
	DOB date,
	phoneNumber varchar(11),
);

create table doctor(
	doctorID int IDENTITY(1,1),
	primary key (doctorID),
	user_doctor_ID int, --foreign key
	foreign key (user_doctor_ID) references userAccount(userID)
			ON DELETE CASCADE
			ON UPDATE CASCADE,
);



create table course(
	courseID int IDENTITY(1,1), --automatic
	primary key (courseID),
	sessionsNo int,
	course_doctor_ID int not null, -- foreign key
	foreign key (course_doctor_ID) references doctor(doctorID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	startDate date, 
	endDate date, 
	totalMoney int,
	frequency int,
	--sessionsDate date, -- many sessions
	totalDuration int,
	Diagnosis varchar(200),
	Notes varchar(400),
	course_patient_ID int,
		foreign key (course_patient_ID) references patient(patientID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	title varchar(50),
	completedSessions int,
	finished int,
);

create table secretary(
	secretaryID int IDENTITY(1,1),
	primary key (secretaryID),
	user_secretary_ID int, --foreign key
	foreign key (user_secretary_ID) references userAccount(userID)
			ON DELETE CASCADE
			ON UPDATE CASCADE,
);

create table course_sessionsDates(
	courseID int, --foreign key
	foreign key (courseID) references course(courseID)
			ON DELETE CASCADE
			ON UPDATE CASCADE,
	sessionID int IDENTITY(1,1), --automatic
	sessionsDate date,
	primary key (courseID,sessionID),
	sessionTime time,
	sessionMoney int,
);


create table reservation(
	reservationID int IDENTITY(1,1),
	primary key(reservationID),
	reservation_secretary_ID int, --foreign 
	reservation_patient_ID int, --foreign
	foreign key (reservation_secretary_ID) references secretary(secretaryID)
		ON DELETE SET NULL
		ON UPDATE SET NULL,
	foreign key(reservation_patient_ID) references patient(patientID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	sessionTime time,
	sessionDate date,
	reservation_course_ID int,
	foreign key(reservation_course_ID) references course(courseID)
		ON DELETE No Action
		ON UPDATE no action,
	confirmed int,
);

create table equipments (
	equipmentID int IDENTITY(1,1),
	primary key (equipmentID),
	equipmentName varchar(20),
);

create table diagnosis (
	diagnosisID int IDENTITY(1,1),
	primary key (diagnosisID),
	diagnosisName varchar(20),
);

create table course_diagnosis(
	courseID int,
	diagnosisID int,
	primary key (courseID, diagnosisID),
	foreign key(courseID) references course(courseID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	foreign key(diagnosisID) references diagnosis(diagnosisID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
);

create table course_equipments(
	courseID int,
	equipmentsID int,
	primary key (courseID, equipmentsID),
	foreign key(courseID) references course(courseID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	foreign key(equipmentsID) references equipments(equipmentID)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
);



