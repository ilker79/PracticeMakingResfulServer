CREATE TABLE Notes (
    Id SERIAL PRIMARY KEY,
    Notes TEXT,
    Date DATE  
);

INSERT INTO
    Notes (Notes, Date)

Values
    ('Today I learned about closures and scope. I felt much better understanding something for the first time in ages!', '2021-01-23'),
    ('I must write up my notes so that I dont forget what I have learned', '2021-01-23');
