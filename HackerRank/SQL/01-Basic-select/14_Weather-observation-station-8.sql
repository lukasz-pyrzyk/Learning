--https://www.hackerrank.com/challenges/weather-observation-station-8
SELECT DISTINCT CITY FROM station
WHERE 
SUBSTRING(CITY, DATALENGTH(CITY), 1) IN ('a', 'e', 'i', 'o', 'u') AND
SUBSTRING(CITY, 1, 1) IN ('a', 'e', 'i', 'o', 'u')