--https://www.hackerrank.com/challenges/weather-observation-station-7?h_r=next-challenge&h_v=zen
SELECT DISTINCT CITY FROM station
WHERE SUBSTRING(CITY, DATALENGTH(CITY), 1) IN ('a', 'e', 'i', 'o', 'u')