use ScoutAPI;

create table Scout_Section(
	section_code char(2) not null primary key ,
	section_description varchar(255) not null);

create table Forms(
	id nchar(10) not null primary key,
	first_name varchar(30) null,
	surname varchar(30) null,
	is_signed bit null,
	date_signed datetime null,
	section_code char(2) not null foreign key references Scout_Section(section_code));

create table Covid_Questions(
	question_id nchar(10) not null primary key,
	form_id nchar(10) not null,
	symptoms_ind bit null,
	close_contact_ind bit null,
	diagnosed_ind bit null,
	self_isolate_ind bit null,
	cocoon_ind bit null,
	at_risk_ind bit null);





	