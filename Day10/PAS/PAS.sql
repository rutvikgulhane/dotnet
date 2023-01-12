create table departments (
	id INT,
	department_name VARCHAR(50)
);
insert into person (id, department_name) values (1, 'Development');
insert into person (id, department_name) values (2, 'Support');
insert into person (id, department_name) values (3, 'Business Development');

create table jobs (
	id INT,
	job VARCHAR(50)
);
insert into jobs (id, job) values (1, 'IT Developer');
insert into jobs (id, job) values (2, 'IT Specalist');
insert into jobs (id, job) values (3, 'Support Engineer');
insert into jobs (id, job) values (4, 'Executive Director');
insert into jobs (id, job) values (5, 'Test Engineer');




create table person (
	id INT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	email VARCHAR(50),
	gender VARCHAR(50),
	password VARCHAR(50),
	deptid INT,
	jobid INT,
	add constraint fk_deptid (deptid) references departments(id),
	add constraint fk_jobid (jobid) references jobs(id),
);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (1, 'Clementine', 'Mattholie', 'cmattholie0@jiathis.com', 'Female', 'iM7XCWQ', 2, 3);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (2, 'Cortie', 'Goadsby', 'cgoadsby1@google.it', 'Male', '8dmHWD0kCvQU', 2, 3);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (3, 'Elliot', 'Stych', 'estych2@senate.gov', 'Genderfluid', 'X8AH9zOVe', 1, 1);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (4, 'Dewie', 'Moubray', 'dmoubray3@pagesperso-orange.fr', 'Male', 'JX4TRCs', 3, 2);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (5, 'Estell', 'Eldredge', 'eeldredge4@cam.ac.uk', 'Female', '3aO7WNKt9u', 3, 4);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (6, 'Peirce', 'Kornel', 'pkornel5@npr.org', 'Male', 'cysSGyW', 2, 5);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (7, 'Bob', 'Wrenn', 'bwrenn6@nasa.gov', 'Male', 'Dhr9lpg8cqR', 1, 2);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (8, 'Christen', 'Soares', 'csoares7@mlb.com', 'Female', 'vv0SVwt', 2, 3);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (9, 'Wallie', 'Varrow', 'wvarrow8@mail.ru', 'Female', 'RFUlB95VCXT', 2, 5);
insert into person (id, first_name, last_name, email, gender, password, deptid, jobid) 
	values (10, 'Aloysius', 'Gamett', 'agamett9@senate.gov', 'Male', 'SYcUB3rEb', 2, 3);


