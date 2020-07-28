--Part 1
SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS
WHERE table_name = "jobs";


--Part 2
SELECT name FROM employers
WHERE location = "St. Louis";


--Part 3

SELECT skills.name, skills.description FROM skills
WHERE id IN (SELECT skillId from jobskills);