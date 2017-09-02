--https://www.hackerrank.com/challenges/weather-observation-station-6
SELECT DISTINCT CITY FROM station
WHERE SUBSTRING(CITY, 1, 1) NOT IN ('a', 'e', 'i', 'o', 'u')