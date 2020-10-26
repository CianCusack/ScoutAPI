use ScoutAPI;

create table Forms(
	id nchar(10) not null,
	first_name varchar(30) null,
	surname varchar(30) null,
	is_signed bit null,
	date_signed datetime null);

create table Covid_Questions(
	question_id nchar(10) not null,
	form_id nchar(10) not null,
	symptoms_ind bit null,
	close_contact_ind bit null,
	diagnosed_ind bit null,
	self_isolate_ind bit null,
	cocoon_ind bit null,
	at_risk_ind bit null);
